using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class AuthorizationController : Controller
    {
        AdminManager adminManager = new AdminManager(new EFAdminDAL());
        RoleManager roleManager = new RoleManager(new EFRoleDAL());
        public ActionResult Index()
        {
            var adminValues = adminManager.GetList();
            return View(adminValues);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            adminManager.AdminAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            List<SelectListItem> valueadminrole = (from c in roleManager.GetRoles()
                                                   select new SelectListItem
                                                   {
                                                       Text = c.RoleName,
                                                       Value = c.RoleId.ToString()

                                                   }).ToList();

            ViewBag.valueadmin = valueadminrole;
            var adminvalue = adminManager.GetByID(id);
            return View(adminvalue);
        }

        [HttpPost]
        public ActionResult EditAdmin(Admin admin)
        {
            admin.AdminStatus = true;
            adminManager.AdminUpdate(admin);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAdmin(int id)
        {
            var result = adminManager.GetByID(id);
            if (result.AdminStatus == true)
            {
                result.AdminStatus = false;
            }
            else
            {
                result.AdminStatus = true;
            }
            adminManager.AdminUpdate(result);
            return RedirectToAction("Index");
        }
    }
}
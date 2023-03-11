using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDAL _IAdminDAL;

        public AdminManager(IAdminDAL IAdminDAL)
        {
            _IAdminDAL = IAdminDAL;
        }

        public void AdminAdd(Admin admin)
        {
            _IAdminDAL.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void AdminUpdate(Admin admin)
        {
            _IAdminDAL.Update(admin);
        }

        public Admin GetByID(int id)
        {
            return _IAdminDAL.Get(x => x.AdminID == id);
        }

        public List<Admin> GetList()
        {
            return _IAdminDAL.List();
        }
    }
}

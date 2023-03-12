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
    public class RoleManager : IRoleService
    {
        IRoleDAL _roleDAL;

        public RoleManager(IRoleDAL roleDAL)
        {
            _roleDAL = roleDAL;
        }

        public List<Role> GetRoles()
        {
            return _roleDAL.List();
        }
    }
}

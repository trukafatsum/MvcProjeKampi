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
    public class HeadingManager : IHeadingService
    {
        IHeadingDAL _HeadingDAL;

        public HeadingManager(IHeadingDAL HeadingDAL)
        {
            _HeadingDAL = HeadingDAL;
        }

        public Heading GetByID(int id)
        {
            return _HeadingDAL.Get(x => x.HeadingID == id);
        }

        public List<Heading> GetList()
        {
            return _HeadingDAL.List();
        }

        public void HeadingAdd(Heading heading)
        {
            _HeadingDAL.Insert(heading);
        }

        public void HeadingDelete(Heading heading)
        {
            _HeadingDAL.Update(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _HeadingDAL.Update(heading);
        }
    }
}

using ConsoleAppEF.Models;
using LoPrescription.DAO;
using LoPrescription.IDAO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace LoPrescription.BLL
{
    public partial class StudentService : BaseService<Student, StudentDao>
    {
        public List<Student> Page()
        {
            this.CurrentDao.SqlLog();
            var list = this.CurrentDao.Page();
            this.CurrentDao.DisposeContext();
            return list;
        }

    }















    //public partial class StudentService : BaseService<Student>
    //{
    //    private StudentDao _dao;

    //    public StudentService()
    //    {
    //        if(_dao == null)
    //        {
    //            _dao = new StudentDao();
    //        }
    //    }

    //    public override void SetCurrentDao()
    //    {
    //        this.CurrentDao = _dao;
    //    }

    //    public List<Student> Page()
    //    {
    //        return _dao.Page();
    //    }


    //}
}
using ConsoleAppEF.Models;
using LoPrescription.IDAO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LoPrescription.DAO
{
    public class StudentDao : BaseDao<Student>, IStudentDao {


        //除了 IBaseDao 的公共方法
        //外的其他方法  在这实现

        public List<Student> Page()
        {
            //using (var db = this.DbContext)
            //{
            //    var list = this.DbContext.Set<Student>().ToList();
            //    return list;
            //}

            var list = this.DbContext.Set<Student>().ToList();
            this.DbContext.Dispose();

            return list;
        }
    }
}
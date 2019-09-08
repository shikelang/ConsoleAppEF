using ConsoleAppEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoPrescription.IDAO
{
    public interface IStudentDao : IBaseDao<Student> {
        //除了 IBaseDao 的公共方法
        //外的其他方法  在这定义
        List<Student> Page();
    }

    //...
}

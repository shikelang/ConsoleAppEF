using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoPrescription.IDAO
{
    public partial interface IDBSession
    {
        int SaveChange();//用于在业务逻辑层对提交进行管理
    }
}

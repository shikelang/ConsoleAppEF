using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoPrescription.IDAO
{
    public interface IBaseDao<T> where T : class, new ()
    {
        //根据条件获取实体对象集合
        IQueryable<T> LoadEntites();

        void SqlLog();

        void DisposeContext();
        //void DisposeContext1();
    }
}

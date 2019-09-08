using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoPrescription.IBLL
{
    public interface IBaseService<T> where T : class, new()
    {

        //根据条件获取实体对象集合
        IQueryable<T> LoadEntites();

    }
}
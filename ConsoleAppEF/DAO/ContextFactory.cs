using ConsoleAppEF.Models;
using LoPrescription.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace LoPrescription.DAO
{
    /// <summary>
    /// 从CallContext数据槽中获取 EF context
    /// </summary>
    public static class ContextFactory
    {
        public static DbContext GetDbContext()
        {
            
            DbContext objectContext = CallContext.GetData(typeof(ContextFactory).FullName) as DbContext;
            if (objectContext == null)
            {
                //如果CallContext数据槽中没有EF上下文，则创建EF上下文，并保存到CallContext数据槽中
                objectContext = new StgpDbContext();//当数据库替换为MySql等，只要在此处EF更换上下文即可。这里的DBContent是model.context.cs中的局部类
                CallContext.SetData(typeof(ContextFactory).FullName, objectContext);
            }
            return objectContext;
        }

    }
}
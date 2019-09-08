using LoPrescription.Helper;
using LoPrescription.IDAO;
using System.Data.Entity;
using System.Linq;

namespace LoPrescription.DAO
{
    public class BaseDao<T> where T : class, new()
    {
        //DbContext objectContext = ContextFactory.GetDbContext();//获取EF上下文

        public DbContext DbContext
        {
            get
            {
                return ContextFactory.GetDbContext(); 
            }
        }

        /// <summary>
        /// 加载实体集合
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public virtual IQueryable<T> LoadEntites()
        {
            //using (var db = DbContext)
            //{
            //    return DbContext.Set<T>().AsQueryable<T>();
            //}

             return DbContext.Set<T>().AsQueryable<T>();
        }
        //  下面还有增删改查 或其他方法

        public void SqlLog()
        {
            DbContext.Database.Log = (sql) =>
            {
                LogHelper.SqlLog(sql);
            };
        }

        public void DisposeContext()
        {
            if(DbContext!= null)
                DbContext.Dispose();
        }

    }
}
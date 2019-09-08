using LoPrescription.DAO;
using LoPrescription.IDAO;
using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace LoPrescription.BLL
{
    public abstract class BaseService<T, TDAO>
        where T : class, new()
        where TDAO : IBaseDao<T>
    {
        public BaseService()
        {
            this.CurrentDao = (TDAO)Activator.CreateInstance(typeof(TDAO), true);
        }

        public TDAO CurrentDao { get; set; }

        public virtual IQueryable<T> LoadEntites()
        {
            return this.CurrentDao.LoadEntites();
        }

        
        public void DisposeContext()
        {
            this.CurrentDao.DisposeContext();
        }

    }



    //public abstract class BaseService<T,TDAO> 
    //    where T : class, new()
    //    where TDAO : IBaseDao<T>
    //{
    //    //private static string nameSpace = "LoPrescription.DAO";
    //    //private static string assemblyName = "ConsoleAppEF";

    //    private TDAO GetCurrentDao()
    //    {
    //        return (TDAO)Activator.CreateInstance(typeof(TDAO), true);
    //    }

    //    public BaseService()
    //    {
    //        this.CurrentDao = (TDAO)Activator.CreateInstance(typeof(TDAO), true);
    //        //SetCurrentDao();
    //    }
    //    //public BaseService(IBaseDao<T> Dao)
    //    //{
    //    //    this.CurrentDao = Dao;
    //    //}

    //    public TDAO CurrentDao { get; set; }
    //    //public IBaseDao<T> CurrentDao { get; set; }
    //    //public abstract void SetCurrentDao();



    //    public virtual IQueryable<T> LoadEntites()
    //    {
    //        return this.CurrentDao.LoadEntites();
    //    }

    //    /*

    //     IDBSession _dbSession;
    //    public IDBSession DbSession
    //    {
    //        get
    //        {
    //            if (_dbSession == null)
    //            {
    //                _dbSession = CallContext.GetData(typeof(DBSession).FullName) as DBSession;

    //                if(_dbSession == null)
    //                {
    //                    _dbSession = new DBSession();
    //                    CallContext.SetData(typeof(DBSession).FullName, _dbSession);
    //                }
    //            }
    //            return _dbSession;
    //        }
    //        set { _dbSession = value; }
    //    }
    //     */

    //}
}
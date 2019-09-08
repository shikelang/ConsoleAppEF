using LoPrescription.IDAO;
using System.Data.Entity;
using System.Linq;

namespace LoPrescription.DAO
{
    public partial class DBSession : IDBSession
    {
        private DbContext _efContext;
        public DbContext EfContext
        {
            get
            {
                if(_efContext == null)
                {
                    _efContext = ContextFactory.GetDbContext();
                }
                return _efContext;
            }
        }

        public int SaveChange()
        {
            return EfContext.SaveChanges(); 
        }



    }



}
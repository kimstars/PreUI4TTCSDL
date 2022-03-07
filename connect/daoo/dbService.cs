using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connect.daoo
{
    class dbService
    {
        public static model1.THUVIEN123Entities2 db = new model1.THUVIEN123Entities2();

        public static void Reload()
        {
            var context = ((IObjectContextAdapter)db).ObjectContext;
            var refreshableObjects = (from entry in context.ObjectStateManager.GetObjectStateEntries(
                                                       EntityState.Added
                                                       | EntityState.Deleted
                                                       | EntityState.Modified
                                                       | EntityState.Unchanged)
                                      where entry.EntityKey != null
                                      select entry.Entity).ToList();

            context.Refresh(RefreshMode.StoreWins, refreshableObjects);
        }
    }
}

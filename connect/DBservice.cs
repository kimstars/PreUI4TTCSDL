using DevExpress.Xpo;
using System;

namespace connect
{
    public class DBservice : XPObject
    {
        public DBservice() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public DBservice(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}
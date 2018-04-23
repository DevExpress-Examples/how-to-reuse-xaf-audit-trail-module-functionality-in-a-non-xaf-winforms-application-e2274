using System;
using DevExpress.Xpo;

namespace WinExample {

    public class PersistentObject1 : XPObject {
        public PersistentObject1()
            : base() {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public PersistentObject1(Session session)
            : base(session) {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        private string _Property1;
        public string Property1 {
            get { return _Property1; }
            set { SetPropertyValue("Property1", ref _Property1, value); }
        }

        private string _Property2;
        public string Property2 {
            get { return _Property2; }
            set { SetPropertyValue("Property2", ref _Property2, value); }
        }
    }

}
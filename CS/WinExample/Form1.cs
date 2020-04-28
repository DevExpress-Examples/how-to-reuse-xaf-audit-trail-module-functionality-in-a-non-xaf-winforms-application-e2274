using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.Persistent.AuditTrail;
using System.Reflection;
using System.Security.Principal;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace WinExample {
    public partial class Form1 : Form {
        public Form1() {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer("XpoProvider=InMemoryDataStore", DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            AuditTrailService.Instance.QueryCurrentUserName += new QueryCurrentUserNameEventHandler(Instance_QueryCurrentUserName);
            session1.Dictionary.GetDataStoreSchema(typeof(PersistentObject1).Assembly);
            AuditTrailService.Instance.SetXPDictionary(session1.Dictionary);
            AuditTrailService.Instance.AuditDataStore = new AuditDataStore<AuditDataItemPersistent, AuditedObjectWeakReference>();
            AuditTrailService.Instance.BeginSessionAudit(session1, AuditTrailStrategy.OnObjectChanged, ObjectAuditingMode.Full);
        }
        void Instance_QueryCurrentUserName(object sender, QueryCurrentUserNameEventArgs e) {
            e.CurrentUserName = WindowsIdentity.GetCurrent().Name;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            AuditTrailService.Instance.SaveAuditData(session1);
        }
    }
}

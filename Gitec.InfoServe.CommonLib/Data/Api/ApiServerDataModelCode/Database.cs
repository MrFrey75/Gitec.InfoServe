using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Gitec.InfoServe.CommonLib.Data
{

    public partial class Database
    {
        public Database(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

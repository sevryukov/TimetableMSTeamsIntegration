using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class XtracurDivision
    {
        public XtracurDivision()
        {
            EventKind = new HashSet<EventKind>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public string Alias { get; set; }
        public bool? IsPublic { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? WebViewKind { get; set; }
        public bool? IsPhysTraining { get; set; }

        public virtual ICollection<EventKind> EventKind { get; set; }
    }
}

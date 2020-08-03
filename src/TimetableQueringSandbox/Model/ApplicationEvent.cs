using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class ApplicationEvent
    {
        public Guid Oid { get; set; }
        public DateTime? DateTime { get; set; }
        public int? KindCode { get; set; }
        public Guid? User { get; set; }
        public string ApplicationName { get; set; }
        public string MachineName { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual User UserNavigation { get; set; }
    }
}

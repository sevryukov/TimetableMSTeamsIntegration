using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class ModuleInfo
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public string Name { get; set; }
        public string AssemblyFileName { get; set; }
        public bool? IsMain { get; set; }
        public int? OptimisticLockField { get; set; }
    }
}

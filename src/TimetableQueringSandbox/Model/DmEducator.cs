using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class DmEducator
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string UserCode { get; set; }
        public bool? IsActive { get; set; }
    }
}

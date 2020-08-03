using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class PublicDivision
    {
        public PublicDivision()
        {
            PublicDivisionPublicDivisionsDivisionDivisions = new HashSet<PublicDivisionPublicDivisionsDivisionDivisions>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Alias { get; set; }
        public string ExternalWebSiteReference { get; set; }

        public virtual ICollection<PublicDivisionPublicDivisionsDivisionDivisions> PublicDivisionPublicDivisionsDivisionDivisions { get; set; }
    }
}

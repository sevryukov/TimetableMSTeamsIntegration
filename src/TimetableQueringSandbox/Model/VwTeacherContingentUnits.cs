using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class VwTeacherContingentUnits
    {
        public string ПпсФамилия { get; set; }
        public string ПпсИмя { get; set; }
        public string ПпсОтчество { get; set; }
        public int? ПпсТабельныйНомер { get; set; }
        public string ПпсЛогин { get; set; }
        public int? ПпсPersNumSapId { get; set; }
        public string ДисциплинаНомер { get; set; }
        public string ДисциплинаНаименование { get; set; }
        public int? ДисциплинаId { get; set; }
        public string ДисциплинаВидЗанятий { get; set; }
        public string ВиртуальныйКонтингентНаименование { get; set; }
        public int? ВиртуальныйКонтингентId { get; set; }
        public string УчебныйГодНаименование { get; set; }
        public int? УчебныйГодНомер { get; set; }
    }
}

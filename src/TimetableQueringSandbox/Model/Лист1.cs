using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class Лист1
    {
        public string Направление { get; set; }
        public string ПпсФамилия { get; set; }
        public string ПпсИмя { get; set; }
        public string ПпсОтчество { get; set; }
        public DateTime? ПпсДатаРождения { get; set; }
        public double? АстрономическиеЧасы { get; set; }
        public double? АкадемЧасы { get; set; }
        public string Дисциплина { get; set; }
        public string ВидЗанятий { get; set; }
        public string Контингент { get; set; }
        public string ОбразовательнаяПрограмма { get; set; }
        public string Семестр { get; set; }
        public string НомерУчебногоПлана { get; set; }
        public string Профиль { get; set; }
        public double? НомерДисциплины { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class VwAdcroomInfo
    {
        public Guid OidЗдания { get; set; }
        public string КодУнимЗдания { get; set; }
        public string НаименованиеЗдания { get; set; }
        public string Город { get; set; }
        public string Улица { get; set; }
        public string НомерДома { get; set; }
        public string НомерДомаДоп { get; set; }
        public Guid OidПомещения { get; set; }
        public string КодУнимПомещения { get; set; }
        public string Адрес { get; set; }
        public string НаименованиеПомещения { get; set; }
        public string Помещения { get; set; }
        public string ВидПомещения { get; set; }
        public int? Вместимость { get; set; }
        public double? Площадь { get; set; }
        public int? КолВоКомпьютеров { get; set; }
        public int? МультимедиаОборудование { get; set; }
        public int? ЛабораторноеОборудование { get; set; }
        public string Примечание { get; set; }
        public bool? СОграниченнымДоступом { get; set; }
        public Guid? Этаж { get; set; }
        public Guid? ВидПомещенияSap { get; set; }
        public Guid? ВидАудитории { get; set; }
    }
}

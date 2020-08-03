using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class TimetableLog
    {
        public int Id { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string View { get; set; }
        public string UserName { get; set; }
        public string DataFile { get; set; }
        public string SettingsFile { get; set; }
        public string Url { get; set; }
        public string DataRecord { get; set; }
    }
}

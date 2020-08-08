using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TimetableQueringSandbox.Model;

namespace TimetableQueringSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            File.WriteAllText(@"D:\dev\work\output.txt", string.Empty);

            using var context = new timetableliveContext();
            using var writer = new StreamWriter(@"D:\dev\work\output.txt");

            var start = new DateTime(2019, 9, 1);
            var end = new DateTime(2020, 9, 1);

            var query = from ef in context.EventFlatten
                        join e in context.Event
                            on ef.Oid equals e.Oid
                        select new { ef.Start, ef.End, e.Gcrecord, e.WebAvailability, e.Oid, e.EventLocation };

            foreach (var item in query
                                    .AsEnumerable()
                                    .Where(x => x.Start >= start)
                                    .Where(x => x.End <= end)
                                    .Where(x => x.WebAvailability == 1)
                                    .Where(x => x.Start != x.End)
                                    .Where(x => x.Gcrecord == null))
            {
                foreach (var location in item.EventLocation)
                { 

                }
            }
        }
    }
}
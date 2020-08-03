using System;
using System.Linq;
using System.Text;
using TimetableQueringSandbox.Model;

namespace TimetableQueringSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            using (var context = new timetableliveContext())
            {
                var pmpu = context.Division
                    .FirstOrDefault(x => x.ShortNameEnglish == "AMCP");

                Console.WriteLine(pmpu?.Oid);

                context.Discipline
                    .Where(x => x.SapDivision == pmpu.Oid)
                    .Select(x => x.Name)
                    .ToList()
                    .ForEach(x => Console.WriteLine(x));

                context.StudyProgram
                    .Select(x => x.Name)
                    .ToList()
                    .ForEach(x => Console.WriteLine(x));
            }
        }
    }
}

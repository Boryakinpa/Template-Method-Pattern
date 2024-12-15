using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class StudentReportGenerator : ReportGenerator
    {
        public override void DataCollection()
        {
            Console.WriteLine("Читаем искэл файл и извлекаем данные...");
        }

        public override void DataProcessing()
        {
            Console.WriteLine("Приводим данные к единому виду");
        }

        public override void ReportGeneration()
        {
            Console.WriteLine("Записываем в табель успеваемости");
        }

        public override void ReportExport()
        {
            Console.WriteLine("Отправляем преподавательскому центру");
        }

    }
}

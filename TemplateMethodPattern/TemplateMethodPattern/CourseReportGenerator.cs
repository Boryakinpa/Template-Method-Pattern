using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class CourseReportGenerator : ReportGenerator
    {
        public override void DataCollection()
        {
            Console.WriteLine("Из подозрительной таблицы курсов считываются данные");
        }

        public override void DataProcessing()
        {
            Console.WriteLine("Данные становятся не подозрительными");
        }

        public override void ReportGeneration()
        {
            Console.WriteLine("Создается корректная таблица курсов");
        }

        public override void ReportExport()
        {
            Console.WriteLine("Отправляется по адресу mail@gmail.com");
        }

    }
}

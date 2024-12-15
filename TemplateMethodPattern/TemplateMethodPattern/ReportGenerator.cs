using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            DataCollection();
            DataProcessing();
            ReportGeneration();
            ReportExport();
        }
        public abstract void DataCollection();
        public abstract void DataProcessing();
        public abstract void ReportGeneration();
        public abstract void ReportExport();
    }
}

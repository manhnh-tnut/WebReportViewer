using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebReportViewer.Models
{
    public class ReportModel
    {
        public string Material  { get; set; }
        public string Spec { get; set; }
        public string Unit { get; set; }
        public int Qty { get; internal set; }
        public string Invoice { get; set; }
        public string Remark { get; set; }
    }
}

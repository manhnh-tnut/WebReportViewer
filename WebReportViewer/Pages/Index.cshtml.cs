using AspNetCore.Reporting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WebReportViewer.Models;

namespace WebReportViewer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHostEnvironment _hostEnvironment;

        public IndexModel(ILogger<IndexModel> logger, IHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment; // has ContentRootPath property
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public IActionResult OnGet()
        {
            string mineType = "";
            int extension = 1;
            string reportPath = $"{_hostEnvironment.ContentRootPath}\\Reports\\InputSlipReport.rdlc";
            Dictionary<string, string> parameters = new();
            parameters.Add("doc", System.DateTime.Now.ToString("yyyyMMddHHmmss"));
            List<ReportModel> data = new() { new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 }, new ReportModel() { Qty = 1 } };
            LocalReport report = new(reportPath);
            report.AddDataSource("DataSet1", data);
            ReportResult result = report.Execute(RenderType.Pdf, extension, parameters, mineType);
            return File(result.MainStream, "application/pdf");
        }
    }
}

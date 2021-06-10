using Microsoft.AspNetCore.Mvc;
using Services.Domains;
using Services.ViewModels;
using System.Collections.Generic;

namespace Host.Controllers
{
    public class CSVExportController : ControllerBase
    {
        public CSVExportController() { }
        [HttpGet]
        public IEnumerable<string> Get(FormModel form)
        {
            try
            {
                return CSVExporterDomain.Generate(form);
            }
            catch (System.Exception)
            {
                //ToDO exCatcher
                return null;
            }
        }
    }
}

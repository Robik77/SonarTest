using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domains
{
    public class CSVExporterDomain
    {
        public static IEnumerable<string> Generate(FormModel form)
        {
            try
            {
                //ToDo some logic 
                return new List<string> { form.ToString(), "test" };
            }
            catch (Exception ex)
            {
                //ToDo ExCatcher 
                return new List<string> { form.ToString(), "test2ex" };
            }
        }
    }
}

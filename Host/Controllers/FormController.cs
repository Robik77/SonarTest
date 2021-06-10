using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Services.Domains;
using Services.ViewModels;
using System.Linq;

namespace Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        readonly FormDomain domain;
        public FormController()
        {
            domain = new FormDomain();
        }
        //returns all existed forms, if !forms.Any() - NotFound 
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var forms = domain.Get();
                return forms.Any()
                    ? new OkObjectResult(forms)
                    : NotFound("It seems, the database has no forms");
            }
            catch (System.Exception)
            {
                //ToDO exCatcher
                throw;
            }          
        }
        //returns form by id, if form == null - NotFound
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var form = domain.GetFormById(id);
                return (form!=null) 
                    ? Ok(form) 
                    : NotFound($"There is no form with id={id}");
            }
            catch (System.Exception)
            {
                //ToDO exCatcher
                throw;
            }
        }
        [HttpPost]
        public IActionResult Delete(FormModel form)
        {
            try
            {
                domain.DeleteForm(form);
                return Ok(form);
            }
            catch (System.Exception)
            {
                //ToDO exCatcher
                throw;
            }
        }
        [HttpPut]
        public IActionResult Edit(FormModel form)
        {
            try
            {
                domain.EditForm(form);
                return Ok(form);
            }
            catch (System.Exception)
            {
                //ToDO exCatcher
                throw;
            }
        }
    }
}

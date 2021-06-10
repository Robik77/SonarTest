using Data.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositiories
{
    public class FormRepository
    {
        readonly DataContext context;
        public FormRepository()
        {
            context = new DataContext();
            DbInitializer.Initialize(context);
        }
        public IEnumerable<Form> Get()
        {
            var forms = context.Forms.ToList();
            return forms;
        }
        public Form GetFormById(int id)
        {
            var form = context.Forms.FirstOrDefault(x => x.Id == id);
            return form;
        }
        public void DeleteForm(Form form)
        {
            context.Forms.Remove(form);
            context.SaveChanges();
        }
        public void EditForm(Form form)
        {
            context.Forms.Update(form);
            context.SaveChanges();
        }
    }
}

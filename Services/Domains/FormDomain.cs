using AutoMapper;
using Data.Entities;
using Data.Repositiories;
using Microsoft.Extensions.Configuration;
using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Domains
{
    public class FormDomain
    {
        readonly FormRepository repository;
        readonly IMapper mapper;
        public FormDomain()
        {
            repository = new FormRepository();
            mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Form, FormModel>();
            }).CreateMapper();
        }
        public IEnumerable<FormModel> Get()
        {
            var forms = repository.Get();
            return forms.Select(form => mapper.Map<Form, FormModel>(form));
        }
        public Form GetFormById(int id)
        {
            var form = repository.GetFormById(id);
            return form;
        }
        public void DeleteForm(FormModel form)
        {
            repository.DeleteForm(mapper.Map<FormModel, Form>(form));
        }
        public void EditForm(FormModel form)
        {
            repository.EditForm(mapper.Map<FormModel, Form>(form));
        }
    }
}

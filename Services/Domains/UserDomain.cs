using AutoMapper;
using Data.Entities;
using Data.Repositiories;
using Microsoft.Extensions.Configuration;
using Services.ViewMidels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Domains
{
    public class UserDomain
    {
        readonly UserRepository repository;
        readonly IMapper mapper;

        public UserDomain()
        {
            repository = new UserRepository();
            mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserModel>();
            }).CreateMapper();
        }
        public IEnumerable<UserModel> Get()
        {
            var users = repository.Get();
            return users.Select(user => mapper.Map<User, UserModel>(user));
        }

        public User GetUserById(string id)
        {
            return repository.GetUserById(id);
        }
        public void AddUser(User user)
        {
            throw new Exception();
        }
    }
}

using Cadastro.Application.Interfaces;
using Cadastro.Application.ViewModels;
using Cadastro.Domain.Contracts.Adapters;
using Cadastro.Domain.Contracts.Repositories;
using Cadastro.Domain.Entities;
using FastMapper.NetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{
    public class UserAppServices : IUserAppServices 
    {
        private readonly IUserRepository _userRepository;
        public UserAppServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void add(UserViewModel model)
        {
            var user = TypeAdapter.Adapt<UserViewModel,UserEntity>(model);


            _userRepository.Add(user);

        }

        public List<UserViewModel> getAll()
        {
            var entity = _userRepository.GetAll().ToList();
            return TypeAdapter.Adapt<List<UserViewModel>>(entity);
        }

        public UserViewModel getById(int userId)
        {

            return TypeAdapter.Adapt<UserViewModel>(_userRepository.GetById(userId));
        }

        public void removeById(int userId)
        {
            _userRepository.Remove(userId);
        }

        public void updateById(int userId, UserViewModel model)
        {
            var user = TypeAdapter.Adapt<UserEntity>(model);
            _userRepository.Update(user, userId);
        }
    }
}

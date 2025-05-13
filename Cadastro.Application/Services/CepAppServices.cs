using Cadastro.Application.Factories;
using Cadastro.Application.Interfaces;
using Cadastro.Application.ViewModels;
using Cadastro.Domain.Contracts.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{
    public class CepAppServices : ICepAppServices
    {
        private readonly ICepAdapter _cepAdapter;
        public CepAppServices(ICepAdapter cepAdapter)
        {
            _cepAdapter = cepAdapter;
        }
        public async Task<CepViewModel> SearchCep(string cep)
        {
            var entity = await _cepAdapter.SearchCep(cep);
            return CepFactory.CreateCepFactory(entity);
        }
    }
}

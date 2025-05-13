using Cadastro.Application.ViewModels;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Factories
{
    public static class CepFactory
    {
        public static CepViewModel CreateCepFactory(CepEntity entity)
        {
            return new CepViewModel(entity.cep, entity.logradouro, entity.complemento, entity.unidade, entity.bairro, entity.localidade, entity.uf, entity.estado, entity.regiao, entity.ibge, entity.gia, entity.ddd, entity.siafi);
        }
    }
}

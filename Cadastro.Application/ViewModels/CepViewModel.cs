using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.ViewModels
{
    public record class CepViewModel(string cep,string logradouro,string complemento, string unidade, string bairro, string localidade, string uf, string estado, string regiao, string ibge, string gia, string ddd, string siafi);
        
}

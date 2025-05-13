using Cadastro.Domain.Contracts.Adapters;
using Cadastro.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cadastro.Adapter
{
    public class CepAdapter : ICepAdapter
    {
        public async Task<CepEntity> SearchCep(string cep)
        {
            using (HttpClient http = new HttpClient())
            {
                var response = await http.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    CepEntity? entity = JsonConvert.DeserializeObject<CepEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else 
                        return new CepEntity();
                }
                return new CepEntity();
            }
        }
    }
}

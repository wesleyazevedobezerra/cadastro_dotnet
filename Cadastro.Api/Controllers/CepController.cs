using Cadastro.Application.Interfaces;
using Cadastro.Application.Services;
using Cadastro.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
// >
namespace Cadastro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly ICepAppServices _cepAppService;
        public CepController(ICepAppServices cepAppService)
        {
            _cepAppService = cepAppService;
        }
        // GET: api/<CepController>
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET api/<CepController>/5
        [HttpGet("{cep}")]
        public async Task<IActionResult> Get(string cep)
        {

            CepViewModel model = await _cepAppService.SearchCep(cep);

            return Ok(model);
        }

        // POST api/<CepController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CepController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CepController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
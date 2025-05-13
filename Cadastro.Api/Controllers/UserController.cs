using Cadastro.Application.Interfaces;
using Cadastro.Application.Services;
using Cadastro.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cadastro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserAppServices _userAppService;
        public UserController(IUserAppServices userAppService)
        {
            _userAppService = userAppService;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            List<UserViewModel> user =  _userAppService.getAll();

            return Ok(user);
        }
        // GET api/<UserController>/5
        [HttpGet("{userId}")]
        public IActionResult Get(int userId)
        {

            UserViewModel model = _userAppService.getById(userId);

            return Ok(model);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] UserViewModel model)
        {
            _userAppService.add(model);
            return Ok();
        }

        // PUT api/<UserController>/5
        [HttpPut("{userId}")]
        public IActionResult Put(int userId, [FromBody] UserViewModel model)
        {
            _userAppService.updateById(userId, model);
            return Ok();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{userId}")]
        public IActionResult Delete(int userId)
        {
            _userAppService.removeById(userId);
            return Ok();
        }

    }
}

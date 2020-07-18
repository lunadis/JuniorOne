using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuniorOne.Blog.Aplication.Interface;
using JuniorOne.Blog.Aplication.ViewModel;
using JuniorOne.Blog.Aplication.ViewModel.Tags;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JuniorOne.Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserAplication _app;

        public UserController(IUserAplication app)
        {
            _app = app;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<IEnumerable<UserViewModel>> Get()
        {
            return Ok(_app.Index());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<UserViewModel> Get(int id)
        {
            return Ok(_app.Select(id));
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] UserViewModel value)
        {
            var result = _app.Save(value);

            if (result) return Ok();

            return BadRequest();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] UserViewModel value)
        {
            var result = _app.Update(value);
            if (result) return Ok();

            return BadRequest();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult<UserViewModel> Delete(int id)
        {
            var result = _app.Delete(id);
            if (result == null) return BadRequest();

            return Ok();
        }
    }
}

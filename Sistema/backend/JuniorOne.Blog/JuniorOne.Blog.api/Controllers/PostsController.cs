using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuniorOne.Blog.Aplication.Interface;
using JuniorOne.Blog.Aplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JuniorOne.Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostAplication _app;

        public PostsController(IPostAplication app)
        {
            _app = app;
        }

        // GET: api/<PostsController>
        [HttpGet]
        public ActionResult<IEnumerable<PostViewModel>> Get()
        {
            return Ok(_app.Index());
        }

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public ActionResult<PostViewModel> Get(int id)
        {
            return Ok(_app.Select(id));
        }

        // POST api/<PostsController>
        [HttpPost]
        public ActionResult Post([FromBody] PostViewModel value)
        {
            var result = _app.Save(value);
            if (result) return Ok();

            return BadRequest();
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] PostViewModel value)
        {
            var result = _app.Update(value);
            if (result) return Ok();

            return BadRequest();
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public ActionResult<PostViewModel> Delete(int id)
        {
            var result = _app.Delete(id);

            if (result == null) return BadRequest();

            return Ok(result);
        }
    }
}

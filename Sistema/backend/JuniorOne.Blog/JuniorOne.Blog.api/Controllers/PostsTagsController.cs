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
    public class PostsTagsController : ControllerBase
    {
        private readonly IPostsTagsAplication _app;

        public PostsTagsController(IPostsTagsAplication app)
        {
            _app = app;
        }

        // GET: api/<PostsTagsController>
        [HttpGet]
        public ActionResult<IEnumerable<PostsTagsViewModel>> Get()
        {
            return Ok(_app.Index());
        }

        // GET api/<PostsTagsController>/5
        [HttpGet("{id}")]
        public ActionResult<PostsTagsViewModel> Get(int id)
        {
            return Ok(_app.Select(id));
        }

        // POST api/<PostsTagsController>
        [HttpPost]
        public ActionResult Post([FromBody] PostsTagsViewModel value)
        {
            var result = _app.Save(value);
            if (result) return Ok();

            return BadRequest();
        }

        // PUT api/<PostsTagsController>/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] PostsTagsViewModel value)
        {
            var result = _app.Update(value);
            if (result) return Ok();

            return BadRequest();
        }

        // DELETE api/<PostsTagsController>/5
        [HttpDelete("{id}")]
        public ActionResult<PostsTagsViewModel> Delete(int id)
        {
            var result = _app.Delete(id);
            if (result == null) return BadRequest();

            return Ok(result);
        }
    }
}

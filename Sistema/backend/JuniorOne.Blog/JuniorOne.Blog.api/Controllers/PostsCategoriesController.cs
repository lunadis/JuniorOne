using JuniorOne.Blog.Aplication.Interface;
using JuniorOne.Blog.Aplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JuniorOne.Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsCategoriesController : ControllerBase
    {
        private readonly IPostsCategoriesAplication _app;

        public PostsCategoriesController(IPostsCategoriesAplication app)
        {
            _app = app;
        }

        // GET: api/<PostsCategoriesController>
        [HttpGet]
        public ActionResult<IEnumerable<PostsCategoriesViewModel>> Get()
        {
            return Ok(_app.Index());
        }

        // GET api/<PostsCategoriesController>/5
        [HttpGet("{id}")]
        public ActionResult<PostsCategoriesViewModel> Get(int id)
        {
            return Ok(_app.Select(id));
        }

        // POST api/<PostsCategoriesController>
        [HttpPost]
        public ActionResult Post([FromBody] PostsCategoriesViewModel value)
        {
            var result = _app.Save(value);
            if (result) return Ok();

            return BadRequest();
        }

        // PUT api/<PostsCategoriesController>/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] PostsCategoriesViewModel value)
        {
            var result = _app.Update(value);
            if (result) return Ok();

            return BadRequest();
        }

        // DELETE api/<PostsCategoriesController>/5
        [HttpDelete("{id}")]
        public ActionResult<PostsCategoriesViewModel> Delete(int id)
        {
            var result = _app.Delete(id);
            if (result == null) return BadRequest();

            return Ok();
        }
    }
}

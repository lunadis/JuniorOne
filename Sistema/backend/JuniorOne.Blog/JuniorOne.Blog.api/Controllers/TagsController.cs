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
    public class TagsController : ControllerBase
    {
        private readonly ITagsAplication _app;

        public TagsController(ITagsAplication app)
        {
            _app = app;
        }

        // GET: api/<TagsController>
        [HttpGet]
        public ActionResult<IEnumerable<TagsViewModel>> Get()
        {
            return Ok(_app.Index());
        }

        // GET api/<TagsController>/5
        [HttpGet("{id}")]
        public ActionResult<TagsViewModel> Get(int id)
        {
            return Ok(_app.Select(id));
        }

        // POST api/<TagsController>
        [HttpPost]
        public ActionResult Post([FromBody] TagsViewModel value)
        {
            var reusult = _app.Save(value);

            if (reusult) return Ok();

            return BadRequest();
        }

        // PUT api/<TagsController>/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] TagsViewModel value)
        {
            var reusult = _app.Update(value);

            if (reusult) return Ok();

            return BadRequest();
        }

        // DELETE api/<TagsController>/5
        [HttpDelete("{id}")]
        public ActionResult<TagsViewModel> Delete(int id)
        {
              var result = _app.Delete(id);
            if (result == null) return BadRequest();

            return Ok(result);
        }
    }
}

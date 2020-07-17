using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using JuniorOne.Blog.Aplication.Interface;
using JuniorOne.Blog.Aplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JuniorOne.Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryAplication _App;

        public CategoriesController(ICategoryAplication app)
        {
            _App = app;
        }



        // GET: api/<CategoriesController>
        [HttpGet]
        public ActionResult<IEnumerable<CategoryViewModel>> Get()
        {
            return Ok(_App.Index());
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public ActionResult<CategoryViewModel> Get(int id)
        {
            return Ok(_App.Select(id));
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public ActionResult Post([FromBody] CategoryViewModel value)
        {
            var result = _App.Save(value);

            if (result) return Ok();

            return BadRequest();

        }

        // PUT api/<CategoriesController>/5
        [HttpPut]
        public ActionResult Put([FromBody] CategoryViewModel value)
        {
            var result = _App.Update(value);
            if (result) return Ok();

            return BadRequest();
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public ActionResult<CategoryViewModel> Delete(int id)
        {
            var result = _App.Delete(id);
            if (result != null) return Ok(result);
            return BadRequest(result);
        }
    }
}

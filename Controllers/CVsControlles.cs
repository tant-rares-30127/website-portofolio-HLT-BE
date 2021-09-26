using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CVsController : ControllerBase
    {
        private ICVService _cvService;

        public CVsController(ICVService cvService)
        {
            _cvService = cvService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var CVs = _cvService.GetAll();
            return Ok(CVs);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var CV = _cvService.GetById(id);
            return Ok(CV);
        }

        [HttpPost]
        public IActionResult Save([FromBody] CV cv)
        {
            var CV = _cvService.Add(cv);
            return Ok(CV);
        }

        [HttpPut("{id:int}")]
        public IActionResult Edit(int id, [FromBody] CV cv)
        {
            var CV = _cvService.Edit(id, cv);
            return Ok(CV);
        }
    }
}

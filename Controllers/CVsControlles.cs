using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
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
            var cv = _cvService.GetById(id);

            return Ok(cv);
        }

        [HttpPost]
        public IActionResult Save([FromBody] CV cv)
        {
            var addedCv = _cvService.Add(cv);
            return Ok(addedCv);
        }

        [Authorize]
        [HttpPut("{id:int}")]
        public IActionResult Edit(int id, [FromBody] CV cv)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var tokenUserId = tokenHandler.ReadJwtToken(jwtToken).Claims.ToList()[0];

            var dbCv = _cvService.GetById(id);

            if (dbCv.User.Id.ToString() != tokenUserId.ToString())
                return BadRequest(new { message = "You are not allowed to edit someones' else CV!" });

            var CV = _cvService.Edit(id, cv);
            return Ok(CV);
        }
    }
}

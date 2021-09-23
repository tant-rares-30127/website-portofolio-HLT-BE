using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using website_portofolio.Data;
using website_portofolio.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace website_portofolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            this._context = context;
        }

        // GET api/<LoginController>/5
        [HttpGet]
        public CVData Get([FromBody] Login login)
        {
            var loginsList = _context.Logins.ToList();
            CVData specificCV = null;

            foreach (Login l in loginsList)
            {
                if (l.Username.Equals(login.Username) && l.Password.Equals(login.Password))
                {
                    specificCV = _context.CVData.Include(n => n.ContactData).ToList()[l.Id-1];
                    return specificCV;
                }
            }

            return specificCV;
        }
    }
}

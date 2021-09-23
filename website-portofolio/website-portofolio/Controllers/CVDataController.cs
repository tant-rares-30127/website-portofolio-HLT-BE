﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using website_portofolio.Data;
using website_portofolio.Models;

namespace website_portofolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CVDataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CVDataController(ApplicationDbContext context)
        {
            this._context = context;
        }


        // GET api/<CVDataController>/5
        [HttpGet("{id}")]
        public CVData GetCVData(int id)
        {
            var specificCVData = _context.CVData.Include(n => n.ContactData).ToList()[id];

            return specificCVData;
        }
    }
}

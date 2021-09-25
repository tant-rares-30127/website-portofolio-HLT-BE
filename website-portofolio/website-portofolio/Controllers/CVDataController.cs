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

        [HttpPost]
        public CVData EditCVPage([FromBody] CVData cvData)
        {
            var currentId = cvData.Id;
            var listCVData = _context.CVData.Include(n => n.ContactData).ToList()[currentId-1];
            listCVData.Introduction = cvData.Introduction;
            listCVData.ImgSrc = cvData.ImgSrc;
            listCVData.Education = cvData.Education;
            listCVData.WorkExperience = cvData.WorkExperience;
            listCVData.Languages = cvData.Languages;
            listCVData.WhatIDo = cvData.WhatIDo;
            listCVData.WhatIUse = cvData.WhatIUse;
            listCVData.Projects = cvData.Projects;
            listCVData.Skills = cvData.Skills;
            listCVData.ContactData.PhoneNumber = cvData.ContactData.PhoneNumber;
            listCVData.ContactData.LinkedIn = cvData.ContactData.LinkedIn;
            listCVData.ContactData.Email = cvData.ContactData.Email;
            listCVData.ContactData.GitHub = cvData.ContactData.GitHub;

            _context.SaveChanges();
            return cvData;
        }
    }
}

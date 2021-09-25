using System;
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
            var specificCVData = _context.CVData.Include(n => n.ContactData).Include(n => n.Education).Include(n => n.WorkExperience).Include(n => n.Languages).ToList()[id];

            return specificCVData;
        }

        [HttpPost]
        public CVData EditCVPage([FromBody] CVData cvData)
        {
            var currentId = cvData.Id;
            var listCVData = _context.CVData.Include(n => n.ContactData).ToList()[currentId-1];
            listCVData.Introduction = cvData.Introduction;
            listCVData.ImgSrc = cvData.ImgSrc;

            listCVData.Education.NameOfTheInstitution1 = cvData.Education.NameOfTheInstitution1;
            listCVData.Education.Description1 = cvData.Education.Description1;
            listCVData.Education.Data1 = cvData.Education.Data1;
            listCVData.Education.NameOfTheInstitution2 = cvData.Education.NameOfTheInstitution2;
            listCVData.Education.Description2 = cvData.Education.Description2;
            listCVData.Education.Data2 = cvData.Education.Data2;

            listCVData.WorkExperience.NameOfTheCompany1 = cvData.WorkExperience.NameOfTheCompany1;
            listCVData.WorkExperience.Position1 = cvData.WorkExperience.Position1;
            listCVData.WorkExperience.Period1 = cvData.WorkExperience.Period1;
            listCVData.WorkExperience.NameOfTheCompany2 = cvData.WorkExperience.NameOfTheCompany2;
            listCVData.WorkExperience.Position2 = cvData.WorkExperience.Position2;
            listCVData.WorkExperience.Period2 = cvData.WorkExperience.Period2;

            listCVData.Languages.LanguageName1 = cvData.Languages.LanguageName1;
            listCVData.Languages.Understanding1 = cvData.Languages.Understanding1;
            listCVData.Languages.Speaking1 = cvData.Languages.Speaking1;
            listCVData.Languages.Writing1 = cvData.Languages.Writing1;
            listCVData.Languages.LanguageName2 = cvData.Languages.LanguageName2;
            listCVData.Languages.Understanding2 = cvData.Languages.Understanding2;
            listCVData.Languages.Speaking2 = cvData.Languages.Speaking2;
            listCVData.Languages.Writing2 = cvData.Languages.Writing2;

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

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PeoplePortal.Helpers;
using PeoplePortal.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using WebApi.Data;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Services
{
    public interface ICVService
    {
        IEnumerable<CV> GetAll();
        CV GetById(int id);
        int Add(CV cv);
        int Edit(int id, CV cv);
    }


    public class CVService : ICVService
    {
        private readonly ApplicationDbContext _context;

        public CVService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CV> GetAll()
        {
            var cvs = _context.CVs
                .Include(x => x.User)
                .Include(x => x.WorkExperience)
                .Include(x => x.Education)
                .Include(x => x.Language);

            return cvs;
        }

        public CV GetById(int id)
        {
            var cv = _context.CVs
                .Include(x => x.User)
                .Include(x => x.WorkExperience)
                .Include(x => x.Education)
                .Include(x => x.Language)
                .FirstOrDefault(x => x.Id == id);

            return cv;
        }

        public int Add(CV cv)
        {
            _context.CVs.Add(cv);
            _context.SaveChanges();
            
            return cv.Id;
        }

        public int Edit(int id,CV cv)
        {
            _context.CVs.Add(cv);

            return 0;
        }
    }
}
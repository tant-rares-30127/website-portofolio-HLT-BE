using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WebApi.Entities
{
    public class WorkExperience
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
    }
}

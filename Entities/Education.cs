using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WebApi.Entities
{
    public class Education
    {
        public int Id { get; set; }
        public string InstitutionName { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public DateTime StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
    }
}

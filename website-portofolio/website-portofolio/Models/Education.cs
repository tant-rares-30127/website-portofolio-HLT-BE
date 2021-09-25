using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace website_portofolio.Models
{
    public class Education
    {
        public int Id { get; set; }

        public string NameOfTheInstitution { get; set; }

        public string Data { get; set; }

        public string Description { get; set; }

        [JsonIgnore]
        public List<CVData> Educations { get; set; }
    }
}

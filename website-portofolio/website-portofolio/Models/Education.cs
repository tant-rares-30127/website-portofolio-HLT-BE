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

        public string NameOfTheInstitution1 { get; set; }

        public string Data1 { get; set; }

        public string Description1 { get; set; }

        public string NameOfTheInstitution2 { get; set; }

        public string Data2 { get; set; }

        public string Description2 { get; set; }

        [JsonIgnore]
        public List<CVData> Educations { get; set; }
    }
}

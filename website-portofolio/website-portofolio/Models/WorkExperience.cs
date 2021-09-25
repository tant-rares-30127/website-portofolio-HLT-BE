using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace website_portofolio.Models
{
    public class WorkExperience
    {
        public int Id { get; set; }

        public string NameOfTheCompany1 { get; set; }

        public string Position1 { get; set; }

        public string Period1 { get; set; }

        public string NameOfTheCompany2 { get; set; }

        public string Position2 { get; set; }

        public string Period2 { get; set; }

        [JsonIgnore]
        public List<CVData> ContactDatas { get; set; }
    }
}

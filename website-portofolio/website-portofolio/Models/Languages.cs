using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace website_portofolio.Models
{
    public class Languages
    {
        public int Id { get; set; }

        public string LanguageName1 { get; set; }

        public string Understanding1 { get; set; }

        public string Speaking1 { get; set; }

        public string Writing1 { get; set; }

        public string LanguageName2 { get; set; }

        public string Understanding2 { get; set; }

        public string Speaking2 { get; set; }

        public string Writing2 { get; set; }

        [JsonIgnore]
        public List<CVData> ContactDatas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace website_portofolio.Models
{
    public class CVData
    {
        public int Id { get; set; }

        public string Introduction { get; set; }

        public string ImgSrc { get; set; }

        public string Education { get; set; }

        public string WorkExperience { get; set; }

        public string Languages { get; set; }

        public string WhatIDo { get; set; }

        public string WhatIUse { get; set; }

        public string Projects { get; set; }

        public string Skills { get; set; }

        public ContactData ContactData { get; set; }
    }
}

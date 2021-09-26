using System.Collections.Generic;

namespace WebApi.Entities
{
    public class CV
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public string Introduction { get; set; }
        public string ImgSrc { get; set; }
        public virtual ICollection<Education> Education { get; set; }
        public virtual ICollection<WorkExperience> WorkExperience { get; set; }
        public virtual ICollection<Language> Language { get; set; }
        public string WhatIDo { get; set; }
        public string WhatIUse { get; set; }
        public string Projects { get; set; }
        public string Skills { get; set; }
    }
}

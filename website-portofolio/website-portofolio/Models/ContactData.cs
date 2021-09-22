using System.Collections.Generic;

namespace website_portofolio.Models
{
    public class ContactData
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }

        public string LinkedIn { get; set; }

        public string Email { get; set; }

        public string GitHub { get; set; }

        public List<CVData> ContactDatas { get; set; }
    }
}
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace website_portofolio.Models
{
    public class ContactData
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }

        public string LinkedIn { get; set; }

        public string Email { get; set; }

        public string GitHub { get; set; }

        [JsonIgnore]
        public List<CVData> ContactDatas { get; set; }
    }
}
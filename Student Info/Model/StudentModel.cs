using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Info.Model
{
    public class StudentModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("middlename")]
        public string Middlename { get; set; }

        [JsonProperty("acadlevel_id")]
        public int AcadLevelId { get; set; }

        [JsonProperty("acadlevel_name")]
        public string AcadLevelName { get; set; }

        [JsonProperty("section_id")]
        public int SectionId { get; set; }

        [JsonProperty("section_name")]
        public string SectionName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}

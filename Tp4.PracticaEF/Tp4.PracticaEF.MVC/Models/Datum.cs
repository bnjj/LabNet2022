using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tp4.PracticaEF.MVC.Models
{

    public class Datum
    {
        [JsonProperty("breed")]
        public string Breed { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("coat")]
        public string Coat { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }
    }






}
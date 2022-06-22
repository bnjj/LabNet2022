using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tp4.PracticaEF.MVC.Models
{


    public class Link
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

   




}
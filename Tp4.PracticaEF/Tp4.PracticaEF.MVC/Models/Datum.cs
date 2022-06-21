using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tp4.PracticaEF.MVC.Models
{
   
        public class Datum
        {
            [JsonProperty("fact")]
            public string Fact { get; set; }

            [JsonProperty("length")]
            public int Length { get; set; }
        }

       



    
}
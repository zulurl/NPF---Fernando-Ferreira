using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPF.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Result
    {
        public string number { get; set; }
        public bool isMultiple { get; set; }
    }

    
}
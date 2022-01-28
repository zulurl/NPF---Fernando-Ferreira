using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPF.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Numbers
    {
        public List<string> numbers { get; set; }
    }


}
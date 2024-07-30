using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EMSDesktop
{
    internal class Response
    {
        [JsonProperty("choice")]
        public string choice { get; set; }

        [JsonProperty("explanation")]
        public string explanation { get; set; }

        public Response(string choice, string explanation)
        {
            this.choice = choice;
            this.explanation = explanation;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSDesktop
{
    internal class RootObject
    {
        [JsonProperty("__count__")]
        public int Count { get; set; }

        public List<QnA> Data { get; set; }
    }
}

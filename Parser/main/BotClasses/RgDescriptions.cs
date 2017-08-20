using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.main.BotClasses
{
    public class RgDescriptions
    {
        public string appid { get; set; }
        public string classid { get; set; }
        public string appinstanceidid { get; set; }
        public string name { get; set; }
        public string market_hash_name { get; set; }
        public string market_name { get; set; }
        public string type { get; set; }
        public Descriptions[] descriptions { get; set; }
        public Tags[] tags { get; set; }
    }
}

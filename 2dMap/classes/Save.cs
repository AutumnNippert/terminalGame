using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _2dMap.classes
{
    class Save
    {
        public int lvl { get; set; }
        public int health { get; set; }
        public int armor { get; set; }
        public int atk { get; set; }
        public int xp { get; set; }

        public string[] inventory { get; set; }
    }
}

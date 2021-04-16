using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsPokedex.Models
{
    class Regions
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public Result[] results { get; set; }

        public class Result
        {
            public string name { get; set; }
            public string url { get; set; }
        }
    }
}

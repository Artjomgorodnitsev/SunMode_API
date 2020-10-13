using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckAPI
{
    class SunMode
    {
        public Results Results { get; set; }
        public string Status { get; set; }
    }
    public class Results
    {
        public string Sunrise { get; set; }
        public string SunSet { get; set; }
    }
}

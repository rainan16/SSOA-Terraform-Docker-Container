using System;
using System.Collections.Generic;

namespace Blazor_Service_GuessMyUI.Data
{
    public class GuessGenderData
    {
        public String name { get; set; }

        public String gender { get; set; }

        public double probability { get; set; }

        public double count { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Blazor_Service_GuessMyUI.Data
{
    public class GuessNationData
    {
        public String name { get; set; }

        public List<CountryData> country { get; set; }
    }
}

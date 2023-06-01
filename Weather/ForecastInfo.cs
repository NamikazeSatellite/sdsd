using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather;

class ForecastInfo
{
    public class Daily
    {
        public List<string> time { get; set; }
        public List<int> weathercode { get; set; }
        public List<double> temperature_2m_max { get; set; }
        public List<double> temperature_2m_min { get; set; }
    }
    public class root
    {
        public Daily daily { get; set; }
    }
}

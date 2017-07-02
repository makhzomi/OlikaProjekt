using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLabGroup99
{

    /// <summary>
    /// där TrafficIntensities kan anta värden som finns i get, set. som sedan visas när man kör programmet. 
    /// </summary>
    enum TrafficIntensities
    {
        Light,
        Medium,
        Heavy,
        Congested,
        Blockage,

    }
    class TrafficPrediction
    {
        public TrafficIntensities TrafficIntensities { get; set; }
        public double FlowSpeed { get; set; }
        public double CarVolume { get; set; }
        public double Temperatures { get; set; }
        public double TimeLine { get; set; }
    }

}


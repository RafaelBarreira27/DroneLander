using DroneLander.Common;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander
{
   
    public enum LandingResultType { Landed, Kaboom, }
    [AddINotifyPropertyChangedInterface]
    public class LandingParameters
    {
        public LandingParameters()
        {
            this.Altitude = CoreConstants.StartingAltitude;
            this.Velocity = CoreConstants.StartingVelocity;
            this.Fuel = CoreConstants.StartingFuel;
            this.Thrust = CoreConstants.StartingThrust;
        }
        

        public double Altitude { get; set; }
        public double Velocity { get; set; }
        public double Fuel { get; set; }
        public double Thrust { get; set; }
    }
}

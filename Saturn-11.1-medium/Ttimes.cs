using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturn_11._1_medium
{
    class Ttimes
    {
        private double Hhours;
        private double Mminutes;
        private double Sseconds;
        public Ttimes(double Hhours, double Mminutes, double Sseconds)
        {
            this.Hhours = Hhours;
            this.Mminutes = Mminutes;
            this.Sseconds = Sseconds;
        }
        public double FHours
        {
            get { return Hhours; }
            set { Hhours = value; }
        }
        public double FMinutes
        {
            get { return Mminutes; }
            set { Mminutes = value; }
        }
        public double FSeconds
        {
            get { return Sseconds; }
            set { Sseconds = value; }
        }
        public void howmuch()
        {
            this.FSeconds = this.FHours * 60 * 60 + this.FMinutes * 60 + this.FSeconds;
        }
        public void fivesec()
        {
            this.FSeconds = this.Sseconds + 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLaba1.BLL
{
    public class AperiodicBlock: BaseBlock
    {
        public double dt { get; set; }
        public double Time { get; set; }
        private double y1;
        public AperiodicBlock(double time,double dt)
        {
            this.Time = time;
            this.dt = dt;
        }
        public override double Transfer(double Input)
        {
            y1 = (Input * dt + Time * y1) / (Time + dt);
            return y1;
        }
    }
}

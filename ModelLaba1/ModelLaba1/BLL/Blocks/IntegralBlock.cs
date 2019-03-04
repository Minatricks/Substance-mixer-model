using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLaba1.BLL
{
    class IntegralBlock : BaseBlock
    {
        public double i1;
        public double dt;
        private double x1;

        public  IntegralBlock(double dt)
        {
            this.dt = dt;
        }

        public override double Transfer(double Input)
        {
            i1 = i1 + dt * (Input + x1) / 2;
            x1 = Input;
            return i1;
        }
    }
}

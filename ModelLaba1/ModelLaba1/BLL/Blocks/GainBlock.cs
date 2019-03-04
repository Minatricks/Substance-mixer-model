using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLaba1.BLL
{
    public class GainBlock: BaseBlock
    {
        public double Gain { get; set; }
        public GainBlock(double Gain)
        {
            this.Gain = Gain;
        }
        public override double Transfer(double Input)
        {
            return Gain*Input;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLaba1.BLL
{
    public class ClampBlock : BaseBlock
    {
        public  double Max { get; set; }
        public double Min { get; set; }
       
        public ClampBlock(double Min,double Max)
        {
            this.Min = Min;
            this.Max = Max;
        }
        public override double Transfer(double Input)
        {
            var y = Input < Min ? Min : Input;
            return y > Max ? Max : y;
        }
    }
}

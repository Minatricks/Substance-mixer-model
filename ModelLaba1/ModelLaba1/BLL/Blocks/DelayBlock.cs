using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLaba1.BLL
{
   public class DelayBlock : BaseBlock
    {
        //Same paramaters like aperiodic block
        public double Time { get; set; }
        public double dt { get; set; }
        public Queue<double> buff;
        public int cnt { get; set; }
        public DelayBlock(double Time,double dt)
        {
            //cnt - время квантвуанян
            //dt - час дискретизації
            this.Time = Time;
            this.dt = dt;
            cnt = (int)(Time / dt);
            buff = new Queue<double>(cnt);
        }
        public override double Transfer(double Input)
        {
            buff.Enqueue(Input);
            if(buff.Count < cnt)
            {
                buff.Enqueue(Input);
                return 0;
            }
            else
            {
                return buff.Dequeue();
            }

        }
    }
}

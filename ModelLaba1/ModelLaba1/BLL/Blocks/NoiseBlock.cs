using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLaba1.BLL
{
    public class NoiseBlock : BaseBlock
    {
        private double _noise;
        //
        private Random rnd;
        public NoiseBlock(double noise)
        {
            this._noise = noise;
            rnd = new Random();
        }

        public override double Transfer(double Input)
        {
            //absn - абсолютне значення натурльних величин шуму у відстотках
            var absn = Input * _noise / 100;
            return Input + 2 * absn * rnd.NextDouble() - absn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLaba1.BLL
{
    public class ObjectModel
    {
        private List<BaseBlock> _blocks;
        private double _dt;
        private ClampBlock _inputClamp;//Чтобы нельзя было задать минусовое значение
        private double _input = 0;
        public double Time { get; set; }
        public double Input
        {
            get
            {
                return _input;
            }
            set
            {
                _input = _inputClamp.Transfer(value);
            }
        }
        public double Output { get; set; }
        public ObjectModel(double dt)
        {
            //Должна быть наша система как в расчетке(Матлаб блоки)
            //dt - частота  дискретизації
            this._dt = dt;
            _blocks = new List<BaseBlock>();
            _blocks.Add(new GainBlock(0.25));
            _blocks.Add(new GainBlock(0.045));
            _blocks.Add(new GainBlock(-0.03));
            _blocks.Add(new AperiodicBlock(4504.5, dt));
            _blocks.Add(new DelayBlock(10, dt));
            _blocks.Add(new NoiseBlock(1));
            _inputClamp = new ClampBlock(0, 100);
        }
        public double GetValue()
        {
            var y = Input;
            foreach (var b in _blocks)
            {
                y += b.Transfer(y);
            }
            Time += _dt;
            Output = y; // Save tempopery time model
            return y;
        }
        public void Reset()
        {
            Time = 0;
            Input = 0;
        }

    }
}

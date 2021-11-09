using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoCycle
{
    public  class Circle
    {
        public event Action<double, double> ChangeAngle;
        private double _angle;

        public double Angle { get { return _angle;}
            set 
            {
                if (_angle != value)
                {
                    ChangeAngle?.Invoke(value, _angle);
                    _angle=value;
                }
            
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase25R
{
    public abstract class BaseClass
    {
        public abstract double Area(double radio);
        public virtual double InteresMensual(double cantidad)
        {
            return cantidad * 12 / 100;
        }
        public virtual double CantidadTotal(double cant, double cantPpal)
        {
            return cant + cantPpal;
        }
    }
    public class DeriveClass: BaseClass
    {
        public override double Area(double radio)
        {
            return 2 * 3.14 * radio;
        }
        public override double InteresMensual(double cantidad)
        {
            return cantidad * 14 / 100;
        }
    }
}

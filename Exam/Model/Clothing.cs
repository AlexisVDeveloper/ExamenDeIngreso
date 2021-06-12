using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model
{
    abstract class Clothing
    {
        internal bool _isPremium;
        internal float _cost;
        internal int _unitsStock;

        public bool IsPremium { get { return _isPremium; } set { _isPremium = value; }  }
        public float Cost { get { return _cost; } set { _cost = value; } }
        public int UnitsInStock { get { return _unitsStock; } }

        internal Clothing(int unitsStock) {
            _unitsStock = unitsStock;
        }

        public virtual float GetTotalCost() {
            /*  Si la calidad de la prenda es Premium: el precio aumenta en un 30%. 
                Si la calidad de la prenda es Standard: el precio no se modifica. */
            _cost += _isPremium ? _cost * 0.3f : 0; 
            return _cost;
        }
    }
}

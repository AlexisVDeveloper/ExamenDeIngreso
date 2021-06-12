using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model
{
    class Jean : Clothing
    {
        private bool _isSkinny;

        public Jean(int unitsStock, bool isSkinny) 
            : base(unitsStock) {
            _isSkinny = isSkinny;
        }

        public override float GetTotalCost() {
            _cost = base.GetTotalCost();
            // Si el pantalón es chupín, el precio se rebaja en un 12 %.
            _cost += _isSkinny ? _cost / 0.12f : 0;
            return _cost;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Exam.Model
{
    class Shirt : Clothing
    {
        private bool _isTShirt;
        private bool _isMaoNeck;

        public bool IsTShirt { get { return _isTShirt; } }
        public bool IsMaoNeck { get { return _isMaoNeck; } }

        public Shirt(int unitsStock, bool isTShirt, bool isMaoNeck)
            : base(unitsStock) {
            _isTShirt = isTShirt;
            _isMaoNeck = isMaoNeck;
        }

        public override float GetTotalCost()
        {
            _cost = base.GetTotalCost();
            // Si la camisa es de tipo manga corta, el precio se rebaja en un 10%.
            _cost += _isTShirt ? _cost / 0.1f : 0;
            //Si la camisa tiene cuello mao, el precio aumenta en un 3%.
            _cost += _isMaoNeck ? _cost * 0.03f : 0;
            return _cost;
        }
    }
}

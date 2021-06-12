using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model
{
    class Store
    {
        private string _name;
        private string _direction;
        private List<Clothing> _clothings;

        public string Name { get { return _name; } }
        public string Direction { get { return _direction; } }

        public Store(string name, string direction) {
            _name = name;
            _direction = direction;

            _clothings = new List<Clothing>();
        }

        public int LookForStock(bool isShirt, bool isTShirt = false, bool isMaoNeck = false, bool isSkinny = false) {
            var currentClotings = _clothings;

            if (isShirt) 
                return currentClotings.Where(c => c is Shirt).Select(c => (Shirt)c).Where(c => c.IsTShirt == isTShirt && c.IsMaoNeck == isMaoNeck ).First().UnitsInStock;
            else
                return currentClotings.Where(c => c is Jean).Select(c => (Jean)c).Where(c => c.IsSkinny == isSkinny).First().UnitsInStock;
        }

        public void SetClothing(Clothing clothing) {
            _clothings.Add(clothing);
        }
    }
}

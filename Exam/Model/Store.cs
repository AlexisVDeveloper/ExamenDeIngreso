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

        public int GetStockFor() {
            if (clothing == null) throw new ArgumentNullException("The cloathing you looking is null."); 
                
            foreach (var clo in _clothings) { 
                if(clothing.Equals(clo)) 
                    return clothing.UnitsInStock;
            }

            throw new ArgumentException("There're not stock for this clothing.");
        }

        public void SetClothing(Clothing clothing) {
            _clothings.Add(clothing);
        }
    }
}

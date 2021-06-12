using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model
{
    class Quotation
    {
        private int _identificationNumber;
        private string _date;
        private string _sellerCode;
        private Clothing _cloathing;
        private int _clothingUnits;
        private float _costQuotation;

        public float CostQuotation { get { return _costQuotation; } set { _costQuotation = value; } }
        public int IdentificationNumber { get { return _identificationNumber; } set { _identificationNumber = value; } }
        public string Date { get { return _date; } set { _date = value; } }
        public string SellerCode { get { return _sellerCode; } set { _sellerCode = value; } }
        public int ClothingUnits { get { return _clothingUnits; } set { _clothingUnits = value; } }

        public Quotation(int identificationNumber, string sellerCode, Clothing clothing, int clothingUnits) {
            _identificationNumber = identificationNumber;
            _sellerCode = sellerCode;
            _cloathing = clothing;
            _clothingUnits = clothingUnits;
            _date = DateTime.Now.ToString();

            _costQuotation = _cloathing.GetTotalCost() * _clothingUnits;
        }

        public Quotation() { }
    }
}

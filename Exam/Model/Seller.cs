using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model
{
    class Seller
    {
        private string _name;
        private string _lastName;
        private string _sellerCode;
        private List<Quotation> _quotations;
        private Store _store;

        public string CompleteName { get { return $"{ _name } { _lastName }"; } }
        public string SellerCode { get { return _sellerCode; } }

        public Seller(string name, string lastName, Store store) {
            _name = name;
            _lastName = lastName;
            _store = store;

            Random rnd = new Random();
            int rndNums = rnd.Next(100, 1001);

            _sellerCode = "C0D3" + rndNums;

            _quotations = new List<Quotation>();
        }

        public void AddQuotation(Quotation quotation)
        {
            _quotations.Add(quotation);
        }

        public List<Quotation> GetHistoryQuotation() {
            return _quotations;
        }
    }
}

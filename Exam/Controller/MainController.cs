using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Model;

namespace Exam
{
    class MainController
    {
        private Store _store;
        private Seller _seller;

        private MainScreen _view;

        private int[] _shirtCount = { 200, 300, 150, 350 }; 
        private int[] _jeanCount = { 1500, 500 };

        private int _currentStock;

        public MainController(MainScreen view) {
            _view = view;

            CreateProperties();
            _view.SetStore(_store.Name, _store.Direction);
            _view.SetSeller(_seller.CompleteName, _seller.SellerCode);

            CreateStock();
        }

        public void QuotationShirt(bool isPremium, float cost, int count, bool isTShirt, bool isMaoNeck) {
            var newCloath = new Shirt(0, isTShirt, isMaoNeck);
            newCloath.IsPremium = isPremium;
            newCloath.Cost = cost;

            Quotation quotation = new Quotation(0, _seller.SellerCode, newCloath, count);
            var total = quotation.CalculateQuotation();
            _view.SetQuotation(total);

            _seller.AddQuotation();
        }

        public void QuotationJean(bool isPremium, float cost, int count, bool skinny) { 
            
        }

        private void LookStock(bool isShirt) {
            try
            {
                _currentStock = _store.GetStockFor();
                _view.SetStockUnits(_currentStock);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void CreateProperties() {
            _store = new Store("Yagmur", "Santiago del Estero 800, CABA, Argentina.");
            _seller = new Seller("Alex", "Vag", _store);
        }

        private void CreateStock() {

            for (var i = 0; i < _shirtCount.Length; i++) {
                bool tShirt = i <= 1  ? true : false;
                bool tMaoNeck = i % 2 == 1 ? true : false;

                var newShirt = new Shirt( _shirtCount[i], tShirt, tMaoNeck );
                _store.SetClothing(newShirt);
            }

            for (var i = 0; i < _jeanCount.Length; i++) {
                var newJean = new Jean(_jeanCount[i], i <= 0);
                _store.SetClothing(newJean);
            }
        }
    }
}

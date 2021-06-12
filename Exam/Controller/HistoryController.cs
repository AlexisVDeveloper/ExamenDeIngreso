using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Model;
using Exam.View;
using Exam.Engine;

namespace Exam
{
    public class HistoryController
    {
        private HistoryScreen _view;
        private List<Quotation> _quotations;
        public HistoryController(HistoryScreen screen) {
            _view = screen;

            _quotations = SaveLoad<List<Quotation>>.LoadObject();
            AddItemToList();
        }

        private void AddItemToList() {
            foreach (var quotation in _quotations) {
                string[] item = { $"{quotation.IdentificationNumber}", $"{quotation.Date}", $"{quotation.SellerCode}", $"{quotation.CostQuotation}" } ;
                _view.AddItemToList(item);
            }
        }
    }
}

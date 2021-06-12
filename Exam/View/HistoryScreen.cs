using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.View
{
    public partial class HistoryScreen : Form
    {
        private HistoryController _historyController;

        public HistoryScreen()
        {
            InitializeComponent();
            _historyController = new HistoryController(this);
        }

        public void AddItemToList(string[] items) {
            var listViewItem = new ListViewItem(items);
            quotationList.Items.Add(listViewItem);
        }
    }
}

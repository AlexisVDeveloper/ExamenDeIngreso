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

        public void AddItemToList(string item) { 
            var listViewItem = new ListViewItem(item);
            quotationList.Items.Add(listViewItem);
        }
    }
}

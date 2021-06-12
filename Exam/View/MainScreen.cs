using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class MainScreen : Form
    {
        private MainController _mainController;

        public MainScreen()
        {
            InitializeComponent();
            _mainController = new MainController(this);
        }

        public void SetStore(string storeName, string storeDir) {
            storeNameLbl.Text = storeName;
            dirStoreLbl.Text = storeDir;
        }

        public void SetSeller(string sellerName, string sellerCode) {
            nameCodeSellerLbl.Text = $"{ sellerName } | { sellerCode }";
        }

        public void SetStockUnits(int stock) {
            unitsInStockTB.Text = $"{ stock }";
        }

        public void SetQuotation(float total) {
            totalTB.Text = $"{ total }";
        }

        private void historyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void quotationBtn_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(countTB.Text);
            float cost = float.Parse(costTB.Text);

            if (tShirtCB.Checked)
                _mainController.QuotationShirt(premiumRB.Checked, cost, count, tShirtCB.Checked, maoNeckCB.Checked);
            else
                _mainController.QuotationJean(premiumRB.Checked, cost, count, jeanSkinnyCB.Checked);
        }

        private void standarRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void premiumRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void shirtRB_CheckedChanged(object sender, EventArgs e)
        {
            jeanRB.Checked = false;
        }

        private void jeanRB_CheckedChanged(object sender, EventArgs e)
        {
            shirtRB.Checked = false;
        }

        private void tShirtCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void jeanSkinnyCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maoNeckCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void costTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void countTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

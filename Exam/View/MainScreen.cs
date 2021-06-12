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

            if (shirtRB.Checked)
            {
                var stock = _mainController.GetStock(shirtRB.Checked, tShirtCB.Checked, maoNeckCB.Checked);
                unitsInStockTB.Text = $"{ stock }";
            }
        }

        public void SetStore(string storeName, string storeDir) {
            storeNameLbl.Text = $"{storeName} - {storeDir}";
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

        private bool ValidateData() {
            if (costTB.Text == "")
            {
                MessageBox.Show("Por Favor, complete el precio unitario.", "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            else if (countTB.Text == "")
            {
                MessageBox.Show("Por Favor, complete la cantidad de unidades.", "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void historyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _mainController.ShowHistoryScreen();
        }

        private void quotationBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            try
            {
                int countInStock = Int32.Parse(unitsInStockTB.Text);
                int count = Int32.Parse(countTB.Text);
                float cost = float.Parse(costTB.Text);

                if (count > countInStock) {
                    MessageBox.Show("La cantidad pedida sobrepasa el stock actual. Por favor elija otra cantidad.", "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    return;
                }

                if (tShirtCB.Checked)
                    _mainController.QuotationShirt(premiumRB.Checked, cost, count, tShirtCB.Checked, maoNeckCB.Checked);
                else
                    _mainController.QuotationJean(premiumRB.Checked, cost, count, jeanSkinnyCB.Checked);
            }
            catch { 
                    MessageBox.Show("Se produjo un error. Por favor vuelva a intentarlo.", "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void shirt_CheckedChanged(object sender, EventArgs e)
        {
            if (shirtRB.Checked) {
                var stock = _mainController.GetStock(shirtRB.Checked, tShirtCB.Checked, maoNeckCB.Checked);
                unitsInStockTB.Text = $"{ stock }";
            }
        }

        private void jean_CheckedChanged(object sender, EventArgs e)
        {
            if (jeanRB.Checked)
            {
                var stock = _mainController.GetStock(shirtRB.Checked, isSkinny: jeanSkinnyCB.Checked);
                unitsInStockTB.Text = $"{ stock }";
            }
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


namespace Exam
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clothingBox = new System.Windows.Forms.GroupBox();
            this.jeanSkinnyCB = new System.Windows.Forms.CheckBox();
            this.maoNeckCB = new System.Windows.Forms.CheckBox();
            this.tShirtCB = new System.Windows.Forms.CheckBox();
            this.jeanRB = new System.Windows.Forms.RadioButton();
            this.shirtRB = new System.Windows.Forms.RadioButton();
            this.unitsBox = new System.Windows.Forms.GroupBox();
            this.unitsInStockTB = new System.Windows.Forms.TextBox();
            this.unitsStockLbl = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.storePanel = new System.Windows.Forms.Panel();
            this.dirStoreLbl = new System.Windows.Forms.Label();
            this.storeNameLbl = new System.Windows.Forms.Label();
            this.sellerPanel = new System.Windows.Forms.Panel();
            this.historyLink = new System.Windows.Forms.LinkLabel();
            this.nameCodeSellerLbl = new System.Windows.Forms.Label();
            this.qualityBox = new System.Windows.Forms.GroupBox();
            this.premiumRB = new System.Windows.Forms.RadioButton();
            this.standarRB = new System.Windows.Forms.RadioButton();
            this.costCountBox = new System.Windows.Forms.GroupBox();
            this.countTB = new System.Windows.Forms.TextBox();
            this.countLbl = new System.Windows.Forms.Label();
            this.costTB = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.finalizePanel = new System.Windows.Forms.Panel();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.priceLbl2 = new System.Windows.Forms.Label();
            this.quotationBtn = new System.Windows.Forms.Button();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.clothingBox.SuspendLayout();
            this.unitsBox.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.storePanel.SuspendLayout();
            this.sellerPanel.SuspendLayout();
            this.qualityBox.SuspendLayout();
            this.costCountBox.SuspendLayout();
            this.finalizePanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clothingBox
            // 
            this.clothingBox.Controls.Add(this.jeanSkinnyCB);
            this.clothingBox.Controls.Add(this.maoNeckCB);
            this.clothingBox.Controls.Add(this.tShirtCB);
            this.clothingBox.Controls.Add(this.jeanRB);
            this.clothingBox.Controls.Add(this.shirtRB);
            this.clothingBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.clothingBox.Location = new System.Drawing.Point(15, 29);
            this.clothingBox.Name = "clothingBox";
            this.clothingBox.Size = new System.Drawing.Size(457, 130);
            this.clothingBox.TabIndex = 0;
            this.clothingBox.TabStop = false;
            this.clothingBox.Text = "Prenda";
            // 
            // jeanSkinnyCB
            // 
            this.jeanSkinnyCB.AutoSize = true;
            this.jeanSkinnyCB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jeanSkinnyCB.Location = new System.Drawing.Point(193, 87);
            this.jeanSkinnyCB.Name = "jeanSkinnyCB";
            this.jeanSkinnyCB.Size = new System.Drawing.Size(79, 25);
            this.jeanSkinnyCB.TabIndex = 4;
            this.jeanSkinnyCB.Text = "Chupín";
            this.jeanSkinnyCB.UseVisualStyleBackColor = true;
            this.jeanSkinnyCB.CheckedChanged += new System.EventHandler(this.jean_CheckedChanged);
            // 
            // maoNeckCB
            // 
            this.maoNeckCB.AutoSize = true;
            this.maoNeckCB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maoNeckCB.Location = new System.Drawing.Point(327, 28);
            this.maoNeckCB.Name = "maoNeckCB";
            this.maoNeckCB.Size = new System.Drawing.Size(108, 25);
            this.maoNeckCB.TabIndex = 3;
            this.maoNeckCB.Text = "Cuello Mao";
            this.maoNeckCB.UseVisualStyleBackColor = true;
            this.maoNeckCB.CheckedChanged += new System.EventHandler(this.shirt_CheckedChanged);
            // 
            // tShirtCB
            // 
            this.tShirtCB.AutoSize = true;
            this.tShirtCB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tShirtCB.Location = new System.Drawing.Point(193, 28);
            this.tShirtCB.Name = "tShirtCB";
            this.tShirtCB.Size = new System.Drawing.Size(119, 25);
            this.tShirtCB.TabIndex = 2;
            this.tShirtCB.Text = "Manga Corta";
            this.tShirtCB.UseVisualStyleBackColor = true;
            this.tShirtCB.CheckedChanged += new System.EventHandler(this.shirt_CheckedChanged);
            // 
            // jeanRB
            // 
            this.jeanRB.AutoSize = true;
            this.jeanRB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jeanRB.Location = new System.Drawing.Point(23, 87);
            this.jeanRB.Name = "jeanRB";
            this.jeanRB.Size = new System.Drawing.Size(88, 25);
            this.jeanRB.TabIndex = 1;
            this.jeanRB.TabStop = true;
            this.jeanRB.Text = "Pantalón";
            this.jeanRB.UseVisualStyleBackColor = true;
            this.jeanRB.CheckedChanged += new System.EventHandler(this.jean_CheckedChanged);
            // 
            // shirtRB
            // 
            this.shirtRB.AutoSize = true;
            this.shirtRB.Checked = true;
            this.shirtRB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shirtRB.Location = new System.Drawing.Point(23, 26);
            this.shirtRB.Name = "shirtRB";
            this.shirtRB.Size = new System.Drawing.Size(79, 25);
            this.shirtRB.TabIndex = 0;
            this.shirtRB.TabStop = true;
            this.shirtRB.Text = "Camisa";
            this.shirtRB.UseVisualStyleBackColor = true;
            this.shirtRB.CheckedChanged += new System.EventHandler(this.shirt_CheckedChanged);
            // 
            // unitsBox
            // 
            this.unitsBox.Controls.Add(this.unitsInStockTB);
            this.unitsBox.Controls.Add(this.unitsStockLbl);
            this.unitsBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.unitsBox.Location = new System.Drawing.Point(15, 165);
            this.unitsBox.Name = "unitsBox";
            this.unitsBox.Size = new System.Drawing.Size(457, 47);
            this.unitsBox.TabIndex = 1;
            this.unitsBox.TabStop = false;
            // 
            // unitsInStockTB
            // 
            this.unitsInStockTB.BackColor = System.Drawing.Color.White;
            this.unitsInStockTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitsInStockTB.Enabled = false;
            this.unitsInStockTB.Location = new System.Drawing.Point(244, 15);
            this.unitsInStockTB.Name = "unitsInStockTB";
            this.unitsInStockTB.Size = new System.Drawing.Size(100, 27);
            this.unitsInStockTB.TabIndex = 1;
            // 
            // unitsStockLbl
            // 
            this.unitsStockLbl.AutoSize = true;
            this.unitsStockLbl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsStockLbl.Location = new System.Drawing.Point(19, 18);
            this.unitsStockLbl.Name = "unitsStockLbl";
            this.unitsStockLbl.Size = new System.Drawing.Size(222, 21);
            this.unitsStockLbl.TabIndex = 0;
            this.unitsStockLbl.Text = "Unidades de stock disponibles:";
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.Purple;
            this.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePanel.Controls.Add(this.titleLbl);
            this.TitlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlePanel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TitlePanel.Location = new System.Drawing.Point(1, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(623, 100);
            this.TitlePanel.TabIndex = 2;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(27, 17);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(429, 65);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Cotizador Express";
            // 
            // storePanel
            // 
            this.storePanel.BackColor = System.Drawing.Color.Transparent;
            this.storePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storePanel.Controls.Add(this.dirStoreLbl);
            this.storePanel.Controls.Add(this.storeNameLbl);
            this.storePanel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.storePanel.Location = new System.Drawing.Point(1, 100);
            this.storePanel.Name = "storePanel";
            this.storePanel.Size = new System.Drawing.Size(485, 43);
            this.storePanel.TabIndex = 3;
            // 
            // dirStoreLbl
            // 
            this.dirStoreLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dirStoreLbl.AutoSize = true;
            this.dirStoreLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirStoreLbl.ForeColor = System.Drawing.Color.Purple;
            this.dirStoreLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dirStoreLbl.Location = new System.Drawing.Point(348, 9);
            this.dirStoreLbl.Name = "dirStoreLbl";
            this.dirStoreLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dirStoreLbl.Size = new System.Drawing.Size(122, 22);
            this.dirStoreLbl.TabIndex = 1;
            this.dirStoreLbl.Text = "Direccion de Tienda";
            this.dirStoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dirStoreLbl.UseCompatibleTextRendering = true;
            // 
            // storeNameLbl
            // 
            this.storeNameLbl.AutoSize = true;
            this.storeNameLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeNameLbl.ForeColor = System.Drawing.Color.Purple;
            this.storeNameLbl.Location = new System.Drawing.Point(11, 9);
            this.storeNameLbl.Name = "storeNameLbl";
            this.storeNameLbl.Size = new System.Drawing.Size(100, 17);
            this.storeNameLbl.TabIndex = 0;
            this.storeNameLbl.Text = "Nombre Tienda";
            // 
            // sellerPanel
            // 
            this.sellerPanel.BackColor = System.Drawing.Color.Transparent;
            this.sellerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellerPanel.Controls.Add(this.historyLink);
            this.sellerPanel.Controls.Add(this.nameCodeSellerLbl);
            this.sellerPanel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sellerPanel.Location = new System.Drawing.Point(1, 143);
            this.sellerPanel.Name = "sellerPanel";
            this.sellerPanel.Size = new System.Drawing.Size(485, 43);
            this.sellerPanel.TabIndex = 4;
            // 
            // historyLink
            // 
            this.historyLink.AutoSize = true;
            this.historyLink.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLink.Location = new System.Drawing.Point(339, 9);
            this.historyLink.Name = "historyLink";
            this.historyLink.Size = new System.Drawing.Size(133, 17);
            this.historyLink.TabIndex = 1;
            this.historyLink.TabStop = true;
            this.historyLink.Text = "Historial Cotizaciones";
            this.historyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.historyLink_LinkClicked);
            // 
            // nameCodeSellerLbl
            // 
            this.nameCodeSellerLbl.AutoSize = true;
            this.nameCodeSellerLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCodeSellerLbl.ForeColor = System.Drawing.Color.Purple;
            this.nameCodeSellerLbl.Location = new System.Drawing.Point(11, 9);
            this.nameCodeSellerLbl.Name = "nameCodeSellerLbl";
            this.nameCodeSellerLbl.Size = new System.Drawing.Size(295, 17);
            this.nameCodeSellerLbl.TabIndex = 0;
            this.nameCodeSellerLbl.Text = "Nombre y Apellido Vendedor | Código Vendedor";
            // 
            // qualityBox
            // 
            this.qualityBox.Controls.Add(this.premiumRB);
            this.qualityBox.Controls.Add(this.standarRB);
            this.qualityBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.qualityBox.Location = new System.Drawing.Point(15, 232);
            this.qualityBox.Name = "qualityBox";
            this.qualityBox.Size = new System.Drawing.Size(225, 75);
            this.qualityBox.TabIndex = 2;
            this.qualityBox.TabStop = false;
            this.qualityBox.Text = "Calidad de Prenda";
            // 
            // premiumRB
            // 
            this.premiumRB.AutoSize = true;
            this.premiumRB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premiumRB.Location = new System.Drawing.Point(119, 31);
            this.premiumRB.Name = "premiumRB";
            this.premiumRB.Size = new System.Drawing.Size(92, 25);
            this.premiumRB.TabIndex = 6;
            this.premiumRB.TabStop = true;
            this.premiumRB.Text = "Premium";
            this.premiumRB.UseVisualStyleBackColor = true;
            // 
            // standarRB
            // 
            this.standarRB.AutoSize = true;
            this.standarRB.Checked = true;
            this.standarRB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standarRB.Location = new System.Drawing.Point(13, 31);
            this.standarRB.Name = "standarRB";
            this.standarRB.Size = new System.Drawing.Size(90, 25);
            this.standarRB.TabIndex = 5;
            this.standarRB.TabStop = true;
            this.standarRB.Text = "Standard";
            this.standarRB.UseVisualStyleBackColor = true;
            // 
            // costCountBox
            // 
            this.costCountBox.Controls.Add(this.countTB);
            this.costCountBox.Controls.Add(this.countLbl);
            this.costCountBox.Controls.Add(this.costTB);
            this.costCountBox.Controls.Add(this.priceLbl);
            this.costCountBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.costCountBox.Location = new System.Drawing.Point(246, 232);
            this.costCountBox.Name = "costCountBox";
            this.costCountBox.Size = new System.Drawing.Size(226, 75);
            this.costCountBox.TabIndex = 3;
            this.costCountBox.TabStop = false;
            this.costCountBox.Text = "Precio unitario y Cantidad";
            // 
            // countTB
            // 
            this.countTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countTB.Location = new System.Drawing.Point(157, 32);
            this.countTB.Name = "countTB";
            this.countTB.Size = new System.Drawing.Size(58, 27);
            this.countTB.TabIndex = 3;
            this.countTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countTB_KeyPress);
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(85, 35);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(69, 20);
            this.countLbl.TabIndex = 2;
            this.countLbl.Text = "Cantidad";
            // 
            // costTB
            // 
            this.costTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costTB.Location = new System.Drawing.Point(23, 32);
            this.costTB.Name = "costTB";
            this.costTB.Size = new System.Drawing.Size(58, 27);
            this.costTB.TabIndex = 1;
            this.costTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costTB_KeyPress);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(6, 34);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(17, 20);
            this.priceLbl.TabIndex = 0;
            this.priceLbl.Text = "$";
            // 
            // finalizePanel
            // 
            this.finalizePanel.BackColor = System.Drawing.Color.Transparent;
            this.finalizePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalizePanel.Controls.Add(this.totalTB);
            this.finalizePanel.Controls.Add(this.priceLbl2);
            this.finalizePanel.Controls.Add(this.quotationBtn);
            this.finalizePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizePanel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.finalizePanel.Location = new System.Drawing.Point(1, 524);
            this.finalizePanel.Name = "finalizePanel";
            this.finalizePanel.Size = new System.Drawing.Size(485, 97);
            this.finalizePanel.TabIndex = 3;
            // 
            // totalTB
            // 
            this.totalTB.BackColor = System.Drawing.Color.White;
            this.totalTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTB.Enabled = false;
            this.totalTB.Location = new System.Drawing.Point(244, 35);
            this.totalTB.Name = "totalTB";
            this.totalTB.Size = new System.Drawing.Size(217, 29);
            this.totalTB.TabIndex = 2;
            // 
            // priceLbl2
            // 
            this.priceLbl2.AutoSize = true;
            this.priceLbl2.Location = new System.Drawing.Point(218, 38);
            this.priceLbl2.Name = "priceLbl2";
            this.priceLbl2.Size = new System.Drawing.Size(20, 24);
            this.priceLbl2.TabIndex = 4;
            this.priceLbl2.Text = "$";
            // 
            // quotationBtn
            // 
            this.quotationBtn.BackColor = System.Drawing.Color.Purple;
            this.quotationBtn.ForeColor = System.Drawing.Color.White;
            this.quotationBtn.Location = new System.Drawing.Point(15, 22);
            this.quotationBtn.Name = "quotationBtn";
            this.quotationBtn.Size = new System.Drawing.Size(183, 56);
            this.quotationBtn.TabIndex = 0;
            this.quotationBtn.Text = "Cotizar";
            this.quotationBtn.UseVisualStyleBackColor = false;
            this.quotationBtn.Click += new System.EventHandler(this.quotationBtn_Click);
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionPanel.Controls.Add(this.clothingBox);
            this.descriptionPanel.Controls.Add(this.unitsBox);
            this.descriptionPanel.Controls.Add(this.costCountBox);
            this.descriptionPanel.Controls.Add(this.qualityBox);
            this.descriptionPanel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionPanel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.descriptionPanel.Location = new System.Drawing.Point(1, 186);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(485, 340);
            this.descriptionPanel.TabIndex = 4;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 621);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.finalizePanel);
            this.Controls.Add(this.sellerPanel);
            this.Controls.Add(this.storePanel);
            this.Controls.Add(this.TitlePanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(502, 660);
            this.MinimumSize = new System.Drawing.Size(502, 660);
            this.Name = "MainScreen";
            this.Text = "Quotation Express";
            this.clothingBox.ResumeLayout(false);
            this.clothingBox.PerformLayout();
            this.unitsBox.ResumeLayout(false);
            this.unitsBox.PerformLayout();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.storePanel.ResumeLayout(false);
            this.storePanel.PerformLayout();
            this.sellerPanel.ResumeLayout(false);
            this.sellerPanel.PerformLayout();
            this.qualityBox.ResumeLayout(false);
            this.qualityBox.PerformLayout();
            this.costCountBox.ResumeLayout(false);
            this.costCountBox.PerformLayout();
            this.finalizePanel.ResumeLayout(false);
            this.finalizePanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox clothingBox;
        private System.Windows.Forms.GroupBox unitsBox;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel storePanel;
        private System.Windows.Forms.Label storeNameLbl;
        private System.Windows.Forms.Label dirStoreLbl;
        private System.Windows.Forms.Panel sellerPanel;
        private System.Windows.Forms.Label nameCodeSellerLbl;
        private System.Windows.Forms.LinkLabel historyLink;
        private System.Windows.Forms.GroupBox qualityBox;
        private System.Windows.Forms.GroupBox costCountBox;
        private System.Windows.Forms.Panel finalizePanel;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Button quotationBtn;
        private System.Windows.Forms.RadioButton shirtRB;
        private System.Windows.Forms.RadioButton jeanRB;
        private System.Windows.Forms.CheckBox jeanSkinnyCB;
        private System.Windows.Forms.CheckBox maoNeckCB;
        private System.Windows.Forms.CheckBox tShirtCB;
        private System.Windows.Forms.Label unitsStockLbl;
        private System.Windows.Forms.RadioButton premiumRB;
        private System.Windows.Forms.RadioButton standarRB;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.TextBox countTB;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label priceLbl2;
        private System.Windows.Forms.TextBox unitsInStockTB;
        private System.Windows.Forms.TextBox totalTB;
    }
}


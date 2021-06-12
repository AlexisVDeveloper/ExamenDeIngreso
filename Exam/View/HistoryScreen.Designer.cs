
namespace Exam.View
{
    partial class HistoryScreen
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
            this.quotationList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // quotationList
            // 
            this.quotationList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Date,
            this.Seller,
            this.Total});
            this.quotationList.HideSelection = false;
            this.quotationList.Location = new System.Drawing.Point(5, 5);
            this.quotationList.Name = "quotationList";
            this.quotationList.Size = new System.Drawing.Size(448, 425);
            this.quotationList.TabIndex = 0;
            this.quotationList.TileSize = new System.Drawing.Size(20, 20);
            this.quotationList.UseCompatibleStateImageBehavior = false;
            this.quotationList.View = System.Windows.Forms.View.Details;
            this.quotationList.VirtualListSize = 20;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Seller
            // 
            this.Seller.Text = "Seller";
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // HistoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.quotationList);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 489);
            this.MinimumSize = new System.Drawing.Size(489, 489);
            this.Name = "HistoryScreen";
            this.Text = "HistoryScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView quotationList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Seller;
        private System.Windows.Forms.ColumnHeader Total;
    }
}
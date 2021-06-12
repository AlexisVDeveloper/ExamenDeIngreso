
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
            this.SuspendLayout();
            // 
            // quotationList
            // 
            this.quotationList.HideSelection = false;
            this.quotationList.Location = new System.Drawing.Point(5, 5);
            this.quotationList.Name = "quotationList";
            this.quotationList.Size = new System.Drawing.Size(448, 425);
            this.quotationList.TabIndex = 0;
            this.quotationList.TileSize = new System.Drawing.Size(20, 20);
            this.quotationList.UseCompatibleStateImageBehavior = false;
            this.quotationList.VirtualListSize = 20;
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
    }
}
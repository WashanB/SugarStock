namespace SugarStock.FORMs
{
    partial class Listbox
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
            this.listBoxPostres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxPostres
            // 
            this.listBoxPostres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxPostres.FormattingEnabled = true;
            this.listBoxPostres.Location = new System.Drawing.Point(107, 81);
            this.listBoxPostres.Name = "listBoxPostres";
            this.listBoxPostres.Size = new System.Drawing.Size(820, 459);
            this.listBoxPostres.TabIndex = 0;
            // 
            // Listbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 642);
            this.Controls.Add(this.listBoxPostres);
            this.Name = "Listbox";
            this.Text = "Listbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPostres;
    }
}
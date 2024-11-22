namespace SugarStock.FORMs
{
    partial class ORDENAR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lesscant = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CantLB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCart = new System.Windows.Forms.Button();
            this.DescLB = new System.Windows.Forms.Label();
            this.Namelb = new System.Windows.Forms.Label();
            this.PBimage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBimage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DescLB);
            this.panel1.Controls.Add(this.PBimage);
            this.panel1.Controls.Add(this.Namelb);
            this.panel1.Location = new System.Drawing.Point(31, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 622);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lesscant);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.CantLB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.PriceLB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BtnCart);
            this.panel2.Location = new System.Drawing.Point(73, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 207);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Lesscant
            // 
            this.Lesscant.Location = new System.Drawing.Point(357, 99);
            this.Lesscant.Name = "Lesscant";
            this.Lesscant.Size = new System.Drawing.Size(52, 24);
            this.Lesscant.TabIndex = 9;
            this.Lesscant.Text = "-";
            this.Lesscant.UseVisualStyleBackColor = true;
            this.Lesscant.Click += new System.EventHandler(this.Lesscant_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CantLB
            // 
            this.CantLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantLB.Location = new System.Drawing.Point(415, 99);
            this.CantLB.Name = "CantLB";
            this.CantLB.Size = new System.Drawing.Size(55, 24);
            this.CantLB.TabIndex = 7;
            this.CantLB.Text = "1";
            this.CantLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CantLB.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad:";
            // 
            // PriceLB
            // 
            this.PriceLB.AutoSize = true;
            this.PriceLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLB.Location = new System.Drawing.Point(415, 58);
            this.PriceLB.Name = "PriceLB";
            this.PriceLB.Size = new System.Drawing.Size(52, 18);
            this.PriceLB.TabIndex = 5;
            this.PriceLB.Text = "10.99$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRECIO:";
            // 
            // BtnCart
            // 
            this.BtnCart.Location = new System.Drawing.Point(150, 145);
            this.BtnCart.Name = "BtnCart";
            this.BtnCart.Size = new System.Drawing.Size(221, 59);
            this.BtnCart.TabIndex = 3;
            this.BtnCart.Text = "ADD TO CART!!";
            this.BtnCart.UseVisualStyleBackColor = true;
            this.BtnCart.Click += new System.EventHandler(this.BtnCart_Click);
            // 
            // DescLB
            // 
            this.DescLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescLB.Location = new System.Drawing.Point(306, 130);
            this.DescLB.Name = "DescLB";
            this.DescLB.Size = new System.Drawing.Size(365, 150);
            this.DescLB.TabIndex = 2;
            this.DescLB.Text = "El tiramisu";
            this.DescLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // Namelb
            // 
            this.Namelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelb.Location = new System.Drawing.Point(299, 18);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(372, 97);
            this.Namelb.TabIndex = 0;
            this.Namelb.Text = "TIRAMISU";
            // 
            // PBimage
            // 
            this.PBimage.Image = global::SugarStock.Properties.Resources.brownies_de_chocolate_2_1;
            this.PBimage.Location = new System.Drawing.Point(21, 58);
            this.PBimage.Name = "PBimage";
            this.PBimage.Size = new System.Drawing.Size(262, 186);
            this.PBimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBimage.TabIndex = 1;
            this.PBimage.TabStop = false;
            this.PBimage.Click += new System.EventHandler(this.PBimage_Click);
            // 
            // ORDENAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(758, 674);
            this.Controls.Add(this.panel1);
            this.Name = "ORDENAR";
            this.Text = "ORDENAR";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBimage;
        private System.Windows.Forms.Label Namelb;
        private System.Windows.Forms.Label DescLB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PriceLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCart;
        private System.Windows.Forms.Label CantLB;
        private System.Windows.Forms.Button Lesscant;
        private System.Windows.Forms.Button button2;
    }
}
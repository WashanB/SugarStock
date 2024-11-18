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
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lesscant = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CantLB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DescLB = new System.Windows.Forms.Label();
            this.PBimage = new System.Windows.Forms.PictureBox();
            this.Namelb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBimage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DescLB);
            this.panel1.Controls.Add(this.PBimage);
            this.panel1.Controls.Add(this.Namelb);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 766);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lesscant);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.CantLB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.PriceLB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(108, 484);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 268);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Lesscant
            // 
            this.Lesscant.Location = new System.Drawing.Point(476, 122);
            this.Lesscant.Margin = new System.Windows.Forms.Padding(4);
            this.Lesscant.Name = "Lesscant";
            this.Lesscant.Size = new System.Drawing.Size(69, 30);
            this.Lesscant.TabIndex = 9;
            this.Lesscant.Text = "-";
            this.Lesscant.UseVisualStyleBackColor = true;
            this.Lesscant.Click += new System.EventHandler(this.Lesscant_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 123);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CantLB
            // 
            this.CantLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantLB.Location = new System.Drawing.Point(553, 122);
            this.CantLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CantLB.Name = "CantLB";
            this.CantLB.Size = new System.Drawing.Size(73, 30);
            this.CantLB.TabIndex = 7;
            this.CantLB.Text = "1";
            this.CantLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CantLB.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad:";
            // 
            // PriceLB
            // 
            this.PriceLB.AutoSize = true;
            this.PriceLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLB.Location = new System.Drawing.Point(553, 71);
            this.PriceLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLB.Name = "PriceLB";
            this.PriceLB.Size = new System.Drawing.Size(65, 24);
            this.PriceLB.TabIndex = 5;
            this.PriceLB.Text = "10.99$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRECIO:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ordenar!!!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DescLB
            // 
            this.DescLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescLB.Location = new System.Drawing.Point(408, 159);
            this.DescLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescLB.Name = "DescLB";
            this.DescLB.Size = new System.Drawing.Size(487, 185);
            this.DescLB.TabIndex = 2;
            this.DescLB.Text = "El tiramisu";
            this.DescLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // PBimage
            // 
            this.PBimage.Image = global::SugarStock.Properties.Resources.brownies_de_chocolate_2_1;
            this.PBimage.Location = new System.Drawing.Point(28, 71);
            this.PBimage.Margin = new System.Windows.Forms.Padding(4);
            this.PBimage.Name = "PBimage";
            this.PBimage.Size = new System.Drawing.Size(349, 229);
            this.PBimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBimage.TabIndex = 1;
            this.PBimage.TabStop = false;
            // 
            // Namelb
            // 
            this.Namelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelb.Location = new System.Drawing.Point(399, 22);
            this.Namelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(496, 119);
            this.Namelb.TabIndex = 0;
            this.Namelb.Text = "TIRAMISU";
            // 
            // ORDENAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(931, 768);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CantLB;
        private System.Windows.Forms.Button Lesscant;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
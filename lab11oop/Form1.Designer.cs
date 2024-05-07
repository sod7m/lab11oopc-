namespace lab11oop
{
    partial class Form1
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
            this.listBoxCar = new System.Windows.Forms.ListBox();
            this.listBoxPlain = new System.Windows.Forms.ListBox();
            this.listBoxShip = new System.Windows.Forms.ListBox();
            this.buttonCar = new System.Windows.Forms.Button();
            this.buttonPlain = new System.Windows.Forms.Button();
            this.buttonShip = new System.Windows.Forms.Button();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.textBoxShip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCar
            // 
            this.listBoxCar.FormattingEnabled = true;
            this.listBoxCar.Location = new System.Drawing.Point(55, 245);
            this.listBoxCar.Name = "listBoxCar";
            this.listBoxCar.Size = new System.Drawing.Size(205, 147);
            this.listBoxCar.TabIndex = 0;
            // 
            // listBoxPlain
            // 
            this.listBoxPlain.FormattingEnabled = true;
            this.listBoxPlain.Location = new System.Drawing.Point(403, 245);
            this.listBoxPlain.Name = "listBoxPlain";
            this.listBoxPlain.Size = new System.Drawing.Size(224, 147);
            this.listBoxPlain.TabIndex = 1;
            // 
            // listBoxShip
            // 
            this.listBoxShip.FormattingEnabled = true;
            this.listBoxShip.Location = new System.Drawing.Point(753, 245);
            this.listBoxShip.Name = "listBoxShip";
            this.listBoxShip.Size = new System.Drawing.Size(226, 147);
            this.listBoxShip.TabIndex = 2;
            // 
            // buttonCar
            // 
            this.buttonCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCar.Location = new System.Drawing.Point(76, 71);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(164, 40);
            this.buttonCar.TabIndex = 3;
            this.buttonCar.Text = "Create Car";
            this.buttonCar.UseVisualStyleBackColor = true;
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // buttonPlain
            // 
            this.buttonPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlain.Location = new System.Drawing.Point(425, 71);
            this.buttonPlain.Name = "buttonPlain";
            this.buttonPlain.Size = new System.Drawing.Size(164, 40);
            this.buttonPlain.TabIndex = 4;
            this.buttonPlain.Text = "Create Plain";
            this.buttonPlain.UseVisualStyleBackColor = true;
            this.buttonPlain.Click += new System.EventHandler(this.buttonPlain_Click);
            // 
            // buttonShip
            // 
            this.buttonShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShip.Location = new System.Drawing.Point(786, 71);
            this.buttonShip.Name = "buttonShip";
            this.buttonShip.Size = new System.Drawing.Size(164, 40);
            this.buttonShip.TabIndex = 5;
            this.buttonShip.Text = "Create Ship";
            this.buttonShip.UseVisualStyleBackColor = true;
            this.buttonShip.Click += new System.EventHandler(this.buttonShip_Click);
            // 
            // textBoxCar
            // 
            this.textBoxCar.Location = new System.Drawing.Point(97, 152);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.Size = new System.Drawing.Size(120, 20);
            this.textBoxCar.TabIndex = 6;
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(449, 152);
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.Size = new System.Drawing.Size(120, 20);
            this.textBoxPlain.TabIndex = 7;
            // 
            // textBoxShip
            // 
            this.textBoxShip.Location = new System.Drawing.Point(813, 152);
            this.textBoxShip.Name = "textBoxShip";
            this.textBoxShip.Size = new System.Drawing.Size(120, 20);
            this.textBoxShip.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "“ціна,швидкість,рік”";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(740, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "ціна,швидкість,рік,порт,пасажири";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "“ціна,швидкість,рік,висота,пасажири”";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxShip);
            this.Controls.Add(this.textBoxPlain);
            this.Controls.Add(this.textBoxCar);
            this.Controls.Add(this.buttonShip);
            this.Controls.Add(this.buttonPlain);
            this.Controls.Add(this.buttonCar);
            this.Controls.Add(this.listBoxShip);
            this.Controls.Add(this.listBoxPlain);
            this.Controls.Add(this.listBoxCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCar;
        private System.Windows.Forms.ListBox listBoxPlain;
        private System.Windows.Forms.ListBox listBoxShip;
        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.Button buttonPlain;
        private System.Windows.Forms.Button buttonShip;
        private System.Windows.Forms.TextBox textBoxCar;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.TextBox textBoxShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


namespace WindowsFormsApplication1
{
    partial class commission_bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_invno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_buyersname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_rate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_commratio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_comm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_add = new System.Windows.Forms.Button();
            this.button_calculate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_invno
            // 
            this.textBox_invno.Location = new System.Drawing.Point(226, 37);
            this.textBox_invno.Name = "textBox_invno";
            this.textBox_invno.Size = new System.Drawing.Size(100, 20);
            this.textBox_invno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoice Number";
            // 
            // textBox_buyersname
            // 
            this.textBox_buyersname.Location = new System.Drawing.Point(332, 37);
            this.textBox_buyersname.Name = "textBox_buyersname";
            this.textBox_buyersname.Size = new System.Drawing.Size(100, 20);
            this.textBox_buyersname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buyer\'s Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SS
            // 
            this.SS.Location = new System.Drawing.Point(438, 37);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(100, 20);
            this.SS.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Count";
            // 
            // textBox_rate
            // 
            this.textBox_rate.Location = new System.Drawing.Point(544, 37);
            this.textBox_rate.Name = "textBox_rate";
            this.textBox_rate.Size = new System.Drawing.Size(100, 20);
            this.textBox_rate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate";
            // 
            // textBox_qty
            // 
            this.textBox_qty.Location = new System.Drawing.Point(650, 37);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(100, 20);
            this.textBox_qty.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(121, 78);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(100, 20);
            this.textBox_amount.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Amount";
            // 
            // textBox_commratio
            // 
            this.textBox_commratio.Location = new System.Drawing.Point(227, 78);
            this.textBox_commratio.Name = "textBox_commratio";
            this.textBox_commratio.Size = new System.Drawing.Size(100, 20);
            this.textBox_commratio.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Commission Ratio";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox_comm
            // 
            this.textBox_comm.Location = new System.Drawing.Point(333, 78);
            this.textBox_comm.Name = "textBox_comm";
            this.textBox_comm.Size = new System.Drawing.Size(100, 20);
            this.textBox_comm.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Commision";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_calculate);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox_amount);
            this.panel1.Controls.Add(this.textBox_comm);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_commratio);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_qty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_rate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SS);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_buyersname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_invno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 119);
            this.panel1.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(438, 76);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 23);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(15, 75);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(97, 23);
            this.button_calculate.TabIndex = 20;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // commission_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panel1);
            this.Name = "commission_bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "commission_bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_invno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_buyersname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_commratio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_comm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
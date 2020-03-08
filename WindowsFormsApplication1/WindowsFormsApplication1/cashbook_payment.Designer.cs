namespace WindowsFormsApplication1
{
    partial class cashbook_payment
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
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_chqno = new System.Windows.Forms.TextBox();
            this.textBox_partyname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_chqdate = new System.Windows.Forms.DateTimePicker();
            this.button_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(223, 40);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(100, 20);
            this.textBox_amount.TabIndex = 1;
            // 
            // textBox_chqno
            // 
            this.textBox_chqno.Location = new System.Drawing.Point(551, 40);
            this.textBox_chqno.Name = "textBox_chqno";
            this.textBox_chqno.Size = new System.Drawing.Size(100, 20);
            this.textBox_chqno.TabIndex = 3;
            // 
            // textBox_partyname
            // 
            this.textBox_partyname.Location = new System.Drawing.Point(672, 40);
            this.textBox_partyname.Name = "textBox_partyname";
            this.textBox_partyname.Size = new System.Drawing.Size(100, 20);
            this.textBox_partyname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cheque Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cheque Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Party Name";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(12, 40);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_date.TabIndex = 10;
            // 
            // dateTimePicker_chqdate
            // 
            this.dateTimePicker_chqdate.Location = new System.Drawing.Point(342, 40);
            this.dateTimePicker_chqdate.Name = "dateTimePicker_chqdate";
            this.dateTimePicker_chqdate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_chqdate.TabIndex = 11;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(697, 71);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 112);
            this.panel1.TabIndex = 13;
            // 
            // cashbook_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dateTimePicker_chqdate);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_partyname);
            this.Controls.Add(this.textBox_chqno);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.panel1);
            this.Name = "cashbook_payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cashbook_payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_chqno;
        private System.Windows.Forms.TextBox textBox_partyname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_chqdate;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel1;
    }
}
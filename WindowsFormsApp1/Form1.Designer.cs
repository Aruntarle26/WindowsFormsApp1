
namespace WindowsFormsApp1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblHRA = new System.Windows.Forms.Label();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblTA = new System.Windows.Forms.Label();
            this.lblTotalSal = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtBasicSal = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtTotalSal = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(165, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Name";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(165, 83);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(72, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Enter Number";
            // 
            // lblHRA
            // 
            this.lblHRA.AutoSize = true;
            this.lblHRA.Location = new System.Drawing.Point(165, 162);
            this.lblHRA.Name = "lblHRA";
            this.lblHRA.Size = new System.Drawing.Size(30, 13);
            this.lblHRA.TabIndex = 2;
            this.lblHRA.Text = "HRA";
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Location = new System.Drawing.Point(165, 120);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(93, 13);
            this.lblBasicSalary.TabIndex = 3;
            this.lblBasicSalary.Text = "Enter Basic Salary";
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Location = new System.Drawing.Point(165, 194);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(22, 13);
            this.lblDA.TabIndex = 4;
            this.lblDA.Text = "DA";
            this.lblDA.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTA
            // 
            this.lblTA.AutoSize = true;
            this.lblTA.Location = new System.Drawing.Point(165, 234);
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(21, 13);
            this.lblTA.TabIndex = 5;
            this.lblTA.Text = "TA";
            // 
            // lblTotalSal
            // 
            this.lblTotalSal.AutoSize = true;
            this.lblTotalSal.Location = new System.Drawing.Point(165, 269);
            this.lblTotalSal.Name = "lblTotalSal";
            this.lblTotalSal.Size = new System.Drawing.Size(63, 13);
            this.lblTotalSal.TabIndex = 6;
            this.lblTotalSal.Text = "Total Salary";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(310, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(310, 83);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 8;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtBasicSal
            // 
            this.txtBasicSal.Location = new System.Drawing.Point(310, 117);
            this.txtBasicSal.Name = "txtBasicSal";
            this.txtBasicSal.Size = new System.Drawing.Size(100, 20);
            this.txtBasicSal.TabIndex = 9;
            this.txtBasicSal.TextChanged += new System.EventHandler(this.txtBasicSal_TextChanged);
            // 
            // txtHRA
            // 
            this.txtHRA.Enabled = false;
            this.txtHRA.Location = new System.Drawing.Point(310, 155);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.Size = new System.Drawing.Size(100, 20);
            this.txtHRA.TabIndex = 10;
            this.txtHRA.TextChanged += new System.EventHandler(this.txtHRA_TextChanged);
            // 
            // txtDA
            // 
            this.txtDA.Enabled = false;
            this.txtDA.Location = new System.Drawing.Point(310, 194);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(100, 20);
            this.txtDA.TabIndex = 11;
            this.txtDA.TextChanged += new System.EventHandler(this.txtDA_TextChanged);
            // 
            // txtTA
            // 
            this.txtTA.Enabled = false;
            this.txtTA.Location = new System.Drawing.Point(310, 227);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(100, 20);
            this.txtTA.TabIndex = 12;
            this.txtTA.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtTotalSal
            // 
            this.txtTotalSal.Enabled = false;
            this.txtTotalSal.Location = new System.Drawing.Point(310, 262);
            this.txtTotalSal.Name = "txtTotalSal";
            this.txtTotalSal.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSal.TabIndex = 13;
            this.txtTotalSal.TextChanged += new System.EventHandler(this.txtTotalSal_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(509, 51);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(509, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(509, 194);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtTotalSal);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.txtBasicSal);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTotalSal);
            this.Controls.Add(this.lblTA);
            this.Controls.Add(this.lblDA);
            this.Controls.Add(this.lblBasicSalary);
            this.Controls.Add(this.lblHRA);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblHRA;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.Label lblTotalSal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtBasicSal;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtTotalSal;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
    }
}


namespace KHPTuan22
{
    partial class PTBac2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnewPT = new System.Windows.Forms.Button();
            this.btntinh = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoA = new System.Windows.Forms.TextBox();
            this.txtsoB = new System.Windows.Forms.TextBox();
            this.txtsoC = new System.Windows.Forms.TextBox();
            this.btnchuyen1 = new System.Windows.Forms.Button();
            this.btnchuyen2 = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsoC);
            this.groupBox1.Controls.Add(this.txtsoB);
            this.groupBox1.Controls.Add(this.txtsoA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin hệ số";
            // 
            // btnnewPT
            // 
            this.btnnewPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewPT.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnnewPT.Location = new System.Drawing.Point(13, 233);
            this.btnnewPT.Name = "btnnewPT";
            this.btnnewPT.Size = new System.Drawing.Size(88, 34);
            this.btnnewPT.TabIndex = 1;
            this.btnnewPT.Text = "PT mới";
            this.btnnewPT.UseVisualStyleBackColor = true;
            this.btnnewPT.Click += new System.EventHandler(this.btnnewPT_Click);
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btntinh.Location = new System.Drawing.Point(149, 233);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(83, 34);
            this.btntinh.TabIndex = 2;
            this.btntinh.Text = "GIải";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnthoat.Location = new System.Drawing.Point(290, 233);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(84, 34);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Out";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtkq);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ số A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ số B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(38, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ số C";
            // 
            // txtsoA
            // 
            this.txtsoA.Location = new System.Drawing.Point(154, 27);
            this.txtsoA.Name = "txtsoA";
            this.txtsoA.Size = new System.Drawing.Size(160, 23);
            this.txtsoA.TabIndex = 3;
            // 
            // txtsoB
            // 
            this.txtsoB.Location = new System.Drawing.Point(154, 92);
            this.txtsoB.Name = "txtsoB";
            this.txtsoB.Size = new System.Drawing.Size(160, 23);
            this.txtsoB.TabIndex = 4;
            // 
            // txtsoC
            // 
            this.txtsoC.Location = new System.Drawing.Point(154, 167);
            this.txtsoC.Name = "txtsoC";
            this.txtsoC.Size = new System.Drawing.Size(160, 23);
            this.txtsoC.TabIndex = 5;
            // 
            // btnchuyen1
            // 
            this.btnchuyen1.Location = new System.Drawing.Point(268, 274);
            this.btnchuyen1.Name = "btnchuyen1";
            this.btnchuyen1.Size = new System.Drawing.Size(106, 23);
            this.btnchuyen1.TabIndex = 4;
            this.btnchuyen1.Text = "Chuyển về bài 1";
            this.btnchuyen1.UseVisualStyleBackColor = true;
            this.btnchuyen1.Click += new System.EventHandler(this.btnchuyen1_Click);
            // 
            // btnchuyen2
            // 
            this.btnchuyen2.Location = new System.Drawing.Point(268, 303);
            this.btnchuyen2.Name = "btnchuyen2";
            this.btnchuyen2.Size = new System.Drawing.Size(106, 23);
            this.btnchuyen2.TabIndex = 5;
            this.btnchuyen2.Text = "Chuyển về bài 2";
            this.btnchuyen2.UseVisualStyleBackColor = true;
            this.btnchuyen2.Click += new System.EventHandler(this.btnchuyen2_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(7, 23);
            this.txtkq.Multiline = true;
            this.txtkq.Name = "txtkq";
            this.txtkq.ReadOnly = true;
            this.txtkq.Size = new System.Drawing.Size(349, 126);
            this.txtkq.TabIndex = 0;
            // 
            // PTBac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 499);
            this.Controls.Add(this.btnchuyen2);
            this.Controls.Add(this.btnchuyen1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.btnnewPT);
            this.Controls.Add(this.groupBox1);
            this.Name = "PTBac2";
            this.Text = "PTBac2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsoC;
        private System.Windows.Forms.TextBox txtsoB;
        private System.Windows.Forms.TextBox txtsoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnewPT;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnchuyen1;
        private System.Windows.Forms.Button btnchuyen2;
        private System.Windows.Forms.TextBox txtkq;
    }
}
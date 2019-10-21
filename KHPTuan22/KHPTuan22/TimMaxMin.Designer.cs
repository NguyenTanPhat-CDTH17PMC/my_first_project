namespace KHPTuan22
{
    partial class TimMaxMin
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
            this.btntim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnchuyen3 = new System.Windows.Forms.Button();
            this.btnchuyen1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtso2);
            this.groupBox1.Controls.Add(this.txtso1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập giá trị";
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(184, 124);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(108, 48);
            this.btntim.TabIndex = 1;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmin);
            this.groupBox2.Controls.Add(this.txtmax);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(223, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(23, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(223, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Min";
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(71, 45);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 2;
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(290, 45);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 3;
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(71, 61);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(100, 20);
            this.txtmax.TabIndex = 4;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(290, 58);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(100, 20);
            this.txtmin.TabIndex = 5;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(376, 149);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Out";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnchuyen3
            // 
            this.btnchuyen3.Location = new System.Drawing.Point(13, 124);
            this.btnchuyen3.Name = "btnchuyen3";
            this.btnchuyen3.Size = new System.Drawing.Size(120, 23);
            this.btnchuyen3.TabIndex = 4;
            this.btnchuyen3.Text = "Chuyển đến bài 3";
            this.btnchuyen3.UseVisualStyleBackColor = true;
            this.btnchuyen3.Click += new System.EventHandler(this.btnchuyen3_Click);
            // 
            // btnchuyen1
            // 
            this.btnchuyen1.Location = new System.Drawing.Point(13, 149);
            this.btnchuyen1.Name = "btnchuyen1";
            this.btnchuyen1.Size = new System.Drawing.Size(120, 23);
            this.btnchuyen1.TabIndex = 5;
            this.btnchuyen1.Text = "Chuyển về bài 1";
            this.btnchuyen1.UseVisualStyleBackColor = true;
            this.btnchuyen1.Click += new System.EventHandler(this.btnchuyen1_Click);
            // 
            // TimMaxMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 305);
            this.Controls.Add(this.btnchuyen1);
            this.Controls.Add(this.btnchuyen3);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimMaxMin";
            this.Text = "TimMaxMin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnchuyen3;
        private System.Windows.Forms.Button btnchuyen1;
    }
}
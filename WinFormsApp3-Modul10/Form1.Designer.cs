namespace WinFormsApp3_Modul10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbAsal = new TextBox();
            tbTujuan = new TextBox();
            tbBerat = new TextBox();
            rbJne = new RadioButton();
            rbPos = new RadioButton();
            rbTiki = new RadioButton();
            button1 = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(98, 50);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 0;
            label1.Text = "Cek Harga Ongkir";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 109);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 1;
            label2.Text = "Kota/Kabupaten Awal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 193);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 2;
            label3.Text = "Kota/Kabupaten Tujuan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 277);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Berat (gram)";
            // 
            // tbAsal
            // 
            tbAsal.Location = new Point(98, 127);
            tbAsal.Name = "tbAsal";
            tbAsal.Size = new Size(237, 23);
            tbAsal.TabIndex = 4;
            // 
            // tbTujuan
            // 
            tbTujuan.Location = new Point(98, 211);
            tbTujuan.Name = "tbTujuan";
            tbTujuan.Size = new Size(237, 23);
            tbTujuan.TabIndex = 5;
            // 
            // tbBerat
            // 
            tbBerat.Location = new Point(98, 295);
            tbBerat.Name = "tbBerat";
            tbBerat.Size = new Size(237, 23);
            tbBerat.TabIndex = 6;
            // 
            // rbJne
            // 
            rbJne.AutoSize = true;
            rbJne.Location = new Point(98, 345);
            rbJne.Name = "rbJne";
            rbJne.Size = new Size(47, 19);
            rbJne.TabIndex = 7;
            rbJne.TabStop = true;
            rbJne.Text = "POS";
            rbJne.UseVisualStyleBackColor = true;
            // 
            // rbPos
            // 
            rbPos.AutoSize = true;
            rbPos.Location = new Point(173, 345);
            rbPos.Name = "rbPos";
            rbPos.Size = new Size(44, 19);
            rbPos.TabIndex = 8;
            rbPos.TabStop = true;
            rbPos.Text = "JNE";
            rbPos.UseVisualStyleBackColor = true;
            // 
            // rbTiki
            // 
            rbTiki.AutoSize = true;
            rbTiki.Location = new Point(241, 345);
            rbTiki.Name = "rbTiki";
            rbTiki.Size = new Size(44, 19);
            rbTiki.TabIndex = 9;
            rbTiki.TabStop = true;
            rbTiki.Text = "TIKI";
            rbTiki.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(98, 399);
            button1.Name = "button1";
            button1.Size = new Size(237, 23);
            button1.TabIndex = 10;
            button1.Text = "Cek Harga Layanan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(399, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 313);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Layanan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 487);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(rbTiki);
            Controls.Add(rbPos);
            Controls.Add(rbJne);
            Controls.Add(tbBerat);
            Controls.Add(tbTujuan);
            Controls.Add(tbAsal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbAsal;
        private TextBox tbTujuan;
        private TextBox tbBerat;
        private RadioButton rbJne;
        private RadioButton rbPos;
        private RadioButton rbTiki;
        private Button button1;
        private GroupBox groupBox1;
    }
}
namespace DoAnCuoiKy
{
    partial class FormTaoHopDong
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
            panel1 = new Panel();
            buttonXong = new Button();
            panel3 = new Panel();
            textBoxSdt = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBoxHoTen = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            comboBoxCaLam = new ComboBox();
            comboBoxGioLam = new ComboBox();
            checkBoxNganHanTheoCa = new CheckBox();
            checkBoxNganHanTheoGio = new CheckBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonXong);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 240);
            panel1.TabIndex = 0;
            // 
            // buttonXong
            // 
            buttonXong.Location = new Point(367, 197);
            buttonXong.Name = "buttonXong";
            buttonXong.Size = new Size(94, 29);
            buttonXong.TabIndex = 2;
            buttonXong.Text = "Xong";
            buttonXong.UseVisualStyleBackColor = true;
            buttonXong.Click += buttonXong_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxSdt);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(512, 55);
            panel3.TabIndex = 1;
            // 
            // textBoxSdt
            // 
            textBoxSdt.Location = new Point(220, 19);
            textBoxSdt.Name = "textBoxSdt";
            textBoxSdt.Size = new Size(272, 27);
            textBoxSdt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(153, 31);
            label2.TabIndex = 0;
            label2.Text = "Số điện thoại:";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxHoTen);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(512, 55);
            panel2.TabIndex = 0;
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(220, 19);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(272, 27);
            textBoxHoTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(116, 31);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBoxCaLam);
            panel4.Controls.Add(comboBoxGioLam);
            panel4.Controls.Add(checkBoxNganHanTheoCa);
            panel4.Controls.Add(checkBoxNganHanTheoGio);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(12, 134);
            panel4.Name = "panel4";
            panel4.Size = new Size(512, 69);
            panel4.TabIndex = 2;
            // 
            // comboBoxCaLam
            // 
            comboBoxCaLam.Enabled = false;
            comboBoxCaLam.FormattingEnabled = true;
            comboBoxCaLam.Location = new Point(351, 37);
            comboBoxCaLam.Name = "comboBoxCaLam";
            comboBoxCaLam.Size = new Size(139, 28);
            comboBoxCaLam.TabIndex = 4;
            this.comboBoxCaLam.Items.AddRange(new object[] {
            "sáng - chiều",
            "chiều - tối",
            "sáng - tối"});
            // 
            // comboBoxGioLam
            // 
            comboBoxGioLam.Enabled = false;
            comboBoxGioLam.FormattingEnabled = true;
            comboBoxGioLam.Location = new Point(351, 3);
            comboBoxGioLam.Name = "comboBoxGioLam";
            comboBoxGioLam.Size = new Size(139, 28);
            comboBoxGioLam.TabIndex = 3;
            this.comboBoxGioLam.Items.AddRange(new object[] {
            "7h - 9h",
            "13h - 15h",
            "17h - 19h"});
            // 
            // checkBoxNganHanTheoCa
            // 
            checkBoxNganHanTheoCa.AutoSize = true;
            checkBoxNganHanTheoCa.Location = new Point(187, 37);
            checkBoxNganHanTheoCa.Name = "checkBoxNganHanTheoCa";
            checkBoxNganHanTheoCa.Size = new Size(158, 24);
            checkBoxNganHanTheoCa.TabIndex = 2;
            checkBoxNganHanTheoCa.Text = "Ngắn hạn (theo ca)";
            checkBoxNganHanTheoCa.UseVisualStyleBackColor = true;
            checkBoxNganHanTheoCa.CheckedChanged += checkBoxNganHanTheoCa_CheckedChanged;
            // 
            // checkBoxNganHanTheoGio
            // 
            checkBoxNganHanTheoGio.AutoSize = true;
            checkBoxNganHanTheoGio.Location = new Point(187, 3);
            checkBoxNganHanTheoGio.Name = "checkBoxNganHanTheoGio";
            checkBoxNganHanTheoGio.Size = new Size(165, 24);
            checkBoxNganHanTheoGio.TabIndex = 1;
            checkBoxNganHanTheoGio.Text = "Ngắn hạn (theo giờ)";
            checkBoxNganHanTheoGio.UseVisualStyleBackColor = true;
            checkBoxNganHanTheoGio.CheckedChanged += checkBoxNganHanTheoGio_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 13);
            label3.Name = "label3";
            label3.Size = new Size(168, 31);
            label3.TabIndex = 0;
            label3.Text = "Loại hợp đồng:";
            // 
            // FormTaoHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 264);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "FormTaoHopDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTaoHopDong";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox textBoxSdt;
        private Label label2;
        private TextBox textBoxHoTen;
        private Panel panel4;
        private CheckBox checkBoxNganHanTheoCa;
        private CheckBox checkBoxNganHanTheoGio;
        private Label label3;
        private Button buttonXong;
        private ComboBox comboBoxCaLam;
        private ComboBox comboBoxGioLam;
    }
}
namespace DoAnCuoiKy
{
    partial class FormDanhSachHopDong
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
            dataGridViewHopDong = new DataGridView();
            buttonTaiHD = new Button();
            buttonHuyHD = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHopDong).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHopDong
            // 
            dataGridViewHopDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewHopDong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewHopDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHopDong.Location = new Point(12, 12);
            dataGridViewHopDong.Name = "dataGridViewHopDong";
            dataGridViewHopDong.RowHeadersWidth = 51;
            dataGridViewHopDong.RowTemplate.Height = 29;
            dataGridViewHopDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHopDong.Size = new Size(652, 317);
            dataGridViewHopDong.TabIndex = 0;
            // 
            // buttonTaiHD
            // 
            buttonTaiHD.AutoSize = true;
            buttonTaiHD.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTaiHD.Location = new Point(12, 335);
            buttonTaiHD.Name = "buttonTaiHD";
            buttonTaiHD.Size = new Size(127, 35);
            buttonTaiHD.TabIndex = 1;
            buttonTaiHD.Text = "Tái hợp đồng";
            buttonTaiHD.UseVisualStyleBackColor = true;
            buttonTaiHD.Click += buttonTaiHD_Click;
            // 
            // buttonHuyHD
            // 
            buttonHuyHD.AutoSize = true;
            buttonHuyHD.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHuyHD.Location = new Point(145, 335);
            buttonHuyHD.Name = "buttonHuyHD";
            buttonHuyHD.Size = new Size(139, 35);
            buttonHuyHD.TabIndex = 2;
            buttonHuyHD.Text = "Hủy hợp đồng";
            buttonHuyHD.UseVisualStyleBackColor = true;
            buttonHuyHD.Click += buttonHuyHD_Click;
            // 
            // FormDanhSachHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 380);
            Controls.Add(buttonHuyHD);
            Controls.Add(buttonTaiHD);
            Controls.Add(dataGridViewHopDong);
            Name = "FormDanhSachHopDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DanhSachHopDong";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHopDong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHopDong;
        private Button buttonTaiHD;
        private Button buttonHuyHD;
    }
}
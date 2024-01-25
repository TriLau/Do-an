using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCuoiKy
{
    public partial class FormTaoHopDong : Form
    {
        private HopDong newHopDong;

        public HopDong NewHopDong
        {
            get { return newHopDong; }
            set { newHopDong = value; }
        }

        public FormTaoHopDong()
        {
            InitializeComponent();
        }

        private void buttonXong_Click(object sender, EventArgs e)
        {
            if (textBoxHoTen.Text.Length > 0 && textBoxSdt.Text.Length > 0 && (checkBoxNganHanTheoGio.Checked == true || checkBoxNganHanTheoCa.Checked == true))
            {
                newHopDong = new HopDong();
                string newTen = textBoxHoTen.Text;
                string newSdt = textBoxSdt.Text;

                newHopDong.TaoHopDongMoi(newTen, newSdt);
                HopDongNganHan hdnh = new HopDongNganHan();
                if (checkBoxNganHanTheoGio.Checked)
                {                  
                    string gioLam = comboBoxGioLam.SelectedItem?.ToString();
                    hdnh.DonDepTheoGio(gioLam);
                }    
                else
                {
                    string caLam = comboBoxCaLam.SelectedItem?.ToString();
                    hdnh.DonDepTheoCa(caLam);
                }    

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void checkBoxNganHanTheoGio_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGioLam.Enabled = false;
            if (checkBoxNganHanTheoGio.Checked)
            {
                checkBoxNganHanTheoCa.Checked = false;
                comboBoxGioLam.Enabled = true;
                comboBoxGioLam.Text = string.Empty;
            }
            comboBoxGioLam.Text = string.Empty;
        }

        private void checkBoxNganHanTheoCa_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCaLam.Enabled = false;
            if (checkBoxNganHanTheoCa.Checked)
            {
                checkBoxNganHanTheoGio.Checked = false;
                comboBoxCaLam.Enabled = true;
                comboBoxCaLam.Text = string.Empty;
            }
            comboBoxCaLam.Text = string.Empty;
        }

        public string GetTenNguoiGiupViec()
        {
            return newHopDong.TenNguoiGiupViec;
        }
    }
}

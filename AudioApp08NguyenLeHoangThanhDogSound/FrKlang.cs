using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;
using System.IO;
namespace AudioApp_08_NguyenLeHoangThanh
{
    public partial class FrAudioKlang : Form
    {
        public FrAudioKlang()
        {
            InitializeComponent();
        }
        static string audiopath = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)) + "\\AudioFiles\\";
        ISoundEngine sf;
        private void FrAudioKlang_Load(object sender, EventArgs e)
        {
            sf = new ISoundEngine();
            this.audioTableAdapter.Fill(this.audio._Audio);
        }
        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            sf.Play2D(txtPath.Text.Trim(), true);
        }
        static DialogResult ch;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = !btnDel.Enabled;
            btnMo.Enabled = !btnMo.Enabled;
            btnRecv.Enabled = !btnRecv.Enabled;
            //
            btnPause.Enabled = !btnPause.Enabled;
            btnPlay.Enabled = !btnPlay.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            btnFaster.Enabled = !btnFaster.Enabled;
            btnLower.Enabled = !btnLower.Enabled;
            btnFT.Enabled = !btnFT.Enabled;
            btnNT.Enabled = !btnNT.Enabled;
            btnFW.Enabled = !btnFW.Enabled;
            btnLT.Enabled = !btnLT.Enabled;
            //
            txtName.Enabled = !txtName.Enabled;
            txtPath.Enabled = !txtPath.Enabled;
            txtLen.Enabled = !txtLen.Enabled;
            txtDes.Enabled = !txtDes.Enabled;
            txtSize.Enabled = !txtSize.Enabled;
            txtType.Enabled = !txtType.Enabled;
            //lưu AudioFiles

            if (btnLoad.Text == "Thêm...")
            {
                ch = openFileDialog1.ShowDialog();
                btnLoad.Text = "Lưu...";
            }
            else
            {
                if (ch == DialogResult.OK)
                {
                    try
                    {
                        System.IO.File.Copy(openFileDialog1.FileName, audiopath + Path.GetFileName(openFileDialog1.FileName), true);
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi copy file:" + ex.Message); }
                }
                //Cập nhật SQL
                if (txtID.Text != "")
                {
                    try
                    {
                        audioTableAdapter.Insert(txtID.Text.Trim(), audiopath + Path.GetFileName(openFileDialog1.FileName), Path.GetFileName(openFileDialog1.FileName), "", 0, 0.0, "");
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi cập nhật file:" + ex.Message); }
                }
                else MessageBox.Show("Không được để trống mã số!");
                btnLoad.Text = "Thêm...";
            }
            //Tải vào listbox;
            this.audioTableAdapter.Fill(this.audio._Audio);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            sf.SetAllSoundsPaused(true);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sf.StopAllSounds();
        }

        private void btnFaster_Click(object sender, EventArgs e)
        {

        }

        private void btnLower_Click(object sender, EventArgs e)
        {

        }

        private void btnNT_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1) listBox1.SelectedIndex++;
            else listBox1.SelectedIndex = 0;
            btnStop_Click(sender, e);
            btnPlay_Click(sender, e);
        }

        private void btnFW_Click(object sender, EventArgs e)
        {
            if (0 < listBox1.SelectedIndex && listBox1.SelectedIndex <= listBox1.Items.Count - 1) listBox1.SelectedIndex--;
            else listBox1.SelectedIndex = listBox1.Items.Count - 1;
            btnStop_Click(sender, e);
            btnPlay_Click(sender, e);
        }

        private void btnFT_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            btnStop_Click(sender, e);
            btnPlay_Click(sender, e);
        }

        private void btnLT_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            btnStop_Click(sender, e);
            btnPlay_Click(sender, e);
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = !btnDel.Enabled;
            btnLoad.Enabled = !btnLoad.Enabled;
            btnRecv.Enabled = !btnRecv.Enabled;
            //
            btnPause.Enabled = !btnPause.Enabled;
            btnPlay.Enabled = !btnPlay.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            btnFaster.Enabled = !btnFaster.Enabled;
            btnLower.Enabled = !btnLower.Enabled;
            btnFT.Enabled = !btnFT.Enabled;
            btnNT.Enabled = !btnNT.Enabled;
            btnFW.Enabled = !btnFW.Enabled;
            btnLT.Enabled = !btnLT.Enabled;
            //
            txtID.Enabled = !txtID.Enabled;
            txtLen.Enabled = !txtLen.Enabled;
            txtName.Enabled = !txtName.Enabled;
            txtPath.Enabled = !txtPath.Enabled;
            txtSize.Enabled = !txtSize.Enabled;
            txtType.Enabled = !txtType.Enabled;
            if (btnMo.Text == "Sửa thông tin")
            {
                //B1: Thông báo nơi sửa thông tin là các TextBox phía trên
                MessageBox.Show("Sửa thông tin trong các TextBox phía trên");
                btnMo.Text = "Lưu...";
            }
            else
            {
                //B2: Cập nhật dữ liệu của file vừa chon vào DB: Table: Files(filename, description)
                try
                {
                    audioTableAdapter.Update(txtDes.Text, txtID.Text.Trim());
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi cập nhật DB cho File âm thanh vừa sửa :" + ex.Message); }
                btnMo.Text = "Sửa thông tin";
            }
            //B3: Tải file mới vừa nạp vào ListBox và nghe thử / axWMP
            this.audioTableAdapter.Fill(this.audio._Audio);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn muốn xóa(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                //B2: Xóa
                try
                {
                    audioTableAdapter.Delete(txtID.Text.Trim());
                    System.IO.File.Delete(txtPath.Text.Trim());
                    //Tùy: muốn xóa file âm thanh khỏi TM : System.IO.File.Delete(...)
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi Xóa :" + ex.Message); }
            }
            //B3: Tải file mới vừa nạp vào ListBox và nghe thử
            this.audioTableAdapter.Fill(this.audio._Audio);
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Quay lại (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                btnStop_Click(sender, e);
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thoát (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                btnStop_Click(sender, e);
                Application.Exit();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

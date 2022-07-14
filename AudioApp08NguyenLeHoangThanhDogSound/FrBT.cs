using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IrrKlang;

namespace AudioApp_08_NguyenLeHoangThanh
{
    public partial class FrBT : Form
    {
        public FrBT()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        static string audiopath=Path.GetDirectoryName(Application.StartupPath+"//AudioFiles//")  ;
        ISoundEngine sf;
        private void FrBT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'audio._Audio' table. You can move, or remove it, as needed.
            this.audioTableAdapter.Fill(this.audio._Audio);
            sf = new ISoundEngine();
        }

        private void txtsize_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            sf.Play2D(txtpath.Text.Trim(), true);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            sf.SetAllSoundsPaused(true);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sf.StopAllSounds();
        }

        private void btnFT_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
            if (0 < listBox1.SelectedIndex && listBox1.SelectedIndex <= listBox1.Items.Count - 1) listBox1.SelectedIndex--;
            else listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void btnNT_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
            if (0 <= listBox1.SelectedIndex && listBox1.SelectedIndex < listBox1.Items.Count - 1) listBox1.SelectedIndex++;
            else listBox1.SelectedIndex = 0;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
            listBox1.SelectedIndex = 0;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        DialogResult ch;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text.Trim()=="Thêm")
            {
                ch = openFileDialog1.ShowDialog();
                btnAdd.Text = "Lưu";
            }
            else
            {
                if (ch == DialogResult.OK) System.IO.File.Copy(openFileDialog1.FileName, audiopath + Path.GetFileName(openFileDialog1.FileName),true);
                if (txtms.Text != "")
                {
                    audioTableAdapter.Insert(txtms.Text.Trim(), audiopath + Path.GetFileName(openFileDialog1.FileName), Path.GetFileName(openFileDialog1.FileName), "", 0, 0.0, "");
                }
                else MessageBox.Show("Không được để ms trống");
                btnAdd.Text = "Thêm";
            }
            
            this.audioTableAdapter.Fill(this.audio._Audio);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ch = MessageBox.Show("Bạn muốn xóa(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {

                    audioTableAdapter.Delete(txtms.Text.Trim());
                    System.IO.File.Delete(txtpath.Text.Trim());
            }
            this.audioTableAdapter.Fill(this.audio._Audio);
        }
    }
}

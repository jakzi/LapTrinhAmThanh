using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioApp_08_NguyenLeHoangThanh
{
    public partial class FrMain : Form
    {
        public FrMain()
        {
            InitializeComponent();
        }
        //thoát//
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thoát(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(h== DialogResult.Yes)
            {
                Application.Exit();
            }    

        }
        //chạy khi khởi động
        private void FrMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = Enabled;
        }
        //đồng hồ
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Bây giờ là:" + System.DateTime.Now.ToLongTimeString();
        }
        //tắt mở thanh thực đơn
        private void tắtMởThanhThựcĐơnMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = !menuStrip1.Visible;//đảo trạng thái
        }
        //tắt mở thanh công cụ
        private void tắtMởThanhCôngCụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }
        //tắt mở dòng trạng thái
        private void tắtMởDòngTrạngTháiStatusbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
        }
        //tắt mở màn hình
        private void tắtMởMànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }
        //gọi form QLAM WMp
        private void quảnLýÂmThanhBằngWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrAudioWMP fr = new FrAudioWMP();
            fr.ShowDialog();
        }
        //gọi irrKlang
        private void quảnLýÂmThanhBằngIrrKlangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrBT fr = new FrBT();
            fr.ShowDialog();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace AudioApp_08_NguyenLeHoangThanh
{
    partial class FrBT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrBT));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.txtms = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.txtlen = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.lbms = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNT = new System.Windows.Forms.Button();
            this.btnFT = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.audio = new AudioApp_08_NguyenLeHoangThanh.Audio();
            this.audioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.audioTableAdapter = new AudioApp_08_NguyenLeHoangThanh.AudioTableAdapters.AudioTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý âm thanh bằng IRRKLANG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRe);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 365);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLast);
            this.groupBox2.Controls.Add(this.btnFirst);
            this.groupBox2.Controls.Add(this.btnFT);
            this.groupBox2.Controls.Add(this.btnNT);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.btnPlay);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbms);
            this.groupBox2.Controls.Add(this.txtdes);
            this.groupBox2.Controls.Add(this.txtlen);
            this.groupBox2.Controls.Add(this.txtsize);
            this.groupBox2.Controls.Add(this.txttype);
            this.groupBox2.Controls.Add(this.txtpath);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.txtms);
            this.groupBox2.Location = new System.Drawing.Point(394, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 365);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chạy file";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.audioBindingSource;
            this.listBox1.DisplayMember = "filename";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 251);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "filepath";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(135, 311);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(117, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRe
            // 
            this.btnRe.Location = new System.Drawing.Point(258, 311);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(110, 23);
            this.btnRe.TabIndex = 3;
            this.btnRe.Text = "Sửa mô tả";
            this.btnRe.UseVisualStyleBackColor = true;
            // 
            // txtms
            // 
            this.txtms.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "ms", true));
            this.txtms.Location = new System.Drawing.Point(82, 31);
            this.txtms.Name = "txtms";
            this.txtms.Size = new System.Drawing.Size(291, 20);
            this.txtms.TabIndex = 0;
            this.txtms.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtname
            // 
            this.txtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "filename", true));
            this.txtname.Location = new System.Drawing.Point(82, 68);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(291, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtpath
            // 
            this.txtpath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "filepath", true));
            this.txtpath.Location = new System.Drawing.Point(82, 105);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(291, 20);
            this.txtpath.TabIndex = 2;
            // 
            // txttype
            // 
            this.txttype.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "type", true));
            this.txttype.Location = new System.Drawing.Point(82, 142);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(291, 20);
            this.txttype.TabIndex = 3;
            // 
            // txtsize
            // 
            this.txtsize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "size", true));
            this.txtsize.Location = new System.Drawing.Point(82, 178);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(291, 20);
            this.txtsize.TabIndex = 4;
            this.txtsize.TextChanged += new System.EventHandler(this.txtsize_TextChanged);
            // 
            // txtlen
            // 
            this.txtlen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "len", true));
            this.txtlen.Location = new System.Drawing.Point(82, 213);
            this.txtlen.Name = "txtlen";
            this.txtlen.Size = new System.Drawing.Size(291, 20);
            this.txtlen.TabIndex = 5;
            // 
            // txtdes
            // 
            this.txtdes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "des", true));
            this.txtdes.Location = new System.Drawing.Point(82, 249);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(291, 20);
            this.txtdes.TabIndex = 6;
            // 
            // lbms
            // 
            this.lbms.AutoSize = true;
            this.lbms.Location = new System.Drawing.Point(7, 37);
            this.lbms.Name = "lbms";
            this.lbms.Size = new System.Drawing.Size(39, 13);
            this.lbms.TabIndex = 7;
            this.lbms.Text = "Mã số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đường dẫn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Loại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kích thước:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Chiều dài:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mô tả:";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(10, 287);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(122, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Chạy";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(138, 287);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(122, 23);
            this.btnPause.TabIndex = 14;
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(266, 287);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(122, 23);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Dừng";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNT
            // 
            this.btnNT.Location = new System.Drawing.Point(204, 316);
            this.btnNT.Name = "btnNT";
            this.btnNT.Size = new System.Drawing.Size(184, 23);
            this.btnNT.TabIndex = 16;
            this.btnNT.Text = "Tiếp theo";
            this.btnNT.UseVisualStyleBackColor = true;
            this.btnNT.Click += new System.EventHandler(this.btnNT_Click);
            // 
            // btnFT
            // 
            this.btnFT.Location = new System.Drawing.Point(10, 316);
            this.btnFT.Name = "btnFT";
            this.btnFT.Size = new System.Drawing.Size(188, 23);
            this.btnFT.TabIndex = 17;
            this.btnFT.Text = "Trước đó";
            this.btnFT.UseVisualStyleBackColor = true;
            this.btnFT.Click += new System.EventHandler(this.btnFT_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(10, 342);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(188, 23);
            this.btnFirst.TabIndex = 18;
            this.btnFirst.Text = "Đầu tiên";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(204, 342);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(188, 23);
            this.btnLast.TabIndex = 19;
            this.btnLast.Text = "Cuối cùng";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // audio
            // 
            this.audio.DataSetName = "Audio";
            this.audio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // audioBindingSource
            // 
            this.audioBindingSource.DataMember = "Audio";
            this.audioBindingSource.DataSource = this.audio;
            // 
            // audioTableAdapter
            // 
            this.audioTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrBT";
            this.Text = "Form kiểm tra";
            this.Load += new System.EventHandler(this.FrBT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbms;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.TextBox txtlen;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnFT;
        private System.Windows.Forms.Button btnNT;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLast;
        private Audio audio;
        private System.Windows.Forms.BindingSource audioBindingSource;
        private AudioTableAdapters.AudioTableAdapter audioTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
namespace AudioApp_08_NguyenLeHoangThanh
{
    partial class FrAudioWMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrAudioWMP));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.audioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.audio = new AudioApp_08_NguyenLeHoangThanh.Audio();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtLen = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLT = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnFW = new System.Windows.Forms.Button();
            this.btnFaster = new System.Windows.Forms.Button();
            this.btnNT = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnFT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnMo = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnRecv = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.audioTableAdapter = new AudioApp_08_NguyenLeHoangThanh.AudioTableAdapters.AudioTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.audioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.audioBindingSource;
            this.listBox1.DisplayMember = "filename";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 276);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "filepath";
            // 
            // audioBindingSource
            // 
            this.audioBindingSource.DataMember = "Audio";
            this.audioBindingSource.DataSource = this.audio;
            // 
            // audio
            // 
            this.audio.DataSetName = "Audio";
            this.audio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // axWMP
            // 
            this.axWMP.DataBindings.Add(new System.Windows.Forms.Binding("URL", this.audioBindingSource, "filepath", true));
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(6, 23);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(429, 274);
            this.axWMP.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDes);
            this.groupBox1.Controls.Add(this.txtLen);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 373);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí files âm thanh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(195, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Thông tin chi tiết :";
            // 
            // txtDes
            // 
            this.txtDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "des", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "E2"));
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(316, 279);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(150, 23);
            this.txtDes.TabIndex = 15;
            // 
            // txtLen
            // 
            this.txtLen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "len", true));
            this.txtLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLen.Location = new System.Drawing.Point(316, 240);
            this.txtLen.Name = "txtLen";
            this.txtLen.Size = new System.Drawing.Size(150, 23);
            this.txtLen.TabIndex = 14;
            // 
            // txtSize
            // 
            this.txtSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "size", true));
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(316, 198);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(150, 23);
            this.txtSize.TabIndex = 13;
            // 
            // txtType
            // 
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "type", true));
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(316, 162);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(150, 23);
            this.txtType.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "filename", true));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(316, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 23);
            this.txtName.TabIndex = 11;
            // 
            // txtPath
            // 
            this.txtPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "filepath", true));
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(316, 86);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(150, 23);
            this.txtPath.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioBindingSource, "ms", true));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(316, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 23);
            this.txtID.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(254, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mô tả :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(203, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chiều dài ( giây ) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kích thước ( KB ):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loại file ( Type ) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên file ( Name ) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đường dẫn ( path ) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã số file :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn files :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPlay);
            this.groupBox2.Controls.Add(this.btnLT);
            this.groupBox2.Controls.Add(this.btnLower);
            this.groupBox2.Controls.Add(this.btnFW);
            this.groupBox2.Controls.Add(this.btnFaster);
            this.groupBox2.Controls.Add(this.btnNT);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.btnFT);
            this.groupBox2.Controls.Add(this.axWMP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(502, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 373);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nghe thử files âm thanh";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(6, 304);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 16;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnLT
            // 
            this.btnLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLT.Location = new System.Drawing.Point(328, 333);
            this.btnLT.Name = "btnLT";
            this.btnLT.Size = new System.Drawing.Size(107, 23);
            this.btnLT.TabIndex = 15;
            this.btnLT.Text = "Last Track";
            this.btnLT.UseVisualStyleBackColor = true;
            this.btnLT.Click += new System.EventHandler(this.btnLT_Click);
            // 
            // btnLower
            // 
            this.btnLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLower.Location = new System.Drawing.Point(360, 304);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(75, 23);
            this.btnLower.TabIndex = 14;
            this.btnLower.Text = "Lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnFW
            // 
            this.btnFW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFW.Location = new System.Drawing.Point(221, 333);
            this.btnFW.Name = "btnFW";
            this.btnFW.Size = new System.Drawing.Size(107, 23);
            this.btnFW.TabIndex = 13;
            this.btnFW.Text = "Forward Track";
            this.btnFW.UseVisualStyleBackColor = true;
            this.btnFW.Click += new System.EventHandler(this.btnFW_Click);
            // 
            // btnFaster
            // 
            this.btnFaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaster.Location = new System.Drawing.Point(279, 304);
            this.btnFaster.Name = "btnFaster";
            this.btnFaster.Size = new System.Drawing.Size(75, 23);
            this.btnFaster.TabIndex = 12;
            this.btnFaster.Text = "Faster";
            this.btnFaster.UseVisualStyleBackColor = true;
            this.btnFaster.Click += new System.EventHandler(this.btnFaster_Click);
            // 
            // btnNT
            // 
            this.btnNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNT.Location = new System.Drawing.Point(113, 333);
            this.btnNT.Name = "btnNT";
            this.btnNT.Size = new System.Drawing.Size(107, 23);
            this.btnNT.TabIndex = 11;
            this.btnNT.Text = "Next Track";
            this.btnNT.UseVisualStyleBackColor = true;
            this.btnNT.Click += new System.EventHandler(this.btnNT_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(168, 304);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(87, 304);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnFT
            // 
            this.btnFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFT.Location = new System.Drawing.Point(6, 333);
            this.btnFT.Name = "btnFT";
            this.btnFT.Size = new System.Drawing.Size(107, 23);
            this.btnFT.TabIndex = 8;
            this.btnFT.Text = "First Track";
            this.btnFT.UseVisualStyleBackColor = true;
            this.btnFT.Click += new System.EventHandler(this.btnFT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÍ ÂM THANH TIẾNG CHÓ SỦA BẰNG WMPLIB";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(18, 436);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Thêm...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(99, 436);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(93, 23);
            this.btnMo.TabIndex = 6;
            this.btnMo.Text = "Sửa thông tin";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(279, 436);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(830, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 34);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRe
            // 
            this.btnRe.Location = new System.Drawing.Point(711, 436);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(113, 34);
            this.btnRe.TabIndex = 9;
            this.btnRe.Text = "Quay lại";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnRecv
            // 
            this.btnRecv.Location = new System.Drawing.Point(198, 436);
            this.btnRecv.Name = "btnRecv";
            this.btnRecv.Size = new System.Drawing.Size(75, 23);
            this.btnRecv.TabIndex = 10;
            this.btnRecv.Text = "Ghi âm";
            this.btnRecv.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // audioTableAdapter
            // 
            this.audioTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrAudioWMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 471);
            this.Controls.Add(this.btnRecv);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnMo);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrAudioWMP";
            this.Text = "Quản lí âm thanh tiếng chó sủa bằng WMPLIB.DLL";
            this.Load += new System.EventHandler(this.FrAudioProWMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.audioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnRecv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtLen;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLT;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnFW;
        private System.Windows.Forms.Button btnFaster;
        private System.Windows.Forms.Button btnNT;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnFT;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Audio audio;
        private AudioTableAdapters.AudioTableAdapter audioTableAdapter;
        private System.Windows.Forms.BindingSource audioBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
namespace GoruntuIsleme
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pBoriginalresim = new System.Windows.Forms.PictureBox();
            this.gBpriginalresim = new System.Windows.Forms.GroupBox();
            this.btn_yükle = new System.Windows.Forms.Button();
            this.gBislenmisresim = new System.Windows.Forms.GroupBox();
            this.pBislenmisresim = new System.Windows.Forms.PictureBox();
            this.btn_işle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_histogramciz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_trackbar = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_islemler = new System.Windows.Forms.Label();
            this.cbİslemler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoriginalresim)).BeginInit();
            this.gBpriginalresim.SuspendLayout();
            this.gBislenmisresim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBislenmisresim)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoriginalresim
            // 
            this.pBoriginalresim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoriginalresim.Location = new System.Drawing.Point(6, 19);
            this.pBoriginalresim.Name = "pBoriginalresim";
            this.pBoriginalresim.Size = new System.Drawing.Size(457, 377);
            this.pBoriginalresim.TabIndex = 0;
            this.pBoriginalresim.TabStop = false;
            this.pBoriginalresim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBoriginalresim_MouseMove);
            // 
            // gBpriginalresim
            // 
            this.gBpriginalresim.Controls.Add(this.pBoriginalresim);
            this.gBpriginalresim.Location = new System.Drawing.Point(6, 28);
            this.gBpriginalresim.Name = "gBpriginalresim";
            this.gBpriginalresim.Size = new System.Drawing.Size(469, 409);
            this.gBpriginalresim.TabIndex = 1;
            this.gBpriginalresim.TabStop = false;
            // 
            // btn_yükle
            // 
            this.btn_yükle.Location = new System.Drawing.Point(11, 475);
            this.btn_yükle.Name = "btn_yükle";
            this.btn_yükle.Size = new System.Drawing.Size(88, 30);
            this.btn_yükle.TabIndex = 1;
            this.btn_yükle.Text = "Yükle";
            this.btn_yükle.UseVisualStyleBackColor = true;
            this.btn_yükle.Click += new System.EventHandler(this.btn_yükle_Click);
            // 
            // gBislenmisresim
            // 
            this.gBislenmisresim.Controls.Add(this.pBislenmisresim);
            this.gBislenmisresim.Location = new System.Drawing.Point(481, 28);
            this.gBislenmisresim.Name = "gBislenmisresim";
            this.gBislenmisresim.Size = new System.Drawing.Size(471, 409);
            this.gBislenmisresim.TabIndex = 2;
            this.gBislenmisresim.TabStop = false;
            // 
            // pBislenmisresim
            // 
            this.pBislenmisresim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBislenmisresim.Location = new System.Drawing.Point(18, 19);
            this.pBislenmisresim.Name = "pBislenmisresim";
            this.pBislenmisresim.Size = new System.Drawing.Size(443, 377);
            this.pBislenmisresim.TabIndex = 0;
            this.pBislenmisresim.TabStop = false;
            // 
            // btn_işle
            // 
            this.btn_işle.Location = new System.Drawing.Point(847, 474);
            this.btn_işle.Name = "btn_işle";
            this.btn_işle.Size = new System.Drawing.Size(88, 30);
            this.btn_işle.TabIndex = 1;
            this.btn_işle.Text = "Düzenle";
            this.btn_işle.UseVisualStyleBackColor = true;
            this.btn_işle.Click += new System.EventHandler(this.btn_işle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_histogramciz);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.lbl_trackbar);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.lbl_islemler);
            this.groupBox1.Controls.Add(this.cbİslemler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gBpriginalresim);
            this.groupBox1.Controls.Add(this.btn_işle);
            this.groupBox1.Controls.Add(this.gBislenmisresim);
            this.groupBox1.Controls.Add(this.btn_yükle);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 520);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_histogramciz
            // 
            this.btn_histogramciz.Location = new System.Drawing.Point(958, 472);
            this.btn_histogramciz.Name = "btn_histogramciz";
            this.btn_histogramciz.Size = new System.Drawing.Size(153, 29);
            this.btn_histogramciz.TabIndex = 11;
            this.btn_histogramciz.Text = "Histogram Çiz";
            this.btn_histogramciz.UseVisualStyleBackColor = true;
            this.btn_histogramciz.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(958, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(153, 29);
            this.textBox1.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(958, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 378);
            this.listBox1.TabIndex = 9;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(847, 440);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(88, 28);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_trackbar
            // 
            this.lbl_trackbar.AutoSize = true;
            this.lbl_trackbar.Location = new System.Drawing.Point(802, 476);
            this.lbl_trackbar.Name = "lbl_trackbar";
            this.lbl_trackbar.Size = new System.Drawing.Size(0, 22);
            this.lbl_trackbar.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(312, 472);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Minimum = -255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(478, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lbl_islemler
            // 
            this.lbl_islemler.AutoSize = true;
            this.lbl_islemler.Location = new System.Drawing.Point(109, 449);
            this.lbl_islemler.Name = "lbl_islemler";
            this.lbl_islemler.Size = new System.Drawing.Size(76, 22);
            this.lbl_islemler.TabIndex = 5;
            this.lbl_islemler.Text = "İşlemler";
            // 
            // cbİslemler
            // 
            this.cbİslemler.FormattingEnabled = true;
            this.cbİslemler.Items.AddRange(new object[] {
            "Mouse İle Renk Alma",
            "Negatifini Alma",
            "Gri Tonlama",
            "Eşikleme",
            "Parlaklık",
            "Kontrast"});
            this.cbİslemler.Location = new System.Drawing.Point(105, 475);
            this.cbİslemler.Name = "cbİslemler";
            this.cbİslemler.Size = new System.Drawing.Size(201, 30);
            this.cbİslemler.TabIndex = 4;
            this.cbİslemler.SelectedIndexChanged += new System.EventHandler(this.cbİslemler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dijital Görüntü İşleme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1148, 538);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dijital Görüntü İşleme Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoriginalresim)).EndInit();
            this.gBpriginalresim.ResumeLayout(false);
            this.gBislenmisresim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBislenmisresim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoriginalresim;
        private System.Windows.Forms.GroupBox gBpriginalresim;
        private System.Windows.Forms.Button btn_yükle;
        private System.Windows.Forms.GroupBox gBislenmisresim;
        private System.Windows.Forms.Button btn_işle;
        private System.Windows.Forms.PictureBox pBislenmisresim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_islemler;
        private System.Windows.Forms.ComboBox cbİslemler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_trackbar;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_histogramciz;
        private System.Windows.Forms.TextBox textBox1;
    }
}


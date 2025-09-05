namespace BooKKer
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            lblInfo = new Label();
            btnImport = new Button();
            btnExport = new Button();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Segoe UI", 10F);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(30, 30);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(307, 95);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "📚 BooKKer\r\nВерсия 06.09.25\r\nАвтор: @BlackPinkMuffin\r\n\r\nПриложение для управления коллекцией книг.";
            // 
            // btnImport
            // 
            btnImport.Location = new Point(30, 160);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(100, 30);
            btnImport.TabIndex = 1;
            btnImport.Text = "📥 Импорт";
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(140, 160);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 30);
            btnExport.TabIndex = 2;
            btnExport.Text = "📤 Экспорт";
            btnExport.Click += btnExport_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(250, 160);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 30);
            btnClose.TabIndex = 3;
            btnClose.Text = "Закрыть";
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(277, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 73);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(384, 220);
            Controls.Add(pictureBox1);
            Controls.Add(lblInfo);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(btnClose);
            Name = "AboutForm";
            Opacity = 0.95D;
            Text = "О программе";
            Load += AboutForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}

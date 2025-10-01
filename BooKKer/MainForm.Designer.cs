namespace BooKKer
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы управления
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.Button btnFindByAuthor;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button btnAbout;

        /// <summary>
        /// Освобождение ресурсов
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Инициализация компонентов формы
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblYear = new Label();
            numYear = new NumericUpDown();
            btnAdd = new Button();
            btnRemove = new Button();
            cmbBooks = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnFindByName = new Button();
            btnFindByAuthor = new Button();
            btnShowAll = new Button();
            lstResults = new ListBox();
            btnAbout = new Button();
            fadeTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = SystemColors.ControlDarkDark;
            lblTitle.Location = new Point(15, 63);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(89, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Название:";
            lblTitle.Click += lblTitle_Click;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(21, 33, 73);
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.ForeColor = SystemColors.ControlDark;
            txtTitle.Location = new Point(105, 66);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(344, 16);
            txtTitle.TabIndex = 1;
            // 
            // lblAuthor
            // 
            lblAuthor.BackColor = Color.Transparent;
            lblAuthor.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold);
            lblAuthor.ForeColor = SystemColors.ControlDarkDark;
            lblAuthor.Location = new Point(44, 91);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(60, 22);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Автор:";
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.FromArgb(21, 33, 73);
            txtAuthor.BorderStyle = BorderStyle.None;
            txtAuthor.ForeColor = SystemColors.ControlDark;
            txtAuthor.Location = new Point(105, 94);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(344, 16);
            txtAuthor.TabIndex = 3;
            // 
            // lblYear
            // 
            lblYear.BackColor = Color.Transparent;
            lblYear.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold);
            lblYear.ForeColor = SystemColors.ControlDarkDark;
            lblYear.Location = new Point(60, 120);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(44, 23);
            lblYear.TabIndex = 4;
            lblYear.Text = "Год:";
            // 
            // numYear
            // 
            numYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numYear.BackColor = Color.FromArgb(21, 33, 73);
            numYear.BorderStyle = BorderStyle.None;
            numYear.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold);
            numYear.ForeColor = SystemColors.ControlDark;
            numYear.Location = new Point(105, 121);
            numYear.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(64, 21);
            numYear.TabIndex = 5;
            numYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(455, 66);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 44);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "➕ Добавить";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Location = new Point(455, 272);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(133, 30);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "❌ Удалить";
            btnRemove.Click += btnRemove_Click;
            // 
            // cmbBooks
            // 
            cmbBooks.AccessibleRole = AccessibleRole.None;
            cmbBooks.BackColor = Color.FromArgb(21, 33, 73);
            cmbBooks.FlatStyle = FlatStyle.Flat;
            cmbBooks.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold);
            cmbBooks.ForeColor = SystemColors.ControlDark;
            cmbBooks.Location = new Point(12, 274);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(437, 28);
            cmbBooks.TabIndex = 8;
            // 
            // lblSearch
            // 
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold);
            lblSearch.ForeColor = SystemColors.ControlDarkDark;
            lblSearch.Location = new Point(593, 5);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(59, 23);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Поиск:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(21, 19, 56);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(661, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(316, 16);
            txtSearch.TabIndex = 10;
            // 
            // btnFindByName
            // 
            btnFindByName.FlatStyle = FlatStyle.Flat;
            btnFindByName.Location = new Point(596, 31);
            btnFindByName.Name = "btnFindByName";
            btnFindByName.Size = new Size(185, 30);
            btnFindByName.TabIndex = 11;
            btnFindByName.Text = "🔍 По названию";
            btnFindByName.Click += btnFindByName_Click;
            // 
            // btnFindByAuthor
            // 
            btnFindByAuthor.FlatStyle = FlatStyle.Flat;
            btnFindByAuthor.Location = new Point(791, 31);
            btnFindByAuthor.Name = "btnFindByAuthor";
            btnFindByAuthor.Size = new Size(186, 30);
            btnFindByAuthor.TabIndex = 12;
            btnFindByAuthor.Text = "🔍 По автору";
            btnFindByAuthor.Click += btnFindByAuthor_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.FlatAppearance.BorderSize = 0;
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Location = new Point(596, 67);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(381, 30);
            btnShowAll.TabIndex = 13;
            btnShowAll.Text = "📋 Показать все";
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lstResults
            // 
            lstResults.BackColor = Color.FromArgb(21, 19, 56);
            lstResults.BorderStyle = BorderStyle.None;
            lstResults.ForeColor = SystemColors.ControlDark;
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(596, 103);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(381, 240);
            lstResults.TabIndex = 14;
            lstResults.SelectedIndexChanged += lstResults_SelectedIndexChanged;
            // 
            // btnAbout
            // 
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Location = new Point(12, 314);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(118, 30);
            btnAbout.TabIndex = 17;
            btnAbout.Text = "ℹ️ О программе";
            btnAbout.Click += btnAbout_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Medium", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(229, 34);
            label1.TabIndex = 18;
            label1.Text = "Добавить книгу";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Franklin Gothic Medium", 21.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(15, 227);
            label2.Name = "label2";
            label2.Size = new Size(187, 34);
            label2.TabIndex = 19;
            label2.Text = "Список книг";
            label2.Click += label2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(988, 356);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblAuthor);
            Controls.Add(txtAuthor);
            Controls.Add(lblYear);
            Controls.Add(numYear);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(cmbBooks);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnFindByName);
            Controls.Add(btnFindByAuthor);
            Controls.Add(btnShowAll);
            Controls.Add(lstResults);
            Controls.Add(btnAbout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BooKKer";
            Load += MainForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
    }
}

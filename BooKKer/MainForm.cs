using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BooKKer
{
    public partial class MainForm : Form
    {
        private BookManager bookManager = Program.BookManager;
        private System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();

        public MainForm()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10);
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            this.Load += MainForm_Load;

            // Стилизация кнопок
            StyleButton(btnAdd);
            StyleButton(btnRemove);
            StyleButton(btnFindByName);
            StyleButton(btnFindByAuthor);
            StyleButton(btnShowAll);
            StyleButton(btnAbout);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshBookList();
            this.ShowInTaskbar = true;

            fadeTimer.Interval = 20;
            fadeTimer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fadeTimer.Stop();
            };
            fadeTimer.Start();
        }

        public void RefreshBookList()
        {
            cmbBooks.Items.Clear();
            cmbBooks.Items.AddRange(bookManager.GetAllBooks().ToArray());
        }


        private void btnAbout_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm(this);
            aboutForm.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Выберите CSV-файл для импорта",
                Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var books = CsvBookLoader.LoadBooks(dialog.FileName);
                bookManager.SetBooks(books);
                RefreshBookList();
                MessageBox.Show("Книги успешно импортированы!", "Импорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                Title = "Сохранить книги в файл",
                Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CsvBookLoader.SaveBooks(dialog.FileName, bookManager.GetAllBooks());
                MessageBox.Show("Книги успешно сохранены!", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            int year = (int)numYear.Value;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Пожалуйста, заполните поля 'Название' и 'Автор'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            new AddBook(bookManager).Execute(title, author, year);
            RefreshBookList();

            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtTitle.Focus();

            MessageBox.Show("Книга успешно добавлена!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedItem is not Book selectedBook)
            {
                MessageBox.Show("Пожалуйста, выберите книгу для удаления.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bookManager.RemoveBook(selectedBook);
            RefreshBookList();

            MessageBox.Show("Книга удалена из коллекции.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnFindByName_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Введите название книги для поиска.", "Поиск по названию", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var results = new FindBookByName(bookManager).Execute(query);
            ShowSearchResults(results);
        }
        private void btnFindByAuthor_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Введите имя автора для поиска.", "Поиск по автору", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var results = new FindBookByAuthor(bookManager).Execute(query);
            ShowSearchResults(results);
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var results = new PrintAllBooks(bookManager).Execute();
            ShowSearchResults(results);
        }
        private void ShowSearchResults(List<Book> books)
        {
            lstResults.Items.Clear();
            foreach (var book in books)
            {
                lstResults.Items.Add($"{book.Title} — {book.Author} ({book.Year})");
            }
        }

        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.FromArgb(100, 30, 30, 30);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 40, 40, 40);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 50, 50, 50);

            btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 12, 12));
            btn.Resize += (s, e) =>
            {
                btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 12, 12));
            };
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        // Остальные события формы
        private void txtSearch_TextChanged(object sender, EventArgs e) { }
        private void txtAuthor_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://trk.mail.ru/c/h172vv5",
                UseShellExecute = true
            });
        }

        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

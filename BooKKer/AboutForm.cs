using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BooKKer
{
    public partial class AboutForm : Form
    {
        private System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
        private MainForm mainForm;

        public AboutForm(MainForm form)
        {
            mainForm = form;
            InitializeComponent();

            this.Text = "О программе";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10);
            this.Opacity = 0;

            this.Load += AboutForm_Load;
            fadeTimer.Interval = 20;
            fadeTimer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fadeTimer.Stop();
            };

            StyleButton(btnImport);
            StyleButton(btnExport);
            StyleButton(btnClose);
        }

        private void AboutForm_Load(object sender, EventArgs e) => fadeTimer.Start();

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
                Program.BookManager.SetBooks(books);
                mainForm.RefreshBookList();
                MessageBox.Show("Книги успешно импортированы!", "Импорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
                CsvBookLoader.SaveBooks(dialog.FileName, Program.BookManager.GetAllBooks());
                MessageBox.Show("Книги успешно сохранены!", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

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
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

        private void AboutForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooKKer
{
    public partial class SplashForm : Form
    {
        public static BookManager SharedBookManager = new BookManager();
        public static string SelectedFilePath;

        public SplashForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.Load += SplashForm_Load;
        }

        private async void SplashForm_Load(object? sender, EventArgs e)
        {
            await Task.Delay(500); // короткая пауза для анимации
            this.Close(); // закрываем заставку
        }


        private async Task LoadBooksWithProgress()
        {
            if (!File.Exists(SelectedFilePath))
                return;

            var lines = await Task.Run(() => File.ReadAllLines(SelectedFilePath));
            int total = lines.Length;
            var books = new System.Collections.Generic.List<Book>();

            for (int i = 0; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length < 3) continue;

                string title = parts[0];
                string author = parts[1];
                if (!int.TryParse(parts[2], out int year)) continue;

                books.Add(new Book(title, author, year));

                int progress = (int)((i + 1) / (float)total * 100);
                progressBar1.Value = Math.Min(progress, 100);
                await Task.Delay(10);
            }

            SharedBookManager.SetBooks(books);
        }
    }
}

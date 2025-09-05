
namespace BooKKer
{
    public class AddBook
    {
        private BookManager manager;
        public AddBook(BookManager manager) => this.manager = manager;
        public void Execute(string title, string author, int year) =>
            manager.AddBook(new Book(title, author, year));
    }

    public class RemoveBook
    {
        private BookManager manager;
        public RemoveBook(BookManager manager) => this.manager = manager;
        public bool Execute(Book book) => manager.RemoveBook(book);
    }

    public class FindBookByName
    {
        private BookManager manager;
        public FindBookByName(BookManager manager) => this.manager = manager;
        public List<Book> Execute(string name) => manager.FindBookByName(name);
    }

    public class FindBookByAuthor
    {
        private BookManager manager;
        public FindBookByAuthor(BookManager manager) => this.manager = manager;
        public List<Book> Execute(string author) => manager.FindBookByAuthor(author);
    }

    public class PrintAllBooks
    {
        private BookManager manager;
        public PrintAllBooks(BookManager manager) => this.manager = manager;
        public List<Book> Execute() => manager.GetAllBooks();
    }
}

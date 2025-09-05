using System;
using System.Collections.Generic;
using System.IO;
using BooKKer;

public class CsvBookLoader
{
    public static List<Book> LoadBooks(string filePath)
    {
        var books = new List<Book>();
        if (!File.Exists(filePath)) return books;

        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split(',');
            if (parts.Length < 3) continue;

            string title = parts[0];
            string author = parts[1];
            if (!int.TryParse(parts[2], out int year)) continue;

            books.Add(new Book(title, author, year));
        }

        return books;
    }

    public static void SaveBooks(string filePath, List<Book> books)
    {
        var lines = books.Select(book => $"{book.Title},{book.Author},{book.Year}");
        File.WriteAllLines(filePath, lines);
    }
}

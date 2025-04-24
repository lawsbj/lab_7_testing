using Laws_Brody_Lab_5.Models;
using System.Net;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Laws_Brody_Lab_5.Services
{

    
    public class LibraryService : ILibraryService
    {
        public List<User> Users { get; set; }
        public List<Book> Books { get;  set; }

        public Dictionary<User, List<Book>> BorrowedBooks { get; set; }

        public LibraryService()
        {
            //Users = ReadUsers();
            Users = new List<User>();
            //Books = ReadBooks();
            Books = new List<Book>();
            BorrowedBooks = new Dictionary<User, List<Book>>();
        }
        public void AddBook(string title, string author, string isbn)
        {
            int id = Books.Any() ? Books.Max(b => b.Id) + 1 : 1;
            Books.Add(new Book { Id = id, Title = title, Author = author, ISBN = isbn });

            //SaveBooksToCSV();

        }

        public void AddUser(string name, string email)
        {
            int id = Users.Any() ? Users.Max(u => u.Id) + 1 : 1;
            Users.Add(new User { Id = id, Name = name, Email = email });
            //SaveUsersToCSV();
        }

        public void DeleteBook(int bookId)
        {
            Book book = Books.FirstOrDefault(b => b.Id == bookId);

            if (book != null)
            {
                Books.Remove(book);
            }
            //SaveBooksToCSV();
        }

        public void DeleteUser(int userId)
        {
            User user = Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                Users.Remove(user);
            }
            //SaveUsersToCSV();
        }

        public void EditBook(int bookId , string title, string author, string isbn)
        {
            Book bookToUpdate = Books.FirstOrDefault(u => u.Id == bookId);

            Books.Remove(bookToUpdate);

            bookToUpdate.Title = title;
            bookToUpdate.Author = author;
            bookToUpdate.ISBN = isbn;

            Books.Add(bookToUpdate);

            //SaveBooksToCSV();
        }

        public void EditUser(int userId, string name, string email)
        {
            User userToUpdate = Users.FirstOrDefault(u => u.Id == userId);

            Users.Remove(userToUpdate);

            userToUpdate.Name = name;
            userToUpdate.Email = email;

            Users.Add(userToUpdate);

            //SaveUsersToCSV();
        }

        public List<Book> ReadBooks()
        {
            List<Book> tempBooks = new List<Book>();
            foreach (var line in File.ReadLines("./Data/Books.csv"))
            {
                var fields = line.Split(',');

                if (fields.Length >= 4)
                {
                    var book = new Book
                    {
                        Id = int.Parse(fields[0].Trim()),
                        Title = fields[1].Trim(),
                        Author = fields[2].Trim(),
                        ISBN = fields[3].Trim()
                    };

                    
                    tempBooks.Add(book);
                }
                
            }
            return tempBooks;
        }

        public List<User> ReadUsers()
        {
            List<User> tempUsers = new List<User>();
            foreach (var line in File.ReadLines("./Data/Users.csv"))
            {
                var fields = line.Split(',');

                if (fields.Length >= 3) 
                {
                    var user = new User
                    {
                        Id = int.Parse(fields[0].Trim()),
                        Name = fields[1].Trim(),
                        Email = fields[2].Trim()
                    };

                    tempUsers.Add(user);
                }
            }

            return tempUsers;
        }

        public void SaveUsersToCSV()
        {
            var lines = new List<string> ();
            lines.AddRange(Users.Select(u => $"{u.Id},{u.Name},{u.Email}"));

            File.WriteAllLines("./Data/Users.csv", lines);
        }

        public void SaveBooksToCSV()
        {
            var lines = new List<string>();
            lines.AddRange(Books.Select(b=> $"{b.Id},{b.Title},{b.Author},{b.ISBN}"));

            File.WriteAllLines("./Data/Books.csv", lines);
        }
    }
}

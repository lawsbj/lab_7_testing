using Laws_Brody_Lab_5.Models;

namespace Laws_Brody_Lab_5.Services
{
    public interface ILibraryService
    {
        public List<User> Users { get; set; }

        public List<Book> Books { get; set; }
        public Dictionary<User, List<Book>> BorrowedBooks { get; set; }

        // books 
        List<Book> ReadBooks();

        void AddBook(string title, string author, string isbn);
        void DeleteBook(int bookId);
        void EditBook(int bookId, string title, string author, string isbn);

        // users 
        List<User> ReadUsers();
        void AddUser(string name, string email);
        void DeleteUser(int userId);
        void EditUser(int userId, string name, string email);

        // saving functions
        void SaveUsersToCSV();

        void SaveBooksToCSV();

    }
}
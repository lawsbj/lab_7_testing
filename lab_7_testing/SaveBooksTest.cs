using Laws_Brody_Lab_5.Models;
using Laws_Brody_Lab_5.Services;

namespace Lab_5_Testing
{
    [DoNotParallelize]
    [TestClass]
    public sealed class SaveBooksTest
    {
        [TestMethod]
        public void GoodSaveBooks()
        {
            //Arrange
            LibraryService test = new LibraryService();

            List<Book> books = new List<Book>();
            //act 
            test.Books = test.ReadBooks();

            test.AddBook("test", "me", "123");

            int num = test.Books.Count();

            test.SaveBooksToCSV();

            books = test.ReadBooks();

            
            // assert

            Assert.AreEqual((num), books.Count());
        }


        // kinda cant make a bad one given how the method is written
        [TestMethod]
        public void BadSaveBooks()
        {
            //Arrange
            LibraryService test = new LibraryService();

            List<Book> books = new List<Book>();
            //act 
            test.Books = test.ReadBooks();

            test.AddBook("test", "me", "123");

            int num = test.Books.Count();

            test.SaveBooksToCSV();

            books = test.ReadBooks();


            // assert

            Assert.AreEqual((num), books.Count());
        }
    }
}

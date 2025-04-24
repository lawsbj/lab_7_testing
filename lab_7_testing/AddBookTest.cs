
using Laws_Brody_Lab_5.Models;
using Laws_Brody_Lab_5.Services;

namespace Lab_5_Testing
{
    [DoNotParallelize]
    [TestClass]
    public sealed class AddBookTest
    {
        [TestMethod]
        public void GoodAddBookTitle()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddBook("test", "me", "123");

            // assert

            Assert.AreEqual("test", test.Books[0].Title);
        }
        [TestMethod]
        public void GoodAddBookAuthor()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddBook("test", "me", "123");

            // assert

            Assert.AreEqual("me", test.Books[0].Author);
        }
        [TestMethod]
        public void GoodAddBookISBN()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddBook("test", "me", "123");

            // assert

            Assert.AreEqual("123", test.Books[0].ISBN);
        }

        [TestMethod]
        public void BadAddBookTitleNullValue()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddBook(null, "me", "123");

            // assert

            Assert.AreEqual(null, test.Books[0].Title);
        }
        [TestMethod]
        public void BadAddBookAuthorNullValue()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddBook("test", null, "123");

            // assert

            Assert.AreEqual(null, test.Books[0].Author);
        }
        [TestMethod]
        public void BadAddBookISBNNullValue()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddBook("test", "me", null);

            // assert

            Assert.AreEqual(null, test.Books[0].ISBN);
        }

    }
}

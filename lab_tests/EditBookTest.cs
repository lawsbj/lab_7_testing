using Laws_Brody_Lab_5.Services;

namespace Lab_5_Testing
{
    [DoNotParallelize]
    [TestClass]
    public sealed class EditBookTest
    {
        [TestMethod]
        public void GoodEditBookTitle()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddBook("test", "me", "123");

            test.EditBook(1, "updated", "me", "123");

            // assert

            Assert.AreEqual("updated", test.Books[0].Title);
        }
        [TestMethod]
        public void GoodEditBookAuthor()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddBook("test", "me", "123");

            test.EditBook(1, "test", "updated", "123");
            // assert

            Assert.AreEqual("updated", test.Books[0].Author);
        }
        [TestMethod]
        public void GoodEditBookISBN()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddBook("test", "me", "123");

            test.EditBook(1, "test", "me", "updated");

            // assert

            Assert.AreEqual("updated", test.Books[0].ISBN);
        }

        [TestMethod]
        public void BadEditBookTitleNullValue()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddBook("test", "me", "123");

            test.EditBook(1, null, "me", "123");
            // assert

            Assert.AreEqual(null, test.Books[0].Title);
        }
        [TestMethod]
        public void BadEditBookAuthorNullValue()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddBook("test", "me", "123");

            test.EditBook(1, "test", null, "123");

            // assert

            Assert.AreEqual(null, test.Books[0].Author);
        }
        [TestMethod]
        public void BadEditBookISBNNullValue()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddBook("test", "me", "123");

            test.EditBook(1, "test", "me", null);

            // assert

            Assert.AreEqual(null, test.Books[0].ISBN);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void BadEditBookNotRealIdPositive()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 

            test.AddBook("test", "me", "123");

            test.EditBook(3, "updated", "me", "123");
            // assert

        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void BadEditBookNotRealIdNegative()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 

            test.AddBook("test", "me", "123");

            test.EditBook(-1, "updated", "me", "123");
            // assert

            
        }
    }
}

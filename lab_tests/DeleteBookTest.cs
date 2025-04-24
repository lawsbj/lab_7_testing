using Laws_Brody_Lab_5.Services;

namespace Lab_5_Testing
{
    [DoNotParallelize]
    [TestClass]
    public sealed class DeleteBookTest
    {
        [TestMethod]
        public void GoodDeleteBookUsingIdOfRealBook()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddBook("test", "me", "123");

            test.DeleteBook(1);

            // assert

            Assert.AreEqual(0, test.Books.Count());
        }
        [TestMethod]
        public void BadDeleteBookUsingIdOfNotRealBook()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddBook("test", "me", "123");

            test.DeleteBook(2);

            // assert

            Assert.AreEqual(1, test.Books.Count());
        }
        [TestMethod]
        public void BadDeleteBookUsingNegativeIdOfNotRealBook()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddBook("test", "me", "123");

            test.DeleteBook(-1);

            // assert

            Assert.AreEqual(1, test.Books.Count());
        }
    }
}

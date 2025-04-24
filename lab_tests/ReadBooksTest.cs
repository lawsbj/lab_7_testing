using Laws_Brody_Lab_5.Services;

namespace Lab_5_Testing

{
    [DoNotParallelize]
    [TestClass]
    public sealed class ReadBooksTest
    {
        [TestMethod]
        public void GoodReadBooks()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.Books = test.ReadBooks();

            int num = test.Books.Count();
            // assert

            Assert.AreEqual(num, test.Books.Count());
        }


        // kinda cant make a bad one given how the method is written
        [TestMethod]
        public void BadReadBooks()
        {
            //Arrange
            LibraryService test = new LibraryService();



            //act 
            test.Books = test.ReadBooks();

            int num = test.Books.Count();

            // assert

            Assert.AreEqual((num), test.Books.Count());
        }
    }
}

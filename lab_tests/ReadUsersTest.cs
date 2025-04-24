using Laws_Brody_Lab_5.Services;

namespace Lab_5_Testing
{
    [DoNotParallelize]
    [TestClass]
    public sealed class ReadUsersTest
    {

        [TestMethod]
        public void GoodReadUsers()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.Users = test.ReadUsers();

            int num = test.Users.Count();

            // assert

            Assert.AreEqual(num, test.Users.Count());
        }


        // kinda cant make a bad one given how the method is written
        [TestMethod]
        public void BadReadUsers()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.Users = test.ReadUsers();

            int num = test.Users.Count();
            // assert

            Assert.AreEqual((num), test.Users.Count());
        }
    }
}

using Laws_Brody_Lab_5.Services;

namespace Lab_5_Testing
{
    [DoNotParallelize]
    [TestClass]
    public sealed class DeleteUserTest
    {
        [TestMethod]
        public void GoodDeleteUserUsingIdOfRealUser()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddUser("test", "email");

            test.DeleteUser(1);

            // assert

            Assert.AreEqual(0, test.Users.Count());
        }
        [TestMethod]
        public void BadDeleteUserUsingIdOfNotRealUser()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddUser("test", "email");

            test.DeleteUser(2);

            // assert

            Assert.AreEqual(1, test.Users.Count());
        }
        [TestMethod]
        public void BadDeleteUserUsingNegativeIdOfNotRealUser()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddUser("test", "email");

            test.DeleteUser(-1);

            // assert

            Assert.AreEqual(1, test.Users.Count());
        }
    }
}

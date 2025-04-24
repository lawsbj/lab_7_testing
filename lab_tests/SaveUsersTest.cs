using Laws_Brody_Lab_5.Models;
using Laws_Brody_Lab_5.Services;

namespace Lab_5_Testing
{
    [DoNotParallelize]
    [TestClass]
    public sealed class SaveUsersTest
    {
        [TestMethod]
        public void GoodSaveUsers()
        {
            //Arrange
            LibraryService test = new LibraryService();

            List<User> Users = new List<User>();
            //act 
            test.Users = test.ReadUsers();

            test.AddUser("test", "me");

            int num = test.Users.Count();

            test.SaveUsersToCSV();

            Users = test.ReadUsers();


            // assert

            Assert.AreEqual((num), Users.Count());


        }


        // kinda cant make a bad one given how the method is written
        [TestMethod]
        public void BadSaveUsers()
        {
            //Arrange
            LibraryService test = new LibraryService();

            List<User> Users = new List<User>();
            //act 
            test.Users = test.ReadUsers();

            test.AddUser("test", "me");

            int num = test.Users.Count();

            test.SaveUsersToCSV();

            Users = test.ReadUsers();


            // assert

            Assert.AreEqual((num), Users.Count());
        }
    }
}

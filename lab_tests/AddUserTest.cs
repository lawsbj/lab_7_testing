using Laws_Brody_Lab_5.Models;
using Laws_Brody_Lab_5.Services;

namespace Lab_5_Testing
{
    [DoNotParallelize]
    [TestClass]
    public sealed class AddUserTest
    {
        [TestMethod]
        public void GoodAddUserName()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddUser("test", "email");


            // assert

            Assert.AreEqual("test", test.Users[0].Name);
        }
        [TestMethod]
        public void GoodAddUserAuthor()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddUser("test", "email");

            // assert

            Assert.AreEqual("email", test.Users[0].Email);
        }
        

        [TestMethod]
        public void BadAddUserNameNullValue()
        {
            //Arrange
            LibraryService test = new LibraryService();
            //act 
            test.AddUser(null, "email");

            // assert

            Assert.AreEqual(null, test.Users[0].Name);
        }
        [TestMethod]
        public void BadAddUserAuthorNullValue()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddUser("test", null);

            // assert

            Assert.AreEqual(null, test.Users[0].Email);
        }
        


    }
}

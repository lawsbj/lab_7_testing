using Laws_Brody_Lab_5.Services;

namespace Lab_5_Testing
{
    [DoNotParallelize]
    [TestClass]
    public sealed class EditUserTest
    {
        [TestMethod]
        public void GoodEditUserName()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddUser("test", "email");

            test.EditUser(1, "updated", "email");
            // assert

            Assert.AreEqual("updated", test.Users[0].Name);
        }
        [TestMethod]
        public void GoodEditUserAuthor()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddUser("test", "email");

            test.EditUser(1, "test", "updated");
            // assert

            Assert.AreEqual("updated", test.Users[0].Email);
        }


        [TestMethod]
        public void BadEditUserNameNullValue()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddUser("test", "email");

            test.EditUser(1, null, "email");
            // assert

            Assert.AreEqual(null, test.Users[0].Name);
        }
        [TestMethod]
        public void BadEditUserAuthorNullValue()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddUser("test", "email");

            test.EditUser(1, "test", null);

            // assert

            Assert.AreEqual(null, test.Users[0].Email);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void BadEditUserNotRealIdPositive()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddUser("test", "email");

            test.EditUser(3, "hi", "monkey");

            // assert

            
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void BadEditUserNotRealIdNegative()
        {
            //Arrange
            LibraryService test = new LibraryService();

            //act 
            test.AddUser("test", "email");

            test.EditUser(-1, "hi", "monkey");

            // assert

            
        }
    }
}

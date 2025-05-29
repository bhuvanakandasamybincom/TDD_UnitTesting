using ClassLibraryProject;
//using NUnit.Framework;

namespace TestProjectLibrary
{
    public class MyLibraryTests
    {
        [Fact]
        
        public void Add_TwoNumbers_ReturnsSum_Negative()
        {
            // Arrange
            MyLibrary library = new MyLibrary();
            int x = 5;
            int y = 10;

            // Act
            int result = library.Add(x, y);

            // Assert
            Assert.Equal(1,result);
        }
        [Fact]
        public void Add_TwoNumbers_ReturnsSum_Positive()
        {
            // Arrange
            MyLibrary library = new MyLibrary();
            int x = 5;
            int y = 10;

            // Act
            int result = library.Add(x, y);

            // Assert
            Assert.Equal(15, result);
        }
    }
}
using Menopaws;
using Menopaws.Data;
using Moq;
using NUnit.Framework;
using Xamarin.Forms;

namespace UnitTests
{
    [TestFixture]
    public class MainPageViewModelTests
    {
        [Test]
        public void CanAddOneHotFlushItemToList()
        {
            // Arrange
            Mock<INavigation> mockNavigation = new Mock<INavigation>();
            Mock<IMenopausalDataStore> mockDataStore = new Mock<IMenopausalDataStore>();
            MainPageViewModel modelToTest = new MainPageViewModel(mockNavigation.Object, mockDataStore.Object);

            // Act
            //modelToTest.AddHotFlush();

            // Assert

        }
    }
}

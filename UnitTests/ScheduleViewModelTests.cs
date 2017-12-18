using Menopaws;
using Menopaws.Data;
using Menopaws.Models;
using Moq;
using NUnit.Framework;
using Xamarin.Forms;

namespace UnitTests
{
    [TestFixture]
    public class ScheduleViewModelTests
    {
        [Test]
        public void CanAddOneHotFlushItemToList()
        {
            // Arrange
            Mock<IMenopausalDataStore> mockDataStore = new Mock<IMenopausalDataStore>();
            ScheduleViewModel modelToTest = new ScheduleViewModel(mockDataStore.Object);
            var hotFlush = new MenopausalEvent {Description = "Boo!"};

            // Act
            modelToTest.AddHotFlush(hotFlush);

            // Assert
            mockDataStore.Verify(x => x.AddEvent(hotFlush), Times.Exactly(1));
        }
    }

    public class ScheduleViewModel
    {
        public ScheduleViewModel(IMenopausalDataStore menopausalDataStore)
        {
            MenopausalDataStore = menopausalDataStore;
        }

        public IMenopausalDataStore MenopausalDataStore { get; }

        public void AddHotFlush(MenopausalEvent hotFlush)
        {
            MenopausalDataStore.AddEvent(hotFlush);
        }
    }
}

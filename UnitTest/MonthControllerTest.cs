using Microsoft.AspNetCore.Mvc;
using newHouseCommittee.Controllers;

namespace UnitTest
{
    public class MonthControllerTest
    {
        private readonly MonthController _monthController;
        
        public MonthControllerTest(DataContextFake context)
        {
            var context = new DataContextFake();
            _monthController = new MonthController(context);
        }
        [Fact]
        public void GetReturenOk()
        {
            var result = _monthController.Get();
            Assert.IsType<OkObjectResult>(result);
        }
        public void GetById_ReturnOk()
        {
            //Arrange - ארגון הפרמטרים שישלחו לבדיקה
            var id = 1;

            //Act - ביצוע הפעולה
            var result = _monthController.Get(id);

            //Assert - הצהרה מה התוצאה הרצויה
            Assert.IsType<OkObjectResult>(result);
        }
        public void GetById_ReturnNotFound()
        {
            //Arrange
            var id = 3;

            //Act
            var result = _monthController.Get(id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
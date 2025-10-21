using Tyuiu.KachulinMV.Sprint0.Task4.V1.Lib;

namespace Tyuiu.KachulinMV.Sprint0.Task4.V1.Test
{
    public class DataServiceTest
    {
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(10, DataService.Substraction(5, 5));
        }

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(10, DataService.Multiplication(5, 5));
        }

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(10, DataService.Division(9, 3));
        }
    }
}



















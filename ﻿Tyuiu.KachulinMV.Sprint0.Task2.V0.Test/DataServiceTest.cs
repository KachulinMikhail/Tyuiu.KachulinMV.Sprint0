using _Tyuiu.KachulinMV.Sprint0.Task2.V0.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _Tyuiu.KachulinMV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            //Область создания методов тестирования, методов из библиотеки
            var name = "Михаил";
            var res = DataService.GetMassage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Михаил", res);
        }
    }
}

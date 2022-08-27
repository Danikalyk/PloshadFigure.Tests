namespace PloshadFigure.Tests
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void Triangles_3and4and5returned6()
        {
            //arrange
            double a = 3; double b = 4; double c = 5; string expected = "Площадь: 6 Тип треугольника: Прямоугольный";
            //act
            Figures fs = new Figures();
            string result = fs.Triangle(a, b, c);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Circle_5returned78534()
        {
            //arrange
            double radius = 5; double expected = 78.54;
            //act
            Figures fs = new Figures();
            double result = fs.Circle(radius);
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
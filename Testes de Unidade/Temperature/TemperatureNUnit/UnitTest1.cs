using NUnit.Framework;
using Temperature;

namespace TemperatureNUnit
{
    public class TestesConversorTemperature
    {
        [TestCase(32, 0)]
        [TestCase(47, 8.33)]
        [TestCase(86, 30)]
        [TestCase(90.5, 32.5)]
        [TestCase(120.18, 48.99)]
        [TestCase(212, 100)]
        public void TesteConversaoTemperature(
            double tempFahrenheit, double tempCelsius)
        {
            double valorCalculado =
                ConversorTemperature.FahrenheitParaCelsius(tempFahrenheit);
            Assert.AreEqual(tempCelsius, valorCalculado);
        }
    }
}
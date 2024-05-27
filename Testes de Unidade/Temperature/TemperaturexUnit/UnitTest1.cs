using System;
using Temperature;
using Xunit;

namespace TemperaturaTests
{
    public class TestesConversorTemperature
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(47, 8.33)]
        [InlineData(86, 30)]
        [InlineData(90.5, 32.5)]
        [InlineData(120.18, 48.99)]
        [InlineData(212, 100)]
        public void TestarConversaoTemperature(
            double fahrenheit, double celsius)
        {
            double valorCalculado =
                ConversorTemperature.FahrenheitParaCelsius(fahrenheit);
            Assert.Equal(celsius, valorCalculado);
        }
    }
}
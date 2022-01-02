using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController forecastController = new WeatherForecastController();

        [Fact]
        public void TestName()
        {
            var returnValue = forecastController.Get();
            Assert.Equal("Jehangir",returnValue);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}

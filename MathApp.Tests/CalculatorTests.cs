using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathApp;
using Xunit;
namespace MathApp.Tests
{ 
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Assert.Equal(5, Calculator.Add(2, 3));
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(-6, 3, -2)]
        public void Divide_ValidNumbers_ReturnsResult(int a, int b, int expected)
        {
            Assert.Equal(expected, Calculator.Divide(a, b));
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var ex = Assert.Throws<ArgumentException>(() => Calculator.Divide(10, 0));
            Assert.Contains("cannot be zero", ex.Message, StringComparison.OrdinalIgnoreCase);
        }
    }
}

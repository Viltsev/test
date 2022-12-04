using System;
using Xunit;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    
    public class UnitTest1
    {
        // UNIT тесты

        [Fact]
        public void Plustest()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            //act
            FuncMath f = new FuncMath();
            int actial =  f.plus(x, y);

            //assert
            Xunit.Assert.Equal(expected, actial );

        }

        [Fact]
        public void MulTest()
        {
            int x = -5;
            int y = -5;
            int expected = 25;

            FuncMath f = new FuncMath();
            int actial = f.multiplication(x, y);

            Xunit.Assert.Equal(expected, actial);
        }

        //Negative - выброс исключения
        [Fact]
        public void DivisionTest_xOnZero()
        {
            int x = 5;
            int y = 0;

            FuncMath f = new FuncMath();
            Xunit.Assert.Throws<ArithmeticException>( () => f.division(x, y));


        }
        // Positive - без исключения
        [Fact]
        public void DivisionTest_xOnNoneZero()
        {
            int x = 6;
            int y = 2;
            int expected = 3;
            FuncMath f = new FuncMath();
            int actial = f.division(x, y);
            Xunit.Assert.Equal(expected, actial);

        }
        [Fact]

        public void factorialTest_xIsNegative()
        {
            int x = -1;
            FuncMath f = new FuncMath();
            Xunit.Assert.Throws<ArgumentOutOfRangeException>(() => f.factorial(x));


        }
        // Positive - без исключения
        [Fact]
        public void factorialTest_xIsNotZero()
        {
            int x = 6;
            long expected = 720;
            FuncMath f = new FuncMath();
            long actial = f.factorial(x);
            Xunit.Assert.Equal(expected, actial);

        }
    }
}

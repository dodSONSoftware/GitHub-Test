using System;
using Xunit;

namespace Globeranger.Sample.ClassLib.UnitTests {

    public class CalculatorTests {

        [Fact]
        public void Add_ShouldAdd_Success ( ) {

            // arrange
            ICalculator calc = new Calculator ( );

            // act
            var result = calc.Add ( 1, 1 );

            // assert
            Assert.Equal ( 2, result );
        }

        [Fact]
        public void Add_ShouldAdd_Fail ( ) {

            // arrange
            ICalculator calc = new Calculator ( );

            // act
            var result = calc.Add ( 1, 1 );

            // assert
            Assert.NotEqual ( 0, result );
        }

        [Fact]
        public void Add_ShouldSubtract_Success ( ) {

            // arrange
            ICalculator calc = new Calculator ( );

            // act
            var result = calc.Subtract ( 1, 1 );

            // assert
            Assert.Equal ( 0, result );
        }

        [Fact]
        public void Add_ShouldSubtract_Fail ( ) {

            // arrange
            ICalculator calc = new Calculator ( );

            // act
            var result = calc.Subtract ( 1, 1 );

            // assert
            Assert.NotEqual ( 1, result );
        }

        [Fact]
        public void Add_ShouldMultiply_Success ( ) {

            // arrange
            ICalculator calc = new Calculator ( );

            // act
            var result = calc.Multiply ( 2, 2 );

            // assert
            Assert.Equal ( 4, result );
        }

        [Fact]
        public void Add_ShouldMultiply_Fail ( ) {

            // arrange
            ICalculator calc = new Calculator ( );

            // act
            var result = calc.Multiply ( 2, 2 );

            // assert
            Assert.NotEqual ( 0, result );
        }

        [Fact]
        public void Add_ShouldDivide_Success ( ) {

            // arrange
            ICalculator calc = new Calculator ( );

            // act
            var result = calc.Divide ( 21, 3 );

            // assert
            Assert.Equal ( 7, result );
        }

        [Fact]
        public void Add_ShouldDivide_Fail ( ) {

            // arrange
            ICalculator calc = new Calculator ( );

            // act
            var result = calc.Divide ( 21, 3 );

            // assert
            Assert.NotEqual ( 0, result );
        }

        [Fact]
        public void Add_ShouldDivide_ByZero_IsInfinity ( ) {

            // arrange
            ICalculator calc = new Calculator ( );

            // act
            var x = calc.Divide ( 21, 0 );

            // assert 
            Assert.True ( double.IsInfinity ( x ) );
        }

        [Fact]
        public void Add_ShouldModulus_Success ( ) {

            // arrange
            ICalculator calc = new Calculator ( );

            // act
            var result = calc.Modulus ( 10, 4 );

            // assert
            Assert.Equal ( 2, result );
        }

        [Fact]
        public void Add_ShouldModulus_Fail ( ) {

            // arrange
            ICalculator calc = new Calculator ( );

            // act
            var result = calc.Modulus ( 10, 4 );

            // assert
            Assert.NotEqual ( 0, result );
        }
    }
}

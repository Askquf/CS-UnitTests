using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestLinearAlgebra;

namespace UnitTestProject
{
    /// <summary>
    /// Checks the work of the MathVector's class public methods.
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Checks the overload of the operator+,
        /// when all coordinates are positive.
        /// </summary>
        [TestMethod]
        public void PlusForPositiveVectorOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = 1.0; vec1[1] = 2.0; vec1[2] = 3.0;
            var vec2 = new MathVector(3);
            vec2[0] = 4.0; vec2[1] = 5.0; vec2[2] = 6.0;
            var expected = new MathVector(3);
            expected[0] = 5.0; expected[1] = 7.0; expected[2] = 9.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 + vec2;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);

        }

        /// <summary>
        /// Checks the work of the method "IMathVector MathVector.Sum(IMathVector vector),
        /// when all coordinates are positive.
        /// </summary>
        [TestMethod]
        public void PlusForPositiveVector()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = 1.0; vec1[1] = 2.0; vec1[2] = 3.0;
            var vec2 = new MathVector(3);
            vec2[0] = 4.0; vec2[1] = 5.0; vec2[2] = 6.0;
            var expected = new MathVector(3);
            expected[0] = 5.0; expected[1] = 7.0; expected[2] = 9.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.Sum(vec2);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator+ for negative vector and possitive vector
        /// </summary>
        [TestMethod]
        public void PlusForPositiveAndNegativeVectorOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -1.0; vec1[1] = -2.0; vec1[2] = -3.0;
            var vec2 = new MathVector(3);
            vec2[0] = 4.0; vec2[1] = 15.0; vec2[2] = 8.0;
            var expected = new MathVector(3);
            expected[0] = 3.0; expected[1] = 13.0; expected[2] = 5.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 + vec2;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "IMathVector MathVector.Sum(IMathVector vector),
        /// for possitive and negative
        /// </summary>
        [TestMethod]
        public void PlusForPositiveAndNegativeVector()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -1.0; vec1[1] = -2.0; vec1[2] = -3.0;
            var vec2 = new MathVector(3);
            vec2[0] = 4.0; vec2[1] = 15.0; vec2[2] = 8.0;
            var expected = new MathVector(3);
            expected[0] = 3.0; expected[1] = 13.0; expected[2] = 5.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.Sum(vec2);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator+,
        /// when the second vector's coordinates are negative.
        /// </summary>
        [TestMethod]
        public void PlusForNegativeVectorOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -1.0; vec1[1] = -2.0; vec1[2] = -3.0;
            var vec2 = new MathVector(3);
            vec2[0] = -4.0; vec2[1] = -15.0; vec2[2] = -8.0;
            var expected = new MathVector(3);
            expected[0] = -5.0; expected[1] = -17.0; expected[2] = -11.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 + vec2;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "IMathVector MathVector.Sum(IMathVector vector),
        /// when the second vector's coordinates are negative.
        /// </summary>
        [TestMethod]
        public void PlusForNegativeVector()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -1.0; vec1[1] = -2.0; vec1[2] = -3.0;
            var vec2 = new MathVector(3);
            vec2[0] = -4.0; vec2[1] = -15.0; vec2[2] = -8.0;
            var expected = new MathVector(3);
            expected[0] = -5.0; expected[1] = -17.0; expected[2] = -11.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.Sum(vec2);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator+,
        /// when some vectors coordinates are zeroes.
        /// </summary>
        [TestMethod]
        public void PlusForNegativeOrPositiveVectorAndNullOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = 1.0; vec1[1] = 2.0; vec1[2] = 0.0;
            var vec2 = new MathVector(3);
            vec2[0] = 0.0; vec2[1] = -2.0; vec2[2] = -8.0;
            var expected = new MathVector(3);
            expected[0] = 1.0; expected[1] = 0.0; expected[2] = -8.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 + vec2;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "IMathVector MathVector.Sum(IMathVector vector),
        /// when some vectors coordinates are zeroes.
        /// </summary>
        [TestMethod]
        public void PlusForNegativeOrPositiveVectorAndNull()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = 1.0; vec1[1] = 2.0; vec1[2] = 0.0;
            var vec2 = new MathVector(3);
            vec2[0] = 0.0; vec2[1] = -2.0; vec2[2] = -8.0;
            var expected = new MathVector(3);
            expected[0] = 1.0; expected[1] = 0.0; expected[2] = -8.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.Sum(vec2);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator-,
        /// when all coordinates are positive.
        /// </summary>
        [TestMethod]
        public void MinusForPositiveVectorOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = 11.0; vec1[1] = 24.0; vec1[2] = 35.0;
            var vec2 = new MathVector(3);
            vec2[0] = 4.0; vec2[1] = 5.0; vec2[2] = 6.0;
            var expected = new MathVector(3);
            expected[0] = 7.0; expected[1] = 19.0; expected[2] = 29.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 - vec2;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "IMathVector MathVector.Sum(IMathVector vector),
        /// when all coordinates are positive.
        /// </summary>
        [TestMethod]
        public void MinusForPositiveVector()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = 11.0; vec1[1] = 24.0; vec1[2] = 35.0;
            var vec2 = new MathVector(3);
            vec2[0] = 4.0; vec2[1] = 5.0; vec2[2] = 6.0;
            var expected = new MathVector(3);
            expected[0] = 7.0; expected[1] = 19.0; expected[2] = 29.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.Sum(vec2.MultiplyNumber(-1));

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator-,
        /// when some coordinates are negative.
        /// </summary>
        [TestMethod]
        public void MinusForPositiveAndNegativeVectorOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 24.0; vec1[2] = -35.0;
            var vec2 = new MathVector(3);
            vec2[0] = 4.0; vec2[1] = -5.0; vec2[2] = 6.0;
            var expected = new MathVector(3);
            expected[0] = -15.0; expected[1] = 29.0; expected[2] = -41.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 - vec2;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "IMathVector MathVector.Sum(IMathVector vector),
        /// when some coordinates are negative.
        /// </summary>
        [TestMethod]
        public void MinusForPositiveAndNegativeVector()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 24.0; vec1[2] = -35.0;
            var vec2 = new MathVector(3);
            vec2[0] = 4.0; vec2[1] = -5.0; vec2[2] = 6.0;
            var expected = new MathVector(3);
            expected[0] = -15.0; expected[1] = 29.0; expected[2] = -41.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.Sum(vec2.MultiplyNumber(-1));

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator+,
        /// when some coordinates are negative.
        /// </summary>
        [TestMethod]
        public void MinusForNegativeVectorOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = -24.0; vec1[2] = -35.0;
            var vec2 = new MathVector(3);
            vec2[0] = -4.0; vec2[1] = -5.0; vec2[2] = -6.0;
            var expected = new MathVector(3);
            expected[0] = -7.0; expected[1] = -19.0; expected[2] = -29.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 - vec2;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "IMathVector MathVector.Sum(IMathVector vector),
        /// when some coordinates are negative.
        /// </summary>
        [TestMethod]
        public void MinusForNegativeVector()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = -24.0; vec1[2] = -35.0;
            var vec2 = new MathVector(3);
            vec2[0] = -4.0; vec2[1] = -5.0; vec2[2] = -6.0;
            var expected = new MathVector(3);
            expected[0] = -7.0; expected[1] = -19.0; expected[2] = -29.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.Sum(vec2.MultiplyNumber(-1));

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator-,
        /// when some coordinates are zeroes.
        /// </summary>
        [TestMethod]
        public void MinusForNegativeOrPositiveVectorAndNullOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 0.0; vec1[2] = 0.0;
            var vec2 = new MathVector(3);
            vec2[0] = 0.0; vec2[1] = 5.0; vec2[2] = -3.0;
            var expected = new MathVector(3);
            expected[0] = -11.0; expected[1] = -5.0; expected[2] = 3.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 - vec2;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "IMathVector MathVector.Sum(IMathVector vector),
        /// when some coordinates are zeroes.
        /// </summary>
        [TestMethod]
        public void MinusForNegativeOrPositiveVectorAndNull()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 0.0; vec1[2] = 0.0;
            var vec2 = new MathVector(3);
            vec2[0] = 0.0; vec2[1] = 5.0; vec2[2] = -3.0;
            var expected = new MathVector(3);
            expected[0] = -11.0; expected[1] = -5.0; expected[2] = 3.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.Sum(vec2.MultiplyNumber(-1));

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator+,
        /// when number is positive.
        /// </summary>
        [TestMethod]
        public void PlusForVectorAndPositiveNumberOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 3.0;
            var expected = new MathVector(3);
            expected[0] = -8.0; expected[1] = 13.0; expected[2] = 3.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 + number;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the  work of the method "IMathVector MathVector.SumNumber(double number)"
        /// when number is positive.
        /// </summary>
        [TestMethod]
        public void PlusForVectorAndPositiveNumber()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 3.0;
            var expected = new MathVector(3);
            expected[0] = -8.0; expected[1] = 13.0; expected[2] = 3.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.SumNumber(number);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator-,
        /// when number is positive.
        /// </summary>
        [TestMethod]
        public void MinusForVectorAndPositiveNumberOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 3.0;
            var expected = new MathVector(3);
            expected[0] = -14.0; expected[1] = 7.0; expected[2] = -3.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 - number;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the  work of the method "IMathVector MathVector.SumNumber(double number)"
        /// when number is positive.
        /// </summary>
        [TestMethod]
        public void MinusForVectorAndPositiveNumber()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 3.0;
            var expected = new MathVector(3);
            expected[0] = -14.0; expected[1] = 7.0; expected[2] = -3.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.SumNumber((-1) * number);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator+,
        /// when number is negative.
        /// </summary>
        [TestMethod]
        public void PlusForVectorAndNegativeNumberOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = -3.0;
            var expected = new MathVector(3);
            expected[0] = -14.0; expected[1] = 7.0; expected[2] = -3.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 + number;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the  work of the method "IMathVector MathVector.SumNumber(double number)"
        /// when number is negative.
        /// </summary>
        [TestMethod]
        public void PlusForVectorAndNegativeNumber()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = -3.0;
            var expected = new MathVector(3);
            expected[0] = -14.0; expected[1] = 7.0; expected[2] = -3.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.SumNumber(number);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator-,
        /// when number is negative.
        /// </summary>
        [TestMethod]
        public void MinusForVectorAndNegativeNumberOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = -3.0;
            var expected = new MathVector(3);
            expected[0] = -8.0; expected[1] = 13.0; expected[2] = 3.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 - number;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the  work of the method "IMathVector MathVector.SumNumber(double number)"
        /// when number is negative.
        /// </summary>
        [TestMethod]
        public void MinusForVectorAndNegativeNumber()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = -3.0;
            var expected = new MathVector(3);
            expected[0] = -8.0; expected[1] = 13.0; expected[2] = 3.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.SumNumber((-1) * number);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator+,
        /// when number is zero.
        /// </summary>
        [TestMethod]
        public void PlusForVectorAndNullOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 0.0;
            var expected = new MathVector(3);
            expected[0] = -11.0; expected[1] = 10.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 + number;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the  work of the method "IMathVector MathVector.SumNumber(double number)"
        /// when number is zero.
        /// </summary>
        [TestMethod]
        public void PlusForVectorAndNull()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 0.0;
            var expected = new MathVector(3);
            expected[0] = -11.0; expected[1] = 10.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.SumNumber(number);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator-,
        /// when number is zero.
        /// </summary>
        [TestMethod]
        public void MinusForVectorAndNullOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 0.0;
            var expected = new MathVector(3);
            expected[0] = -11.0; expected[1] = 10.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 - number;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the  work of the method "IMathVector MathVector.SumNumber(double number)"
        /// when number is positive.
        /// </summary>
        [TestMethod]
        public void MinusForVectorAndNull()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 0.0;
            var expected = new MathVector(3);
            expected[0] = -11.0; expected[1] = 10.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.SumNumber((-1) * number);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator*,
        /// when coordinates are positive-positive, positive-negative, negative-negative.
        /// </summary>
        [TestMethod]
        public void MultForPositiveAndNegativeVectorOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 10.0;
            var vec2 = new MathVector(3);
            vec2[0] = -3.0; vec2[1] = -2.0; vec2[2] = 14.0;
            var expected = new MathVector(3);
            expected[0] = 33.0; expected[1] = -20.0; expected[2] = 140.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 * vec2;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the  work of the method "IMathVector MathVector.Multiply(IMathVector vector),
        /// when coordinates are positive-positive, positive-negative, negative-negative.
        /// </summary>
        [TestMethod]
        public void MultForPositiveAndNegativeVector()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 10.0;
            var vec2 = new MathVector(3);
            vec2[0] = -3.0; vec2[1] = -2.0; vec2[2] = 14.0;
            var expected = new MathVector(3);
            expected[0] = 33.0; expected[1] = -20.0; expected[2] = 140.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.Multiply(vec2);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator*,
        /// when some coordinates are zeroes.
        /// </summary>
        [TestMethod]
        public void MultForVectorWithNullOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            var vec2 = new MathVector(3);
            vec2[0] = -3.0; vec2[1] = -2.0; vec2[2] = 14.0;
            var expected = new MathVector(3);
            expected[0] = 33.0; expected[1] = -20.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 * vec2;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the  work of the method "IMathVector MathVector.Multiply(IMathVector vector),
        /// when some coordinates are zeroes.
        /// </summary>
        [TestMethod]
        public void MultForVectorWithNull()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            var vec2 = new MathVector(3);
            vec2[0] = -3.0; vec2[1] = -2.0; vec2[2] = 14.0;
            var expected = new MathVector(3);
            expected[0] = 33.0; expected[1] = -20.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.Multiply(vec2);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator*,
        /// when number is positive.
        /// </summary>
        [TestMethod]
        public void MultForVectorAndPositiveNumberOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 3.0;
            var expected = new MathVector(3);
            expected[0] = -33.0; expected[1] = 30.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 * number;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "double MathVector.MultiplyNumber(double number),
        /// when number is positive.
        /// </summary>
        [TestMethod]
        public void MultForVectorAndPositiveNumber()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 3.0;
            var expected = new MathVector(3);
            expected[0] = -33.0; expected[1] = 30.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.MultiplyNumber(number);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator*,
        /// when number is negative.
        /// </summary>
        [TestMethod]
        public void MultForVectorAndNegativeNumberOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = -3.0;
            var expected = new MathVector(3);
            expected[0] = 33.0; expected[1] = -30.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 * number;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "double MathVector.MultiplyNumber(double number),
        /// when number is negative.
        /// </summary>
        [TestMethod]
        public void MultForVectorAndNegativeNumber()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = -3.0;
            var expected = new MathVector(3);
            expected[0] = 33.0; expected[1] = -30.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.MultiplyNumber(number);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator*,
        /// when number is zero.
        /// </summary>
        [TestMethod]
        public void MultForVectorAndNullNumberOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 0.0;
            var expected = new MathVector(3);
            expected[0] = 0.0; expected[1] = 0.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 * number;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "double MathVector.MultiplyNumber(double number),
        /// when number is zero.
        /// </summary>
        [TestMethod]
        public void MultForVectorAndNullNumber()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 0.0;
            var expected = new MathVector(3);
            expected[0] = 0.0; expected[1] = 0.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.MultiplyNumber(number);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator/,
        /// when coordinates are positive-positive, positive-negative, negative-negative.
        /// </summary>
        [TestMethod]
        public void DivideForPositiveAndNegativeVectorOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = 35.0; vec1[1] = 10.0; vec1[2] = -10.0;
            var vec2 = new MathVector(3);
            vec2[0] = 7.0; vec2[1] = -5.0; vec2[2] = -10.0;
            var expected = new MathVector(3);
            expected[0] = 5.0; expected[1] = -2.0; expected[2] = 1.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 / vec2;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "double MathVector.DivideNumber(IMathVector vector),
        /// when coordinates are positive-positive, positive-negative, negative-negative.
        /// </summary>
        [TestMethod]
        public void DivideForPositiveAndNegativeVector()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = 35.0; vec1[1] = 10.0; vec1[2] = -10.0;
            var vec2 = new MathVector(3);
            vec2[0] = 7.0; vec2[1] = -5.0; vec2[2] = -10.0;
            var expected = new MathVector(3);
            expected[0] = 5.0; expected[1] = -2.0; expected[2] = 1.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.Divide(vec2);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator/,
        /// when some coordinates are zeroes.
        /// </summary>
        /// <exception cref="DivideByZeroException">is thrown,
        /// when the second operand (number) is zero.
        /// </exception>
        [TestMethod]
        public void DivideForVectorWithNullOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = 0.0; vec1[1] = 10.0; vec1[2] = 14.0;
            var vec2 = new MathVector(3);
            vec2[0] = -3.0; vec2[1] = 0.0; vec2[2] = 14.0;
            var expected = new MathVector(3);
            Assert.ThrowsException<DivideByZeroException>(() =>
            {
                var temp = vec1 / vec2;
            });
        }

        /// <summary>
        /// Checks the overload of the operator/,
        /// when number is positive.
        /// </summary>
        [TestMethod]
        public void DivideForVectorAndPositiveNumberOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -33.0; vec1[1] = 12.0; vec1[2] = 0.0;
            double number = 3.0;
            var expected = new MathVector(3);
            expected[0] = -11.0; expected[1] = 4.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 / number;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "double MathVector.DivideNumber(double number),,
        /// when number is positive.
        /// </summary>
        [TestMethod]
        public void DivideForVectorAndPositiveNumber()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -33.0; vec1[1] = 12.0; vec1[2] = 0.0;
            double number = 3.0;
            var expected = new MathVector(3);
            expected[0] = -11.0; expected[1] = 4.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.DivideNumber(number);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the overload of the operator/,
        /// when number is negative.
        /// </summary>
        [TestMethod]
        public void DivideForVectorAndNegativeNumberOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -33.0; vec1[1] = 12.0; vec1[2] = 0.0;
            double number = -3.0;
            var expected = new MathVector(3);
            expected[0] = 11.0; expected[1] = -4.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1 / number;

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "double MathVector.DivideNumber(double number),,
        /// when number is negative.
        /// </summary>
        [TestMethod]
        public void DivideForVectorAndNegativeNumber()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -33.0; vec1[1] = 12.0; vec1[2] = 0.0;
            double number = -3.0;
            var expected = new MathVector(3);
            expected[0] = 11.0; expected[1] = -4.0; expected[2] = 0.0;

            //Act
            IMathVector result = new MathVector(3);
            result = vec1.DivideNumber(number);

            //Assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        /// <summary>
        /// Checks the work of the method "double MathVector.DivideNumber(double number),
        /// when number is zero.
        /// </summary>
        /// <exception cref="DivideByZeroException">is thrown,
        /// when the second operand (number) is zero.
        /// </exception>
        [TestMethod]
        public void DivideForVectorAndNullNumber()
        {
            //Arrange 
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            double number = 0.0;
            var expected = new MathVector(3);
            Assert.ThrowsException<DivideByZeroException>(() =>
            {
                var temp = vec1.DivideNumber(number);
            });
        }

        /// <summary>
        /// Checks the operator%,
        /// when all coordinates are positive-positive, positive-negative, negative-negative.
        /// </summary>
        [TestMethod]
        public void ScMultForPositiveAndNegativeVectorOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 10.0;
            var vec2 = new MathVector(3);
            vec2[0] = -3.0; vec2[1] = -2.0; vec2[2] = 14.0;
            double expected = 153;

            //Act
            double result = 0;
            result = vec1 % vec2;

            //Assert
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Checks the work of the method "double MathVector.ScalarMultiply(IMathVector vector),
        /// when all coordinates are positive-positive, positive-negative, negative-negative.
        /// </summary>
        [TestMethod]
        public void ScMultForPositiveAndNegativeVector()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 10.0;
            var vec2 = new MathVector(3);
            vec2[0] = -3.0; vec2[1] = -2.0; vec2[2] = 14.0;
            double expected = 153;

            //Act
            double result = 0;
            result = vec1.ScalarMultiply(vec2);

            //Assert
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Checks the operator%,
        /// when some coordinates are zeroes.
        /// </summary>
        [TestMethod]
        public void ScMultForVectorWithNullOverloaded()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            var vec2 = new MathVector(3);
            vec2[0] = 0.0; vec2[1] = -2.0; vec2[2] = 14.0;
            double expected = -20;

            //Act
            double result = 0;
            result = vec1 % vec2;

            //Assert
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Checks the work of the method "double MathVector.ScalarMultiply(IMathVector vector),
        /// when some coordinates are zeroes.
        /// </summary>
        [TestMethod]
        public void ScMultForVectorWithNull()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -11.0; vec1[1] = 10.0; vec1[2] = 0.0;
            var vec2 = new MathVector(3);
            vec2[0] = 0.0; vec2[1] = -2.0; vec2[2] = 14.0;
            double expected = -20;

            //Act
            double result = 0;
            result = vec1.ScalarMultiply(vec2);

            //Assert
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Checks the work of the method "double MathVector.CalcDistance(IMathVector vector)",
        /// </summary>
        [TestMethod]
        public void Distance()
        {
            //Arrange
            var vec1 = new MathVector(3);
            vec1[0] = -4.0; vec1[1] = 1.0; vec1[2] = 7.0;
            var vec2 = new MathVector(3);
            vec2[0] = 0.0; vec2[1] = 4.0; vec2[2] = 7.0;
            double expected = 5;

            //Act
            double result = vec1.CalcDistance(vec2);

            //Assert
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Checks the work of the property "int MathVector.Dimensions{get;}".
        /// </summary>
        [TestMethod]
        public void DimesionsPropertyTest()
        {
            // arrange
            var vector = new MathVector(3);
            vector[0] = 1.0; vector[1] = 2.0; vector[2] = 3.0;
            int expected = 3;

            // act
            int result = vector.Dimensions;

            // assert
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Checks the work of the property "double MathVector.Length{get;}",
        /// when all coordinates are positive.
        /// </summary>
        [TestMethod]
        public void LengthPropertyTestForPositiveValues()
        {
            // arrange
            var vector = new MathVector(3);
            vector[0] = 1.0; vector[1] = 2.0; vector[2] = 3.0;
            double expected = Math.Sqrt(14.0);

            // act
            double result = vector.Length;

            // assert
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Checks the work of the property "double MathVector.Length{get;}",
        /// when all coordinates are negative.
        /// </summary>
        [TestMethod]
        public void LengthPropertyTestForPositiveAndNegativeValues()
        {
            // arrange
            var vector = new MathVector(3);
            vector[0] = -1.0; vector[1] = -2.0; vector[2] = -3.0;
            double expected = Math.Sqrt(14.0);

            // act
            double result = vector.Length;

            // assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void IndexSetNormalRangeTest()
        {
            // arrange
            var vector = new MathVector(1);
            vector[0] = 1.0;

            // assert
            Assert.IsNotNull(vector[0]);
        }

        [TestMethod]
        public void IndexSetMoreRangeTest()
        {
            // arrange
            var vector = new MathVector(1);

            // assert
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                vector[4] = 1.3;
            });
        }

        [TestMethod]
        public void IndexSetLessRangeTest()
        {
            // arrange
            var vector = new MathVector(1);

            // assert
            //Assert.AreEqual(vector[0], expected);
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                vector[-4] = 1.3;
            });
        }

        [TestMethod]
        public void IndexGetMoreRangeTest()
        {
            // arrange
            var vector = new MathVector(1);

            // assert
            //Assert.AreEqual(vector[0], expected);
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                var temp = vector[4];
            });
        }

        [TestMethod]
        public void IndexGetLessRangeTest()
        {
            // arrange
            var vector = new MathVector(1);

            // assert
            //Assert.AreEqual(vector[0], expected);
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                var temp = vector[-4];
            });
        }

        

        public void IndexGetNormalRangeTest()
        {
            // arrange
            var vector = new MathVector();
            vector[0] = 1.0;
            double expected = 1.0;

            // assert
            Assert.AreEqual(expected, vector[0]);
        }

    }
}

/*Project: IJAssignment02
 *Purpose: Unit Test of a console application. PROG2070 Assignemnt02 
 *History: 
 *Created by Ilshin Ji February 14, 2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using IJAssignment02;


namespace IJAssignment02.Tests
{
    /// <summary>
    /// Rectangle app testing class
    /// </summary>
    [TestFixture]
    class RectangleTest
    {
        /// <summary>
        /// GetLength Test#1 with Default Constructore
        /// </summary>
        [Test]
        public void GetLength_WithDefaultConstructor_Output1()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle();

            int expected = 1;

            //Act 
            int actual = rectangle.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// GetLength Test#2 with value2
        /// </summary>
        [Test]
        public void GetLength_WithConstructorInputValue2_Output2()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle(2, 1);

            int expected = 2;

            //Act 
            int actual = rectangle.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// GetLength Test#3 with value10
        /// </summary>
        [Test]
        public void GetLength_WithConstructorInputValue10_Output10()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle(10, 1);

            int expected = 10;

            //Act 
            int actual = rectangle.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// SetLength Test#1 with value10
        /// </summary>
        [Test]
        public void SetLength_Input10_Output10()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle();

            int expected = 10;

            //Act 
            int actual = rectangle.SetLength(10);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// SetLength Test#2 with value5
        /// </summary>
        [Test]
        public void SetLength_Input5_Output5()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle();

            int expected = 5;

            //Act 
            int actual = rectangle.SetLength(5);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// SetLength Test#3 with value3
        /// </summary>
        [Test]
        public void SetLength_Input3_Output3()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle();

            int expected = 3;

            //Act 
            int actual = rectangle.SetLength(3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// GetWidth Test#1 with Default Constructore
        /// </summary>
        [Test]
        public void GetWidth_WithDefaultConstructor_Output1()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle();

            int expected = 1;

            //Act 
            int actual = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// GetWidth Test#2 with value2
        /// </summary>
        [Test]
        public void GetWidth_WithConstructorInputValue2_Output2()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle(1, 2);

            int expected = 2;

            //Act 
            int actual = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// GetWidth Test#3 with value10
        /// </summary>
        [Test]
        public void GetWidth_WithConstructorInputValue10_Output10()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle(1, 10);

            int expected = 10;

            //Act 
            int actual = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// SetLength Test#1 with value10
        /// </summary>
        [Test]
        public void SetWidth_Input10_Output10()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle();

            int expected = 10;

            //Act 
            int actual = rectangle.SetWidth(10);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// SetLength Test#2 with value5
        /// </summary>
        [Test]
        public void SetWidth_Input5_Output5()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle();

            int expected = 5;

            //Act 
            int actual = rectangle.SetWidth(5);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// SetLength Test#3 with value3
        /// </summary>
        [Test]
        public void SetWidth_Input3_Output3()
        {
            //Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle();

            int expected = 3;

            //Act 
            int actual = rectangle.SetWidth(3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// GetPerimeter Test#1 with Default Constructor
        /// </summary>
        [Test]
        public void GetPerimeter_WithDefaultConstructor_Output4()
        {
            // Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle();

            int expected = 4;

            //Act 
            int actual = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// GetPerimeter Test#2 with Length value 2 and with value 2 
        /// </summary>
        [Test]
        public void GetPerimeter_Input2And2_Output8()
        {
            // Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle(2,2);

            int expected = 8;

            //Act 
            int actual = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// GetPerimeter Test#3 with Length value 10 and with value 10 
        /// </summary>
        [Test]
        public void GetPerimeter_Input10And10_Output40()
        {
            // Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle(10, 10);

            int expected = 40;

            //Act 
            int actual = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// GetArea Test#1 with Default Constructor
        /// </summary>
        [Test]
        public void GetArea_WithDefaultConstructor_Output1()
        {
            // Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle();

            int expected = 1;

            //Act 
            int actual = rectangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// GetArea Test#2 with Length value 2 and with value 2 
        /// </summary>
        [Test]
        public void GetArea_Input2And2_Output4()
        {
            // Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle(2, 2);

            int expected = 4;

            //Act 
            int actual = rectangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// GetArea Test#2 with Length value 10 and with value 10
        /// </summary>
        [Test]
        public void GetArea_Input10And10_Output100()
        {
            // Arrange
            IJAssignment02.Rectangle rectangle = new IJAssignment02.Rectangle(10, 10);

            int expected = 100;

            //Act 
            int actual = rectangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

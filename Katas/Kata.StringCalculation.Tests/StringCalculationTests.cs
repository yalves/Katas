using System;
using Katas.StringCalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.StringCalculation.Tests
{
    /*
        1 - Create a simple String calculator with a method int Add(string numbers). The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string, it will return 0). For example "" or "1" or "1,2".
            - Start with the simplest test case of an empty string and move to 1 and two numbers.
            - Remember to solve things as simply as possible so that you force yourself to write tests you did not think about.
            - Remember to refactor after each passing test.
        2 - Allow the Add method to handle an unknown amount of numbers.
        3 - Allow the Add method to handle new lines between numbers (instead of commas).
            - The following input is ok: "1\n2,3" (will equal 6)
            - The following input is NOT ok: "1,\n" (not need to prove it - just clarifying)
        4 - Support different delimiters. To change a delimiter, the beginning of the string will contain a separate line that looks like this: [delimiter]\n[numbers...], for example ;\n1;2 should return three where the default delimiter is ; .
            - The first line is optional. All existing scenarios should still be supported.
        5 - Calling Add with a negative number will throw an exception "negatives not allowed" - and the negative that was passed.
            - If there are multiple negatives, show all of them in the exception message. 
    */

    [TestClass]
    public class StringCalculationTests
    {
        [TestMethod]
        public void Given_a_empty_string_stringcalculator_should_return_0()
        {
            // Arrange
            var stringCalculator = new StringCalculator();

            // Act
            var result = stringCalculator.Add("");

            // Assert
            Assert.AreEqual(0, result);
        }


        [TestMethod]
        [DataRow(5)]
        [DataRow(6)]
        public void Given_one_number_in_string_stringcalculator_should_return_the_number(int number)
        {
            // Arrange
            var stringCalculator = new StringCalculator();

            // Act
            var result = stringCalculator.Add(number.ToString());

            // Assert
            Assert.AreEqual(number, result);
        }

        [TestMethod]
        public void Given_multiple_numbers_in_string_stringcalculator_should_return_the_sum_of_the_numbers()
        {
            // Arrange
            var stringCalculator = new StringCalculator();

            // Act
            var result = stringCalculator.Add("1,2");

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Given_a_linebreak_between_numbers_in_string_stringcalculator_should_return_the_sum_of_the_numbers()
        {
            // Arrange
            var stringCalculator = new StringCalculator();

            // Act
            var result = stringCalculator.Add("1\n2");

            // Assert
            Assert.AreEqual(3, result);
        }
    }
}

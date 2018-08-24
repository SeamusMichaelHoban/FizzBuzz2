using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        FizzBuzzer fizzBuzzer;

        [SetUp]
        public void SetUp()
        {
             fizzBuzzer = new FizzBuzzer();
        }


        [Test]
        public void FizzBuzzer_Returns_1_for_1()
        {
           

            var result = fizzBuzzer.FizzBuzz(1);

            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void FizzBuzzer_Returns_2_for_2()
        {
      

            var result = fizzBuzzer.FizzBuzz(2);

            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void FizzBuzzer_Returns_Fizz_for_3()
        {

            var result = fizzBuzzer.FizzBuzz(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void FizzBuzzer_Returns_Fizz_for_6()
        {
            var result = fizzBuzzer.FizzBuzz(6);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void FizzBuzzer_Returns_Buzz_for_5()
        {

            var result = fizzBuzzer.FizzBuzz(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void FizzBuzzer_Returns_Fizz_for_10()
        {
            var result = fizzBuzzer.FizzBuzz(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void FizzBuzzer_Returns_FizzBuzz_for_15()
        {
            var result = fizzBuzzer.FizzBuzz(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void FizzBuzzer_Returns_FizzBuzz_for_30()
        {
            var result = fizzBuzzer.FizzBuzz(30);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

    }
}

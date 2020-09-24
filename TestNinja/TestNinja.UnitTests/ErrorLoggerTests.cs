using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _errorLogger;

        [SetUp]
        public void SetUp()
        {
            _errorLogger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            _errorLogger.Log("a");

            Assert.That(_errorLogger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            // can't call this directly when testing exception
            //_errorLogger.Log(error);

            // you need to use a lambda expression
            Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);

            // can also use this syntax if custom type of exception
            // Assert.That(() => _errorLogger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>);

        }
    }
}

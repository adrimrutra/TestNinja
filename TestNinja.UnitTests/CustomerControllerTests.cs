﻿using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ShoulReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);

            // NotFound
            Assert.That(result, Is.TypeOf<NotFound>());


            // NotFound or of its derivatives
            // Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ShoulReturnOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);

            // Ok
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}

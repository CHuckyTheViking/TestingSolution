
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedUwpLibrary.Models;

namespace SharedUwpLibrary.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void FullName_ShouldReturnTheFullNameOfTheEmployee()
        {
            Employee employee = new Employee() { FirstName = "Jesper", LastName = "Müllern" };
            Assert.AreEqual("Jesper Müllern", employee.FullName);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SharedCoreLibrary.Tests
{
    public class EmployeeTests
    {
        private List<Employee> _employees { get; set; }
        public EmployeeTests()
        {
            _employees = new List<Employee>();
        }

        [Theory]
        [InlineData("Jesper", "Müllern")]
        [InlineData("Håkan", "Karlsson")]
        public void AddEmployee_ShouldAddAnEmployeeToAListOfEmployees(string firstname, string lastname)
        {
            var employee = new Employee(firstname, lastname);
            _employees.Add(employee);
            Assert.Contains(employee, _employees);

        }

    }
}

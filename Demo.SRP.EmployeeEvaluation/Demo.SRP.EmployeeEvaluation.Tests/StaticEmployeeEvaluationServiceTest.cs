using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using Demo.SRP.EmployeeEvaluation.Kernel.Services.Static;
using FluentAssertions;
using Xunit;

namespace Demo.SRP.EmployeeEvaluation.Tests
{
    public class StaticEmployeeEvaluationServiceTest
    {
        [Fact]
        public void Evaluate_ReturnsExpectedJobLevel()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 1);
            employee.SkillManager.AddSkills(EmployeeSkill.Communications, EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer);

            var service = new StaticEmployeeEvaluationService();
            var expectedJobLevel = EmployeeJobLevel.JuniorSoftwareEngineerI;

            // Act
            var actualJobLevel = service.Evaluate(employee);

            // Assert
            actualJobLevel.Should().Be(expectedJobLevel);
        }
    }
}

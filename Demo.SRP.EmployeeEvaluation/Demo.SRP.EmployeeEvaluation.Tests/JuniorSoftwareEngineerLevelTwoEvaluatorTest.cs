using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules;
using FluentAssertions;
using Xunit;

namespace Demo.SRP.EmployeeEvaluation.Tests
{
    public class JuniorSoftwareEngineerLevelTwoEvaluatorTest
    {
        [Fact]
        public void EvaluateEmployeeLevel_MeetsRequirements_ReturnsJuniorSoftwareEngineerII()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 4);
            employee.SkillManager.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.MicrosoftAzureNetworking);
            var evaluator = new JuniorSoftwareEngineerLevelTwoEvaluator();

            // Act
            var level = evaluator.EvaluateEmployeeLevel(employee);

            // Assert
            level.Should().Be(EmployeeJobLevel.JuniorSoftwareEngineerII);
        }

        [Fact]
        public void EvaluateEmployeeLevel_DoesNotMeetRequirements_ReturnsUndefined()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 2);
            employee.SkillManager.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer);
            var evaluator = new JuniorSoftwareEngineerLevelTwoEvaluator();

            // Act
            var level = evaluator.EvaluateEmployeeLevel(employee);

            // Assert
            level.Should().Be(EmployeeJobLevel.Undefined);
        }
    }
}

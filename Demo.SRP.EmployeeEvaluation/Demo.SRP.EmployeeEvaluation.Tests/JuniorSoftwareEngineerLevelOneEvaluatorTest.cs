using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules;
using FluentAssertions;
using Xunit;

namespace Demo.SRP.EmployeeEvaluation.Tests
{
    public class JuniorSoftwareEngineerLevelOneEvaluatorTest
    {
        [Fact]
        public void EvaluateEmployeeLevel_MeetsRequirements_ReturnsJuniorSoftwareEngineerI()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 2);
            employee.SkillManager.AddSkills(EmployeeSkill.Communications, EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer);
            var evaluator = new JuniorSoftwareEngineerLevelOneEvaluator();

            // Act
            var level = evaluator.EvaluateEmployeeLevel(employee);

            // Assert
            level.Should().Be(EmployeeJobLevel.JuniorSoftwareEngineerI);
        }

        [Fact]
        public void EvaluateEmployeeLevel_DoesNotMeetRequirements_ReturnsUndefined()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 1);
            employee.SkillManager.AddSkills(EmployeeSkill.Communications, EmployeeSkill.MicrosoftCSharp);
            var evaluator = new JuniorSoftwareEngineerLevelOneEvaluator();

            // Act
            var level = evaluator.EvaluateEmployeeLevel(employee);

            // Assert
            level.Should().Be(EmployeeJobLevel.Undefined);
        }
    }
}

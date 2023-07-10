using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules;
using FluentAssertions;
using Xunit;

namespace Demo.SRP.EmployeeEvaluation.Tests
{
    public class SoftwareEngineerTeamLeaderEvaluatorTest
    {
        [Fact]
        public void EvaluateEmployeeLevel_MeetsRequirements_ReturnsTeamLeader()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 11);
            employee.SkillManager.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.InspiringMotivation);
            var evaluator = new SoftwareEngineerTeamLeaderEvaluator();

            // Act
            var level = evaluator.EvaluateEmployeeLevel(employee);

            // Assert
            level.Should().Be(EmployeeJobLevel.TeamLeader);
        }

        [Fact]
        public void EvaluateEmployeeLevel_DoesNotMeetRequirements_ReturnsUndefined()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 9);
            employee.SkillManager.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer);
            var evaluator = new SoftwareEngineerTeamLeaderEvaluator();

            // Act
            var level = evaluator.EvaluateEmployeeLevel(employee);

            // Assert
            level.Should().Be(EmployeeJobLevel.Undefined);
        }
    }
}

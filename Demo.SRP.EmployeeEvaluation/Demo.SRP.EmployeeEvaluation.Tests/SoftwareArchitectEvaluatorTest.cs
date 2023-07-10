using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules;
using FluentAssertions;
using Xunit;

namespace Demo.SRP.EmployeeEvaluation.Tests
{
    public class SoftwareArchitectEvaluatorTest
    {
        [Fact]
        public void EvaluateEmployeeLevel_MeetsRequirements_ReturnsSoftwareArchitect()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 11);
            employee.SkillManager.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftAzureSecurity,
                EmployeeSkill.MicrosoftAzureAiCognitiveService,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.InspiringMotivation);
            var evaluator = new SoftwareArchitectEvaluator();

            // Act
            var level = evaluator.EvaluateEmployeeLevel(employee);

            // Assert
            level.Should().Be(EmployeeJobLevel.SoftwareArchitect);
        }

        [Fact]
        public void EvaluateEmployeeLevel_DoesNotMeetRequirements_ReturnsUndefined()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 9);
            employee.SkillManager.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftAzureSecurity,
                EmployeeSkill.MicrosoftAzureAiCognitiveService,
                EmployeeSkill.MicrosoftSqlServer);
            var evaluator = new SoftwareArchitectEvaluator();

            // Act
            var level = evaluator.EvaluateEmployeeLevel(employee);

            // Assert
            level.Should().Be(EmployeeJobLevel.Undefined);
        }
    }
}

using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using FluentAssertions;
using Xunit;

namespace Demo.SRP.EmployeeEvaluation.Tests
{
    public class EmployeeEvaluationRuleEngineTest
    {
        [Fact]
        public void CalculateLevel_ReturnsJuniorSoftwareEngineerI_WhenExperienceIsOneYear()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 1);
            employee.SkillManager.AddSkills(EmployeeSkill.Communications, EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer);

            // Act
            var actualLevel = EmployeeEvaluationRuleEngine.CalculateLevel(employee);

            // Assert
            actualLevel.Should().Be(EmployeeJobLevel.JuniorSoftwareEngineerI);
        }

        [Fact]
        public void CalculateLevel_ReturnsJuniorSoftwareEngineerII_WhenExperienceIsThreeYears()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 3);
            employee.SkillManager.AddSkills(EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp, EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.MicrosoftAzureNetworking);

            // Act
            var actualLevel = EmployeeEvaluationRuleEngine.CalculateLevel(employee);

            // Assert
            actualLevel.Should().Be(EmployeeJobLevel.JuniorSoftwareEngineerII);
        }

        [Fact]
        public void CalculateLevel_ReturnsSeniorSoftwareEngineerI_WhenExperienceIsFiveYears()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 5);
            employee.SkillManager.AddSkills(EmployeeSkill.Communications, EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer);

            // Act
            var actualLevel = EmployeeEvaluationRuleEngine.CalculateLevel(employee);

            // Assert
            actualLevel.Should().Be(EmployeeJobLevel.SeniorSoftwareEngineerI);
        }
    }
}

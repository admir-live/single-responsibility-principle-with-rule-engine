using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules;
using FluentAssertions;
using Xunit;

public class SeniorSoftwareEngineerLevelOneEvaluatorTest
{
    [Fact]
    public void EvaluateEmployeeLevel_MeetsRequirements_ReturnsSeniorSoftwareEngineerI()
    {
        // Arrange
        var employee = new Employee("John", "Doe", 6);
        employee.SkillManager.AddSkills(
            EmployeeSkill.Communications,
            EmployeeSkill.MicrosoftCSharp,
            EmployeeSkill.MicrosoftSqlServer,
            EmployeeSkill.Communications);
        var evaluator = new SeniorSoftwareEngineerLevelOneEvaluator();

        // Act
        var level = evaluator.EvaluateEmployeeLevel(employee);

        // Assert
        level.Should().Be(EmployeeJobLevel.SeniorSoftwareEngineerI);
    }

    [Fact]
    public void EvaluateEmployeeLevel_DoesNotMeetRequirements_ReturnsUndefined()
    {
        // Arrange
        var employee = new Employee("John", "Doe", 4);
        employee.SkillManager.AddSkills(
            EmployeeSkill.Communications,
            EmployeeSkill.MicrosoftCSharp,
            EmployeeSkill.MicrosoftSqlServer);
        var evaluator = new SeniorSoftwareEngineerLevelOneEvaluator();

        // Act
        var level = evaluator.EvaluateEmployeeLevel(employee);

        // Assert
        level.Should().Be(EmployeeJobLevel.Undefined);
    }
}

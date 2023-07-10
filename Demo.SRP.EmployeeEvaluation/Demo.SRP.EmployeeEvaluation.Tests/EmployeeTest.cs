using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using FluentAssertions;
using Xunit;

namespace Demo.SRP.EmployeeEvaluation.Tests
{
    public class EmployeeTest
    {
        [Fact]
        public void Constructor_CreatesEmployeeWithGivenProperties()
        {
            // Arrange & Act
            var employee = new Employee("John", "Doe", 5);

            // Assert
            employee.FirstName.Should().Be("John");
            employee.LastName.Should().Be("Doe");
            employee.YearsOfExperience.Should().Be(5);
        }

        [Theory]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(4, true)]
        public void MeetsExperienceAndSkillRequirements_ReturnsExpectedResult(int yearsOfExperience,
            bool expectedResult)
        {
            // Arrange
            var employee = new Employee("John", "Doe", 5);
            employee.SkillManager.AddSkills(EmployeeSkill.Communications, EmployeeSkill.MicrosoftCSharp);

            // Act
            var result = employee.MeetsExperienceAndSkillRequirements(yearsOfExperience, EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void ToString_ReturnsExpectedResult()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 5);
            employee.SkillManager.AddSkills(EmployeeSkill.Communications, EmployeeSkill.MicrosoftCSharp);

            // Act
            var result = employee.ToString();

            // Assert
            result.Should()
                .Be(
                    "Hey! I am John Doe. I have a total of 5 years experience. I am skilled in Communications, Microsoft C#.\n");
        }
    }
}

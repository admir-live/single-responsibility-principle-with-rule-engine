using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using FluentAssertions;
using Xunit;

namespace Demo.SRP.EmployeeEvaluation.Tests
{
    public class EmployeeSkillTest
    {
        [Fact]
        public void MicrosoftCSharp_ReturnsExpectedSkill()
        {
            // Act
            var skill = EmployeeSkill.MicrosoftCSharp;

            // Assert
            skill.Id.Should().Be(1);
            skill.Name.Should().Be("Microsoft C#");
        }

        [Fact]
        public void MicrosoftSqlServer_ReturnsExpectedSkill()
        {
            // Act
            var skill = EmployeeSkill.MicrosoftSqlServer;

            // Assert
            skill.Id.Should().Be(2);
            skill.Name.Should().Be("Microsoft SQL Server");
        }

        [Fact]
        public void ImplicitConversionToString_ReturnsExpectedString()
        {
            // Arrange
            var skill = EmployeeSkill.MicrosoftCSharp;

            // Act
            string skillAsString = skill;

            // Assert
            skillAsString.Should().Be("Microsoft C#");
        }
    }
}

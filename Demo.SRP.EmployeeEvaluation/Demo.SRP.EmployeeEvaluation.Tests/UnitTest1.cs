using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using Demo.SRP.EmployeeEvaluation.Kernel.Services;
using Demo.SRP.EmployeeEvaluation.Kernel.Services.Static;
using Xunit;

namespace Demo.SRP.EmployeeEvaluation.Tests
{
    public class EmployeeEvaluationTest
    {
        public IEmployeeEvaluationService EmployeeEvaluationService { get; } = new StaticEmployeeEvaluationService();

        [Fact]
        public void EmployeeEvaluationService_Should_Return_SoftwareEngineerL1()
        {
            // Arrange
            var employee = new Employee(firstName: "Samed", lastName: "Skulj");

            // Act
            var level = EmployeeEvaluationService.Evaluate(employee: employee);

            // Assert
            Assert.Equal(expected: level, actual: EmployeeLevel.SoftwareEngineerL1);
        }

        [Fact]
        public void EmployeeEvaluationService_Should_Return_SoftwareEngineerL2()
        {
            // Arrange
            var employee = new Employee(firstName: "Haris", lastName: "Mlaco", yearsOfExperience: 1);
            employee.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp);

            // Act
            var level = EmployeeEvaluationService.Evaluate(employee: employee);

            // Assert
            Assert.Equal(expected: level, actual: EmployeeLevel.SoftwareEngineerL2);
        }

        [Fact]
        public void EmployeeEvaluationService_Should_Return_SoftwareEngineerL3()
        {
            // Arrange
            var employee = new Employee(firstName: "Faris", lastName: "Haskovic", yearsOfExperience: 3);
            employee.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer);

            // Act
            var level = EmployeeEvaluationService.Evaluate(employee: employee);

            // Assert
            Assert.Equal(expected: level, actual: EmployeeLevel.SoftwareEngineerL3);
        }

        [Fact]
        public void EmployeeEvaluationService_Should_Return_SoftwareEngineerL4()
        {
            // Arrange
            var employee = new Employee(firstName: "Mirza", lastName: "Hodzic", yearsOfExperience: 6);
            employee.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.InspiringMotivation);

            // Act
            var level = EmployeeEvaluationService.Evaluate(employee: employee);

            // Assert
            Assert.Equal(expected: level, actual: EmployeeLevel.SoftwareEngineerL4);
        }

        [Fact]
        public void EmployeeEvaluationService_Should_Return_SoftwareEngineerL5()
        {
            // Arrange
            var employee = new Employee(firstName: "Admir", lastName: "Mujkic", yearsOfExperience: 11);
            employee.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftAzureSecurity,
                EmployeeSkill.MicrosoftAzureAiCognitiveService,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.InspiringMotivation);

            // Act
            var level = EmployeeEvaluationService.Evaluate(employee: employee);

            // Assert
            Assert.Equal(expected: level, actual: EmployeeLevel.SoftwareEngineerL5);
        }

        [Fact]
        public void EmployeeEvaluationService_Should_Return_SoftwareEngineerL6()
        {
            // Arrange
            var employee = new Employee(firstName: "Fehim", lastName: "Dervišbegović", yearsOfExperience: 23);
            employee.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftAzureSecurity,
                EmployeeSkill.MicrosoftAzureAiCognitiveService,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.MicrosoftAzureNetworking,
                EmployeeSkill.InspiringMotivation);

            // Act
            var level = EmployeeEvaluationService.Evaluate(employee: employee);

            // Assert
            Assert.Equal(expected: level, actual: EmployeeLevel.SoftwareEngineerL6);
        }
    }
}
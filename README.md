# Demonstration single responsibility principle (SRP) in conjunction with a Rule Engine Design Pattern

### Introduction
To keep up with current trends, where business applications are becoming increasingly complex, engineers must be more strategic in their approach to the domain and system design. To assist junior engeeners in better understanding the single responsibility concept, I will demonstrate how to use a very common rule engine design pattern in which complex rules are broken into little bits.


### What is single-responsibility principle (SRP)

The single-responsibility principle (SRP) is a philosophy of computer programming that states that each module, class, or function in a computer program should be responsible for a single aspect of the program's operation and should encapsulate that aspect. All of the services provided by that module, class, or function should be tightly coupled to that responsibility.


### Problem

We frequently notice during PR reviews methods with extremely high cyclomatic complexity. To demonstrate the strength of the SRP principle and the Rule Engine Design Pattern, we utilized an extremely typical real-world scenario such as employee evaluation. Due to the fact that this example is aimed at software engineers, we have used software engineer job roles in conjunction with required abilities for a particular role.

The following example demonstrates how we may reduce cyclomatic complexity from 20+ to only 1. Yes,  only 1. :-)

```csharp
using Demo.SRP.EmployeeEvaluation.Kernel.Domain;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Services.Static
{
    public sealed class StaticEmployeeEvaluationService : IEmployeeEvaluationService
    {
        public EmployeeLevel Evaluate(Employee employee)
        {
            var level = EmployeeLevel.SoftwareEngineerL1;

            if (employee.YearsOfExperience >= 1 &&
                employee.Skills.Contains(item: EmployeeSkill.Communications) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftCSharp))
            {
                level = EmployeeLevel.SoftwareEngineerL2;
            }

            if (employee.YearsOfExperience >= 3 &&
                employee.Skills.Contains(item: EmployeeSkill.Communications) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftCSharp) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftSqlServer))
            {
                level = EmployeeLevel.SoftwareEngineerL3;
            }

            if (employee.YearsOfExperience >= 5 &&
                employee.Skills.Contains(item: EmployeeSkill.Communications) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftCSharp) &&
                employee.Skills.Contains(item: EmployeeSkill.InspiringMotivation) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftSqlServer))
            {
                level = EmployeeLevel.SoftwareEngineerL4;
            }

            if (employee.YearsOfExperience >= 7 &&
                employee.Skills.Contains(item: EmployeeSkill.Communications) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftCSharp) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftAzureAiCognitiveService) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftAzureSecurity) &&
                employee.Skills.Contains(item: EmployeeSkill.InspiringMotivation) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftSqlServer))
            {
                level = EmployeeLevel.SoftwareEngineerL5;
            }

            if (employee.YearsOfExperience >= 11 &&
                employee.Skills.Contains(item: EmployeeSkill.Communications) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftCSharp) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftAzureAiCognitiveService) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftAzureSecurity) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftAzureNetworking) &&
                employee.Skills.Contains(item: EmployeeSkill.InspiringMotivation) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftSqlServer))
            {
                level = EmployeeLevel.SoftwareEngineerL6;
            }

            return level;
        }
    }
}
```

After implementing the early mentioned concept, we can expect only one line of code. As a result, we can expect a high maintainability index with the open-close principal in place.

```csharp
using Demo.SRP.EmployeeEvaluation.Kernel.Domain;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Services.Static
{
    public sealed class StaticEmployeeEvaluationService : IEmployeeEvaluationService
    {
        public EmployeeLevel Evaluate(Employee employee)
        {
            return EmployeeEvaluationRuleEngine.CalculateLevel(employee: employee);
        }
    }
}

```

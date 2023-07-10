Rule Engine with the Strategy Pattern
================================================

This repository demonstrates the use of a rule engine with the strategy design pattern. The project is implemented in C# and is structured around the domain of employee evaluation.

Project Structure
-----------------

The project is divided into several parts:

![image](https://github.com/admir-live/single-responsibility-principle-with-rule-engine/assets/48647732/d578c3a2-6128-4872-85f3-3b593c0062aa)

1.  **Kernel**: This is the core of the project, containing the main domain logic and services. It includes the following:
    *   **Domain**: This includes the main entities such as Employee, EmployeeId, EmployeeSkill, and EmployeeJobLevel. It also includes the EmployeeEvaluationRuleEngine which is used to calculate the job level of an employee based on their skills and experience.
    *   **Services**: This includes the IEmployeeEvaluationService interface and its implementation StaticEmployeeEvaluationService. The service uses the EmployeeEvaluationRuleEngine to evaluate an employee.
    *   **Rules**: This includes the different evaluation strategies for different job levels. Each strategy is implemented as a separate class and they all implement the IEmployeeLevelEvaluationStrategy interface.
2.  **Main**: This is the entry point of the application. It creates some employees, evaluates them, and displays their job levels.
3.  **Tests**: This includes unit tests for the different parts of the application.

Usage
-----

The main program creates some employees with different skills and experience, evaluates them, and displays their job levels. Here is a snippet from the main program:

```csharp
var employees = new[]
{
    CreateEmployee("John", "Doe", 32,
        EmployeeSkill.Communications,
        EmployeeSkill.MicrosoftCSharp,
        EmployeeSkill.MicrosoftSqlServer,
        EmployeeSkill.MicrosoftAzureNetworking,
        EmployeeSkill.MicrosoftAzureAiCognitiveService,
        EmployeeSkill.InspiringMotivation),
        
    CreateEmployee("Sarah", "Smith", 5,
        EmployeeSkill.Communications,
        EmployeeSkill.MicrosoftCSharp,
        EmployeeSkill.Communications,
        EmployeeSkill.MicrosoftSqlServer),
        
    CreateEmployee("Michael", "Brown", 35,
        EmployeeSkill.Communications,
        EmployeeSkill.MicrosoftCSharp,
        EmployeeSkill.MicrosoftAzureSecurity,
        EmployeeSkill.MicrosoftAzureAiCognitiveService,
        EmployeeSkill.MicrosoftSqlServer,
        EmployeeSkill.InspiringMotivation)
};

EvaluateAndDisplayEmployeeLevels(employees);
```
    
    

Each employee is created with a name, age, and a set of skills. The EvaluateAndDisplayEmployeeLevels function then evaluates each employee and displays their job level.

How the Program Works
---------------------

Imagine you're playing a game where you're the boss of a company. You have a bunch of employees, and each one has different skills and experience. You want to give each employee a job level based on their skills and experience.

This is where the program comes in. It's like a smart robot that helps you decide the job level for each employee. You just tell the robot about each employee's skills and experience, and the robot will tell you what job level they should be.

The robot uses a set of rules for each job level. For example, to be a "Level 1 Junior Software Engineer", the employee needs to be good at communication, programming in C#, and have at least 1 year of experience. The robot uses these rules to decide the job level for the employee. It starts from the lowest level and checks if the employee meets the requirements for that level. If they do, the robot checks the next level, and so on, until it finds the highest level that the employee qualifies for.

Understanding the Strategy Pattern
----------------------------------

In the context of this program, each job level (like "Junior Software Engineer Level 1", "Junior Software Engineer Level 2", etc.) is a strategy. The program picks the best strategy (job level) for each employee based on their skills and experience. This is a great example of the strategy pattern, which allows you to easily switch between different algorithms (strategies) at runtime.

Testing
-------

The project includes unit tests for the different parts of the application. For example, there are tests for the EmployeeEvaluationRuleEngine to ensure that it correctly calculates the job level of an employee based on their skills and experience.

Conclusion
----------

This project demonstrates how to use a rule engine with the strategy design pattern to implement the single responsibility principle. It shows how to structure a project around a specific domain and how to write unit tests for the different parts of the application.

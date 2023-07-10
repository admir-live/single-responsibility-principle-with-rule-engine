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

| **Class/Interface**                                                                                                                                                                                       | **Description**                                                                                                                                                                                                                   |
|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Employee.cs                                                                                                                                                                                               | Represents an employee with properties like FirstName, LastName, YearsOfExperience, and SkillManager. It also has a method to check if the employee meets the given experience and skill requirements.                            |
| EmployeeEvaluationRuleEngine.cs                                                                                                                                                                           | A static class that is the rule engine for calculating the job level of an employee. It uses a list of strategies to evaluate the employee's job level.                                                                           |
| IEmployeeLevelEvaluationStrategy.cs                                                                                                                                                                       | Defines a strategy for evaluating an employee's job level. It has a single method that takes an Employee object and returns an EmployeeJobLevel.                                                                                  |
| IEmployeeEvaluationRule.cs                                                                                                                                                                                | A marker interface for employee evaluation rules.                                                                                                                                                                                 |
| JuniorSoftwareEngineerLevelOneEvaluator.cs, JuniorSoftwareEngineerLevelTwoEvaluator.cs, SeniorSoftwareEngineerLevelOneEvaluator.cs, SoftwareArchitectEvaluator.cs, SoftwareEngineerTeamLeaderEvaluator.cs | Implement the IEmployeeLevelEvaluationStrategy interface. Each class represents a strategy for evaluating a specific job level. They override a method to check if an employee meets the requirements for the specific job level. |
| IEmployeeEvaluationService.cs                                                                                                                                                                             | Defines a service for evaluating an employee. It has a single method that takes an Employee object and returns an EmployeeJobLevel.                                                                                               |
| StaticEmployeeEvaluationService.cs                                                                                                                                                                        | Implements the IEmployeeEvaluationService interface. It uses the EmployeeEvaluationRuleEngine to evaluate an employee.                                                                                                            |
| SkillManager.cs                                                                                                                                                                                           | Manages the skills of an employee. It has methods for adding skills, removing a skill, checking if the employee has certain skills, and displaying the skills of the employee.                                                    |
| EmployeeSkill.cs                                                                                                                                                                                          | Represents a skill that an employee can have. It is an enumeration with predefined skills.                                                                                                                                        |
| EmployeeId.cs                                                                                                                                                                                             | Represents the ID of an employee. It has methods for parsing a string to an EmployeeId and comparing EmployeeIds.                                                                                                                 |
| EmployeeLevel.cs                                                                                                                                                                                          | Represents the job level of an employee. It is an enumeration with predefined job levels.                                                                                                                                         |
| BaseEntity.cs, BaseEntity(TKey).cs                                                                                                                                                                        | Base classes for entities. They provide common properties like CreatedAt and ModifiedAt.                                                                                                                                          |
| Enumeration.cs                                                                                                                                                                                            | Base class for enumerations. It provides methods for comparing and getting all values of an enumeration.                                                                                                                          |
| ValueObject(T).cs                                                                                                                                                                                         | Base class for value objects. It provides methods for comparing value objects.                                                                                                                                                    |
| IRule.cs                                                                                                                                                                                                  | Generic interface for rules. It has a single method that takes a parameter of type TSpecification and returns a result of type TResponse.                                                                                         |


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

Picture yourself in a captivating game where you assume the role of a company's esteemed boss. As the mastermind behind the operations, you oversee a diverse group of employees, each boasting unique skills and experiences. Naturally, you aim to assign an appropriate job level to every individual based on their specific attributes.

Enter the program—an ingenious robotic companion poised to assist you in this endeavor. Think of it as an astute digital ally, capable of seamlessly determining the ideal job level for each employee. With a mere description of their skills and experience, this virtual assistant will deftly calculate the most suitable job level recommendation.

This insightful assistant employs a comprehensive set of criteria for every job level. Take, for instance, the coveted title of "Level 1 Junior Software Engineer." Attaining this distinction necessitates a strong aptitude for communication, proficiency in the art of C# programming, and a minimum of one year of hands-on experience. Armed with these rules, the assistant embarks on a meticulous assessment, commencing with the lowest level. It thoroughly evaluates whether the employee meets the prerequisites for that level and subsequently progresses to the next tier, diligently repeating the process until it pinpoints the highest job level that the employee qualifies for.


Understanding the Strategy Pattern
----------------------------------

Within the this program, it operates on the premise that each job level, such as "Junior Software Engineer Level 1" or "Junior Software Engineer Level 2," represents a distinct strategy. The program adeptly selects the most fitting strategy, or job level, for each employee by considering their individual skill sets and experience. This implementation aptly showcases the strategy pattern, a design pattern that facilitates seamless interchangeability between various algorithms, or strategies, during runtime. Such flexibility empowers the program to effortlessly adapt and switch between different strategies, ensuring optimal decision-making and resource allocation.

Testing
-------

The project includes unit tests for the different parts of the application. For example, there are tests for the `EmployeeEvaluationRuleEngine` to ensure that it correctly calculates the job level of an employee based on their skills and experience.
                                                                                  |

| **Test Class**                                                                                                                                                                                                                | **Description**                                                                                                                                                                                                                                                                       |
|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| EmployeeEvaluationRuleEngineTest.cs                                                                                                                                                                                           | It's like a quiz for our rule engine. We're asking it questions like "If I give you an employee with one year of experience and certain skills, can you correctly tell me their job level?"                                                                                           |
| EmployeeTest.cs                                                                                                                                                                                                               | This is a test for our Employee class. We're checking things like "If I create an employee with certain details (like name, skills, and experience), does everything get set up correctly?"                                                                                           |
| EmployeeIdTest.cs                                                                                                                                                                                                             | Here we're testing our EmployeeId class. We're asking "If I give you a string, can you correctly convert it into an EmployeeId?" We also check what happens if we give it an empty string (it should complain), and if it can correctly tell us whether two EmployeeIds are the same. |
| EmployeeSkillTest.cs                                                                                                                                                                                                          | This is a test for our EmployeeSkill class. We're checking if it can correctly tell us the ID and name of certain skills, and if it can correctly convert a skill into a string.                                                                                                      |
| JuniorSoftwareEngineerLevelOneEvaluatorTest.cs, JuniorSoftwareEngineerLevelTwoEvaluatorTest.cs, SeniorSoftwareEngineerLevelOneEvaluatorTest.cs, SoftwareArchitectEvaluatorTest.cs, SoftwareEngineerTeamLeaderEvaluatorTest.cs | These are tests for our job level evaluators. We're asking each evaluator "If I give you an employee, can you correctly tell me if they meet the requirements for your job level?"                                                                                                    |
| StaticEmployeeEvaluationServiceTest.cs                                                                                                                                                                                        | This is a test for our evaluation service. We're asking it "If I give you an employee, can you correctly tell me their job level?"                                                                                                                                                    |


Conclusion
----------

I established this job with my students in mind together with I have actually understood that sharing it with a broader engeeners. Basically, this task works as a superb instance of exactly how to efficiently use the solitary duty concept by utilizing a policy engine in mix with the technique strategy pattern. By embracing this method the job effectively arranges its various parts as well as appoints certain duties within the specified domain name.

This project strongly emphasizes the importance of creating unit tests for different sections, with a target of achieving test coverage exceeding 80%. Unit tests are of utmost significance in validating the functionality and behavior of individual software components, guaranteeing their adherence to requirements and specifications. By adopting this approach, the project aligns with the principles of test-driven development, wherein tests are written prior to implementing the corresponding code. This iterative process effectively safeguards that the software adheres to desired standards and operates as intended.

To summarize, I hope this will help junior engineers understand the concept mentioned above. Feel free to contact me if you have any recommendations or questions.

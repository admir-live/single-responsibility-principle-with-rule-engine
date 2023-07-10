using System;
using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using FluentAssertions;
using Xunit;

namespace Demo.SRP.EmployeeEvaluation.Tests
{
    public class EmployeeIdTest
    {
        [Fact]
        public void Parse_ReturnsExpectedEmployeeId()
        {
            // Arrange
            var expectedId = "test_id";

            // Act
            var employeeId = EmployeeId.Parse(expectedId);

            // Assert
            employeeId.Id.Should().Be(expectedId);
        }

        [Fact]
        public void Parse_ShouldThrowArgumentException_WhenIdIsNullOrWhiteSpace()
        {
            // Arrange
            var nullId = (string)null;
            var whiteSpaceIds = new[] { "", " ", "   ", "\t" };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => EmployeeId.Parse(nullId));
            foreach (var id in whiteSpaceIds)
            {
                Assert.Throws<ArgumentException>(() => EmployeeId.Parse(id));
            }
        }

        [Fact]
        public void OperatorEqual_ReturnsCorrectResult()
        {
            // Arrange
            var idA = EmployeeId.Parse("test_id");
            var idB = EmployeeId.Parse("test_id");

            // Act
            var isEqual = idA == idB;

            // Assert
            isEqual.Should().BeTrue();
        }

        [Fact]
        public void OperatorNotEqual_ReturnsCorrectResult()
        {
            // Arrange
            var idA = EmployeeId.Parse("test_id");
            var idB = EmployeeId.Parse("different_id");

            // Act
            var isNotEqual = idA != idB;

            // Assert
            isNotEqual.Should().BeTrue();
        }

        [Fact]
        public void OperatorEqual_ReturnsTrue_WhenBothEmployeeIdsAreSame()
        {
            // Arrange
            var employeeId1 = EmployeeId.Parse("SameId");
            var employeeId2 = EmployeeId.Parse("SameId");

            // Act & Assert
            (employeeId1 == employeeId2).Should().BeTrue();
        }

        [Fact]
        public void OperatorNotEqual_ReturnsTrue_WhenBothEmployeeIdsAreDifferent()
        {
            // Arrange
            var employeeId1 = EmployeeId.Parse("Id1");
            var employeeId2 = EmployeeId.Parse("Id2");

            // Act & Assert
            (employeeId1 != employeeId2).Should().BeTrue();
        }

        [Fact]
        public void ToString_ReturnsCorrectId()
        {
            // Arrange
            var expectedId = "TestToString";
            var employeeId = EmployeeId.Parse(expectedId);

            // Act
            var result = employeeId.ToString();

            // Assert
            result.Should().Be(expectedId);
        }
        
        [Fact]
        public void ImplicitOperatorToString_ReturnsCorrectString()
        {
            // Arrange
            var idString = "test";
            var employeeId = EmployeeId.Parse(idString);

            // Act
            string result = employeeId;

            // Assert
            result.Should().Be(idString);
        }

        [Fact]
        public void ImplicitOperatorToEmployeeId_ReturnsCorrectObject()
        {
            // Arrange
            var idString = "test";

            // Act
            EmployeeId employeeId = idString;

            // Assert
            employeeId.ToString().Should().Be(idString);
        }

        [Fact]
        public void ImplicitOperatorToEmployeeId_ThrowsArgumentException_WhenIdIsNullOrWhiteSpace()
        {
            // Arrange
            var nullId = (string)null;
            var whiteSpaceId = " ";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => { EmployeeId employeeId = nullId; });
            Assert.Throws<ArgumentException>(() => { EmployeeId employeeId = whiteSpaceId; });
        }
        
        [Fact]
        public void Equals_ReturnsTrue_WhenBothEmployeeIdsAreSame()
        {
            // Arrange
            var employeeId1 = EmployeeId.Parse("SameId");
            var employeeId2 = EmployeeId.Parse("SameId");

            // Act & Assert
            (employeeId1.Equals(employeeId2)).Should().BeTrue();
        }

        [Fact]
        public void Equals_ReturnsFalse_WhenBothEmployeeIdsAreDifferent()
        {
            // Arrange
            var employeeId1 = EmployeeId.Parse("Id1");
            var employeeId2 = EmployeeId.Parse("Id2");

            // Act & Assert
            (employeeId1.Equals(employeeId2)).Should().BeFalse();
        }

        [Fact]
        public void GetHashCode_ReturnsSameHashCode_WhenBothEmployeeIdsAreSame()
        {
            // Arrange
            var employeeId1 = EmployeeId.Parse("SameId");
            var employeeId2 = EmployeeId.Parse("SameId");

            // Act & Assert
            (employeeId1.GetHashCode().Equals(employeeId2.GetHashCode())).Should().BeTrue();
        }

        [Fact]
        public void GetHashCode_ReturnsDifferentHashCode_WhenBothEmployeeIdsAreDifferent()
        {
            // Arrange
            var employeeId1 = EmployeeId.Parse("Id1");
            var employeeId2 = EmployeeId.Parse("Id2");

            // Act & Assert
            (employeeId1.GetHashCode().Equals(employeeId2.GetHashCode())).Should().BeFalse();
        }
    }
}

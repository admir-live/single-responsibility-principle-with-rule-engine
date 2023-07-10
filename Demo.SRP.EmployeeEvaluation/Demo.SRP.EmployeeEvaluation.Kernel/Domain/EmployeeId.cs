using System;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public sealed class EmployeeId : IEquatable<EmployeeId>
    {
        private EmployeeId(string id)
        {
            Id = id.Trim();
        }

        public static EmployeeId NextId => new(Guid.NewGuid().ToString("N"));

        public string Id { get; }

        public bool Equals(EmployeeId other)
        {
            return other != null && Id == other.Id;
        }

        public static EmployeeId Parse(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("The ID cannot be null or consist only of whitespace.", nameof(id));
            }

            return new EmployeeId(id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            return obj is EmployeeId other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Id;
        }

        public static implicit operator string(EmployeeId id)
        {
            return id?.ToString();
        }

        public static implicit operator EmployeeId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Cannot implicitly convert null or white-space string to EmployeeId.",
                    nameof(id));
            }

            return Parse(id.Trim());
        }

        public static bool operator ==(EmployeeId left, EmployeeId right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EmployeeId left, EmployeeId right)
        {
            return !(left == right);
        }
    }
}

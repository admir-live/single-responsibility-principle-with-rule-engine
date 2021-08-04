using System;
using System.Collections.Generic;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public sealed class EmployeeId : ValueObject<EmployeeId>, IEquatable<EmployeeId>
    {
        private EmployeeId(string id)
        {
            Id = id.Trim();
        }

        public static EmployeeId NextId => new EmployeeId(id: Guid.NewGuid().ToString(format: "N"));

        public string Id { get; set; }
        protected override IEnumerable<object> EqualityCheckAttributes => new List<object> {Id};

        bool IEquatable<EmployeeId>.Equals(EmployeeId other)
        {
            return Equals(other: other);
        }

        public static EmployeeId Parse(string id)
        {
            if (string.IsNullOrWhiteSpace(value: id))
            {
                throw new ArgumentNullException(paramName: nameof(id));
            }

            return new EmployeeId(id: id);
        }

        private bool Equals(EmployeeId other)
        {
            return base.Equals(obj: other) && Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(objA: null, objB: obj))
            {
                return false;
            }

            if (ReferenceEquals(objA: this, objB: obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals(other: (EmployeeId) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value1: base.GetHashCode(), value2: Id);
        }

        public override string ToString()
        {
            return Id;
        }

        public static implicit operator string(EmployeeId id)
        {
            return id.ToString();
        }

        public static implicit operator EmployeeId(string id)
        {
            return Parse(id: id.Trim());
        }

        public static bool operator ==(EmployeeId left, EmployeeId right)
        {
            return right is { } && left is { } && left.Id == right.Id;
        }

        public static bool operator !=(EmployeeId left, EmployeeId right)
        {
            return !(left == right);
        }
    }
}
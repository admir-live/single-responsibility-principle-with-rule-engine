﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Mutual
{
    public abstract class Enumeration : IComparable
    {
        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; }
        public int Id { get; }

        public int CompareTo(object other)
        {
            return Id.CompareTo(value: ((Enumeration) other).Id);
        }

        public override string ToString()
        {
            return Name;
        }

        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            var fields = typeof(T).GetFields(bindingAttr: BindingFlags.Public |
                                                          BindingFlags.Static |
                                                          BindingFlags.DeclaredOnly);

            return fields.Select(selector: f => f.GetValue(obj: null)).Cast<T>();
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;

            if (otherValue == null)
            {
                return false;
            }

            var typeMatches = GetType() == obj.GetType();
            var valueMatches = Id.Equals(obj: otherValue.Id);

            return typeMatches && valueMatches;
        }

        protected bool Equals(Enumeration other)
        {
            return Name == other?.Name && Id == other?.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value1: Name, value2: Id);
        }

        public static bool operator ==(Enumeration left, Enumeration right)
        {
            if (ReferenceEquals(objA: left, objB: right))
            {
                return true;
            }

            return left.Equals(other: right);
        }

        public static bool operator !=(Enumeration left, Enumeration right)
        {
            return !(left == right);
        }
    }
}
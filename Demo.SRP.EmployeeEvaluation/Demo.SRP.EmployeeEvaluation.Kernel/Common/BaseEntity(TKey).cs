﻿using System;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Common
{
    public abstract class BaseEntity<TKey> : BaseEntity where TKey : IEquatable<TKey>
    {
        public virtual TKey Id { get; set; }
    }
}

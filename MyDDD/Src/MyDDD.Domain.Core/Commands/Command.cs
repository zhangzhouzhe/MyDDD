using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Domain.Core.Commands
{
    public abstract class Command
    {
        public DateTime TimeStamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}

using MyDDD.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Domain.Commands
{
    public abstract class StudentCommand : Command
    {
        public Guid Id { get; protected set; }//注意：set 都是 protected 的

        public string Name { get; protected set; }

        public string Email { get; protected set; }

        public DateTime BirthDate { get; protected set; }

        public string Phone { get; protected set; }
  
    }
}

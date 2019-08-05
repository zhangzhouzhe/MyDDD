using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Domain.Commands
{
    public class RegisterStudentCommand : StudentCommand
    {
        public RegisterStudentCommand(string name, string email, DateTime birthDate, string phone)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Phone = phone;
        }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}

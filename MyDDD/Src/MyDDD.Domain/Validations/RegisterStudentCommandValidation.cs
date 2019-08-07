using MyDDD.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Domain.Validations
{
    public class RegisterStudentCommandValidation : StudentValidation<RegisterStudentCommand>
    {
        public RegisterStudentCommandValidation()
        {
            ValidataEmail();
            ValidateName();
        }
    }
}

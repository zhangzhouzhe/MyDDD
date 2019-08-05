using FluentValidation;
using MyDDD.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Domain.Validations
{
    public abstract class StudentValidation<T> : AbstractValidator<T>
        where T : StudentCommand
    {
        protected void ValidateName()
        {
            RuleFor(it => it.Name)
                .NotEmpty().WithMessage("姓名不能为空")
                .Length(2, 10).WithMessage("长度");
        }
    }
}

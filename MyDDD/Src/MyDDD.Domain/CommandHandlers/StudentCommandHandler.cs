using MediatR;
using Microsoft.Extensions.Caching.Memory;
using MyDDD.Domain.Commands;
using MyDDD.Domain.Core.Bus;
using MyDDD.Domain.Interfaces;
using MyDDD.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyDDD.Domain.CommandHandlers
{
    public class StudentCommandHandler : CommandHandler,
          IRequestHandler<RegisterStudentCommand, Unit>
    {
        private readonly IStudentRepository _studentRepository;
        // 注入总线
        private readonly IMediatorHandler Bus;
        private IMemoryCache Cache;
        public StudentCommandHandler(IStudentRepository studentRepository,
                                    IUnitOfWork uow,
                                    IMediatorHandler bus,
                                    IMemoryCache cache
                                    ) : base(uow, bus, cache)
        {
            _studentRepository = studentRepository;
            Bus = bus;
            Cache = cache;
        }

        public Task<Unit> Handle(RegisterStudentCommand message, CancellationToken cancellationToken)
        {
            // 命令验证
            if (!message.IsValid())
            {
                // 错误信息收集
                return Task.FromResult(new Unit());
            }

            // 实例化领域模型，这里才真正的用到了领域模型
            // 注意这里是通过构造函数方法实现
            var customer = new Student(Guid.NewGuid(), message.Name, message.Email,message.BirthDate);

            // 判断邮箱是否存在
            // 这些业务逻辑，当然要在领域层中（领域命令处理程序中）进行处理
            if (_studentRepository.GetByEmail(customer.Email) != null)
            {
                //这里对错误信息进行发布，目前采用缓存形式
                List<string> errorInfo = new List<string>() { "The customer e-mail has already been taken." };
                Cache.Set("ErrorData", errorInfo);
                return Task.FromResult(new Unit());
            }


            // 持久化
            _studentRepository.Add(customer);

            // 统一提交
            if (Commit())
            {
                // 提交成功后，这里需要发布领域事件
                // 比如欢迎用户注册邮件呀，短信呀等

                // waiting....
            }

            return Task.FromResult(new Unit());

        }
    }
}

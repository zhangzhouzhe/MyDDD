using MyDDD.Domain.Core.Commands;
using MyDDD.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyDDD.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command)
            where T : Command;

        Task RaiseEvent<T>(T @event) where T : Event;
    }
}

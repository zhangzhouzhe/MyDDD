using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MyDDD.Domain.Core.Commands;
using MyDDD.Domain.Core.Events;

namespace MyDDD.Domain.Core.Bus
{
    public class InMemoryBus : IMediatorHandler
    {

        private readonly IMediator _mediator;

        private readonly ServiceFactory _serviceFacotry;
        private static readonly ConcurrentDictionary<Type, object> _request =
            new ConcurrentDictionary<Type, object>();
        public InMemoryBus(IMediator mediator, ServiceFactory serviceFactory)
        {
            _serviceFacotry = serviceFactory;
            mediator = _mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken)
        {
            var requestType = request.GetType();
            return null;
        }

        public Task RaiseEvent<T>(T @event) where T : Event
        {
            return _mediator.Publish(@event);
        }
    }
}

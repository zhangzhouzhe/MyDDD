using Microsoft.Extensions.Caching.Memory;
using MyDDD.Domain.Core.Bus;
using MyDDD.Domain.Interfaces;
using System;

namespace MyDDD.Domain
{
    public class CommandHandler
    {
        private readonly IUnitOfWork _uow;
        private readonly IMediatorHandler _bus;
        private IMemoryCache _cache;
        public CommandHandler(IUnitOfWork uow, IMediatorHandler bus, IMemoryCache cache)
        {
            _uow = uow;
            _bus = bus;
            _cache = cache;
        }

        public bool Commit()
        {
            if (_uow.Commit()) return true;

            return false;
        }
    }
}

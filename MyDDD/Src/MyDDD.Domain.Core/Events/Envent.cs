using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Domain.Core.Events
{
    public abstract class Event :INotification
    {
        public DateTime TimeStamp { get; private set; }
        protected Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}

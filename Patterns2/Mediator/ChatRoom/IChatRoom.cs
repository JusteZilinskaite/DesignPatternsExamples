﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Mediator.ChatRoom
{
    public interface IChatRoom
    {
        public void Register(Colleague colleague);
        public void Broadcast(string to, Colleague colleague, string message);
    }
}

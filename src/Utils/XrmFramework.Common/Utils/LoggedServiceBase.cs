﻿// Copyright (c) Christophe Gondouin (CGO Conseils). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Plugins
{
    public abstract class LoggedServiceBase : ILoggedService
    {
        protected IService Service { get; }
        protected Logger Log { get; }

        protected LoggedServiceBase(IServiceContext context, IService service)
        {
            Log = context.Logger;
            Service = service;
        }
    }
}
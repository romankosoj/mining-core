﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal
{
    internal interface ILibuvTrace
    {
        void ConnectionRead(string connectionId, int count);
        void ConnectionReadFin(string connectionId);
        void ConnectionWriteFin(string connectionId);
        void ConnectionWroteFin(string connectionId, int status);
        void ConnectionWrite(string connectionId, int count);
        void ConnectionWriteCallback(string connectionId, int status);
        void ConnectionError(string connectionId, Exception ex);
        void ConnectionReset(string connectionId);
        void ConnectionPause(string connectionId);
        void ConnectionResume(string connectionId);

	    void LogError(int _, Exception exception, string msg);
    }
}

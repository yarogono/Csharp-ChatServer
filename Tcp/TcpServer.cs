﻿using ChatServer.Logging;

namespace ChatServer.Network;

public class TcpServer
{
    private readonly IChatLogger _logger;

    public TcpServer(IChatLogger logger)
    {
        _logger = logger;
    }

    public Task RunAsync(string chatServerEndpoint)
    {
        throw new NotImplementedException();
    }
}

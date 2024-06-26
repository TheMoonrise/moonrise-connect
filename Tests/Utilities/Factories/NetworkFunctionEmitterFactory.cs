﻿using MoonriseGames.Connect.Functions;
using Moq;

namespace MoonriseGames.Connect.Tests.Utilities.Factories
{
    internal static class NetworkFunctionEmitterFactory
    {
        public static Mock<NetworkFunctionEmitter> BuildMock()
        {
            var connection = NetworkConnectionFactory.BuildMock();
            var registry = new Mock<NetworkFunctionRegistry>();
            var queue = new Mock<NetworkFunctionQueue>(registry.Object);

            return new Mock<NetworkFunctionEmitter>(queue.Object, registry.Object, connection.Object);
        }
    }
}

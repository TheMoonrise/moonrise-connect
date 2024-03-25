﻿using System;
using MoonriseGames.Connect.Connection;

namespace MoonriseGames.Connect.Tests.Utilities.Connection
{
    internal class TestNetworkIdentity : NetworkIdentity
    {
        private string Id { get; }
        public string DisplayName => Id;

        public TestNetworkIdentity(string id) => Id = id;

        public override bool Equals(object obj) => obj is TestNetworkIdentity identity && identity.Id == Id;

        public override int GetHashCode() => HashCode.Combine(Id);
    }
}

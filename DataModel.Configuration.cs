﻿using System;
using MUnique.OpenMU.Interfaces;
using MUnique.OpenMU.Network.PlugIns;

namespace MUnique.OpenMU.DataModel.Configuration
{
    /// <summary>
    /// The definition of a connect server.
    /// </summary>
    public class ConnectServerDefinition : IConnectServerSettings
    {
        /// <summary>
        /// Gets or sets the server identifier.
        /// </summary>
        public byte ServerId { get; set; }

        /// <summary>
        /// Gets or sets the description of the server.
        /// </summary>
        /// <remarks>
        /// Will be displayed in the server list in the admin panel as <see cref="IManageableServer.Description"/>.
        /// </remarks>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the client which is expected to connect.
        /// </summary>
        public virtual GameClientDefinition Client { get; set; }

        /// <inheritdoc/>
        IGameClientVersion IConnectServerSettings.Client => this.Client;

        /// <summary>
        /// Gets or sets a value indicating whether the client should get disconnected when a unknown packet is getting received.
        /// </summary>
        public bool DisconnectOnUnknownPacket { get; set; }

        /// <summary>
        /// Gets or sets the maximum size of the packets which should be received from the client. If this size is exceeded, the client will be disconnected.
        /// </summary>
        /// <remarks>DOS protection.</remarks>
        public byte MaximumReceiveSize { get; set; }

        /// <summary>
        /// Gets or sets the network port on which the server is listening.
        /// </summary>
        public int ClientListenerPort { get; set; }

        /// <summary>
        /// Gets or sets the timeout after which clients without activity get disconnected.
        /// </summary>
        public TimeSpan Timeout { get; set; }

        /// <summary>
        /// Gets or sets the current patch version.
        /// </summary>
        public byte[] CurrentPatchVersion { get; set; }

        /// <summary>
        /// Gets or sets the patch address.
        /// </summary>
        public string PatchAddress { get; set; }

        /// <summary>
        /// Gets or sets the maximum connections per ip.
        /// </summary>
        public int MaxConnectionsPerAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="MaxConnectionsPerAddress"/> should be checked.
        /// </summary>
        public bool CheckMaxConnectionsPerAddress { get; set; }

        /// <summary>
        /// Gets or sets the maximum connections the connect server should handle.
        /// </summary>
        public int MaxConnections { get; set; }

        /// <summary>
        /// Gets or sets the listener backlog for the client listener.
        /// </summary>
        public int ListenerBacklog { get; set; }

        /// <summary>
        /// Gets or sets the maximum FTP requests per connection.
        /// </summary>
        public int MaxFtpRequests { get; set; }

        /// <summary>
        /// Gets or sets the maximum ip requests per connection.
        /// </summary>
        public int MaxIpRequests { get; set; }

        /// <summary>
        /// Gets or sets the maximum server list requests per connection.
        /// </summary>
        public int MaxServerListRequests { get; set; }
    }

    /// <summary>
    /// Defines a game client.
    /// </summary>
    public class GameClientDefinition : IGameClientVersion
    {
        /// <summary>
        /// Gets or sets the season.
        /// </summary>
        public byte Season { get; set; }

        /// <summary>
        /// Gets or sets the episode.
        /// </summary>
        public byte Episode { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        public ClientLanguage Language { get; set; }

        /// <summary>
        /// Gets or sets the version which is defined in the client binaries.
        /// </summary>
        public byte[] Version { get; set; }

        /// <summary>
        /// Gets or sets the serial which is defined in the client binaries.
        /// </summary>
        public byte[] Serial { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
    }
}

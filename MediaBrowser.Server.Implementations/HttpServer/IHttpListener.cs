﻿using MediaBrowser.Controller.Net;
using ServiceStack.Web;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediaBrowser.Server.Implementations.HttpServer
{
    public interface IHttpListener : IDisposable
    {
        /// <summary>
        /// Gets or sets the error handler.
        /// </summary>
        /// <value>The error handler.</value>
        Action<Exception, IRequest> ErrorHandler { get; set; }

        /// <summary>
        /// Gets or sets the request handler.
        /// </summary>
        /// <value>The request handler.</value>
        Func<IHttpRequest, Uri, Task> RequestHandler { get; set; }

        /// <summary>
        /// Gets or sets the web socket handler.
        /// </summary>
        /// <value>The web socket handler.</value>
        Action<WebSocketConnectEventArgs> WebSocketConnected { get; set; }

        /// <summary>
        /// Gets or sets the web socket connecting.
        /// </summary>
        /// <value>The web socket connecting.</value>
        Action<WebSocketConnectingEventArgs> WebSocketConnecting { get; set; }
        
        /// <summary>
        /// Starts this instance.
        /// </summary>
        /// <param name="urlPrefixes">The URL prefixes.</param>
        void Start(IEnumerable<string> urlPrefixes);

        /// <summary>
        /// Stops this instance.
        /// </summary>
        void Stop();
    }
}

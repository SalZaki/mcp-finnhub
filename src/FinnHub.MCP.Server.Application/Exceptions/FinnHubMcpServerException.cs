﻿// ---------------------------------------------------------------------------------------------------------------------
//  <copyright>
//    This file is part of FinnHub MCP Server and is licensed under the MIT License.
//    See the LICENSE file in the project root for full license information.
//  </copyright>
// ---------------------------------------------------------------------------------------------------------------------

namespace FinnHub.MCP.Server.Application.Exceptions;

/// <summary>
/// Base class for all exceptions originating from the FinnHub MCP Server.
/// </summary>
/// <param name="message">The error message describing the exception.</param>
/// <param name="inner">Optional inner exception for chaining.</param>
public abstract class FinnHubMcpServerException(string message, Exception? inner = null)
    : ApplicationException(message, inner);

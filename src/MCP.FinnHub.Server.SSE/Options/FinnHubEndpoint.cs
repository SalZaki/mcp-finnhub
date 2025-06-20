﻿// --------------------------------------------------------------------------------------------------------------------
//  <copyright>
//    This file is part of the MCP FinnHub project and is licensed under the MIT License.
//    See the LICENSE file in the project root for full license information.
//  </copyright>
//  <summary>
//    Add summary.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MCP.FinnHub.Server.SSE.Options;

[ExcludeFromCodeCoverage]
public sealed class FinnHubEndpoint
{
    [Required]
    public string Name { get; init; } = string.Empty;

    [Required]
    public string Url { get; init; } = string.Empty;

    public bool IsActive { get; init; } = true;

    public string Description { get; init; } = string.Empty;
}

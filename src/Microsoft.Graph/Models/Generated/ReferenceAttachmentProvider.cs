// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ReferenceAttachmentProvider.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ReferenceAttachmentProvider
    {
    
        /// <summary>
        /// other
        /// </summary>
        Other = 0,
	
        /// <summary>
        /// one Drive Business
        /// </summary>
        OneDriveBusiness = 1,
	
        /// <summary>
        /// one Drive Consumer
        /// </summary>
        OneDriveConsumer = 2,
	
        /// <summary>
        /// dropbox
        /// </summary>
        Dropbox = 3,
	
    }
}
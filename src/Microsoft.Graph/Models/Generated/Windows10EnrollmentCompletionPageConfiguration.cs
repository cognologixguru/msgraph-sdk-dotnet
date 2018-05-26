// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Windows10Enrollment Completion Page Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows10EnrollmentCompletionPageConfiguration : DeviceEnrollmentConfiguration
    {
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets body text.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bodyText", Required = Newtonsoft.Json.Required.Default)]
        public string BodyText { get; set; }
    
        /// <summary>
        /// Gets or sets more info url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "moreInfoUrl", Required = Newtonsoft.Json.Required.Default)]
        public string MoreInfoUrl { get; set; }
    
        /// <summary>
        /// Gets or sets more info text.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "moreInfoText", Required = Newtonsoft.Json.Required.Default)]
        public string MoreInfoText { get; set; }
    
    }
}

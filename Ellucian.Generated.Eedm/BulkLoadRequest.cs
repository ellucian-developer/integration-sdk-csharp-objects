//Copyright 2019 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Bulk Load Request to initiate process 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BulkLoadRequest
    {
        /// <summary>
        /// Resource name of HEDM schema
        /// </summary>
        [JsonProperty("resourceName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Header version representation of HEDM schema
        /// </summary>
        [JsonProperty("representation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Representation { get; set; }

        /// <summary>
        /// Tracking ID used by the requesting system
        /// </summary>
        [JsonProperty("requestorTrackingId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RequestorTrackingId { get; set; }

        /// <summary>
        /// Job Number for requesting system to check with
        /// </summary>
        [JsonProperty("jobNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string JobNumber { get; set; }

        /// <summary>
        /// Job Status
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BulkLoadRequestStatus Status { get; set; }

        /// <summary>
        /// ApplicationId of the application in the ethos tenant
        /// </summary>
        [JsonProperty("applicationId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Message from source system about bulk load request
        /// </summary>
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message { get; set; }

    }
}

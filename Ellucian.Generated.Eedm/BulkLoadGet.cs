//Copyright 2019 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Bulk Load Get to obtain job status
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BulkLoadGet
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
        [FilterProperty("criteria")]
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
        public string Status { get; set; }

        /// <summary>
        /// ApplicationId of the application in the ethos tenant
        /// </summary>
        [JsonProperty("applicationId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Id of the Tenant in Ethos
        /// </summary>
        [JsonProperty("tenantId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// Total count of resources in job
        /// </summary>
        [JsonProperty("xTotalCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string XTotalCount { get; set; }

        /// <summary>
        /// Collection of <see cref="BulkLoadGetError"> errors</see>
        /// </summary>
        [JsonProperty("errors", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<BulkLoadGetError> Errors { get; set; }

        /// <summary>
        /// Collection of <see cref="BulkLoadProcessingStep"> errors</see>
        /// </summary>
        [JsonProperty("processingSteps", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<BulkLoadProcessingStep> ProcessingSteps { get; set; }

    }

    /// <summary>
    /// Error object for 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BulkLoadGetError
    {
        /// <summary>
        /// Error Code
        /// </summary>
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Id for the resource the error is related to
        /// </summary>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// error message
        /// </summary>
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message { get; set; }
    }

    /// <summary>
    /// Bulk load processing step
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BulkLoadProcessingStep
    {
        /// <summary>
        /// Count of records in this step
        /// </summary>
        [JsonProperty("count", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Count { get; set; }

        /// <summary>
        /// elapsed time for the batch process
        /// </summary>
        [JsonProperty("elapsedTime", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ElapsedTime { get; set; }

        /// <summary>
        /// job number of this step
        /// </summary>
        [JsonProperty("jobNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string JobNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("seq", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Seq { get; set; }

        /// <summary>
        /// start time of this step
        /// </summary>
        [JsonProperty("startTime", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// status of this step
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// step name
        /// </summary>
        [JsonProperty("step", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Step { get; set; }
    }
}

// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The status of the employee on the job.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstitutionJobsStatus
    {
        
        /// <summary>
        /// Active
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Ended
        /// </summary>
        [EnumMember(Value = "ended")]
        Ended,

        /// <summary>
        /// Leave
        /// </summary>
        [EnumMember(Value = "leave")]
        Leave,
    }
}
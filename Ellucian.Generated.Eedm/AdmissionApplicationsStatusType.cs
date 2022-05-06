//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an address
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdmissionApplicationsStatusType
    {
        /// <summary>
        /// Default
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Started
        /// </summary>
        [EnumMember(Value = "started")]
        Started,

        /// <summary>
        /// Submitted
        /// </summary>
        [EnumMember(Value = "submitted")]
        Submitted,

        /// <summary>
        /// ReadyForReview
        /// </summary>
        [EnumMember(Value = "readyForReview")]
        ReadyForReview,

        /// <summary>
        /// DecisionMade
        /// </summary>
        [EnumMember(Value = "decisionMade")]
        DecisionMade,

        /// <summary>
        /// EnrollmentCompleted
        /// </summary>
        [EnumMember(Value = "enrollmentCompleted")]
        EnrollmentCompleted
    }
}

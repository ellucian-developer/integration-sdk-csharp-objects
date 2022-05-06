// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The top level category of the admission application status type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdmissionApplicationStatusTypesCategory
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// started
        /// </summary>
        [EnumMember(Value = "started")]
        Started,

        /// <summary>
        /// submitted
        /// </summary>
        [EnumMember(Value = "submitted")]
        Submitted,

        /// <summary>
        /// readyForReview
        /// </summary>
        [EnumMember(Value = "readyForReview")]
        Readyforreview,

        /// <summary>
        /// decisionMade
        /// </summary>
        [EnumMember(Value = "decisionMade")]
        Decisionmade,

        /// <summary>
        /// enrollmentComplete
        /// </summary>
        [EnumMember(Value = "enrollmentComplete")]
        Enrollmentcomplete,
    }
}



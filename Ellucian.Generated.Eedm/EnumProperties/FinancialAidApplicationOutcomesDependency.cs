// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The dependency status of a financial aid applicant.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationOutcomesDependency
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// independent
        /// </summary>
        [EnumMember(Value = "independent")]
        Independent,

        /// <summary>
        /// dependent
        /// </summary>
        [EnumMember(Value = "dependent")]
        Dependent,

        /// <summary>
        /// rejected independent
        /// </summary>
        [EnumMember(Value = "rejectedIndependent")]
        RejectedIndependent,

        /// <summary>
        /// rejected dependent
        /// </summary>
        [EnumMember(Value = "rejectedDependent")]
        RejectedDependent,

    }
}

// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The source of the financial aid application.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationsSource
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// isir
        /// </summary>
        [EnumMember(Value = "isir")]
        Isir,

        /// <summary>
        /// profile
        /// </summary>
        [EnumMember(Value = "profile")]
        Profile,

        /// <summary>
        /// manualFederal
        /// </summary>
        [EnumMember(Value = "manualFederal")]
        Manualfederal,

        /// <summary>
        /// manualInstitution
        /// </summary>
        [EnumMember(Value = "manualInstitution")]
        Manualinstitution,
    }
}



//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The academic credentials awarded to the student. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentAcademicCredentialsCredentials
    {
        /// <summary>
        /// The academic credential that has been awarded.
        /// </summary>

        [JsonProperty("credential", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Credential { get; set; }

        /// <summary>
        /// The date when the person earned the credential.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("earnedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EarnedOn { get; set; }
    }
}
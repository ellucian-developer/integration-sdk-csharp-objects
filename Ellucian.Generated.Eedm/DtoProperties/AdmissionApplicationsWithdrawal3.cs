//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Application withdrawal related information.
    /// </summary>
    [DataContract]
    public class AdmissionApplicationsWithdrawal3
    {
        /// <summary>
        /// The application withdrawal reason.
        /// </summary>
        [DataMember(Name = "withdrawnOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime? WithdrawnOn { get; set; }
        
        /// <summary>
        /// The application withdrawal reason.
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 WithdrawalReason { get; set; }

        /// <summary>
        /// The institution attended by the applicant.
        /// </summary>
        [DataMember(Name = "institutionAttended", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AdmissionApplicationInstitutionAttendedDtoProperty InstitutionAttended { get; set; }
    }
}

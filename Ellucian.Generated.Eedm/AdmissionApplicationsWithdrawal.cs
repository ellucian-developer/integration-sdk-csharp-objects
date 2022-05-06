//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Application withdrawal related information.
    /// </summary>
    [DataContract]
    public class AdmissionApplicationsWithdrawal
    {
        /// <summary>
        /// The application withdrawal reason.
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public GuidObject2 WithdrawalReason { get; set; }

        /// <summary>
        /// The institution attended by the applicant.
        /// </summary>
        [DataMember(Name = "institutionAttended", EmitDefaultValue = false)]
        public string InstitutionAttended { get; set; }
    }
}

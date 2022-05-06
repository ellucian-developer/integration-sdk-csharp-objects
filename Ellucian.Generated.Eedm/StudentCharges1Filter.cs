// Copyright 2018 Ellucian Company L.P. an?d its affiliates.
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// student-charges v11 URL criteria, supporting both styles of json input
    /// </summary>
    public class StudentCharges1Filter : BaseModel2
    {
        /// <summary>
        /// The person (student), who incurred the charge.  Specifically, this is the global identifier for the Student.
        /// </summary>
        [DataMember(Name = "student", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The account receivable type the charge is attached to.  Specifically, the global identifier for the Account Receivable Type.
        /// </summary>
        [DataMember(Name = "fundingSource", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 FundingSource { get; set; }

        /// <summary>
        /// Accounting Code the charge is associated with.  Specifically, this is the global identifier for the Accounting Code.
        /// </summary>
        [DataMember(Name = "fundingDestination", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 FundingDestination { get; set; }

        /// <summary>
        /// The term the charges are incurred in.  Specifically, this is the global identifier for the Academic Period.
        /// </summary>
        [DataMember(Name = "academicPeriod", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// Type of the charge the student incurred. 
        /// </summary>
        [DataMember(Name = "chargeType", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(StudentChargeTypesEnumConverter))]
        public StudentChargeTypes ChargeType { get; set; }

    }
}

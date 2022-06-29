//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about the institutional units to which the instructor is assigned.
    /// </summary>
    [DataContract]
    public class InstructorsInstitutionalUnit2
    {
        ///// <summary>
        ///// The school to which the instructor is assigned.
        ///// </summary>        
        //[DataMember(Name = "school", EmitDefaultValue = false)]
        //public GuidObject2 School { get; set; }

        ///// <summary>
        ///// The division to which the instructor is assigned.
        ///// </summary>
        //[DataMember(Name = "division", EmitDefaultValue = false)]
        //public GuidObject2 Division { get; set; }

        /// <summary>
        /// The department to which the instructor is assigned.
        /// </summary>        
        [DataMember(Name = "department", EmitDefaultValue = false)]
        public GuidObject2 Department { get; set; }

        /// <summary>
        /// The percentage of the instructor's workload allocated to the institutional unit.
        /// </summary>        
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// An indicator of the instructor's administrative organization.
        /// </summary>

        [JsonProperty("administrativeUnit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InstructorsAdministrativeUnit AdministrativeUnit { get; set; }

    }
}
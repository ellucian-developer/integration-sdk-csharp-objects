using Ellucian.Generated.Eedm;
// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a employee proficiency
    /// </summary>
    [DataContract]
    public class EmploymentProficiencies_V10_0 : CodeItem2
    {
        ///// <summary>
        ///// The human-readable description of a resource.
        ///// </summary>
        //[DataMember(Name = "description", EmitDefaultValue = false)]
        //public string Description2 { get; set; }

        /// <summary>
        /// The <see cref="EmploymentProficiencyType">entity type</see> for the employee proficiency
        /// </summary>
        [DataMember(Name = "type")]
        public EmploymentProficiencyType employeeProficiencyType { get; set; }

        /// <summary>
        /// The <see cref="EmploymentProficiencyLicensing">entity type</see> for the employee proficiency
        /// </summary>
        [DataMember(Name = "licensing")]
        public EmploymentProficiencyLicensing employeeProficiencyLicensing { get; set; }

        /// <summary>
        /// The <see cref="EmploymentProficiencyLicensingAuthorityDtoProperty">entity type</see> for the employee proficiency
        /// </summary>
        [DataMember(Name = "licensingAuthority", EmitDefaultValue = false)]
        public EmploymentProficiencyLicensingAuthorityDtoProperty employmentProficiencyLicensingAuthority { get; set; }
    }
}
// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Educational-Institution-Unit Parent DTO Property
    /// </summary>
    [DataContract]
    public class EducationalInstitutionUnitParentDtoProperty
    {
        /// <summary>
        /// The institution which the unit is a part of
        /// </summary>
        [DataMember(Name = "institution", EmitDefaultValue = false)]
        public GuidObject2 Institution { get; set; }

        /// <summary>
        /// The parent (upper-level) unit within the institution
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public GuidObject2 Unit { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public EducationalInstitutionUnitParentDtoProperty()
        {          
        }
    }
}

// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a employee classifcation
    /// </summary>
    [DataContract]
    public class EmploymentClassifications_V7_0 : CodeItem2
    {
        /// <summary>
        /// The <see cref="EmploymentClassificationType">entity type</see> for the employee classification type
        /// </summary>
        [DataMember(Name = "type")]
        public EmploymentClassificationType employeeClassificationType { get; set; }
    }
}
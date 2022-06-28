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
    /// The list of valid admission application status types 
    /// </summary>
    [DataContract]
    public class AdmissionApplicationStatusTypes_V6_0 : CodeItem2
    {
        /// <summary>
        /// Admission application status type category
        /// </summary>
        [DataMember(Name = "category")]
        public AdmissionApplicationStatusTypesCategory Category { get; set; }         
     }      
}          

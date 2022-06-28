using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Admission applicants types of residency 
    /// </summary>
    [DataContract]
    public class AdmissionResidencyTypes_V6_0 : CodeItem2
    {
        /// <summary>
        /// The human-readable name of a resource.
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        new public string Code { get; set; } 
    }      
}          

//Copyright 2017 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The list of valid admission application status types 
    /// </summary>
    [DataContract]
    public class AdmissionDecisionTypes_V11_0 : CodeItem2
    {
        /// <summary>
        /// Admission application status type category
        /// </summary>
        [DataMember(Name = "decisionCategories", EmitDefaultValue = false)]
        public IEnumerable<AdmissionApplicationStatusTypesCategory2?> Category { get; set; }         
     }      
}          

//Copyright 2017-2019 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The valid list of user defined employment departments. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class EmploymentDepartments_V12_1_0 : FilterCodeItem2
    {
        /// <summary>
        /// Status of the departement code table entry. (Active or Inactive).
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public EmploymentDepartmentStatuses? Status { get; set; }
    }      
}          

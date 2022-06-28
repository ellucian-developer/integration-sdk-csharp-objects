// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{

    /// <summary>
    /// Information about a type of location for an Organization.
    /// </summary>
    /// 
    [DataContract]
    public class OrganizationLocationType
    {
        /// <summary>
        /// The <see cref="OrganizationLocationTypeList">type</see> of location for an organization
        /// </summary>
        [DataMember(Name = "locationType")]
        public OrganizationLocationTypeList OrganizationLocationTypeList { get; set; }
    }
   
}
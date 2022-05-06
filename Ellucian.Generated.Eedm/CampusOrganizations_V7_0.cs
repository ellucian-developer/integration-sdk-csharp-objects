// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Organizations involved in extra curricular activities.
    /// </summary>
    [DataContract]
    public class CampusOrganizations_V7_0 : BaseModel2
    {
        /// <summary>
        /// The generally unique code for a campus organization.
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; set; }


        /// <summary>
        /// Name of the Campus Organization.
        /// </summary>
        [DataMember(Name = "name")]
        public string CampusOrganizationName { get; set; }

        /// <summary>
        /// Parent organization to which the campus organization comes under.
        /// </summary>
        [DataMember(Name = "parentOrganization", EmitDefaultValue = false)]
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ParentOrganization { get; set; }

        /// <summary>
        /// Type of the organizations (eg: athletic, culture)
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 CampusOrganizationType { get; set; }

    }
}
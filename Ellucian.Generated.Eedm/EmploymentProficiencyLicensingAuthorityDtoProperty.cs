// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Employment Proficiency Licensing Authority DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class EmploymentProficiencyLicensingAuthorityDtoProperty
    {
        /// <summary>
        /// Id of the EmploymentProficiencyLicensingAuthority
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //[DataMember(Name = "detail", EmitDefaultValue = false)]
        public GuidObject2 detail { get; set; }

        /// <summary>
        /// Name of the EmploymentProficiencyLicensingAuthority
        /// </summary>
        [JsonProperty("name")]
        //[DataMember(Name = "name", EmitDefaultValue = false)]
        public string name { get; set; }

    }
}
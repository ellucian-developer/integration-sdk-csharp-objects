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
    /// The supervisors of the person for the external employment. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ExternalEmploymentsSupervisors
    {
        /// <summary>
        /// The name of the supervisor.
        /// </summary>

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The phone number of the supervisor.
        /// </summary>

        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// The email address of the supervisor.
        /// </summary>

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }
        
    }
}


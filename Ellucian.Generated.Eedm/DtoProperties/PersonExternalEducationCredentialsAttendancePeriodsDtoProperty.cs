//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The periods associated with the person's attendance at the institution. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonExternalEducationCredentialsAttendanceperiodsDtoProperty
    {
        /// <summary>
        /// The date when the person's education at the institution began.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The date when the person's education at the institution ended.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndOn { get; set; }


    }
}


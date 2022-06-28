//Copyright 2019 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The valid list of user defined student academic period statuses. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentAcademicPeriodStatuses_V1_0_0 : FilterCodeItem2
    {
        /// <summary>
        /// The usage(s) associated with the student academic period status.
        /// </summary>
        [JsonProperty("usages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public List<string> Usages { get; set; }

    }
}

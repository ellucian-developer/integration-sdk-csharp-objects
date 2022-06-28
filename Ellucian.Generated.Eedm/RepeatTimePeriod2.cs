// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The period of time to be repeated.
    /// </summary>
    [DataContract]
    public class RepeatTimePeriod2
    {
        /// <summary>
        /// The beginning of the time period being repeated.
        /// </summary>
        [DataMember(Name = "startOn")]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The end of the time period being repeated
        /// </summary>
        [DataMember(Name = "endOn")]
        public DateTimeOffset? EndOn { get; set; }
    }
}

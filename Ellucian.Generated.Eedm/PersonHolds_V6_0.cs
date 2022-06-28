using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    ///  Holds on person records
    /// </summary>
    [DataContract]
    public class PersonHolds_V6_0 :BaseModel2
    {
        /// <summary>
        /// The person (student), for whom the hold has been recorded
        /// </summary>
        [DataMember(Name = "person")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The type of the hold
        /// </summary>
        [DataMember(Name = "type")]
        public PersonHoldTypeType PersonHoldTypeType { get; set; }

        /// <summary>
        /// Notification Indicator
        /// </summary>
        [DataMember(Name = "notificationIndicator")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public NotificationIndicatorType? NotificationIndicator { get; set; }

        /// <summary>
        /// The date when the hold goes into effect
        /// </summary>
        [DataMember(Name = "startOn")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The date when the hold ends
        /// </summary>
        [DataMember(Name = "endOn")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndOn { get; set; }

        /// <summary>
        /// A comment for the hold
        /// </summary>
        [DataMember(Name = "comment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }
    }
}

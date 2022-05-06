// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Indicates if the student should be notified of the hold being placed
    /// </summary>
   [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationIndicatorType
    {
       /// <summary>
       /// notify the person
       /// </summary>
       [EnumMember(Value = "notify")]
        Notify,
       /// <summary>
       /// watch the person
       /// </summary>
       [EnumMember(Value = "watch")]
       Watch
    }
}

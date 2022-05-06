// Copyright 2015-2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type or style of a of room's layout, for example, \"Classroom\" style, \"Lecture Hall\" style, etc.  
    /// A room may support multiple types of layouts.
    /// </summary>
    [DataContract]
    public class RoomType
    {
        /// <summary>
        /// The type or style of a of room's layout, for example, \"Classroom\" style, \"Banquet\" style, etc.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public RoomTypeTypes? Type { get; set; }

        /// <summary>
        /// Globally unique identifier for a room type
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public GuidObject2 RoomTypesGuid { get; set; }

    }
}
// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type or style of a of Room's layout.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoomLayoutType
    {
        /// <summary>
        /// Banquet layout
        /// </summary>
        Banquet,

        /// <summary>
        /// Booth layout
        /// </summary>
        Booth,
 
        /// <summary>
        /// Classroom layout
        /// </summary>
        Classroom,

        /// <summary>
        /// Empty layout
        /// </summary>
        Empty,

        /// <summary>
        /// Theater layout
        /// </summary>
        Theater
    }
}
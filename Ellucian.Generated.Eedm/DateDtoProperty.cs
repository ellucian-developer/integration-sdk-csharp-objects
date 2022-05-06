// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A date
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DateDtoProperty
    {
        /// <summary>
        /// The month portion of the date
        /// </summary>
        [JsonProperty("month", NullValueHandling = NullValueHandling.Ignore)]     
        public int? Month { get; set; }
        
        /// <summary>
        /// The day portion of a date.
        /// </summary>
        [JsonProperty("day", NullValueHandling = NullValueHandling.Ignore)]     
        public int? Day { get; set; }

         /// <summary>
        /// The year portion of the date.
        /// </summary>
        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]     
        public int Year { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public DateDtoProperty()
        {
        }
    }
}
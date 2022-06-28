//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A student's request for housing including room and roommate preferences. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HousingRequests_V10_0 : BaseModel2
    {
        /// <summary>
        /// The student requesting housing.
        /// </summary>
        [JsonProperty("person")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The academic periods for which a student is requesting housing.
        /// </summary>
        [JsonProperty("academicPeriods", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> AcademicPeriods { get; set; }

        /// <summary>
        /// The first date for which housing is requested.
        /// </summary>
        //[JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn")]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The last date for which housing is requested.
        /// </summary>
        //[JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? EndOn { get; set; }

        /// <summary>
        /// The status of the housing request.
        /// </summary>
        [JsonProperty("status")]
        public HousingRequestsStatus Status { get; set; }

        /// <summary>
        /// A number that indicates relative priority of housing requests.
        /// </summary>
        [JsonProperty("priorityNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? PriorityNumber { get; set; }

        /// <summary>
        /// The person's housing preferences.
        /// </summary>
        [JsonProperty("preferences", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<HousingRequestPreferenceProperty> Preferences { get; set; }

        /// <summary>
        /// A person's preferred room characteristics.
        /// </summary>
        [JsonProperty("roomCharacteristics", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<HousingPreferenceRequiredProperty> RoomCharacteristics { get; set; }

        /// <summary>
        /// A person's preferred floor characteristic.
        /// </summary>
        [JsonProperty("floorCharacteristic", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HousingPreferenceRequiredProperty FloorCharacteristics { get; set; }

        /// <summary>
        /// A list of requested roommates or roommate attributes.
        /// </summary>
        [JsonProperty("roommatePreferences", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<HousingRequestRoommatePreferenceProperty> RoommatePreferences { get; set; }

    }
}

// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type or style of a of Room's layout.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoomTypeTypes
    {

        /// <summary>
        /// Residence Hall Room
        /// </summary>
       [EnumMember(Value = "residencehallroom")]
        Residencehallroom,

        /// <summary>
        /// Residential Single Room
        /// </summary>
        [EnumMember(Value = "residentialsingleroom")]
        Residentialsingleroom,

        /// <summary>
        /// Residential Double Room
        /// </summary>
        [EnumMember(Value = "residentialdoubleroom")]
        Residentialdoubleroom,

        /// <summary>
        ///  Residential Triple Room
        /// </summary>
        [EnumMember(Value = "residentialtripleroom")]
        Residentialtripleroom,

        /// <summary>
        /// Residential Suite Room
        /// </summary>
        [EnumMember(Value = "residentialsuiteroom")]
        Residentialsuiteroom,

        /// <summary>
        /// Apartment
        /// </summary>
        [EnumMember(Value = "apartment")]
        Apartment,

        /// <summary>
        /// House
        /// </summary>
        [EnumMember(Value = "house")]
        House,

        /// <summary>
        /// Classroom
        /// </summary>
        [EnumMember(Value = "classroom")]
        Classroom,

        /// <summary>
        /// Lecture Hall
        /// </summary>
        [EnumMember(Value = "lecturehall")]
        Lecturehall,

        /// <summary>
        /// Seminar Room
        /// </summary>
        [EnumMember(Value = "seminarroom")]
        Seminarroom,

        /// <summary>
        /// Conference Room
        /// </summary>
        [EnumMember(Value = "conferenceroom")]
        Conferenceroom,

        /// <summary>
        /// Science Laboratory
        /// </summary>
        [EnumMember(Value = "sciencelaboratory")]
        Sciencelaboratory,

        /// <summary>
        /// Computer Laboratory
        /// </summary>
        [EnumMember(Value = "computerlaboratory")]
        Computerlaboratory,

        /// <summary>
        /// Mechanics Lab
        /// </summary>
        [EnumMember(Value = "mechanicslab")]
        Mechanicslab,

        /// <summary>
        /// Audio Visual Lab
        /// </summary>
        /// 
        [EnumMember(Value = "audiovisuallab")]
        Audiovisuallab,

        /// <summary>
        ///  Art Studio
        /// </summary>
        [EnumMember(Value = "artstudio")]
        Artstudio,

        /// <summary>
        /// Music Room
        /// </summary>
        [EnumMember(Value = "musicroom")]
        Musicroom,

        /// <summary>
        /// Performing Arts Studio
        /// </summary>
        [EnumMember(Value = "performingartsstudio")]
        Performingartsstudio,

        /// <summary>
        /// Ballroom
        /// </summary>
        [EnumMember(Value = "ballroom")]
        Ballroom,

        /// <summary>
        /// Office
        /// </summary>
        [EnumMember(Value = "office")]
        Office,

        /// <summary>
        /// Study Facility
        /// </summary>
        [EnumMember(Value = "studyfacility")]
        Studyfacility,

        /// <summary>
        /// Clinic
        /// </summary>
        [EnumMember(Value = "clinic")]
        Clinic,

        /// <summary>
        /// Animal Quarters
        /// </summary>
        [EnumMember(Value = "animalquarters")]
        Animalquarters,

        /// <summary>
        /// Greenhouse
        /// </summary>
        [EnumMember(Value = "greenhouse")]
        Greenhouse,

        /// <summary>
        /// Special Use Facility
        /// </summary>
        [EnumMember(Value = "specialusefacility")]
        Specialusefacility,

        /// <summary>
        /// General Use Facility
        /// </summary>
        [EnumMember(Value = "generalusefacility")]
        Generalusefacility,

        /// <summary>
        /// Food Facility
        /// </summary>
        [EnumMember(Value = "foodfacility")]
        Foodfacility,

        /// <summary>
        /// Daycare
        /// </summary>
        [EnumMember(Value = "daycare")]
        Daycare,

        /// <summary>
        /// Lounge
        /// </summary>
        [EnumMember(Value = "lounge")]
        Lounge,

        /// <summary>
        /// Merchandising Room
        /// </summary>
        [EnumMember(Value = "merchandisingroom")]
        Merchandisingroom,

        /// <summary>
        /// Support Facility
        /// </summary>
        [EnumMember(Value = "supportfacility")]
        Supportfacility,

        /// <summary>
        /// Health Care Facility
        /// </summary>
        [EnumMember(Value = "healthcarefacility")]
        Healthcarefacility,

        /// <summary>
        /// Atrium
        /// </summary>
        [EnumMember(Value = "atrium")]
        Atrium,

        /// <summary>
        ///  Amphitheater
        /// </summary>
        [EnumMember(Value = "amphitheater")]
        Amphitheater,

        /// <summary>
        /// Auditorium
        /// </summary>
        [EnumMember(Value = "auditorium")]
        Auditorium,

        /// <summary>
        /// Booth
        /// </summary>
        [EnumMember(Value = "booth")]
        Booth,

        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}
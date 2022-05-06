// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The method by which leave can be accumulated.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LeavePlansAccrualMethod
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// frontLoad
        /// </summary>
        [EnumMember(Value = "frontLoad")]
        Frontload,

        /// <summary>
        /// payrollAccrual
        /// </summary>
        [EnumMember(Value = "payrollAccrual")]
        Payrollaccrual,
    }
}

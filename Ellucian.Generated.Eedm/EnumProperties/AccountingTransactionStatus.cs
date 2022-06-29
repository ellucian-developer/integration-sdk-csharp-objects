// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// 	Indicates if accounting string component value is available for transaction entry. 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountingTransactionStatus
    {
        /// <summary>
        /// Available GL/Project
        /// </summary>
        available,

        /// <summary>
        /// Unavailable GL/Project
        /// </summary>
        unavailable
    }
}

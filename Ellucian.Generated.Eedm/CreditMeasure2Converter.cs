// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;


namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// JSON converter for CreditMeasure2 type - due to mismatched 
    /// implementations between Colleague and Banner, we need to 
    /// accept the value "hour" as well as "hours" in incoming JSON
    /// </summary>
    public class CreditMeasure2Converter : StringEnumConverter
    {
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;
            if (enumString == "hour") { enumString = "hours"; }

            return Enum.Parse(typeof(CreditMeasure2), enumString, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}




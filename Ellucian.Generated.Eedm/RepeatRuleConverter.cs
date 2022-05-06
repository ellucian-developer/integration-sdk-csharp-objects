// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Linq;

namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// JSON converter for RepeatRule type
    /// </summary>
    public class RepeatRuleConverter : JsonConverter
    {
        /// <summary>
        /// Read method to parse the json to the specified type.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns>Class derived from IRepeatRule</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
           object obj;
            bool flag = IsNullableType(objectType);
            Type type = (flag ? Nullable.GetUnderlyingType(objectType) : objectType);
            if (reader.TokenType == JsonToken.Null)
            {
                if (!IsNullableType(objectType))
                {
                    throw new JsonException("Cannot convert null value to:" + objectType.ToString());
                }
                return null;
            }

            if (objectType.Name != "IRepeatRule")  return null;
            try
            {
                JObject jObject = JObject.Load(reader);

                string frequencyType = jObject["type"].Value<string>();

                if (String.IsNullOrEmpty(frequencyType))
                    //return new JsonException("Unable to determine repeat rule type.");
                    return new RepeatRuleDaily() { Type = null };

                switch (frequencyType.ToLower())
                {
                    case "daily":
                        obj = jObject.ToObject<RepeatRuleDaily>(serializer);
                        break;
                    case "weekly":
                        obj = jObject.ToObject<RepeatRuleWeekly>(serializer);
                        break;
                    case "monthly":
                        obj = jObject.ToObject<RepeatRuleMonthly>(serializer);
                        break;
                    case "yearly":
                        obj = jObject.ToObject<RepeatRuleYearly>(serializer);
                        break;
                    default:
                        // return new JsonException("Unable to determine repeat rule type.");
                        return new RepeatRuleDaily() { Type = null };
                }
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                throw new JsonException(string.Format("Error converting value {0} to type '{1}'.", reader.Value, objectType.ToString()), exception);
            }
            return obj;
        }

      private bool IsNullableType(Type t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("Repeat Rule Converter. Can not convert NullableType.");
            }
            if (!t.IsGenericType)
            {
                return false;
            }
            return t.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        /// <summary>
        /// Indentifies whether this converter can convert the specified object type
        /// </summary>
        /// <param name="objectType">The object type to convert</param>
        /// <returns>True/false</returns>
        public override bool CanConvert(Type objectType)
        {
            return (objectType.IsInterface || objectType.IsAbstract) && typeof(IRepeatRule).IsAssignableFrom(objectType);
        }

        /// <summary>
        /// Property that identifies whether this converter can write (serialize)
        /// </summary>
        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Write method to serialize an object into JSON.
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">value to serialize</param>
        /// <param name="serializer">Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}

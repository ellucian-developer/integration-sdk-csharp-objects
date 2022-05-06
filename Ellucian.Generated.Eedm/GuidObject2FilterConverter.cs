// Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// Allows property to accept either a string or a guidObject2
    /// </summary>
    public class GuidObject2FilterConverter : JsonConverter
    {
        /// <summary>
        /// WriteJson
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        /// <summary>
        /// ReadJson
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            GuidObject2 myCustomType = new GuidObject2();//

            if (reader.TokenType != JsonToken.Null)
            {
                if (reader.TokenType == JsonToken.String)
                {
                    JValue jValue = new JValue(reader.Value);
                    if (jValue != null)
                    {
                        return new GuidObject2(jValue.ToString());
                    }
                }
                else if (objectType == typeof(GuidObject2))
                {
                    JObject item = JObject.Load(reader);
                    //return item.ToObject<GuidObject2>();
                   
                    var value = item.ToObject<GuidObject2>();

                    // Verify all the properties from the query object are included.
                    // JObject created from DTO property type
                    var jObject = JToken.Parse(JsonConvert.SerializeObject(value)) as JObject;
                    if ((jObject != null) && (!JObject.DeepEquals(jObject, item)))
                    {
                        throw new Exception("Invalid Properties");
                    }
                    return value;
                }
            }

            return myCustomType;
        }

        /// <summary>
        /// CanConvert
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(GuidObject2))
                return true;
            return false;
        }
    }
}
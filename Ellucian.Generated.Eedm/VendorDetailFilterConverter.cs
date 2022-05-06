// Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// Allows property to accept either an array or single vlaue
    /// </summary>
    public class VendorDetailFilterConverter : JsonConverter
    {
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
            if (reader.TokenType != JsonToken.Null && reader.TokenType == JsonToken.String)
            {
                JValue jValue = new JValue(reader.Value);
                if (jValue != null)
                {
                    return new VendorDetailsDtoProperty() {
                       Institution = new GuidObject2(jValue.ToString()),
                       Organization = new GuidObject2(jValue.ToString()),
                       Person = new GuidObject2(jValue.ToString())
                    };
                }
            }

            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Object)
            {
                var value = token.ToObject<VendorDetailsDtoProperty>();

                // Verify all the properties from the query object are included.
                // JObject created from DTO property type
                var jObject = JToken.Parse(JsonConvert.SerializeObject(value)) as JObject;
                if ((jObject != null) && (!JObject.DeepEquals(jObject, token)))
                {
                    throw new Exception("Invalid Properties");
                }

                return value;
            }

            return new VendorDetailsDtoProperty();
        }

        /// <summary>
        /// CanConvert
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return true;
        }
        /// <summary>
        /// CanWrite
        /// </summary>
        public override bool CanWrite { get { return false; } }

        /// <summary>
        /// WriteJson
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException(); //This will never be called since CanWrite is false
        }
    }
}
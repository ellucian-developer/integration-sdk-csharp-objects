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
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// JSON converter for InstructionalLocation type
    /// </summary>
    public class InstructionalLocationDtoPropertyConverter : JsonConverter
    {
        /// <summary>
        /// JSON read method
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
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

            if (objectType.Name != "InstructionalLocationDtoProperty") return null;
            try
            {
                JObject jObject = JObject.Load(reader);

                string instructionalLocationtype = jObject["type"].Value<string>();

                if (String.IsNullOrEmpty(instructionalLocationtype))
                    // return new JsonException("Unable to determine instructional location type.");
                    return new LocationRoomDtoProperty() { LocationType = null };

                switch (instructionalLocationtype.ToLower())
                {
                    case "site":
                        obj = jObject.ToObject<LocationSiteDtoProperty>(serializer);
                        break;
                    case "room":
                        obj = jObject.ToObject<LocationRoomDtoProperty>(serializer);
                        break;
                    case "online":
                        obj = jObject.ToObject<LocationOnlineDtoProperty>(serializer);
                        break;
                    case "other":
                        obj = jObject.ToObject<LocationOtherDtoProperty>(serializer);
                        break;
                    default:
                        // return null;
                        return new LocationRoomDtoProperty() { LocationType = null };
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
        /// Identifies whether this converter can convert the specified object type
        /// </summary>
        /// <param name="objectType">The object type to convert</param>
        /// <returns>True/false</returns>
        public override bool CanConvert(Type objectType)
        {
            return (objectType.IsInterface || objectType.IsAbstract) && typeof(InstructionalLocation2).IsAssignableFrom(objectType);
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
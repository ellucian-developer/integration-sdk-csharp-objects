// Copyright 2014-2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// This converter sets a property to "Colleague" for the purpose of assigning a data origin to a response.
    /// </summary>
    public class DataOriginConverter : JsonConverter
    {
        private const string DataOrigin = "Colleague";

        /// <summary>
        /// Initializes a new instance of the <see cref="DataOriginConverter" /> class.
        /// </summary>
        public DataOriginConverter()
        {
        }

        /// <summary>
        /// Determines whether this converter can convert the type of object
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>true if this instance can convert the specified object type; false otherwise</returns>
        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(string))
                return true;

            return false;
        }

        /// <summary>
        /// Reads the JSON representation of the object
        /// </summary>
        /// <param name="reader">The Newtonsoft.Json.JsonReader to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (objectType != typeof(string))
                throw new Exception(string.Format("Unexpected value when reading string.  Expected string, got {0}", objectType.ToString()));

            // allow the value to be null
            if (reader == null || reader.Value == null)
                return null;
       
            return reader.Value.ToString();
        }

        /// <summary>
        /// Writes the JSON representation of the object
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value.GetType() != typeof(string))
                throw new Exception(string.Format("Unexpected value when writing string.  Expected string, got {0}", value.GetType().ToString()));                
            
            if (string.IsNullOrEmpty(value.ToString()))
                writer.WriteValue(DataOrigin);
            else
                writer.WriteValue(value);
        }
    }
}
// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Utilities;
//using Windows.Data.Json;

namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// JSON converter for InstructionalLocation type
    /// </summary>
    public class InstructionalLocationConverter : JsonConverter
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
            if (reader.TokenType == JsonToken.Null) return null;

            if (objectType.Name != "InstructionalLocation")
                return null;

            StringBuilder json = new StringBuilder();
            int arrayCount = 0;
            int objectCount = 0;
            List<string> propertyNames = new List<string>();
            bool addComma = false;

            do
            {
                if (addComma)
                {
                    if (reader.TokenType != JsonToken.EndArray && reader.TokenType != JsonToken.EndObject)
                    {
                        json.Append(", ");
                    }
                    addComma = false;
                }

                // The token when we were called tells us what type of JSON type we're dealing with
                switch (reader.TokenType)
                {
                    case JsonToken.Boolean:
                        json.Append(Convert.ToBoolean(reader.Value, CultureInfo.InvariantCulture));
                        break;
                    case JsonToken.Bytes:
                        json.Append(CreateStringValue(reader.Value.ToString()));
                        break;
                    case JsonToken.Comment:
                        break;
                    case JsonToken.Date:
                        json.Append(CreateStringValue(reader.Value.ToString()));
                        break;
                    case JsonToken.EndArray:
                        json.Append(" ]");
                        addComma = true;
                        arrayCount--;
                        break;
                    case JsonToken.EndConstructor:
                        break;
                    case JsonToken.EndObject:
                        json.Append(" }");
                        addComma = true;
                        objectCount--;
                        break;
                    case JsonToken.Float:
                    case JsonToken.Integer:
                        Convert.ToDouble(reader.Value, CultureInfo.InvariantCulture);
                        break;
                    case JsonToken.None:
                        break;
                    case JsonToken.Null:
                        json.Append(" null ");
                        break;
                    case JsonToken.PropertyName:
                        //propertyNames.Add(reader.Value.ToString());
                        json.Append(CreateStringValue(reader.Value.ToString(), ": "));
                        break;
                    case JsonToken.Raw:
                        json.Append(reader.Value.ToString());
                        break;
                    case JsonToken.StartArray:
                        json.Append("[ ");
                        arrayCount++;
                        break;
                    case JsonToken.StartConstructor:
                        break;
                    case JsonToken.StartObject:
                        json.Append("{ ");
                        objectCount++;
                        break;
                    case JsonToken.String:
                        if (reader.Path.Equals("locations[0].type", StringComparison.OrdinalIgnoreCase))
                        {
                            propertyNames.Add(reader.Value.ToString());
                        }
                        json.Append(CreateStringValue(reader.Value.ToString()));
                        addComma = true;
                        break;
                    case JsonToken.Undefined:
                        break;
                    default:
                        break;
                }
            } while (arrayCount + objectCount > 0 && reader.Read());

            if (propertyNames.Count == 0) 
                return json.ToString();

            string propertyName = propertyNames[0];
            object value;
            switch (propertyName.ToLower())
            {
                case "site":
                    value = JsonConvert.DeserializeObject<InstructionalSite>(json.ToString());
                    break;
                case "room":
                    value = JsonConvert.DeserializeObject<InstructionalRoom>(json.ToString());
                    break;
                case "online":
                    value = JsonConvert.DeserializeObject<InstructionalOnline>(json.ToString());
                    break;
                case "other":
                    value = JsonConvert.DeserializeObject<InstructionalOtherLocation>(json.ToString());
                    break;
                default:
                    return null;
            }

            return value;
        }

        private string CreateStringValue(string text, string addOn = "")
        {
            string quote = "\"";
            string space = " ";
            string outText = text ?? string.Empty;
            string output = quote + outText + quote + space + addOn;
            return output;
        }

        /// <summary>
        /// Identifies whether this converter can convert the specified object type
        /// </summary>
        /// <param name="objectType">The object type to convert</param>
        /// <returns>True/false</returns>
        public override bool CanConvert(Type objectType)
        {
            return typeof(InstructionalLocation).IsAssignableFrom(objectType);
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

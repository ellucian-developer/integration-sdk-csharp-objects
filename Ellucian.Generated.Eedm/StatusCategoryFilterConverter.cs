// Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ellucian.Generated.Eedm;
using System.Runtime.Serialization;
using System.Linq;

namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// Allows property to accept either a SectionStatus2 or a SectionStatusDtoProperty
    /// Returns object as SectionStatus2
    /// </summary>
    public class StatusCategoryFilterConverter : JsonConverter
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
            var sectionStatusDtoProperty = new SectionStatusDtoProperty()
            {
                Category = SectionStatus2.NotSet
            };

            if (reader.TokenType != JsonToken.Null)
            {
                if (reader.TokenType == JsonToken.String)
                {
                    JValue jValue = new JValue(reader.Value);
                    if (jValue != null)
                    {
                        var value = GetEnumFromEnumMemberAttribute(jValue.ToString(), SectionStatus2.NotSet);
                        sectionStatusDtoProperty.Category = value;
                        return sectionStatusDtoProperty;
                    }
                }
                else if (objectType == typeof(SectionStatusDtoProperty))
                {
                    JObject item = JObject.Load(reader);
                    var value = item.ToObject<SectionStatusDtoProperty>();

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

            return sectionStatusDtoProperty;
        }

        /// <summary>
        /// CanConvert
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(SectionStatusDtoProperty))
                return true;
            return false;
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


        /// <summary>
        /// Converts filter string value to enum value.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public TEnum GetEnumFromEnumMemberAttribute<TEnum>(string value, TEnum defaultValue) where TEnum : struct
        {
            if (string.IsNullOrEmpty(value))
            {
                return defaultValue;
            }

            TEnum result;
            var enumType = typeof(TEnum);
            foreach (var enumName in Enum.GetNames(enumType))
            {
                var fieldInfo = enumType.GetField(enumName);
                var enumMemberAttribute = ((EnumMemberAttribute[])fieldInfo.GetCustomAttributes(typeof(EnumMemberAttribute), true)).FirstOrDefault();
                if (enumMemberAttribute != null && enumMemberAttribute.Value == value)
                {
                    return Enum.TryParse(enumName, true, out result) ? result : defaultValue;
                }
            }
            throw new Exception(string.Format("Invalid Enumeration value: {0}", value));
        }
    }
}
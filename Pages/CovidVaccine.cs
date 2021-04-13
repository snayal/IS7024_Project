﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using CovidVaccine;
//
//    var vaccine = Vaccine.FromJson(jsonString);


// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using CovidVaccine;
//
//    var vaccine = Vaccine.FromJson(jsonString);

namespace CovidVaccine
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Vaccine
    {
        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }

        [JsonProperty("week_of_allocations")]
        public DateTimeOffset WeekOfAllocations { get; set; }

        [JsonProperty("_1st_dose_allocations")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long The1StDoseAllocations { get; set; }

        [JsonProperty("_2nd_dose_allocations")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long The2NdDoseAllocations { get; set; }
    }

    public partial class Vaccine
    {
        public static Vaccine[] FromJson(string json) => JsonConvert.DeserializeObject<Vaccine[]>(json, CovidVaccine.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Vaccine[] self) => JsonConvert.SerializeObject(self, CovidVaccine.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}


namespace RealEstate.VaccinesData
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Vaccines
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("mmwrWeek")]
        public long MmwrWeek { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("administeredDaily")]
        public long AdministeredDaily { get; set; }

        [JsonProperty("administeredCumulative")]
        public long AdministeredCumulative { get; set; }

        [JsonProperty("administered7_DayRolling")]
        public long Administered7DayRolling { get; set; }

        [JsonProperty("adminDose1_Daily")]
        public long AdminDose1Daily { get; set; }

        [JsonProperty("adminDose1_Cumulative")]
        public long AdminDose1Cumulative { get; set; }

        [JsonProperty("adminDose1_DayRolling")]
        public long AdminDose1DayRolling { get; set; }

        [JsonProperty("dateType")]
        public long DateType { get; set; }

        [JsonProperty("administeredDailyChange")]
        public long AdministeredDailyChange { get; set; }

        [JsonProperty("administeredDailyChange1")]
        public long AdministeredDailyChange1 { get; set; }

        [JsonProperty("seriesCompleteDaily")]
        public long SeriesCompleteDaily { get; set; }

        [JsonProperty("seriesCompleteCumulative")]
        public long SeriesCompleteCumulative { get; set; }

        [JsonProperty("seriesCompleteDayRolling")]
        public long SeriesCompleteDayRolling { get; set; }

        [JsonProperty("boosterDaily")]
        public long BoosterDaily { get; set; }

        [JsonProperty("boosterCumulative")]
        public long BoosterCumulative { get; set; }

        [JsonProperty("booster7_DayRollingAverage")]
        public long Booster7DayRollingAverage { get; set; }
    }

    public partial class Vaccines
    {
        public static List<Vaccines> FromJson(string json) => JsonConvert.DeserializeObject<List<Vaccines>>(json, VaccinesData.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Vaccines> self) => JsonConvert.SerializeObject(self, VaccinesData.Converter.Settings);
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
}

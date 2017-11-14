using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace StackOverflow_API.Models
{
    public partial class SeQuestionInfoBase
    {
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("items")]
        public Questions[] questions { get; set; }

        [JsonProperty("quota_max")]
        public long QuotaMax { get; set; }

        [JsonProperty("quota_remaining")]
        public long QuotaRemaining { get; set; }

        public static SeQuestionInfoBase FromJson(string json)
        {
            return JsonConvert.DeserializeObject<SeQuestionInfoBase>(json, Converter.Settings);
        }
       
    }

    

    //public static class Serialize
    //{
    //    public static string ToJson(this SeQuestionInfoBase self)
    //    {
    //        return JsonConvert.SerializeObject(self, Converter.Settings);
    //    }
    //}

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }

    
}
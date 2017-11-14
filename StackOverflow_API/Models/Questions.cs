using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace StackOverflow_API.Models
{
    public partial class Questions 
    {
       
            [JsonProperty("answer_count")]
            public long AnswerCount { get; set; }

            [JsonProperty("creation_date")]
            public long CreationDate { get; set; }

            [JsonProperty("is_answered")]
            public bool IsAnswered { get; set; }

            [JsonProperty("last_activity_date")]
            public long LastActivityDate { get; set; }

            [JsonProperty("link")]
            public string Link { get; set; }

            [JsonProperty("owner")]
            public Owner Owner { get; set; }

            [JsonProperty("question_id")]
            public long QuestionId { get; set; }

            [JsonProperty("score")]
            public long Score { get; set; }

            [JsonProperty("tags")]
            public string[] Tags { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("view_count")]
            public long ViewCount { get; set; }
        


        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }



    }
}
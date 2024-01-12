using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Question3.Models
{
    public class PostRecord
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName ("userId")]
        public string UserId { get; set; }
        [JsonPropertyName("title")]
        public string title { get; set; }
        [JsonPropertyName("body")]
        public string body { get; set; }
    }
}

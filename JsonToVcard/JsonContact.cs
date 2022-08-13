using System.Text.Json.Serialization;

namespace JsonToVcard;

public class JsonContact
{
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
}
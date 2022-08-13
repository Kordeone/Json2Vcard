using System.Text.Json.Serialization;

namespace JsonToVcard;

public class Root
{
    [JsonPropertyName("list")]
    public List<List> list { get; set; }
}
public class List
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string phone_number { get; set; }
    public DateTime date { get; set; }
    public string date_unixtime { get; set; }
}

﻿using Newtonsoft.Json;

namespace BasketBot.Contracts.ChatMembers;

public class User
{
    [JsonProperty("id")]
    public long Id { get; set; }
    [JsonProperty("first_name")]
    public string FirstName { get; set; }
    [JsonProperty("last_name")]
    public string LastName { get; set; }
    [JsonProperty("username")]
    public string UserName { get; set; }
}
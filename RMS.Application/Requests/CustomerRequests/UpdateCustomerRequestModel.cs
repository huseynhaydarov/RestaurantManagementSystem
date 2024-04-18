﻿using System.Text.Json.Serialization;

namespace RMS.Application.Requests.CustomerRequests;

public class UpdateCustomerRequestModel
{
    [JsonIgnore]
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
}

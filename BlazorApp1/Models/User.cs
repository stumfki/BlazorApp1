using System;
using System.Text.Json;

namespace BlazorApp1.Models
{
    public class UserResponse
    {
        public List<User> Results { get; set; }
    }

    public class User
    {
        public string Gender { get; set; }
        public Name Name { get; set; }
        public Location Location { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Picture Picture { get; set; }
    }

    public class Name
    {
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class Location
    {
        public Street Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public JsonElement Postcode { get; set; }

        public string PostcodeAsString => Postcode.ValueKind == JsonValueKind.String ? Postcode.GetString() : Postcode.GetRawText();
    }
}

public class Street
{
    public int Number { get; set; }
    public string Name { get; set; }
}

public class Picture
{
    public string Large { get; set; }
    public string Medium { get; set; }
    public string Thumbnail { get; set; }
}




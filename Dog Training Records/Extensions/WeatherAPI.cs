using System.Text.Json;
using Dog_Training_Records.Models;

namespace Dog_Training_Records.Extensions;

public static class WeatherAPI
{
    public static async Task<WeatherResponse?> GetWeatherAsync(string location)
    {
        var client = new HttpClient();
        var response = await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={location}&appid=9f9b2b2b0b0b0b0b0b0b0b0b0b0b0b0b");
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<WeatherResponse>(json) ?? null;
    }
    
}


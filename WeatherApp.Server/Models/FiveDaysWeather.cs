﻿using Newtonsoft.Json;
using WeatherApp.Server.DTOs.FiveDaysWeather;
using WeatherApp.Server.Interfaces;
namespace WeatherApp.Server.Models
{
    public class FiveDaysWeather : IHasGuidId, IHasDateStamp, IHasSoftDelete
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid? TenantId { get; set; }
        public Tenant? Tenant { get; set; }
        public ICollection<Item>? Items { get; set; }
        public string CityName { get; set; } = string.Empty;
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Country { get; set; } = string.Empty;
        public int Population { get; set; } = 0;
        public int Timezone { get; set; } = 0;
        public int Sunrise { get; set; } = 0;
        public int Sunset { get; set; } = 0;
    }
}

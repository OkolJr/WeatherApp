public class Record : IHasGuidId, IHasDateStamp, IHasSoftDelete
{
  public Guid Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime? DeletedAt { get; set; }
  public string City { get; set; } = string.Empty;
  public double Lat { get; set; } = 0;
  public double Lon { get; set; } = 0;
  public string Country {  get; set; } = string.Empty;
  public string State {  get; set; } = string.Empty;
  public Guid CurrentWeatherId { get; set; } = string.Empty;
  public CurrentWeather? CurrentWeather { get; set; }
  public Guid FiveDaysWeatherId { get; set; } = string.Empty;
  public FiveDaysWeather? FiveDaysWeather { get; set; }
}

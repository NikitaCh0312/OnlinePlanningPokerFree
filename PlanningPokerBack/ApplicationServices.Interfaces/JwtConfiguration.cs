namespace ApplicationServices.Interfaces;

public class JwtConfiguration
{
    public string Key { set; get; }

    public string Issuer { set; get; }

    public string Audience { set; get; }

    public int DurationDays { set; get; }
}
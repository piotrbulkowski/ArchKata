namespace DNSResolver;

public sealed class DnsClientOptions
{
    // Ensures the use of TCP instead of default UDP
    public bool UseTcp { get; init; } 
}
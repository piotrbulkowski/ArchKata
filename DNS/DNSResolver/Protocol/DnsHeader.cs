namespace DNSResolver.Protocol;

/// <summary>
/// DNS header definition as specified in RFC 1035 4.1.1
/// </summary>
public record DnsHeader
{
    public ushort Id { get; set; }
    public bool Qr { get; set; } 
    public byte OpCode { get; set; }
    public bool Aa { get; set; } 
    public bool Tc { get; set; } 
    public bool Rd { get; set; } 
    public bool Ra { get; set; } 
    public bool Z { get; set; } 
    public byte RCode { get; set; } 
    public ushort QdCount { get; set; } 
    public ushort AnCount { get; set; } 
    public ushort NsCount { get; set; } 
    public ushort ArCount { get; set; } 
}
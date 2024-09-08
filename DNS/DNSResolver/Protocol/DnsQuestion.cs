namespace DNSResolver.Protocol;

/// <summary>
/// DNS question definition as specified in RFC 1035 4.1.1
/// </summary>
internal record DnsQuestion
{
    public byte[] QName { get; set; }
    public byte[] QType { get; set; }
    public byte[] QClass { get; set; }
}
namespace DNSResolver.Protocol;

internal record DnsResource
{
    public byte[] Name { get; set; }
    public byte[] Type { get; set; }
    public byte[] Class { get; set; }
    public uint Ttl { get; set; }
    public ushort RdLength { get; set; }
    public byte[] RData { get; set; }
}
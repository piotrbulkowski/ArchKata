namespace DNSResolver.Protocol;

public class DnsMessage
{
    public DnsHeader Header { get; set; }
    public DnsQuestion Question { get; set; }
    public DnsResource? Answer { get; set; }
    public DnsResource? Authority { get; set; }
    public DnsResource? Additional { get; set; }
}
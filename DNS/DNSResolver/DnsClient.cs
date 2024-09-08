using DNSResolver.Protocol;

namespace DNSResolver;

public class DnsClient : IDnsClient
{
    /// <inheritdoc/>
    public async Task<DnsMessage> LookupAsync(string domainName, NameServer nameServer)
    {
        throw new NotImplementedException();
    }
}
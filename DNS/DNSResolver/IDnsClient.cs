using DNSResolver.Protocol;

namespace DNSResolver;

public interface IDnsClient
{
    /// <summary>
    /// Performs a DNS lookup <paramref name="domainName" /> and <paramref name="nameServer" />
    /// </summary>
    /// <param name="domainName">The domain name which has to be resolved.</param>
    /// <param name="nameServer">The nameserver used for DNS lookup.</param>
    /// <param name="ct">The <see cref="CancellationToken"/> instance.</param>
    /// <returns>The <see cref="DnsMessage"/> instance.</returns>
    Task<DnsMessage> LookupAsync(string domainName, NameServer nameServer, CancellationToken ct = default);
}
using System.Net;
using DNSResolver.Protocol;

namespace DNSResolver.Handlers;

internal abstract class DnsLookupHandler
{
    // TODO: Analyze the possiblity of ValueTask usage in performance testing cycle
    // TODO: It might be useful to split DnsMessage into request;response
    public abstract Task<DnsMessage> LookupAsync(IPEndPoint ipEndPoint, DnsMessage message, CancellationToken ct);
}
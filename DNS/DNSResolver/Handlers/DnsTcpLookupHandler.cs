using System.Net;
using DNSResolver.Protocol;

namespace DNSResolver.Handlers;

internal sealed class DnsTcpLookupHandler : DnsLookupHandler
{
    public override Task<DnsMessage> LookupAsync(IPEndPoint ipEndPoint, DnsMessage message, CancellationToken ct)
    {
        ct.ThrowIfCancellationRequested();
        throw new NotImplementedException();
    }
}
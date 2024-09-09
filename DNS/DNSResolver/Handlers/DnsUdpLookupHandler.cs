using System.Net;
using System.Net.Sockets;
using DNSResolver.Protocol;

namespace DNSResolver.Handlers;

internal sealed class DnsUdpLookupHandler : DnsLookupHandler
{
    public override Task<DnsMessage> LookupAsync(IPEndPoint ipEndPoint, DnsMessage message, CancellationToken ct)
    {
        ct.ThrowIfCancellationRequested();
        
        var udpClient = new UdpClient(ipEndPoint.AddressFamily);
        udpClient.Connect(ipEndPoint.Address, ipEndPoint.Port);
        udpClient.Dispose();
        throw new NotImplementedException();
    }
}
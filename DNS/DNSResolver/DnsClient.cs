using DNSResolver.Handlers;
using DNSResolver.Protocol;

namespace DNSResolver;

public class DnsClient : IDnsClient
{
    private DnsClientOptions _options;
    private readonly DnsLookupHandler _lookupHandler;

    
    /// <summary>
    /// Creates a new instance of <see cref="DnsClient"/> with provided <paramref name="options"/>.
    /// </summary>
    /// <param name="options">The L<see cref="DnsClientOptions"/> instance used with this DnsClient.</param>
    public DnsClient(DnsClientOptions options)
    {
        _options = options;
        
        if (options.UseTcp)
        {
            _lookupHandler = new DnsTcpLookupHandler();
        }
        else
        {
            _lookupHandler = new DnsUdpLookupHandler();
        }
    }
    /// <inheritdoc/>
    public async Task<DnsMessage> LookupAsync(string domainName, NameServer nameServer, CancellationToken ct = default)
    {
        ct.ThrowIfCancellationRequested();
        //_lookupHandler.LookupAsync()
        throw new NotImplementedException();
    }
}
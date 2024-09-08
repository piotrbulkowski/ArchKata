using System.Net;

namespace DNSResolver;

/// <summary>
/// NS record instance used by the <see cref="IDnsClient"/>
/// 
/// </summary>
public record NameServer
{
    /// <summary>
    /// DNS uses port 53 for UDP and TCP as specified in RFC 1035 4.2
    /// </summary>
    public const int DnsProtocolPort = 53;
    
    private IPEndPoint IpEndPoint { get; }
    public static readonly IPEndPoint CloudflareDns = new IPEndPoint(IPAddress.Parse("1.1.1.1"), DnsProtocolPort);
    public static readonly IPEndPoint GooglePublicDns1 = new IPEndPoint(IPAddress.Parse("8.8.8.8"), DnsProtocolPort);
    public static readonly IPEndPoint GooglePublicDns2 = new IPEndPoint(IPAddress.Parse("8.8.4.4"), DnsProtocolPort);

    /// <summary>
    /// Initializes the instance of <see cref="NameServer"/> class.
    /// </summary>
    /// <param name="ipEndPoint">The name server ip address and port specification.</param>
    /// <remarks>The Port property in <paramref name="ipEndPoint"/> can be specified for a custom DNS server lookup.</remarks>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="ipEndPoint"/> is null.</exception>
    public NameServer(IPEndPoint ipEndPoint)
    {
        ArgumentNullException.ThrowIfNull(ipEndPoint);
        IpEndPoint = ipEndPoint;
    }
    /// <summary>
    /// Initializes the instance of <see cref="NameServer"/> class.
    /// </summary>
    /// <param name="ipAddress">The name server ip address.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="ipAddress"/> is null.</exception>
    public NameServer(IPAddress ipAddress) : this(new IPEndPoint(ipAddress, DnsProtocolPort))
    {
    }
}
// See https://aka.ms/new-console-template for more information

using DNSResolver;

var dnsClientOptions = new DnsClientOptions
{
    UseTcp = false
};

var dnsClient = new DnsClient(dnsClientOptions);
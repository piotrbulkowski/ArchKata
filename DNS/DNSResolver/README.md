# DNSResolver client overview
The goal is to build a DNS Resolver client that adheres to https://datatracker.ietf.org/doc/html/rfc1035

Progress:
- [x] **Step 1** Data structures for DNS lookup 
- [x] **Step 2** Basic DnsClient
- [ ] **Step 3** ??? NS records cache, performance analysis, reverse lookup, tests

### Step 1 data structures
Description: The goal in the first step is to build data structures for DNS message
Acceptance criteria: 
- Header data structure implemented as in RFC 4.1.1
- Question data structure implemented as in RFC 4.1.2
- Message data structure as in RFC 4.1 Format
```
    +---------------------+
    |        Header       |
    +---------------------+
    |       Question      | the question for the name server
    +---------------------+
    |        Answer       | RRs answering the question
    +---------------------+
    |      Authority      | RRs pointing toward an authority
    +---------------------+
    |      Additional     | RRs holding additional information
    +---------------------+
Refer to https://datatracker.ietf.org/doc/html/rfc1035#section-4.1
```

### Step 2 dns lookup client
Description: Implement the request sending functionality, ensure BigEndian
Acceptance criteria:
- A client is created that can send a UDP and TCP request to a name server
- A client can parse the response to a structure defined as in RFC 4.1.3

### Step 3 undefined
???
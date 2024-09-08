# DNSResolver client overview
The goal is to build a DNS Resolver client that adheres to https://datatracker.ietf.org/doc/html/rfc1035

Progress:
- [x] **Step 1** Data structures for DNS lookup 
- [x] **Step 2** Basic DnsClient
- [ ] **Step 3** DnsClient data parsing
- [ ] ??? NS records cache, performance analysis, reverse lookup, tests

### Step 1 data structures
Description: The goal in the first step is to build data structures for DNS message
Acceptance criteria: 
- Header data structure implemented as in RFC 4.1.1
- Question data structure implemented as in RFC 4.1.2
- Message data structure as in RFC 4.1 Format
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

### Step 2 send the request and get the response
Description: Implement the request sending functionality, ensure BigEndian
Acceptance criteria:
- A client is created that can send a UDP request to a name server

### Step 3 parse the response 
Description: Parse the response
Acceptance criteria:
- service implemented in step 2 can parse the response to a structure defined in RFC 4.1.3

### Step 4 undefined
???
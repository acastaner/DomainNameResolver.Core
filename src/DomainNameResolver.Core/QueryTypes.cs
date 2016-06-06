﻿namespace DomainNameResolver.Core
{
    public enum QueryType
    {
        All = 255,
        A = 1,
        AAAA = 28,
        AFSDB = 18,
        APL = 42,
        CAA = 42,
        CDNSKEY = 60,
        CDS = 59,
        CERT = 37,
        CNAME = 5,
        DHCID = 49,
        DLV = 32769,
        DNAME = 39,
        DNSKEY = 48,
        DS = 43,
        HIP = 55,
        IPSECKEY = 45,
        KEY = 25,
        KX = 36,
        LOC = 29,
        MX = 15,
        NAPTR = 35,
        NS = 2,
        NSEC = 47,
        NSEC3 = 50,
        NSEC3PARAM = 51,
        PTR = 12,
        RRSIG = 46,
        RP = 17,
        SIG = 24,
        SOA = 6,
        SRV = 33,
        SSHFP = 44,
        TA = 32768,
        TKEY = 249,
        TLSA = 52,
        TSIG = 250,
        TXT = 16,
        URI = 256
    }
}
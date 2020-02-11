# CIDRs
### Subnet Masks
- The subnet masks basically allows part of the underlying IP to get additional next values from the base IP
- total is 32, /number means how many ip has been used ( not valid)
```
• /32 allows for 1 IP = 2^0
• /31 allows for 2 IP = 2^1
• /30 allows for 4 IP = 2^2
• /29 allows for 8 IP = 2^3
• /28 allows for 16 IP = 2^4
• /27 allows for 32 IP = 2^5
• /26 allows for 64 IP = 2^6
• /25 allows for 128 IP = 2^7
• /24 allows for 256 IP = 2^8
• /16 allows for 65,536 IP = 2^16
• /0 allows for all IPs = 2^32

• /32 – no IP number can change
• /24 - last IP number can change
• /16 – last IP two numbers can change
• /8 – last IP three numbers can change
• /0 – all IP numbers can change


• 192.168.0.0/24 = … ?
  • 192.168.0.0 – 192.168.0.255 (256 IP)
• 192.168.0.0/16 = … ?
  • 192.168.0.0 – 192.168.255.255 (65,536 IP)
• 134.56.78.123/32 = … ?
  • Just 134.56.78.123
• 0.0.0.0/0
  • All IP!

```
### Private vs Public IP (IPv4)
- Allowed ranges
- The Internet Assigned Numbers Authority (IANA) established certain blocks of IPV4 addresses for the use of private (LAN) and public
(Internet) addresses.
### Private IP can only allow certain values
```
  • 10.0.0.0 – 10.255.255.255 (10.0.0.0/8) <= in big networks
  • 172.16.0.0 – 172.31.255.255 (172.16.0.0/12) <= default AWS one
  • 192.168.0.0 – 192.168.255.255 (192.168.0.0/16) <= example: home networks
```
### All the rest of the IP on the internet are public IP

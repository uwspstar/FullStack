# VPC - AWS Virtual Private Cloud (VPC)
### Default VPC Walkthrough
- All new accounts have a default VPC
- New instances are launched into default VPC if no subnet is specified
- Default VPC have internet connectivity and all instances have public IP
- We also get a public and a private DNS name
### Because VPC is private, only the Private IP ranges are allowed:
```
• 10.0.0.0 – 10.255.255.255 (10.0.0.0/8)
• 172.16.0.0 – 172.31.255.255 (172.16.0.0/12)
• 192.168.0.0 – 192.168.255.255 (192.168.0.0/16)
```
### VPC and VPC Subnet
- You can have multiple VPCs in a region (max 5 per region – soft limit)
- VPC inside region
- VPC is region special
- VPC has 1 or mort VPC subnet
- VPC subnet inside Avaliablity Zone
- 1 subnet in 1 Avaliablity Zone
- 1 VPC in 1 region
- VPC is a virtual network or data center inside AWS for one client, or a department in an enterprise
- The AWS client has full control over resources & virtual compute instances (virtual servers) hosted inside the VPC
- Is Similar to having your own data center inside AWS
- Logically isolated from other VPCs on AWS
- You can have 1 or mort IO address subnets inside a VPC
- A VPC is confined to an AWS region and does not extend between regions
- AWS reserves 5 IPs address (first 4 and last 1 IP address) in each Subnet
- These 5 IPs are not available for use and cannot be assigned to an instance
### Components
- CIDR and IP address subnets
- implied Router
- Router table
- internet gateway take you to connect internet
- Security Groups last protect
- Newwork Access Control lists( N. ACLs) first protect line, work in subnet level
- Virtual PRivate Gateway take you to connect HQ or permis (using VPN)
### IPv6 Addressing
- All IPv6 addresses are Public
- Hence, AWS allocates the IP6 address range if you require that
### Core Knowledge - VPC Components - Implied Router and Route Tables
- it is central VPC routing function,
- it is subnet to subnet and subnet to internet
- it connects the different AZ's together 
- it connects the VPC to the Internet Gateway
- the route tables will also have entries to external destinations
### Route Tables
- you can have up to 200 route tables oer VPC
- you can have up to 50 routes entries per route table
- each subnet MUST be associated with only one route table at any given time
- if you do not specify a subnet-to-route-table assosication, the subnet (when created) will be associated with the main (default) VPC route table
- you can change the subnet association to another route table
- you can aslo edit the main (default) route table if you need, but you can NOT delete the Main(defult) route table
- However you can make a custom route table manuallt become the main route table, then you can delete the former main, as it is no longer a main route table
- Every route table in a VPC comes with a default rule that allows all VPC subnets to communicate with one another, you can NOT modify or delete thsi rule
###  Core Knowledge -VPC Components - IP Addressing - Internet Gateway - Subnet Types
- One the VPC is created, you can NOT change its CIDR block range
- if you need a different CIDR size, create a new VPC
- The different subnets within a VPC can NOT overlap (basic TCP/IP rule)
- You can however, expand your VPC CIRD by adding new/extra IP address ranges
- First 4 IP address in each subnet and the last one are reserved by AWS
### Internaet Gateway
- Internaet Gateway is the gateways throught which you VPC communicateds with the internet, and with other AWS services
- Internaet Gateway is a horizontally scaled, redundant, and highly available VPC component
- There is only one Internaet Gateway for each VPC, you can NOT have more than one
- It performs NAT( static one-to-one) between your private and Public (or Elastic) IPv4 address
- It support both IPv4 and IPv6
### Public Subnet vs. Private Subnet

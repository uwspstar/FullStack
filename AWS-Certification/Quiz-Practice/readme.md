# VPC
### How many internet gateways can I attach to my custom VPC ```One```
### Which of the following allows you to SSH or RDP into an EC2 instance located in a private subnet
```
A Bastion host allows you to securely administer (via SSH or RDP) an EC2 instance 
located in a private subnet. Don't confuse Bastions and NATs, 
which allow outside traffic to reach an instance in a private subnet.
```
### a chief advantage of using VPC endpoints to connect your VPC to services such as S3
```
In contrast to a NAT gateway, traffic between your VPC and the other service 
does not leave the Amazon network when using VPC endpoints.
```
### Which of the below statements is true for any VPC security group, by default, when it is created? ```C```
```
All inbound traffic rule will be explicitly denied
All inbound traffic is allowed by default
All outbound traffic is allowed by default
Traffic to the internet gateway is allowed by default
```
### At which EC2 instance states can the source/destination check attribute be changed? (Choose two) ```CD```
```
A) When the NAT instance state is terminated     
B) When the NAT instance state is pending   
C) When the NAT instance state is running   
D) When the NAT instance state is stopped
```

### Are you permitted to conduct your own vulnerability scans on your own VPC without alerting AWS first?
```
Until recently customers were not permitted to conduct penetration testing without AWS engagement. 
However that has changed. There are still conditions though.
```
### By default, instances in new subnets in a custom VPC can communicate with each other across Availability Zones. ``` TRUE```
```
In a custom VPC with new subnets in each AZ, 
there is a route that supports communication across all subnets/AZs. 
Plus a default SG with an allow rule 'All traffic, all protocols, all ports, 
from anything using this default SG'.
```
###  You can accelerate your application by adding a second internet gateway to your VPC. ```FALSE```
```
You may have only one internet gateway per VPC.
```
### When peering VPCs, you may peer your VPC only with another VPC in your same AWS account. ```FALSE```
```
You may peer a VPC to another VPC that's in your same account, or to any VPC in any other account.
```
### An application load balancer must be deployed into at least two subnets. ```TRUE```
```An application load balancer must be deployed into at least two subnets.```
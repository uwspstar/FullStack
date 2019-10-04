# VPC
### To save administration headaches, a consultant advises that you leave all security groups in web-facing subnets open on port 22 to 0.0.0.0/0 CIDR. That way, you can connect wherever you are in the world. Is this a good security design?
```
0.0.0.0/0 would allow ANYONE from ANYWHERE to connect to your instances. 
This is generally a bad plan. 
The phrase 'web-facing subnets' does not mean just web servers. 
It would include any instances in that subnet some of which you may not strangers attacking. 
You would only allow 0.0.0.0/0 on port 80 or 443 to to connect to your public facing Web Servers, 
or preferably only to an ELB. 
Good security starts by limiting public access to only what the customer needs. 
Please see the AWS Security whitepaper for complete details.
```
### By default, how many VPCs am I allowed in each AWS region? ```FIVE```
### Security groups act like a firewall at the instance level, whereas _________ are an additional layer of security that act at the subnet level. 
```NACLs```
### Security Groups are stateful and Network Access Control Lists are stateless.
### You have five VPCs in a 'hub and spoke' configuration, with VPC 'A' in the center and individually paired with VPCs 'B', 'C', 'D', and 'E', which make up the 'spokes'. There are no other VPC connections. Which of the following VPCs can VPC 'B' communicate with directly?
```
As transitive peering is not allowed, VPC 'B' can communicate directly only with VPC 'A'.
```
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

# EC2
### EC2 Instance Types – Main ones
```
• R: applications that needs a lot of RAM – in-memory caches
• C: applications that needs good CPU – compute / databases
• M: applications that are balanced (think “medium”) – general / web app
• I: applications that need good local I/O (instance storage) – databases
• G: applications that need a GPU – video rendering / machine learning
• T2 / T3: burstable instances (up to a capacity)
• T2 / T3 - unlimited: unlimited burst
```
# AMI
### Creating an AMI after installing the applications allows you to start more EC2 instances directly from that AMI, hence bypassing the need to install the application (as it's already installed)

# ELB & ASG

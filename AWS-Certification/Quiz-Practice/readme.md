# VPC
### You are running at desired capacity of 3 and the maximum capacity of 3. You have alarms set at 60% CPU to scale out your application. Your application is now running at 80% capacity. What will happen?
```
The capacity of your ASG cannot go over the maximum capacity you have allocated during scale out events
```
### You created a subnet in a custom VPC and launched an EC2 instance in that subnet. During the EC2 instance creation, using AWS console, you did not choose the option to assign a public IP address to your instance. This instance now needs access to the Internet, but it has no public IP address. ```D```
```
How would you solve this internet connectivity issue for this EC2 instance?  

A- The instance will always have a public DNS attached to the instance by default     

B- Allocate and attach an Elastic IP directly to the instance     

C- The instance would not launch if the public IP is not assigned     

D- Create an internet gateway, attach it to the VPC, do the needed route table  configuration for a public subnet. Adjust security group, and N ACLs  configurations to facilitate this, and finally, attach an elastic IP to the instance to connect to the Internet  
```
### You are the AWS SME at YCDIT2, Inc. Your AWS SysOps administrator created a VPC with a public subnet. He created and attached an Internet Gateway to the VPC, and launched an EC2 instance with a public IP in the subnet. He also created a security group for the EC2 instance. When trying to connect to the EC2 instance from the Internet, he was not able to. From the statements below, which could be a possible reason for his inability to connect?  (Choose 2) ```AB```
```
A- There is no entry in the route table pointing to the internet gateway as a Target     

B- The admin did not configure the security group after he created it     

C- The security group is denying any outbound traffic to the Internet     

D- The admin forgot to create a NACL for the EC2 instance 
```
### After creating a VPC with CIDR 10.0.0.0/16. with the lack of proper architecture, The AWS SysOps admin created one large subnet of CIDR 10.0.0.0/16. later on, another subnet was needed to host another tier of an application being deployed. The admin is trying to create another subnet of CIDR 10.0.1.0/24. ```C```
```
Can she create the second subnet without disrupting services to the first subnet?  

A) Yes, she can configure the new subnet, and AWS will automatically adjust the VPC subnets so both can exist.     

B) Yes, Edit the fist subnet from the console to make room for the second one     

C) No, It is not possible to create a second subnet as the intended one overlaps with the existing one.     

D) Yes, Delete the VPC and create a new one   
```
### You have created a VPC with CIDR 10.0.0.0/24. The VPC has two subnets: public (10.0.0.0/25) and private (10.0.0.128/25). For an anticipated project you want to increase the CIDR range your VPC CIDR block, How can you do this?
```
A) Change the subnet sizes to /28 subnets, then you will have more room to grow your VPC CIDR     
B) You can always change a VPC's original CIDR block as needed
C) You can add additional VPC CIDR blocks, but can’t change the existing one     
D) Delete all the subnets first, only then you can modify the size of the VPC   
```
### At which EC2 instance states can the source/destination check attribute be changed? (Choose two) ```CD```
```
A) When the NAT instance state is terminated     
B) When the NAT instance state is pending   
C) When the NAT instance state is running   
D) When  the NAT instance state is stopped 
```
### You are the AWS architect at YCDIT2, Inc. You have been tasked to design and launch an EC2 NAT instance in a public subnet in your client’s VPC. After creating and successfully testing the NAT Instance. You have also updated you private subnet’s route table such that the NAT device is the target for traffic destined to the Internet. However, the private subnet EC2 instances are still not able to connect to the Internet for updates and patch download. ```D```
```
Which of the following steps could be a possible reason for this problem?  

A) NAT instance is launched with only one ENI in the public subnet     
B) The NAT instance has not been configured with the proper NAT rules to 
process the private instance’s traffic intended for the internet     
C) The NAT instance will not work, you need to configure static, 
one-to-one NATon the VPC Internet Gateway for private subnet’s instances to connect to the Internet     
D) Disabling the Source/Destination Check attribute on the NAT instance
```
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

### Load Balancers provide a a static DNS name we can use in our application. The reason being that AWS wants your load balancer to be accessible using a static endpoint, even if the underlying infrastructure that AWS manages changes.

### You are running a website with a load balancer and 10 EC2 instances. Your users are complaining about the fact that your website always asks them to re-authenticate when they switch pages. You are puzzled, because it's working just fine on your machine and in the dev environment with 1 server. What could be the reason?
```
Stickiness ensures traffic is sent to the same backend instance for a client. This helps maintaining session data
```

### Your application is using an Application Load Balancer. It turns out your application only sees traffic coming from private IP which are in fact your load balancer's. What should you do to find the true IP of the clients connected to your website?
```
Look into the X-Forwarded-For header in the backend. This header is created by your load balancer and passed on to your backend application
```
### You quickly created an ELB and it turns out your users are complaining about the fact that sometimes, the servers just don't work. You realise that indeed, your servers do crash from time to time. How to protect your users from seeing these crashes?
```
Health checks ensure your ELB won't send traffic to unhealthy (crashed) instances
```
### You are designing a high performance application that will require millions of connections to be handled, as well as low latency. The best Load Balancer for this is
```
NLB provide the highest performance if your application needs it
```
### Application Load Balancers handle all these protocols except ```TCP```

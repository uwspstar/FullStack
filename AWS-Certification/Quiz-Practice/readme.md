# Identity Access Management & S3

### What is the minimum file size that I can store on S3?
```
0 byte
```
### You are a solutions architect who works with a large digital media company. The company has decided that they want to operate within the Japanese region and they need a bucket called "testbucket" set up immediately to test their web application on. You log in to the AWS console and try to create this bucket in the Japanese region however you are told that the bucket name is already taken. What should you do to resolve this?
```
Bucket names are global, not regional. This is a popular bucket name and is already taken.
You should choose another bucket name
```
### What does S3 stand for?
```
Simple Storage Service
```
### S3 has what consistency model for PUTS of new objects?
```
Read after write consistence
```
### What is the availability of objects stored in S3?
```
99.99%
```
### You work for a busy digital marketing company who currently store their data on-premise. They are looking to migrate to AWS S3 and to store their data in buckets. Each bucket will be named after their individual customers, followed by a random series of letters and numbers. Once written to S3 the data is rarely changed, as it has already been sent to the end customer for them to use as they see fit. However, on some occasions, customers may need certain files updated quickly, and this may be for work that has been done months or even years ago. You would need to be able to access this data immediately to make changes in that case, but you must also keep your ```storage costs extremely low```. The data is not easily reproducible if lost. Which S3 storage class should you choose to minimize costs and to maximize retrieval times?
```
The need to immediate access is an important requirement along with cost. 
Glacier has a long recovery time at a low cost or a shorter recovery time at a high cost, and 1Zone-IA has a lower Availability level which means that it may not be available when needed.
```
### How many S3 buckets can I have per account by default?
```
100
```

# Overall
### In which of the following is CloudFront content cached?
```
CloudFront content is cached in Edge Locations.
```
### Which of the following is correct?
```
The number of Edge Locations is greater than the number of Availability Zones, 
which is greater than the number of Regions.
```
### What is an AWS region?
```
A region is a geographical area divided into Availability Zones. 
Each region contains at least two Availability Zones.
```
### Which statement best describes Availability Zones?
```
Distinct location from within an AWS region that are engineered to be isolated from failures
An Availability Zone (AZ) is a distinct location within an AWS Region. 
Each Region comprises at least two AZs
```
### What does an AWS Region consist of?
```
Each region is a separate geographic area. 
Each region has multiple, isolated locations known as Availability Zones.
```
### An AWS VPC is a component of which group of AWS services?
```
Networking Services
A Virtual Private Cloud (VPC) is a virtual network dedicated to a single AWS account. 
It is logically isolated from other virtual networks in the AWS cloud, 
providing compute resources with security and robust networking functionality.
```
### What is an Amazon VPC?
```
VPC stands for Virtual Private Cloud.
```
# S3
### Your company does not trust S3 for encryption and wants it to happen on the application. You recommend
```
With Client Side Encryption you perform the encryption yourself and send the encrypted data to AWS directly. 
AWS does not know your encryption keys and cannot decrypt your data.
```
### Your company wants data to be encrypted in S3, and maintain control of the rotation policy for the encryption keys, but not know the encryption keys values. You recommend
```
With SSE-KMS you let AWS manage the encryption keys but you have full control of the key rotation policy
With SSE-S3 you let go of the management of the encryption keys and cannot define a key rotation policy
```
### Your client wants to make sure the encryption is happening in S3, but wants to fully manage the encryption keys and never store them in AWS. You recommend
```
SSE-C, Here you have full control over the encryption keys, and let AWS do the encryption
```
### You've added files in your bucket and then enabled versioning. The files you've already added will have which version?
```
null
```
### I tried creating an S3 bucket named "dev" but it didn't work. This is a new AWS Account and I have no buckets at all. What is the cause?
```
Bucket names must be globally unique and "dev" is already taken
```
### You're trying to upload a 25 GB file on S3 and it's not working
```
you should suer Multi Part upload whe your file is bigger than 5GB
Multi Part Upload is also recommended as soon as the file is over 100MB
```

# Classic Architecture
### My deployments on Elastic Beanstalk have been painfully slow, and after looking at the logs, I realize this is due to the fact that my dependencies are resolved on each EC2 machine at deployment time. How can I speed up my deployment with the minimal impact?
```
Golden AMI are a standard in making sure save the state after the installation 
or pulling dependencies so that future instances can boot up from that AMI quickly.
```
### I am creating an application and would like for it to be running with minimal cost in a development environment with Elastic Beanstalk. I should run it in
```
Single instance Mode :  one EC2 instance and one Elastic IP
```
### As a solution architect managing a complex ERP software suite, you are orchestrating a migration to the AWS cloud. The software traditionally takes well over an hour to setup on a Linux machine, and you would like to make sure your application does leverage the ASG feature of auto scaling based on the demand. How do you recommend you speed up the installation process?
```
Golden AMI are a standard in making sure you snapshot a state after an application installation 
so that future instances can boot up from that AMI quickly.
```

### You are looking to store shared software updates data across 100s of EC2 instances. The software updates should be dynamically loaded on the EC2 instances and shouldn't require heavy operations. What do you suggest?
```
EFS is a network file system (NFS) and allows to mount the same file system to 100s of EC2 instances. 
Publishing software updates their allow each EC2 instance to access them.
RDS is meant to store relational datasets, not big binary files.
Store the software updates on EBS and Sync them using data replication software 
from one to one master in each AZ
requires too many operations and is not a native AWS features
```
### You have an ASG that scales on demand based on the traffic going to your new website: TriangleSunglasses.Com. You would like to optimise for cost, so you have selected an ASG that scales based on demand going through your ELB. Still, you want your solution to be highly available so you have selected the minimum instances to 2. How can you further optimize the cost while respecting the requirements?
```
Reserve two EC2 instance
```
### NOT help make our application tier stateless
```
EBS volumes are created for a specific AZ and can only be attached to one EC2 instance at a time. 
This will not help make our application stateles
Offload Data in RDS help as the data can now be accessed from multiple servers.
Store the session data in ElasticCache elp as the session data can now be accessed from multiple servers

```
# ROUTE53
### You have purchased a domain on Godaddy and would like to use it with Route 53. What do you need to change to make this work?
```
Private hosted zones are meant to be used for internal network queries and are not publicly accessible. 
Public Hosted Zones are meant to be used for people requesting your website through the public internet. 
Finally, NS records must be updated on the 3rd party registrar. 
```
### You have a legal requirement that people in any country but France should not be able to access your website. Which Route 53 record helps you in achieving this?
```
Geo Location
```
### You want your users to get the best possible user experience and that means minimizing the response time from your servers to your users. Which routing policy will help?
```
Latency will evaluate the latency results and help your users get a DNS response 
that will minimize their latency (e.g. response time)
```
### After updating a Route 53 record to point "myapp.mydomain.com" from an old Load Balancer to a new load balancer, it looks like the users are still not redirected to your new load balancer. You are wondering why...
```
DNS records have a TTL (Time to Live) in order for clients to know for 
how long to caches these values and not overload the DNS with DNS requests. 
TTL should be set to strike a balance between how long the value should be cached vs how much pressure should go on the DNS. 
```
### You have deployed a new Elastic Beanstalk environment and would like to direct 5% of your production traffic to this new environment, in order to monitor for CloudWatch metrics and ensuring no bugs exist. What type of Route 53 records allows you to do so?
```
Weighted allows you to redirect a part of the traffic based on a weight (hence a percentage). 
It's common to use to send a part of a traffic to a new application you're deploying
```
### You have purchased "mycoolcompany.com" on the AWS registrar and would like for it to point to lb1-1234.us-east-2.elb.amazonaws.com . What sort of Route 53 record is impossible to setup for this?
```
The DNS protocol does not allow you to create a CNAME record for the top node of a DNS namespace 
(mycoolcompany.com), also known as the zone apex
```

# RDS
### Which RDS Classic (not Aurora) feature does not require us to change our SQL connection string?
```
Multi AZ keeps the same connection string regardless of which database is up. 
Read Replicas imply we need to reference them individually in our application as each read replica will have its own DNS name
```
### How can you enhance the security of your Redis cache to force users to enter a password?
```
Use Redis Auth
IAM Auth is not supported for Redis
Security Groups helps filter traffic going to your ElastiCache instances but cannot help with application level authentication
```
### You would like to ensure you have a database available in another ```region``` if a disaster happens to your main region. Which database do you recommend?
```
Global Databases allow you to have cross region replication
```
### Which RDS database technology does NOT support IAM authentication?
```
Oracle, current IAM only support MySQL and PostgreSQL
```
### You have a requirement to use TDE (Transparent Data Encryption) on top of KMS. Which database technology does ```NOT``` support TDE on RDS?
```
PostgreSQL
```

### One analytics application is currently performing its queries against your main production database. These queries slow down the database which impacts the main user experience. What should you do to improve the situation?
```
Read Replicas will help as our analytics application can now perform queries against it,
and these queries won't impact the main production database. 
```
### Your application functions on an ASG behind an ALB. Users have to constantly log back in and you'd rather not enable stickiness on your ALB as you fear it will overload some servers. What should you do?
```
RDS could work to store session data, 
but wouldn't provide as high of a performance as ElastiCache. 

Storing Session Data in ElastiCache is a common pattern 
to ensuring different instances can retrieve your user's state if needed
```

### You want to ensure your Redis cluster will always be available
```
Multi AZ ensures high availability
```
###
Which RDS Classic (not Aurora) feature does not require us to change our SQL connection string?
```
Multi AZ keeps the same connection string regardless of which database is up. 
Read Replicas imply we need to reference them individually in our application 
as each read replica will have its own DNS name
```
### We have setup read replicas on our RDS database, but our users are complaining that upon updating their social media posts, they do not see the update right away
```
Read Replicas have asynchronous replication 
and therefore it's likely our users will only observe eventual consistency.
```
### Our RDS database struggles to keep up with the demand of the users from our website. Our million users mostly read news, and we don't post news very often. Which solution is NOT adapted to this problem?
```
Our RDS database struggles to keep up with the demand of the users from our website. 
Our million users mostly read news, 
and we don't post news very often. Which solution is NOT adapted to this problem?
```
### My company would like to have a MySQL database internally that is going to be available even in case of a disaster in the AWS Cloud. I should setup
```
In this question, we consider a disaster to be an entire Availability Zone going down. In which case Multi-AZ will help. If we want to plan against an entire region going down, backups and replication across regions would help. 
```
# EBS
### In order to enable encryption at rest using EC2 and Elastic Block Store, you must ________.
```
The use of encryption at rest is default requirement for many industry compliance certifications.
Using AWS managed keys to provide EBS encryption at rest is a relatively painless 
and reliable way to protect assets and demonstrate your professionalism in any commercial situation.
```
### You would like to have a high performance cache for your application that mustn't be shared. You don't mind losing the cache upon termination of your instance. Which storage mechanism do you recommend as a Solution Architect? ```C```
  ```
  a) EFS
  b) EBS
  c) Instance Store
  ```
  ```
  Instance Store provide the best disk performance
  ````
### You would like to have the same data being accessible as an NFS drive cross AZ on all your EC2 instances. What do you recommend? ```A```
  ```
  a) Mount an EFS
  b) Mount an EBS
  c) Mount an Instance Store
  ```
  ```
  EFS is a network file system (NFS) and allows to mount the same file system on EC2 instances that are in different AZ
  ```

### You would like to leverage EBS volumes in parallel to linearly increase performance, while accepting greater failure risks. Which RAID mode helps you in achieving that?
  ```
  RAID 0
  See https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/raid-config.html
  ```
### Although EBS is already a replicated solution, your company SysOps advised you to use a RAID mode that will mirror data and will allow your instance to not be affected if an EBS volume entirely fails. Which RAID mode did he recommend to you?
  ```
  RAID 1
  See https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/raid-config.html
  ```
### What is true with Instance-Store backed EC2?
  ```
  https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html#instance-store-lifetime The data in an instance store persists only during the lifetime of its associated instance. 
  If an instance reboots (intentionally or unintentionally), 
  data in the instance store persists. 
  However, data in the instance store is lost under any of the following circumstances: 
  The underlying disk drive fails The instance stops The instance terminates
  ```
### You have provisioned an 8TB gp2 EBS volume and you are running out of IOPS. What is NOT a way to increase performance?
```
EBS IOPS peaks at 16,000 IOPS. or equivalent 5334 GB.
```
### EBS Volumes are created for a specific AZ. It is possible to migrate them between different AZ through backup and restore

# ELB & ASG
### IAM roles attached to an ASG will get assigned to EC2 instances

### Your application load balancer is hosting 3 target groups with hostnames being users.example.com, api.external.example.com and checkout.example.com. You would like to expose HTTPS traffic for each of these hostnames. How do you configure your ALB SSL certificates to make this work?
```
SNI (Server Name Indication) is a feature allowing you to expose multiple SSL certs if the client supports it. Read more here: https://aws.amazon.com/blogs/aws/new-application-load-balancer-sni/
```
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

### You are running a website with a load balancer and 10 EC2 instances. Your users are complaining about the fact that your website always asks them to re-authenticate when they switch pages. You are puzzled, because it's working just fine on your machine and in the dev environment with 1 server. What could be the reason?
```
```
### Load Balancers provide a
```
static DNS name we can use in our application
The reason being that AWS wants your load balancer to be accessible using a static endpoint, even if the underlying infrastructure that AWS manages changes
```
### An ASG spawns across 2 availability zones. AZ-A has 3 EC2 instances and AZ-B has 4 EC2 instances. The ASG is about to go into a scale-in event. What will happen? ```balance across AZ first```
```
Make sure you remember the Default Termination Policy for ASG. It tries to balance across AZ first, and then delete based on the age of the launch configuration.
```
### A web application hosted in EC2 is managed by an ASG. You are exposing this application through an Application Load Balancer. The ALB is deployed on the VPC with the following CIDR: 192.168.0.0/18. How do you configure the EC2 instance security group to ensure only the ALB can access the port 80?
```
Open up the EC2 security on port 80 to the ALB's Security group
This is the most secure way of ensuring only the ALB can access the EC2 instances. Referencing by security groups in rules is an extremely powerful rule and many questions at the exam rely on it. Make sure you fully master the concepts behind it!
```

### You would like to expose a fixed static IP to your end users for compliance purposes, so they can write firewall rules that will be stable and approved by regulators. Which Load Balancer should you use?
```
Network Load Balancers expose a public static IP, 
whereas an Application or Classic Load Balancer exposes a static DNS (URL)
Load Balancing Overview
```
### You would like to expose a fixed static IP to your end users for compliance purposes, so they can write firewall rules that will be stable and approved by regulators. Which Load Balancer should you use?

### Running an application on an auto scaling group that scales the number of instances in and out is called
```
Horizontal Scalability
```
### Scaling an instance from an r4.large to an r4.4xlarge is called
```
Vertical Scalability
```

### Your boss wants to scale your ASG based on the number of requests per minute your application makes to your database.
```
You create a CloudWatch custom metric and build an alarm on this ti scale your ASG
Auto Scaling Groups Overview. 
The metric "requests per minute" is not an AWS metric, hence it needs to be a custom metric
```
### I have an ASG and an ALB, and I setup my ASG to get health status of instances thanks to my ALB. One instance has just been reported unhealthy. What will happen?
```
Because the ASG has been configured to leverage the ALB health checks, unhealthy instances will be terminated
```

### You are running at desired capacity of 3 and the maximum capacity of 3. You have alarms set at 60% CPU to scale out your application. Your application is now running at 80% capacity. What will happen?
```
The capacity of your ASG cannot go over the maximum capacity you have allocated during scale out events
```

# VPC

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


# AWS Certification
- https://www.udemy.com/aws-certified-solutions-architect-associate-saa-c01

### What’s AWS?
- AWS (Amazon Web Services) is a Cloud Provider
- They provide you with servers and services that you can use on demand and scale easily

### AWS Regions
- AWS has regions all around the world
(us-east-1)
- Each region has availability zones (us-east-1a, us-east-1b…)
- Each availability zone is a physical data center in the region, 
but separate from the other ones (so that they’re isolated
from disasters)
- AWS Consoles are region scoped
(except IAM, S3 & Route53)

### IAM
- IAM (Identity and Access Management)
- Your whole AWS security is there: 
  - Users
  - Groups
  - Roles
  - Policies
  ```
    - Users: Usually a physical person
    - Groups: Functions (admins, devops) Teams (engineering, design…) Contains users!
    - Roles: Internal usage within AWS resources
    - Policies: (JSON Documents) Defines what each of the above can and cannot do
  ```
- Root account should never be used (and shared)
- Users must be created with proper permissions
- IAM is at the center of AWS
- Policies are written in JSON (JavaScript Object Notation)

### IAM
- IAM has a global view
- Permissions are governed by Policies (JSON)
- MFA (Multi Factor Authentication) can be setup
- IAM has predefined “managed policies”
- We’ll see IAM policies in details in the future
- It’s best to give users the minimal amount of permissions they need to perform their job (least privilege principles)

### IAM Federation
- Big enterprises usually integrate their own repository of users with IAM
- This way, one can login into AWS using their company credentials
- Identity Federation uses the SAML standard (Active Directory)

### IAM 101
- One IAM User per PHYSICAL PERSON
- One IAM Role per Application
- IAM credentials should NEVER BE SHARED
- Never, ever, ever, ever, write IAM credentials in code. EVER.
- And even less, NEVER EVER EVER COMMIT YOUR IAM credentials
- Never use the ROOT account except for initial setup.
- Never use ROOT IAM Credentials

### EC2
- EC2 is one of most popular of AWS offering, Knowing EC2 is fundamental to understand how the Cloud works
- It mainly consists (EC2), (EBS), (ELB), (ASG):
  - Renting virtual machines (EC2)
  - Storing data on virtual drives (EBS)
  - Distributing load across machines (ELB)
  - Scaling the services using an auto-scaling group (ASG)
  
### SSH (port 22)
- tool Putty windows

### Security Groups
- Security Groups are the fundamental of network security in AWS
- They control how traffic is allowed into or out of our EC2 Machines.
- It is the most fundamental skill to learn to troubleshoot networking issues
- inbound and outbound port
- Security groups are acting as a “firewall” on EC2 instances
  ```
  - regulate: 
    - Access to Ports
    - Authorised IP ranges – IPv4 and IPv6
    - Control of inbound network (from other to the instance)
    - Control of outbound network (from the instance to other)
  ```


### Security Groups Good to know
- Can be attached to multiple instances
- Locked down to a region / VPC combination
- Does live “outside” the EC2 – if traffic is blocked the EC2 instance won’t see it
- It’s good to maintain one separate security group for SSH access
- If your application is ```not accessible (time out)```, then it’s a ```security group issue```
- If your application gives a ```“connection refused“ ```error, then it’s ```an application error``` or it’s not launched
- All ```inbound``` traffic is ```blocked by default```
- All ```outbound``` traffic is ```authorised by default```

### Private vs Public IP (IPv4)
- Networking has two sorts of IPs. IPv4 and IPv6:
  - IPv4: 1.160.10.240
  - IPv6: 3ffe: 1900:4545:3:200:f8ff:fe21:67cf
- IPv4 is still the most common format used online.
- IPv6 is newer and solves problems for the Internet of Things (IoT).
- IPv4 allows for 3.7 billion different addresses in the public space
- IPv4: [0-255].[0-255].[0-255].[0-255].

### Private vs Public IP (IPv4) Fundamental Differences
- Public IP:
  - Public IP means the machine can be identified on the internet (WWW)
  - Must be unique across the whole web (not two machines can have the same public IP).
  - Can be geo-located easily
- Private IP:
  - Private IP means the machine can only be identified on a private network only
  - The IP must be unique across the private network
  - BUT two different private networks (two companies) can have the same IPs.
  - Machines connect to WWW using an internet gateway (a proxy)
  - Only a specified range of IPs can be used as private IP

### Elastic IPs
- When you stop and then start an EC2 instance, it can change its public IP.
- If you need to have a fixed public IP for your instance, you need an Elastic IP
- An Elastic IP is a public IPv4 IP you own as long as you don’t delete it
- You can attach it to one instance at a time 
- With an Elastic IP address, you can mask the failure of an instance or software by rapidly remapping the address to another instance in your account.
- You can only have 5 Elastic IP in your account (you can ask AWS to increase that).
- Overall, try to ```avoid using Elastic IP```:
  ```
  • They often reflect poor architectural decisions
  • Instead, use a random public IP and register a DNS name to it
  • Or, as we’ll see later, use a Load Balancer and don’t use a public IP
  ```
### Private vs Public IP (IPv4)
- By default, your EC2 machine comes with:
  - A private IP for the internal AWS Network
  - A public IP, for the WWW.
- When we are doing SSH into our EC2 machines:
- We can’t use a private IP, because we are not in the same network
- We can only use the public IP.
- If your machine is stopped and then started, ```the public IP can change```

### EC2 User Data
- It is possible to bootstrap our instances using an EC2 User data script.
- bootstrapping means launching commands when a machine starts
- That script is only run once at the instance first start
- EC2 user data is used to automate boot tasks such as:
  ```
  - Installing updates
  - Installing software
  - Downloading common files from the internet
  - Anything you can think of
  ```
- The EC2 User Data Script runs with the root user

### EC2 Instance Launch Types
- On Demand Instances: short workload, predictable pricing
- Reserved Instances: long workloads (>= 1 year)
- Convertible Reserved Instances: long workloads with flexible instances
- Scheduled Reserved Instances: launch within time window you reserve
- Spot Instances: short workloads, for cheap, can lose instances
- Dedicated Instances: no other customers will share your hardware
- Dedicated Hosts: book an entire physical server, control instance placement

### EC2 On Demand
- Pay for what you use (```billing per second```, after the first minute)
- Has the highest cost but ```NO upfront payment```
- No long term commitment
- Recommended for ```short-term``` and ```un-interrupted workloads```, where you can't predict how the application will behave.

### EC2 Reserved Instances
- Up to 75% discount compared to On-demand
- Pay upfront for what you use with long term commitment
- Reservation period can be 1 or 3 years
- Reserve a specific instance type
- Recommended for steady state usage applications (think database)
- Convertible Reserved Instance
  - can change the EC2 instance type 
  - Up to 54% discount
- Scheduled Reserved Instances
  - launch within time window you reserve
  - When you require a fraction of day / week / month
  
### EC2 Spot Instances
- Can get a discount of up to 90% compared to On-demand
- You bid a price and get the instance as long as its under the price
- Price varies based on offer and demand
- Spot instances are reclaimed with a 2 minute notification warning when the spot price goes above your bid
- Used for batch jobs, Big Data analysis, or workloads that are resilient to failures.
- Not great for critical jobs or databases
  
### EC2 Dedicated Hosts
- Physical dedicated EC2 server for your use
- Full control of EC2 Instance placement
- Visibility into the underlying sockets / physical cores of the hardware
- Allocated for your account for a 3 year period reservation
- More expensive
- Useful for software that have complicated licensing model (BYOL – Bring Your Own License)
- Or for companies that have strong regulatory or compliance needs  
  
### EC2 Dedicated Instances
- Instances running on hardware that’s dedicated to you
- May share hardware with other instances in same account
- No control over instance placement (can move hardware after Stop / Start)  

### Which host is right for me?
- On demand: coming and staying in resort whenever we like, we pay the full price
- Reserved: like planning ahead and if we plan to stay for a long time, we may get a good discount.
- Spot instances: the hotel allows people to bid for the empty rooms and the highest bidder keeps the rooms.You can get kicked out at any time
- Dedicated Hosts: We book an entire building of the resort
  
### EC2 InstanceTypes – Main ones
- R: applications that needs a lot of RAM – in-memory caches
- C: applications that needs good CPU – compute / databases
- M: applications that are balanced (think “medium”) – general / web app • I: applications that need good local I/O (instance storage) – databases
- G: applications that need a GPU – video rendering / machine learning
- T2 / T3: burstable instances (up to a capacity) • T2 / T3 - unlimited: unlimited burst
- Real-world tip: use https://www.ec2instances.info

### Burstable Instances (T2/T3)
- AWS has the concept of burstable instances (T2/T3 machines)
- Burst means that overall, the instance has OK CPU performance.
- When the machine needs to process something unexpected (a spike in
load for example), it can burst, and CPU can be VERY good.
- If the machine bursts, it utilizes “burst credits”
- If all the credits are gone, the CPU becomes BAD
- If the machine stops bursting, credits are accumulated over time
- Burstable instances can be amazing to handle unexpected traffic and getting the insurance that it will be handled correctly
- If your instance consistently runs low on credit, you need to move to a different kind of non-burstable instance

### T2/T3 Unlimited
- Nov 2017: It is possible to have an “unlimited burst credit balance”
- You pay extra money if you go over your credit balance, but you don’t lose in performance
- Overall, it is a new offering, so be careful, costs could go high if you’re not monitoring the health of your instances
- Read more here: https://aws.amazon.com/blogs/aws/new-t2-unlimited- going-beyond-the-burst-with-high-performance/


### IAM vs AMI
- Identity and access management (IAM)
- Amazon Machine Image (AMI)

### What’s an AMI?
- As we saw, AWS comes with base images such as:
  - Ubuntu
  - Fedora
  - RedHat
  - Windows
  - Etc...
- These images can be customised at runtime using EC2 User data
- But what if we could create our own image, ready to go? 
- That’s an AMI – an image to use to create our instances 
- AMIs can be built for Linux or Windows machines

### Why would you use a custom AMI?
- Using a custom built AMI can provide the following advantages:
  - Pre-installed packages needed
  - Faster boot time (no need for ec2 user data at boot time)
  - Machine comes configured with monitoring / enterprise software
  - Security concerns – control over the machines in the network
  - Control of maintenance and updates of AMIs over time
  - Active Directory Integration out of the box
  - Installing your app ahead of time (for faster deploys when auto-scaling)
  - Using someone else’s AMI that is optimised for running an app, DB, etc...
- ```AMI are built for a specific AWS region (!)```

### Using Public AMIs
- You can leverage AMIs from other people
- You can also pay for other people’s AMI by the hour 
  - These people have optimised the software
  - The machine is easy to run and configure
  - You basically rent “exper tise” from the AMI creator
- AMI can be found and published on the Amazon Marketplace
- ```Warning:```
  - Do not use an AMI you don’t trust!
  - Some AMIs might come with malware or may not be secure for your enterprise

### AMI Storage
- Your AMI take space and they live in Amazon S3
- Amazon S3 is a durable, cheap and resilient storage where most of your backups will live (but you won’t see them in the S3 console)
- By default, your AMIs are ```private, and locked for your account / region```
- You can also make your AMIs public and share them with other AWS accounts or sell them on the AMI Marketplace

### AMI Pricing
- AMIs live in Amazon S3, so you get charged for the actual space in takes in Amazon S3
  - Amazon S3 pricing in US-EAST-1:
    - First 50 TB / month: $0.023 per GB
    - Next 450 TB / month: $0.022 per GB
- Overall it is quite inexpensive to store private AMIs.
- Make sure to remove the AMIs you don’t use


### Cross Account AMI Copy (FAQ + Exam Tip)
- You can share an AMI with another AWS account.
- Sharing an AMI does not affect the ownership of the AMI.
- If you copy an AMI that has been shared with your account, you are the owner of the target AMI in your account.
- To copy an AMI that was shared with you from another account, the owner of the source AMI must grant you read permissions for the storage that backs the AMI, either the associated EBS snapshot (for an Amazon EBS-backed AMI) or an associated S3 bucket (for an instance store-backed AMI).
- ```Limits:```
- You can't copy an encrypted AMI that was shared with you from another account. Instead,if the underlying snapshot and encryption key were shared with you, you can copy the snapshot while re- encrypting it with a key of your own. You own the copied snapshot, and can register it as a new AMI.
- You can't copy an AMI with an associated billing Product code that was shared with you from another account. This includes Windows AMIs and AMIs from the AWS Marketplace. To copy a shared AMI with a billing Product code, launch an EC2 instance in your account using the shared AMI and then create an AMI from the instance.
https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Copy ingAMIs.html

### Quize
- ap-northeast-1a is a...```AZ```
  ```Anything that ends with a letter is an AZ```
- AZ are in isolated data centers
  ```
  this helps guarantee that multi AZ won't all fail at once (due to a meteorological disaster 
    for example). Read more here: https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RegionsAndAvailabilityZones.html
  ```
- IAM components ```Users, Roles, Groups, Policies```
- IAM is a global service (encompasses all regions)
- An IAM user can belong to multiple groups
- You are getting started with AWS and your manager wants things to remain simple yet secure. He wants management of engineers to be easy, and not re-invent the wheel every time someone joins your company. What will you do?
  ```
  I'll create multiple IAM users and groups and assign policies to groups.
  New users will be added to groups
  This is best practice when you have a big organisation
  ```
- Never share your IAM credentials. If your colleagues need access to AWS they'll need their own account
- You pay for an EC2 instance compute component ```only when it's in running state```
- You are getting a permission error exception when trying to SSH into your Linux Instance
  ```
  the key is missing permissions chmod 0400
  The exam expects you to know this, even if you used Windows / Putty to SSH into your instances. 
  If you're a windows user, just have a quick look at the Linux SSH lecture!
  ```
- You are getting a network timeout when trying to SSH into your EC2 instance
  ```
  your security groups are misconfigured
  Remember this during your hands on. Any timeout errors 
  (not just in SSH but also HTTP for example) means a misconfiguration of your security groups
  ```
- When a security group is created, what is the default behavior?
  ```
  Deny all traffice inbound and allow all traffic outbound
  ```
- Security groups can reference all of the following except: DNS name
- you want to provide startup instructions to your EC2 instances, you should be using ```EC2 Use Data```











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


### Quize
- ap-northeast-1a is a...```AZ```
```Anything that ends with a letter is an AZ```
- AZ are in isolated data centers
```
this helps guarantee that multi AZ won't all fail at once (due to a meteorological disaster for example). Read more here: https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RegionsAndAvailabilityZones.html
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













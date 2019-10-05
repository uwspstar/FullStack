
# AWS Certified Solutions Architect - Associate
- IAM
```
- Delete your root access keys
- Activate MFA on your root account
- Create individual IAM users
- Use groups to assign permissions
- Apply an IAM password policy
```
- AWS (Amazon Web Services) is a Cloud Provider
- They provide you with servers and services that you can use on
demand and scale easily

- AWS certified Solutions Architect associate exam.
  - security identity 
  - compute
  - storage
  - databases
  - network and content delivery compute is mostly

- region
  ```
  region is just simply a geographical area.
  So each region consists of two or more availability zones.
  ```
- availability zone (AZ)
  ```
  one availability zone could be two or three data centers that are all within say a couple of miles
  ```
- edge location
  ```
  an edge location or locations are endpoints for the US 
  which you use for caching content so typically this consists of *** cloudfront
  ```
  ```
  What's important is that you understand that each location is not a region.
  It's actually just a sort of a smaller location that AWS have 
  and its use for caching content and there's always going to be more edge locations 
  than there are regions currently there's over 150 edge locations around the world.
  ```
- understand the difference between a region and availability zone and an edgy location
  ```
  A region is a physical location in the world which combines two or more availability zones.
  And so you have a London region you have a Sydney region Singapore region et cetera,
  and availability zone is one or more discrete data centers,
  each with redundant power networking connectivity housed in separate facilities, 
  and then, an edge location is just an endpoint for AWS which is used for caching content.
  Typically this consists of cloudfront which is Amazon's content delivery network (CDN)
  ```
- Cloudfront (Amazon's CDN)


- ```VPC``` stands for ```Virtual Private Cloud```
- What Is Amazon VPC?
  ```
  Amazon Virtual Private Cloud (Amazon VPC) enables you 
  to launch AWS resources into a virtual network that you've defined. 
  This virtual network closely resembles a traditional network 
  that you'd operate in your own data center, 
  with the benefits of using the scalable infrastructure of AWS
  ```
- An AWS VPC is a component of which group of AWS services
  ```
  A Virtual Private Cloud (VPC) is a virtual network dedicated to a single AWS account. 
  It is logically isolated from other virtual networks in the AWS cloud, 
  providing compute resources with security and robust networking functionality.
  ```
- Each region is a separate geographic area. Each region has multiple, isolated locations known as Availability Zones.
- An Availability Zone (AZ) is a distinct location within an AWS Region. Each Region comprises at least two AZs.
- A region is a geographical area divided into Availability Zones. Each region contains at least two Availability Zones.
- The number of Edge Locations is greater than the number of Availability Zones, which is greater than the number of Regions.
- CloudFront content is cached in Edge Locations.
- IAM (identity access management)
- Which of the following is not a component of IAM?
- When you create a new user, that user
  ```
  that user will be able to interact with AWS programmatically
  using their *** access key ID ***  and *** Secret access key *** using the API, CLI, or the AWS SDKs.
  ```
- To access the ```console``` you use an ```account``` and ```password``` combination. 
- To access AWS ```programmatically``` you use a ```Key``` and ```Secret Key``` combination
- Which statement best describes IAM
  ```
  IAM allows you to manage
  users, groups, roles, and policy ( which is their corresponding level of access to the AWS Platform )
  ```
- Using ```SAML``` (Security Assertion Markup Language 2.0), you can give your federated users ```single sign-on (SSO)``` access to the AWS Management Console.
- In what language are ```policy documents``` written? ```JSON```
- In what default policy given?
  ```
  NO access to any AWS services
  ```
- You have a client who is considering a move to AWS. In establishing a new account, what is the first thing the company should do?
  ```
  Set up an account using their company email address
  ```
- A new employee has just started work, and it is your job to give her administrator access to the AWS console. You have given her a user name, an access key ID, a secret access key, and you have generated a password for her. She is now able to log in to the AWS console, but she is unable to interact with any AWS services. What should you do next?
  ```
  Grant her Administrator access by adding her to the Administrators' group
  ```
- What level of access does the ```"root"``` account have? ```Administrator Access```
- configured multi-factor authentication on the root account
- ```Power User``` Access allows
  ```
  Accesss to all AWS services except the management of groups and users within IAM
  ```
- You are a solutions architect working for a large engineering company that are moving from a legacy infrastructure to AWS. You have configured the company's first AWS account and you have set up IAM. Your company is based in Andorra, but there will be a small subsidiary operating out of South Korea, so that office will need its own AWS environment. Which of the following statements is true?
  ```
  you will need to configure users and policy documents one onece, as these are are applied globally.
  ```
- You are a security administrator working for a hotel chain. You have a new member of staff who has started as a systems administrator, and she will need full access to the AWS console. You have created the user account and generated the access key id and the secret access key. You have moved this user into the group where the other administrators are, and you have provided the new user with their secret access key and their access key id. However, when she tries to log in to the AWS console, she cannot. Why might that be?
  ```
  you cannot log in to the AWS console using the Access Key ID / Secret Access Key pair, 
  instead, you mush generate a password for the user, and supply the user with this password 
  and your organization's unique AWS console login URL
  ```
- Every user you create in the IAM systems ```starts``` with ```No Permissions```
- ``` Policy``` is a document that provides a formal statement of one or more ```permissions```.
- You have created a new AWS account for your company, and you have also configured multi-factor authentication on the root account. You are about to create your new users. What strategy should you consider in order to ensure that there is good security on this account.
  ```
  Enact a strong password policy: 
  user passwords mush be changed every 45 days, 
  with each password containing a combination of capital letters, lower case letters, numbers 
  and special symboles
  ```
- S3 (Simple Storage Service)
  ```
  Amazon S3 is object storage built to store 
  and retrieve any amount of data from anywhere on the Internet. 
  It’s a simple storage service that offers an extremely durable, highly available, 
  and infinitely scalable data storage infrastructure at very low costs.
  ```
  - https://aws.amazon.com/s3/faqs/
  
- S3 is object storage can be``` 0 bytes``` all the way up to ```5 TB terabytes```.

- Bucket ```bucket``` is basically just a ```folder```.

- Bucket Name
  ```
  only one web address available so you have to make sure your bucket names 
  are unique and when you upload, such as 
  https://s3-eu-west-1/amazonaws.com/acloudguru
  ```
- You have been asked to advise on a scaling concern. The client has an elegant solution that works well. As the information base grows they use CloudFormation to spin up another stack made up of an S3 bucket and supporting compute instances. The trigger for creating a new stack is when the PUT rate approaches 100 PUTs per second. The problem is that as the business grows that number of buckets is growing into the hundreds and will soon be in the thousands. You have been asked what can be done to reduce the number of buckets without changing the basic architecture.

  ```
  Change the trigger level to around 3000 as S3 can now accommodate much higher PUT and GET levels
  
  Until 2018 there was a hard limit on S3 puts of 100 PUTs per second. 
  To achieve this care needed to be taken with the structure of the name Key 
  to ensure parallel processing. 
  As of July 2018 the limit was raised to 3500 and the need for the Key design 
  was basically eliminated. 
  Disk IOPS is not the issue with the problem. 
  The account limit is not the issue with the problem.
  ```
- You run a meme creation website where users can create memes and then download them for use on their own sites. The original images are stored in S3 and each meme's metadata in DynamoDB. You need to decide upon a low-cost storage option for the memes, themselves. If a meme object is unavailable or lost, a Lambda function will automatically recreate it using the original file from S3 and the metadata from DynamoDB. Which storage solution should you use to store the non-critical, easily reproducible memes in the most cost-effective way?
  ```
  S3- 1Zone-IA
  S3 – OneZone-IA is the recommended storage for 
  when you want cheaper storage for infrequently accessed objects. 
  It has the same durability but less availability. 
  There can be cost implications if you use it frequently or use it for short lived storage. 
  Glacier is cheaper, but has a long retrieval time. 
  RRS has effectively been deprecated. 
  It still exists but is not a service that AWS want to sell anymore.
  ```
- You have uploaded a file to S3. Which HTTP code would indicate that the upload was successful? ``` HTTP 200```
- S3 has eventual consistency for which HTTP Methods?
  ```
  Overwrite PUTS and DELETES
  ```
- What is Amazon Glacier
  ```
  An AWS servuce designed for long term data archival
  ```
 - You work for a health insurance company that amasses a large number of patients' health records. Each record will be used once when assessing a customer, and will then need to be securely stored for a period of 7 years. In some rare cases, you may need to retrieve this data within 24 hours of a claim being lodged. Given these requirements, which type of AWS storage would deliver the least expensive solution?
  ```
  The recovery rate is a key decider. 
  The record shortage must be; safe, durable, low cost, and the recovery can be slow. 
  All features of Glacier
  ```
- The difference between S3 and EBS is that EBS is object-based whereas S3 is block-based ```FALSE```
- What is the availability of S3 – OneZone-IA
  ```
  OneZone-IA is only stored in one Zone. 
  While it has the same Durability, it may be less Available than normal S3 or S3-IA.
  ```
- One of your users is trying to upload a 7.5GB file to S3. However, they keep getting the following error message: "Your proposed upload exceeds the maximum allowed object size.". What solution to this problem does AWS recommend?
  ```
  Design your application to user the Multipart Upload API for all objects
  ```
 - You run a popular photo-sharing website that depends on S3 to store content. Paid advertising is your primary source of revenue. However, you have discovered that other websites are linking directly to the images in your buckets, not to the HTML pages that serve the content. This means that people are not seeing the paid advertising, and you are paying AWS unnecessarily to serve content directly from S3. How might you resolve this issue?
  ```
  remove the abliity for images to be served publicly to the site 
  and then use signed URLs with expiry detes
  ```
 - You have been asked by your company to create an S3 bucket with the name "acloudguru1234" in the EU West region. What would the URL for this bucket be?
 ```
 https://s3-eu-west-1.amazonaws.com/acloudguru1234
 ```
- You work for a major news network in Europe. They have just released a new mobile app that allows users to post their photos of newsworthy events in real-time, which are then reviewed by your editors before being copied to your website and made public. Your organization expects this app to grow very quickly, essentially doubling its user base each month. The app uses S3 to store the images, and you are expecting sudden and sizable increases in traffic to S3 when a major news event takes place (as users will be uploading large amounts of content.) You need to keep your storage costs to a minimum, and it does not matter if some objects are lost. With these factors in mind, which storage media should you use to keep costs as low as possible?
  ```
  S3-OneZone-Infrequent Access
  The key driver here is cost, so an awareness of cost is necessary to answer this. 
  Full S3 is quite expensive at around $0.023 per GB for the lowest band. 
  S3 standard IA is $0.0125 per GB, 
  S3 One-Zone-IA is $0.01 per GB, 
  and Legacy S3-RRS is around $0.024 per GB for the lowest band. 
  Of the offered solutions SS3 One-Zone-IA is the cheapest suitable option. 
  Glacier cannot be considered as it is not intended for direct access, 
  however it comes in at around $0.004 per GB. 
  Of course you spotted that RRS is being deprecated, 
  and there is no such thing as S3 – Provisioned IOPS. In this case OneZone
  ```
- How many S3 buckets can I have per account by default ```1000```
- You work for a busy digital marketing company who currently store their data on-premise. They are looking to migrate to AWS S3 and to store their data in buckets. Each bucket will be named after their individual customers, followed by a random series of letters and numbers. Once written to S3 the data is rarely changed, as it has already been sent to the end customer for them to use as they see fit. However, on some occasions, customers may need certain files updated quickly, and this may be for work that has been done months or even years ago. You would need to be able to access this data immediately to make changes in that case, but you must also keep your storage costs extremely low. The data is not easily reproducible if lost. Which S3 storage class should you choose to minimize costs and to maximize retrieval times?
  ```
  The need to immediate access is an important requirement along with cost. 
  Glacier has a long recovery time at a low cost 
  or a shorter recovery time at a high cost, 
  and 1Zone-IA has a lower Availability level 
  which means that it may not be available when needed.
  ```
- What is the availability of objects stored in S3 ```99.99%```
- S3 has what consistency model for PUTS of new objects ```Read Aftr Write Consistency```
- What does S3 stand for ```Simple Storage Service```
- You are a solutions architect who works with a large digital media company. The company has decided that they want to operate within the Japanese region and they need a bucket called "testbucket" set up immediately to test their web application on. You log in to the AWS console and try to create this bucket in the Japanese region however you are told that the bucket name is already taken. What should you do to resolve this?
  ```
  Bucked names are global, not regional. This is a popular bucket name and
  is already taken. You should choose another buket name.
  ```
- What is the minimum file size that I can store on S3 ```0 bytes```
- What is AWS Storage Gateway?
  ```
  It is a physical or virtual appliance 
  that can be used to cache S3 locally at a customer's site.
  At its heart it is a way of using AWS S3 managed storage to supplement on-premise storage. 
  It can also be used within a VPC in a similar way.
  ```
 ### Exam Tips:
  - Edge Location - This is the location where content will be cached. This is separate to an AWS Region/AZ
  - Origin - This is the origin of all the files that the CDN will distribute. This can be either an S# Bucket, an EC2 instance, an Elastic Load Balancer, or Route53.
  - Distribution - This is the name given the CDN which consists of a collection of Edge Locations.
  - Web Distribution - Typically used for Websites.
  - RTMP - Used for Media Streaming
  - Edge locations are not hust READ only - you can write to them too. (ie put an object on to them,)
  - Objects are cached for the life of TTL (Time To Live)
  - You can invalidate cached objects, but you will be charged.
  
 ### Snowball
 ``` 
  snowball is a petabytesscale data transport solution 
  that uses secure appliances to transfer large amounts of data into and out of AWP.
  it's a big desk it's a way of getting a huge amount of data into AWS 
  and you can also use it to export data from eight of us 
  and using snowball addresses common challenges with large scale
  data transfers including high network costs long transfer times and security concerns.
  Transferring data would snowball is simple far secure and can be as little as one fifth the cost of
  using high speed Internet and snowball basically comes in two flavors.
  You've got 50 terabytes or 80 terabytes.
  So snowball uses multiple layers of security designed to protect your data including tamper resistant
  enclosures 256 bit encryption and an industry standard trusted platform module 
  or TPM which is designed
  to ensure both security and full chain of custody of your data 
  and once your data transfer job has been processed 
  and verified NWS performs a software erasure of the snowball appliance and they do it in such
  a way that you can't just take a snowball and restore the data from previous customers 
  as well it's completely wiped.
  So it's basically they nuke it essentially.
  We also have a snowball edge so snowball edge comes in 100 terabytes worth of data.
  And this is a device with an onboard storage and compute capabilities.
  You can actually run like lambda functions from snowball edge.
  ```
- Snowball can inport to S3 and Export from S3

### storage Gateway
- storage Gateway
  ```
  what is storage Gateway.
  Well it comes in a bunch of different flavors 
  but basically it's a service that connects an on premise software appliance 
  with cloud based storage to provide seamless and secure integration 
  between an organization's on premise I.T. environment 
  and Adobe as a storage infrastructure and the service enables you to securely
  store data to the AWB cloud for scalable and cost effective storage.
  ```
- storage gateways software appliance
  ```
  So storage gateways software appliance is available for you to download as a virtual machine image 
  that you install on a host in your data center and storage Gateway supports 
  either VM where's ASX AI or Microsoft's hyper v as the hypervisor.
  So that's a hypervisor is just what you run virtual machines on.
  And once you've installed your gateway and associate it with your Adobe s account 
  through the activation process you can use the AWB management console 
  to create this storage Gateway option that is right for you.
  ```
- Storage gateways three different types
  - File Gateway (NFS & SMB)
  - Volume Gateway (iSCSI)
    - Stored Volumes
    - Cached Volumes
  - Tape Gateway (VTL)
 
### Exam Tips:
- File Gate way
  ```
  File Gateway - for flat files, stored directly on S3
  ```
- Volume Gateway
  - Stored Volumes - Entired Dataset is stored on site and is aysnchromosly backed up to S3
  - Cached Volumes - Entore Dataset is stored on S3 and the most frequently accesssed data is cached on site.
- Gateway Virtual Tpe Libray

### Exam Tips:
- Indentity Accesss Management Consists of The  Following 
  - Users
  - Groups
  - Roles
  - Policies
- IAM is universal. It does not apply to regions at this time
- The "root account" is simply the account created when first setup your AWS account. 
It has complete Admin access
- New users are assigned Access Key ID & Secret Access Keys when first created.
- These are not the same as a password. You cannot use the Access key ID & Secret Access Key to Login in to the console. You can use this to access AWS via the APIs and Command Line, however/
- You only get to view tehse once. If you lose them, you have to regenerate them. So, save them in a secure location
- Always setup Multifcator Authentication on your root account.
- You can create and customise your own password rotation policies.
- S3 is Object-based: i.e allows you to upload files.
- Files can be from 0 Bytes to 5 TB
- There is unlimited storage
- Files are stored in Buckets.
- S3 is a universal namespace. That is, names mmust be unique globally
- https://s3-eu-west-1.amazonaws.com/uwspstar
- Not suitable to install an operating system on
- Successful uploads will generated a HTTP 200 status code
- By defaultm all newly created buckets are PRIVATE. You can setup access control to your buckets using
  - Bucket Policies
  - Access Control Lists
- S3 buckets can be configured to create access logs which log all requests made to the S3 bucket. This can be sent to another bucket and event another bucket in another account
- The key Fundamentals of S3 Are:
  - Key ( This is simply the name of the object)
  - Value( this is simply the data and is made up of a sequence of bytes).
  - Version ID (important for versioning)
  - Metdata (Data about data your are stroing)
  - Subresources
    - Access control Lists
    - Torrent
- Read after Write consistency for PUTS of a new Objects
- Eventual Consistency for overwrite PUTS and DELETES (can take some time to propagate)
- S3 standard (99.99% availablity)
  ```
  99.99% availablity 99,9999999% durablility, stored redundantly across muliple devices in muliple facilitys 
  and is dsgined to sustain the loss of 3 facilities concurrently
  ```
- S3- IA
  ```
  (Infrequently Accessed): For data that is accessed less frequently, 
  but requires rapid access when needed. Lower fee than S3, but you are charged a retrieval fee.
  
  The need to immediate access is an important requirement along with cost. 
  Glacier has a long recovery time at a low cost or a shorter recovery time at a high cost, 
  and 1Zone-IA has a lower Availability level 
  which means that it may not be available when needed.
  ```
- S3 One Zone- IA  (99.50% availability)
  ```
  For where you want a lower-cost option for infrequently access data, 
  but do not require the multiple avilablitty Zone data resilience.
  
  S3 – OneZone-IA is the recommended storage for 
  when you want cheaper storage for infrequently accessed objects. 
  It has the same durability but less availability. 
  There can be cost implications if you use it frequently or use it for short lived storage. 
  Glacier is cheaper, but has a long retrieval time. 
  RRS has effectively been deprecated. 
  It still exists but is not a service that AWS want to sell anymore.
  
  The key driver here is cost, so an awareness of cost is necessary to answer this. 
  Full S3 is quite expensive at around $0.023 per GB for the lowest band. 
  S3 standard IA is $0.0125 per GB, 
  S3 One-Zone-IA is $0.01 per GB, 
  and Legacy S3-RRS is around $0.024 per GB for the lowest band. 
  Of the offered solutions SS3 One-Zone-IA is the cheapest suitable option. 
  Glacier cannot be considered as it is not intended for direct access,
  however it comes in at around $0.004 per GB. 
  Of course you spotted that RRS is being deprecated, 
  and there is no such thing as S3 – Provisioned IOPS. In this case OneZone
  ```
- S3 - Intelligent Tiering
  ```
  Designed to iptimized cosets by automatically moving  data to the most cost-effective accesss tier, 
  without performance impact or operational overhead
  ```
- S3 Glacier
  ```
  S3 Glacier is a secure , durable, and low-cost storage class for data archiving. 
  Retrieval times configurable from minutes to hours
  ```
- S3 Glacier Deep Archive
  ```
  S# Glacier Deep Archive is Amazon S3's lowest-cost storage class 
  where a retrieval time of 12 hours is acceptable.
  
  The record shortage must be; safe, durable, low cost, and the recovery can be slow. 
  All features of Glacier.
  ```
- Encrypition in Transit is achieved by
  - SSL/TLS
- Encryption At Rest (Server Side) is acchieved by 
  - S3 Managed Keys - SSE- S3
  - AWS Key Management Service, Managed Keys - SSE-KMS
  - Server Side Encryption With Customer Provided Keys-SSE-C
- Client Side Encryption
- Cross Region Replication
  - Versioning mush be enabled on both the source and destination buckets.
  - Regions must be unique.
  - Files in an existing bucket are not replicated automatically
  - All subsequent updated files will be replicated automatically
  - Delete markers are not replicated
  - Deleting individual versions or delete markers will not be replicated
  - Understand whnat Cross Region Replication is at a high level.
- Lifecycle Policies
  - Automates moving your objects between the different storage tiers.
  - Can be used in conjunction with versioning.
  - Can be applied to current versions and prvious versions
- CloudFront
  - Edge Location - This is the location where content will be cached. This is separate to an AWS Region/AZ
  - Origin - This is the origin of all the files that the CDN will distribute. This can be either an S3 bucket, and EC2 Instance, and Elastic Load Balancer, or Route53
  - Distribution This isthe name given the CDN which consists of a collection of Edge Locations
  - Web Distribution - Typically used for websites.
  - Edge location are not just READ only - you can write to them too, (ie put an object on to them)
  - Objects are cached for the life of the TTL (Time To Live)
  - You can clear cached objects, but you will be charged
- Snowball
  - Understand what Snowball is
  - Import to S3
  - Export to S3
- File Gateway
  - File Gateway - For flat files, stored directly on S3
- Volume Gateway
  - Stored Volumes - Entire Dataset is stored on site and is asynchronously backed up to S3
  - Cached Volumes - Entire Dataset is stored on S3 and the most frequently accessed data is cached on site.
- Cateway Virtual Tape Library
  - Used for backup and uses po-ular backup applications like NetBackup, Backup, Veeam etc.
- Read teh S3 FAQs before taking the exam. it comes up ALOT!
 
 ### Exam Tips
 - Termination Protection is turned off by default, you must turn it on.
 - On an EBS-backed instance, the default action is for the root EBS volume to be deleted when the instance is terminated
 - EBS Root Volumes of you DEFAULT AMI's cannot be encrypted. You can also use a third party tool (such as bit locker etc) to encrypt the root volume, or this can be done when creating AMI's (lab to follow) in the AWS console or using the API.
 - Additional volumes can be encrypted
### Exam Tips
 - Allinbound traffic is blocked by default
 - All outbound traffice is allowed
 - Changes to security groups take effect immediately
 - You can have any number of EC2 instances within a security group
 - You can have multiple security groups attached to ECS instances
 - Security Group are STATEFUL
 - if you created an inbound rule allowing traffice inm the traffice is automatically allowed back out again.
 - you cannot block specific IO address using Security Groups, instead use Network Access Control Lists
 - You can specify allow rules, but not deny rules.
### EBS
  ```
  Amazon Elastic Block Store (EBS) provides persistend block storage volumes for use with Amazon EC2 instances in the AWS Cloud. Each Amazon EBS volume is automatically replicated within its Availability Zone to protect you from component failure, offering high availability and durability.
  ```
- 5 different Types of EBS Storage
  - General Purpose (SSD)
  - Provisioned IOPS (SSD) ```really really fast```
  - Throughput Optimised Hard Disk Drive
  - Cold Hard Disk Drive
  - Magnetic
  ### Exam Tips
  - Volumes exist on EBS, Think of EBS as a virtual hard disk
  - Snapshots exist on S3. Think of snapshots as a photograph of the disk
  - Snapshots are point in time copies of Volumes
  - Snapshots are incremental - this means that only the blocks that have changed since your last snamshot are moved to S3.
  - the first snapshot may take some time
  - To created a snapshot for Amazon EBS volumes that serve as root devices, you should stope the instance before taking the snapshot.
  - Howevre you can take a snap while the instance is running
  - You  can create AMI's from both Voulumes and Snapshots.
  - You can change EBS volume sizes on the fly, incluing changing the size and storage type.
  Volumes will ALWAYS be in the same AZ as the EC2 instance
  - To move an ES3 volume from on AZ to another, tke a snapshot of it, create an AMI from the sanpshot and then use the AMI to launch to lunch the EC2 instance in a new AZ.
  - To move an ES2 volume from one region to another, take a snapshot of it, create an AMI from the snapshot and then copy the AMI from one region to the other. Then use the copied AMI to launch the new EC2 instance in the new region
  ### AMI Types (EBS vs Instance Store)
 
 
### what is a VPC flow log.

- Well VPC flow logs is a feature that enables you to capture information about the IP traffic going to and from network interfaces within your VPC.
- flow log data is stored using Amazon Cloud watch logs, 
- after you've created a flow log you can view and retrieve data in Amazon Cloud watch logs.

### Creating an AMI after installing the applications allows you to start more EC2 instances directly from that AMI, hence bypassing the need to install the application (as it's already installed)
 
### Although creating a new NIC & associating an EIP also results in your instance being accessible from the internet, it leaves your instance with 2 NICs & 2 private IPs as well as the public address and is therefore not the simplest solution. 

### By default, any user-created ```VPC subnet``` WILL NOT automatically assign public IPv4 addresses to instances – the only ```subnet``` that does this is the ```“default” VPC subnets``` automatically created by AWS in your account.

### Each subnet must reside entirely within one Availability Zone and cannot span zones.

### Until recently customers were not permitted to conduct penetration testing without AWS engagement. However that has changed. There are still conditions though.
 
### In a custom VPC with new subnets in each AZ, there is a route that supports communication across all subnets/AZs. Plus a default SG with an allow rule 'All traffic, all protocols, all ports, from anything using this default SG'.

### You may have only one internet gateway per VPC.

### You may peer a VPC to another VPC that's in your same account, or to any VPC in any other account.

### An application load balancer must be deployed into at least two subnets.
 
### In contrast to a NAT gateway, traffic between your VPC and the other service does not leave the Amazon network when using VPC endpoints.
 
### A Bastion host allows you to securely administer (via SSH or RDP) an EC2 instance located in a private subnet. Don't confuse Bastions and NATs, which allow outside traffic to reach an instance in a private subnet.

### You have five VPCs in a 'hub and spoke' configuration, with VPC 'A' in the center and individually paired with VPCs 'B', 'C', 'D', and 'E', which make up the 'spokes'. There are no other VPC connections. Which of the following VPCs can VPC 'B' communicate with directly?
```
As transitive peering is not allowed, VPC 'B' can communicate directly only with VPC 'A'.
```
 
### Security Groups are stateful and Network Access Control Lists are stateless.

### Security groups act like a firewall at the instance level, whereas _________ are an additional layer of security that act at the subnet level. 
```
Network ACLs
```

  
 
 
 
 
  
  
  








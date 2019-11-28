
Question No:1
### If you determine that the resources on a launched Amazon EC2 instance are insufficient to handle the workload of an application, you can resize the instance without performing any migration as long as your root device is a(n) volume.
A. persistent
B. SSD
C. instance store 
D. EBS

Explanation: As your needs change, you might find that your instance is over-utilized (the instance type is too small) or under-utilized (the instance type is too large). If the root devicefor your instance is an Elastic Block Store (EBS) volume, you can change the size of the instance simply by changing its instance type, which is known as resizing it. If the root device for your instance is an instance store volume, you must migrate your application to a new instance with the instance type that you want. Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-resize.html Answer: D

Question No:2
### How does AWS define cloud computing?
A. A physical pool of compute, storage and network resources that can’t be accessed over the internet.
B. The term used to describe virtualized technology.
C. A pool of servers offering compute resources that are designed to be issued exclusively to individual tenants (users and organizations).
D. The on-demand delivery of IT resources through a cloud services platform via the Internet with pay-as-you-go pricing. 

Explanation: Cloud computing provides a simple way to access servers, storage, databases and a broad set of application services over the Internet. A cloud services platform such as Amazon Web Services owns and maintains the network-connected hardware required for these application services, while you provision and use what you need via a web application. Reference: https://d0.awsstatic.com/whitepapers/aws-overview.pdf Answer: D

Question No:3
### In Amazon Elastic Compute Cloud, when taking a snapshot, what is the status of the snapshot until it is completed?
A. Stalled 
B. Running 
C. Working 
D. Pending 

Explanation: In Amazon Elastic Compute Cloud, the status of the snapshot is 'pending' until the snapshot is complete.
Reference: http://docs.amazonwebservices.com/AWSEC2/latest/UserGuide/ebs-creating-snapshot.html Answer: D

Question No:4
### Which of the following is not a characteristic of Amazon Elastic Compute Cloud (Amazon EC2)?
A. It increases the need to forecast traffic by providing dynamic IP addresses for static cloud computing.
B. It eliminates your need to invest in hardware up front, so you can develop and deploy applications faster.
C. It can be used to launch as many EC2 instances as needed up to the AWS instance limit for a region.
D. It offers scalable computing capacity in the Amazon Web Services (AWS) cloud. 

Explanation: Amazon Elastic Compute Cloud (Amazon EC2) provides scalable computing capacity in the Amazon Web Services (AWS) cloud. Using Amazon EC2 eliminates your need to invest in hardware up front, so you can develop and deploy applications faster. You can use Amazon EC2 to launch as many or as few virtual servers as you need, configure security and networking, and manage storage. Amazon EC2 enables you to scale up or down to handle changes in requirements or spikes in popularity, reducing your need to forecast traffic. Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts.html Answer: A

Question No:5
### Which of the following happens when a bucket is created?
A. By default, versioning is disabled.
B. By default, versioning is enabled for the US Standard region buckets. 
C. By default, versioning is enabled.
D. By default, versioning is disabled only for the local region of the user. 

Explanation: A user can enable versioning with AWS S3 only at the bucket level. Versioning is disabled by default when a bucket is created. Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/ObjectVersioning.html Answer: A

Question No:6
### An Elastic Cloud Compute (EC2) instance can be best described as .
A. a Windows 10 virtual machine running locally on a Type I hypervisor
B. any AMI virtual machine running locally on a Type II hypervisor
C. a Linux Red Hat virtual machine running locally on a Type I hypervisor
D. a copy of the AMI running as a virtual server on a host computer in the data center

Explanation: An EC2 Instance is a copy of an Amazon Machine Image (AMI) that is running as a virtual server on a host computer in Amazon’s data center. When you create/launch an instance you must select the instance type. This determines the hardware characteristics (32-bit or 64-bit; amount of RAM, amount and type of CPUs, and hard drive capacity) of the virtual machine. Reference: https://aws.amazon.com/ec2/  Answer: D

Question No:7
### A   , also called Virtual Machine Monitor (VMM), is software/hardware platform virtualization software that allows multiple operating systems to run on a host computer concurrently
A. AWS VMOP
B. Hypervisor
C. OS Virtualizer
D. AWS Virtual Monitor

Explanation: A hypervisor or virtual machine monitor (VMM) is a piece of computer software, firmware or hardware that creates and runs virtual machines. This is the base of cloud computing services like Amazon AWS and the way they run instances (also called virtual machines). Reference: http://en.wikipedia.org/wiki/Hypervisor Answer: B

Question No:8
### Does Amazon S3 provide a filesystem?
A. Yes, NFS (Network File System).
B. Yes, any Filesystem of your choice.
C. No, it only stores streams of data
D. No, it's an object store, with buckets and objects.

Explanation: Amazon Simple Storage Service (S3) is an object storage organized in a hierarchy of buckets and objects that can be easily managed and accessed by your users and applications. Reference: http://docs.aws.amazon.com/AmazonS3/latest/gsg/GetStartedWithS3.html Answer: D
 
Question No:9
### Amazon provides durable, block-level storage volumes you can attach to a running instance and which persist beyond the life of the instance.
A. Elastic Block Store
B. Elastic File System
C. Persistent Block Store 
D. EC2 Instance Store

Explanation: Amazon EBS provides durable, block-level storage volumes that you can attach to a running instance. You can use Amazon EBS as a primary storage device for data that requires frequent and granular updates. For example, Amazon EBS is the recommended storage option when you run a database on an instance. An EBS volume behaves like a raw, unformatted, external block device that you can attach to a single instance. The volume persists independently from the running life of an instance. Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Storage.html  Answer: A

Question No:10
### Which choice is a stated benefit of using AWS?
A. data center servers specifically for your account
B. security configuration is entirely managed by AWS 
C. system compliance is entirely managed by AWS
D. reduced effort to meet compliance requirements

Explanation: AWS services are designed to comply with common compliance regulations, such as PCI DSS level. You will have to configure services to meet your specific compliance needs, but segments of your IT system on AWS should comply will several standard compliance regulations immediately.
You can request dedicated instances, but you cannot select specific data centers for your account, and with the Shared Responsibility Model, AWS will not assist you in configurations to meet your security or compliance requirements. Reference: https://d0.awsstatic.com/whitepapers/aws-overview.pdf  Answer: D

Question No:11
### An Amazon EC2 Instance Store provides temporary block-level storage for your instance. An instance store is ideal for temporary storage of information that changes frequently, such as buffers, caches, scratch data, and other temporary content. Ephemeral storage is ideal for
A. persistent data
B. high-performance storage of user files 
C. storing critical system files
D. non-persistent data

Explanation: An Amazon EC2 Instance Store provides temporary block-level storage for your instance. An instance store is ideal for temporary storage of information that changes frequently, such as buffers, caches, scratch data, and other temporary content. Ephemeral storage is ideal for non-persistent data.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html Answer: D

Question No:12
### Which of the following does Amazon S3 provide?
A. A transient storage in the cloud
B. A highly encrypted virtual disk in the cloud 
C. A virtual server in the cloud
D. A highly-scalable cloud storage

Explanation: Amazon S3 provides Scalable Storage in the Cloud. Amazon Simple Storage Service (Amazon S3) is object storage with a simple web service interface to store and retrieve any amount of data from anywhere on the web. It is designed to deliver 99.999999999% durability, and scale past trillions of objects worldwide. Reference: https://aws.amazon.com/s3/ Answer: D

Question No:13
### What is a common use case for Amazon Lightsail?
A. to process large compute jobs with minimal administrative requirements
B. to process individual steps in a process automatically based on changes in your system status
C. to host simple websites, blogs or small applications 
D. to manage scaling of Amazon EC2 instances

Explanation: With its simplicity and small scale uses, Amazon Lightsail is commonly used to host simple websites, small applications and blogs. You can run multiple Lightsail instances together, allowing them to communicate and it's even possible, if required, to connect it to other AWS resources and to your existing VPC running within AWS via a peering connection. Reference: https://lightsail.aws.amazon.com/ls/docs/getting-started/article/what-is-amazon-lightsail  Answer: C

Question No:14
### To enable access to or from the Internet for instances in a VPC subnet, you must:
A. ensure that instances in your subnet have only private IP addresses. 
B. attach an existing datastore to a virtual machine.
C. ensure that your network access control and security group rules block the relevant traffic flowing into your instance.
D. ensure that your subnet's route table points to the Internet Gateway.

Explanation: To enable access to or from the Internet for instances in a VPC subnet, you must do the following:
. Attach an Internet Gateway to your VPC.
. Ensure that your subnet's route table points to the Internet gateway.
. Ensure that instances in your subnet have public IP addresses or Elastic IP addresses.
. Ensure that your network access control and security group rules allow the relevant traffic to flow to and from your instance. Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Internet_Gateway.html  Answer: D

Question No:15
### A client has requested additional compute power for end-of-year transaction processing. You estimate that they will need an additional 10 servers during a three-day period. You begin creating the servers by specifying the instance type in the AWS console. What are some of the viewable instance attributes in the AWS console for the instance type that you decide to choose? (Choose 3 answers)
A. Storage (size and type)
B. Virtual CPUs
C. Amazon Machine Image (AMI) 
D. Memory

Explanation: The instance type defines the virtual hardware of the EC2 instance. You can select an instance to meet your needs depending on these factors: the number of virtual CPUs, network performance, memory, and storage (size and type). Instance types are grouped into families based on these characteristics and you can scale up in size.
Reference: https://aws.amazon.com/ec2/instance-types/ Answer: A,B,D

Question No:16
### What answer lists all the instance pricing categories that EC2 provides?
A. On-demand, Reserved, and Spot instances
B. On-Demand, Reserved, Shared, and Custom
C. On-Demand, Spot Instances, Shared and Dedicated 
D. On-Demand, Reserved, Spot, and Custom

Explanation: The specific pricing options AmazonEC2 instances can be either On-Demand, Reserved or Spot instances.
With on-demand instances, you can pay for compute capacity by the second (with a minimum one-minute charge), or by the hour, depending on the operating system you select for your virtual machine instance. With on-demand pricing, there is no long-term commitments or upfront payments.
Reserved Instances provide you with a significant discount (up to 75%) compared to On-Demand instance pricing. Amazon EC2 Spot instances allow you to bid on spare Amazon EC2 computing capacity for up to 90% off the on-demand price.
There are also tenancy options, which determine the AWS hardware your instances are hosted on. This is technically different than the pricing options. AWS offers shared tenancy by default, as well as dedicated tenancy, and finally dedicated host tenancy. Shared tenancy means your instances can be hosted on any available hardware in a given availability zone, and will still be secure and separate from other instances with shared tenancy. Dedicated tenancy means your instances only alone run on a specific, single-tenant AWS server. A Dedicated Host is a physical EC2 server dedicated for your use, and you can actually control the server settings. The ability to control the server settings is what separates dedicated tenancy from dedicated host tenancy. The pay-as-you-go pricing was previously per instance-hour, but was updated on October 2, 2017 to include some instance types and operating systems that can be billed at per second. Reference: http://aws.amazon.com/ec2/faqs/ Answer: A

Question No:17
### Which of the following is the most accurate definition of the Amazon Machine Images (AMIs)?
A. It is a template that contains a software configuration (for example, an operating system, an application server, and applications).
B. It is a storage volume for temporary data that's deleted when you stop or terminate your instances.
C. It is a template that contains configurations of CPU, memory, storage, and networking capacity for your instances.
D. It is a web service that makes it easier to set up, operate, and scale a relational database in the cloud.

Explanation: One of the main features of Amazon EC2 is Amazon Machine Images (AMIs), which is a template that contains a software configuration (for example, an operating system, an application server, and applications). AMIs contain common software configurations for public use.
Moreover, users can create their custom AMI or AMIs. This ability helps users to quickly and easily start new instances that have everything they need.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html Answer: A

Question No:18
### Each Amazon region is designed to be completely isolated from the other Amazon regions so that
A. they provide better security
B. they reduce the operational costs
C. they achieve the greatest possible fault tolerance and stability 
D. they provide low latency connections

Explanation: Each Amazon region is designed to be completely isolated from the other Amazon regions. This achieves the greatest possible fault tolerance and stability.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html Answer: C

Question No:19
### Is it possible to access S3 objects from the Internet?
A. No, there is no way to access any S3 objects from the Internet.
B. Yes, it is possible if proper public readable accesses and ACLs are set. 
C. No, only a general overview of S3 objects can be read from the Internet. 
D. Yes, but it has to pass through EC2.

Explanation: You must grant read permission on the specific objects to make them publicly accessible so that your users can view them on your website. You make objects publicly readable by using either the object ACL or by writing a bucket policy.
Reference: https://aws.amazon.com/articles/5050 Answer: B

Question No:20
### By default, are volumes that you attach as you launch the instance automatically deleted when the instance terminates?
A. No, but you can manually enable this behavior.
B. Yes, but any additional EBS volumes that you attach at launch, or any EBS volumes that you attach to an existing instance persist even after the instance terminates.
C. No
D. No, but any additional EBS volumes that you attach at launch needs to be replaced before deletion.

Explanation: By default, Amazon EBS root device volumes are automatically deleted when the instance terminates. However, by default, any additional EBS volumes that you attach at launch, or any EBS volumes that you attach to an existing instance persist even after the instance terminates.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/terminating-instances.html Answer: B

Question No:21
### Which of the following would be considered features of using Elastic Load Balancing to automatically distribute incoming application traffic across multiple Amazon EC2 instances? (Choose 3 answers)
A. Elastic Load Balancing ensures that only healthy Amazon EC2 instances receive traffic by detecting unhealthy instances and rerouting traffic across the remaining healthy instances.
B. Elastic Load Balancing delivers your content through a worldwide network of edge locations.
C. Elastic Load Balancing automatically scales its request handling capacity to meet the demands of application traffic.
D. Elastic Load Balancing works with Amazon Virtual Private Cloud (VPC) to provide robust networking and security features.

Explanation: Elastic Load Balancing works with Amazon Virtual Private Cloud (VPC) to provide robust networking and security features. Elastic Load Balancing ensures that only healthy Amazon EC2 instances receive traffic by detecting unhealthy instances and rerouting traffic across the remaining healthy instances. Elastic Load Balancing automatically scales its request handling capacity to meet the demands of application traffic.
CloudFront delivers your content through a worldwide network of edge locations. Using Elastic Beanstalk, you can quickly deploy and manage applications in the AWS Cloud without worrying about the infrastructure that runs those applications.
Reference: https://aws.amazon.com/elasticloadbalancing/ Answer: A,C,D

Question No:22
### What does the phrase 'stop guessing capacity' mean?
A. To use elastic IP addresses to increase high availability
B. To implement self-healing processes
C. To set correct data storage lifecycles
D. Use of auto scaling to prevent the need to predict and guess your capacity and demand requirement

Explanation: One of the best practices of the reliability pillar of the Well-Architected Framework is to 'stop guessing capacity.' This looks at the use of Auto Scaling to prevent the need to predict and guess your capacity and demand requirement which aids in a better end-user experience. Reference: https://d1.awsstatic.com/whitepapers/architecture/AWS_Well-Architected_Framework.pdf Answer: D

Question No:23
### Elastic Load Balancing automatically distributes incoming traffic across multiple instances.
A. RDS 
B. M3 
C. EC2
D. DB 

Explanation: AWS provides the Elastic Load Balancing service to automatically distribute the incoming traffic across multiple Amazon Elastic Compute Cloud (Amazon EC2) instances.
The load balancer serves as a single point of contact for clients, which increases the availability of your application. You can add and remove instances from your load balancer as your needs change, without disrupting the overall flow of requests to your application.
Reference: http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/SvcIntro.html Answer: C

Question No:24
### You are designing an AWS VPC for a large healthcare organization. The majority of the departments will require basic, low to medium throughput for their day to day operations. But the Radiology and MRI group continually sends very large imaging files and requires low latency and up to 10 Gbps throughput in a single availability zone. What configuration will best meet these requirements?
A. Create the Radiology/MRI instances in a Placement Group.
B. Use Direct Connect for Radiology/MRI.
C. Use a VPN for Radiology/MRI.
D. Create the Radiology/MRI instances in a Read Replica Group.

Explanation: A placement group is a logical grouping of instances within a single Availability Zone. Placement groups are recommended for applications that benefit from low network latency, high network throughput, or both. To provide the lowest latency, and the highest packet-per-second network performance for your placement group, choose an instance type that supports enhanced networking.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html Answer: A

Question No:25
### Why does AWS recommend using stateless cloud applications, when possible?
A. They offer a higher degree of encryption for data in transit.
B. They are more secure than stateful applications.
C. Decoupling layers enables more scalability and resilience
D. They are more always more cost effective than stateful applications. 

Explanation: A stateless application needs no knowledge of previous application actions, and stores no session data, and thus can be scaled horizontally with minimal friction.
Reference: https://d0.awsstatic.com/whitepapers/AWS_Cloud_Best_Practices.pdf Answer: C

Question No:26
### You are managing a group of EC2 instances in your company's VPC. Your VPC has been experiencing much higher network traffic than expected and it is not expected to subside. You are considering using EC2 instances with enhanced networking capability. What benefits can enhanced networking instances provide? (Choose 3 answers)
A. Lower latency
B. Less jitter
C. Less packet loss
D. More packets per second

Explanation: Enhanced networking uses single root I/O virtualization (SR-IOV) to provide high-performance networking capabilities on supported instance types. SR-IOV is a method of device virtualization that provides higher I/O performance and lower CPU utilization when compared to traditional virtualized network interfaces. Enhanced networking provides higher bandwidth, higher packet per second (PPS) performance, and consistently lower inter-instance latencies.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/enhanced-networking.html  Answer: A,B,D

Question No:27
### You have set up an AWS environment which contains several on-demand EC2 instances dedicated to a high profile client that your company is currently involved with. Unfortunately the project has been postponed due to the fact that the company is having a cash flow problem. Consequently you do not want to incur charges for these on-demand instances, but you also want to ensure that you do not lose all of your hard work and hence need to keep all the data that is currently contained on these instances. Which of the following will minimize charges for these instances whilst keeping all the data available for a later time when the project begins again? (Choose 2 answers)
A. Stop all the instances.
B. Take a snapshot of all the instances and then terminate all the instances. 
C. Terminate all the instances.
D. Terminate all the instances and then make an image of all the instances.

Explanation: If you stop the instances you will not be charged and the data will still be kept. If you terminate the instances you will lose all your data. If you take a snapshot of all the instances and then terminate all the instances you will not be charged but will still have all your data in the snapshot which can be restored later. Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html  Answer: A,B

Question No:28
### You have been asked to set up a public website on AWS with the following criteria:
. You want the database and the application web server running on an Amazon VPC.
. You want the database to be able to connect to the Internet so that it can be automatically updated to the correct patch level.
. You do not want to receive any incoming traffic from the Internet to the database.
Which solution would satisfy all of the above requirements for your planned public website on AWS?
A. Deploy both the public website and the database in a public subnet. Assign the database to a security group that only allows access from the IP of the public website.
B. Use CloudFront to sit in front of the database. Configure the database as the origin.
C. Deploy both the public website and the database in a public subnet. Create a network access control list (NACL) and attach to the public subnet that blocks all incoming requests from the Internet.
D. Deploy the public website in a public subnet. Deploy the database in a private subnet which connects to the Internet via a NAT gateway.

Explanation: You want the database to be able to connect to the Internet, so you need to either set it up on a public subnet or set it up on a private subnet which connects to the Internet via a NAT gateway.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Scenario2.html Answer: D

Question No:29
### An EC2 instance has one additional EBS volume attached to it. How can a user attach the same volume to another running instance in the same AZ?
A. No need to detach. Just select the volume and attach it to the new instance, it will take care of mapping internally
B. Attach the volume as read only to the second instance
C. Detach the volume first and attach to new instance
D. Terminate the first instance and only then attach to the new instance 

Explanation: If an EBS volume is attached to a running EC2 instance, the user needs to detach the volume from the original instance and then attach it to a new running instance. The user doesn't need to stop / terminate the original instance.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-detaching-volume.html Answer: C

Question No:30
### A client has requested additional compute power for end-of-year transaction processing. You estimate that they will need an additional 10 servers during a three-day period. You begin creating the servers by specifying the instance type and selecting an AMI. What two key features do the instance type and AMI encapsulate? (Choose 2 answers)
A. The software loaded on the instance
B. The number of virtual licenses for software provided 
C. The key pair for the instance
D. The amount of virtual hardware dedicated to the instance

Explanation: When creating an EC2 instance, by selecting the instance type and the Amazon Machine Image (AMI), you are selecting the the hardware type of the machine and the type of software you want on the machine, respectively. Various Linux types as well as Windows operating systems are available. In certain instances, you can also choose an AMI that comes with a database.
Reference: https://aws.amazon.com/ec2/instance-types/ Answer: A,D

Question No:31
### You have been assigned to a client which is a Federal agency and is utilizing a hybrid cloud environment. The agency distributes large amounts of sensitive data throughout the world. Your task is to ensure that the distribution of this data is secure using various encryption techniques as well as security groups and Access Control Lists. One of the requirements is to distribute content utilizing Cloudfront for optimal performance but to completely restrict access from within certain blacklisted countries. What service can you use with Cloudfront to fulfill this requirement?
A. server side encryption 
B. IAM Roles
C. firewall rules
D. geo restriction 

Explanation: You can use geo restriction, also known as geoblocking, to prevent users in specific geographic locations from accessing content that you're distributing through a CloudFront web distribution.
To use geo restriction, you have two options:
. Use the CloudFront geo restriction feature. Use this option to restrict access to all of the files that are associated with a distribution and to restrict access at the country level.
. Use a third-party geolocation service. Use this option to restrict access to a subset of the files that are associated with a distribution or to restrict access at a finer granularity than the country level.
Reference: http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/georestrictions.html Answer: D
 
Question No:32
### A recovery time objective (RTO) is related to__ , while a recovery point objective (RPO) is related to__ .
A. the actual time for a system to restore; the estimated time for a system to restore 
B. the estimated time for a system to restore; the actual time for a system to restore 
C. data loss measured in time; time required for system restoration
D. time required for system restoration; data loss measured in time

Explanation: A recovery time objective (RTO) is the time it takes to restore system service after a disruption, while a recovery point objective (RPO) is an acceptable amount of data loss measured in time. The two concepts are interrelated. The amount of data loss a business can tolerate usually determines the desired recovery time objective. The desired RTO then generally determines the disaster recovery method.
Reference: https://en.wikipedia.org/wiki/Recovery_point_objective Answer: D

Question No:33
### You are designing a cloud solution for your client which is an accounting company withseveral proprietary applications. Some of these applications are not portable to the cloud and will dictate that you design a hybrid solution. You need to enable traffic flow between the AWS VPC and the on-premises applications and your design will include a VPN to facilitate this communication. A VPN only subnet will need to be created. For a VPN only subnet, where should a route in the route table direct traffic?
A. Jump box
B. On-premises router
C. Virtual Private Gateway 
D. Internet Gateway

Explanation: Each subnet must be associated with a route table, which specifies the allowed routes for outbound traffic leaving the subnet. Every subnet that you create is automatically associated with the main route table for the VPC. If a subnet doesn't have a route to the Internet gateway, but has its traffic routed to a virtual private gateway for a VPN connection, the subnet is known as a VPN-only subnet.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html Answer: C

Question No:34
### Which disaster recovery method generally has the highest RTO and RPO, but requires the least cost, in terms of resources, to restore service?
A. Backup and restore 
B. Multi-site
C. Pilot light
D. Warm standby

Explanation: With the backup and restore method of recovery, data is backed up to an AWS storage service, such as Amazon S3. The data can be imported into AWS using a variety of options such as storage gateway, AWS Snowball (import/export), Direct Connect, VPN or the internet. In the event of a disaster, archives can be recovered from Amazon S3, and the data can then be restored directly to cloud resources. This method takes the longest time, but requires the least investment because it is essentially a system of archiving data consistently and retrieving it when needed. Aside from data transfer and storage, no complex applications or smaller version of your service needs to be kept running offsite.
Reference: https://d1.awsstatic.com/whitepapers/aws-disaster-recovery.pdf Answer: A

Question No:35
### You are leading the migration of a client's compute environment to the cloud. In a requirements meeting, you are discussing the types of EC2 instances needed as well as tenancy options. The majority of the environment can utilize a basic design but you have uncovered some special circumstances. The client has several server bound software licenses that need to be utilized. What tenancy option will best meet this requirement?
A. Dedicated host
B. Shared tenancy
C. Dedicated instance
D. Dual Tenancy

Explanation: Tenancy options provided by AWS are shared tenancy, dedicated instances, and dedicated hosts. An Amazon EC2 Dedicated Host is a physical server with EC2 instance capacity fully dedicated to your use. Dedicated Hosts can help you address compliance requirements and reduce costs by allowing you to use your existing server-bound software licenses.
Reference: https://aws.amazon.com/ec2/dedicated-hosts/ Answer: A

Question No:36
### In regards to AWS infrastructure, a(n) cache data and reduce latency.
A. region
B. edge location
C. data center
D. availability zone
is deployed in highly populated areas to

Explanation: Edge Locations are AWS sites deployed in major cities and highly populated areas. Edge Locations are not used to deploy your main infrastructures. Instead they are used by AWS services such as AWS CloudFront to cache data and reduce latency for end user access. Reference: https://d0.awsstatic.com/whitepapers/AWS_Cloud_Best_Practices.pdf  Answer: B

Question No:37
### What choices below are benefits of using AWS managed services? (Choose 2 answers.)
A. service specialization
B. lower cost and complexity
C. reduced time to market
D. Increased control over the service operating system and custom installations

Explanation: The AWS managed services reduce the amount of development time required to design and implement a working service, and reduce the operational cost, time and technical knowledge required. As a trade-off, developers have less control over how the operating system and other components operate 'under the hood' and managed services in general offer a standard set of options that are not customized for each user.
Reference: https://d0.awsstatic.com/whitepapers/aws-overview.pdf Answer: B,C

Question No:38
### Which choice is a stated benefit of using AWS?
A. system compliance is entirely managed by AWS
B. reduced effort to meet compliance requirements
C. data center servers specifically for your account
D. security configuration is entirely managed by AWS

Explanation: AWS services are designed to comply with common compliance regulations, such as PCI DSS level. You will have to configure services to meet your specific compliance needs, but segments of your IT system on AWS should comply will several standard compliance regulations immediately.
You can request dedicated instances, but you cannot select specific data centers for your account, and with the Shared Responsibility Model, AWS will not assist you in configurations to meet your security or compliance requirements.
Reference: https://d0.awsstatic.com/whitepapers/aws-overview.pdf  Answer: B

Question No:39
### You are managing a very basic blog with no dynamic content on an EC2 instance which uses a mysql database . You post an article that to your surprise goes viral causing millions of people to visit your website. This increase in traffic causes a strain on your DB server which is dynamically servicing the blog content. How might you quickly resolve this issue and make the blog post infinitely scaleable? (Choose 2 answers)
A. Create a static HTML page using S3 and use Route 53 to point the DNS to the static S3 bucket. Use Reduced Redundancy Storage (RRS) on the S3 bucket.
B. Create a static HTML page using S3 and use Route 53 to point the DNS to the static S3 bucket.
C. Use spot EC2 instances to increase your capacity
D. Create a database read replica and route read queries from your applications to the read replica.

Explanation: You can host a static website on Amazon S3. On a static website, individual web pages include static content. They may also contain client-side scripts. Because your storage on Amazon S3 is virtually unlimited you can scale infinitely. You also do not need to service dynamic content so a database is not needed.
Reduced Redundancy Storage (RRS) is an Amazon S3 storage option that enables customers to reduce their costs by storing noncritical, reproducible data at lower levels of redundancy than Amazon S3’s standard storage.
The two answers are correct as using RRS doesn't alter the solution to the problem in any way. Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html Answer: A,B

Question No:40
### You have designed an application which does the following.
. It checks for new items in an S3 bucket once per hour.
. If new items exist, a message is added to an SQS queue.
. It has several EC2 instances which retrieve messages from the SQS queue, parse the file, and send you an email containing the relevant information from the file.
You upload a test file to the bucket, wait a couple hours and find that you have hundreds of emails from the application.
Which of the following is the most likely cause for this volume of email? (Choose 2 answers)
A. To keep multiple instances from processing the same SQS message, your application must delete the SQS message after processing it.
B. Messages are not being deleted following processing. 
C. You are being spammed
D. Your SQS queue is not large enough

Explanation: Many instances can poll a single queue, but to keep multiple instances from processing the same SQS message, your application must delete the SQS message after processing it. While SQS does not guarantee a message will be processed only once, the same message being processed many times is probably an indication that the message is not being deleted following processing Reference: http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-how-i t-works.html#sqs-basic-requirements Answer: A,B

Question No:41
### You are leading the design of your company's AWS cloud environment. Your requirements make it clear that a few departments will require a low latency network and up to 10GB of performance. You decide that ```Placement Groups``` would be a good option for these departments. What requirements for EC2 instances should be met when deployed in Placement Groups? (Choose 2 answers)
A. EC2 instances must be in multi-AZ for fault tolerance.
B. EC2 instances must be reserved instances.
C. EC2 instances must be in a single Availability Zone.
D. Choose instance types that support enhanced networking .

Explanation: A placement group is a logical grouping of instances within a single Availability Zone. Placement groups are recommended for applications that benefit from low network latency, high network throughput, or both. To provide the lowest latency, and the highest packet-per-second network performance for your placement group, choose an instance type that supports enhanced networking.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html Answer: C,D

Question No:42
### You are designing a web application that needs to be highly available and handle a high percentage of read traffic. You are planning on designing a multi-AZ environment for high availability. You are considering using read replicas to help offset some of the read traffic. Your client wants to discuss multiple options for handling large amounts of read traffic. What other option can you suggest to handle the read traffic?
A. Promote the standby server to a read replica when needed. 
B. Store read traffic on Redshift.
C. Use Elasticache to cache frequently used data.
D. Use DynamoDB to handle read traffic.

Explanation: Amazon ElastiCache is a web service that makes it easy to deploy and run Memcached or Redis protocol-compliant server nodes in the cloud. Amazon ElastiCache improves the performance of web applications by allowing you to retrieve information from a fast, managed, in-memory system, instead of relying entirely on slower disk-based databases. Amazon ElastiCache is ideally suited as a front-end for Amazon Web Services like Amazon RDS and Amazon DynamoDB, providing extremely low latency for high performance applications and offloading some of the request volume while these services provide long lasting data durability. Reference: https://aws.amazon.com/elasticache/faqs/ Answer: C

Question No:43
### Which of the following would be considered features of using Elastic Load Balancing to automatically distribute incoming application traffic across multiple Amazon EC2 instances? (Choose 3 answers)
A. Elastic Load Balancing automatically scales its request handling capacity to meet the demands of application traffic.
B. Elastic Load Balancing ensures that only healthy Amazon EC2 instances receive traffic by detecting unhealthy instances and rerouting traffic across the remaining healthy instances.
C. Using Elastic Load Balancing you can quickly deploy and manage applications in the AWS cloud without worrying about the infrastructure that runs those applications.
D. Elastic Load Balancing works with Amazon Virtual Private Cloud (VPC) to provide robust networking and security features.

Explanation: Elastic Load Balancing works with Amazon Virtual Private Cloud (VPC) to provide robust networking and security features. Elastic Load Balancing ensures that only healthy Amazon EC2 instances receive traffic by detecting unhealthy instances and rerouting traffic across the remaining healthy instances. Elastic Load Balancing automatically scales its request handling capacity to meet the demands of application traffic.
CloudFront delivers your content through a worldwide network of edge locations. Using Elastic Beanstalk, you can quickly deploy and manage applications in the AWS Cloud without worrying about the infrastructure that runs those applications.
Reference: https://aws.amazon.com/elasticloadbalancing/ Answer: A,B,D

Question No:44
### You have been assigned to a client with an existing AWS cloud environment. They have a VPC with multiple web servers in a public subnet and database servers in a private subnet. They purchased reserved Linux instances up-front but are finding they underestimated their workload and would like to scale now. What can you do with these instances to scale them without violating the term agreement of these instances?
A. Change to a larger instance of any type.
B. Change to Spot instances of a larger type.
C. Change to a larger instance within the same instance family. D. Change to On-Demand instances of a larger type.

Explanation: A Reserved Instance (RI) is an EC2 offering that provides you with a significant discount on EC2 usage when you commit to a one-year or three-year term. You can modify the Availability Zone of the RI, change the scope of the RI from Availability Zone to region (and vice-versa), change the network platform from EC2-VPC to EC2-Classic (and vice versa) or modify instance sizes within the same instance family (on the Linux/Unix platform).
Reference: https://aws.amazon.com/ec2/faqs/ Answer: C

Question No:45
### You are designing an AWS VPC for a large healthcare organization. The majority of the departments will require basic, low to medium throughput for their day to day operations. But the Radiology and MRI group continually sends very large imaging files and requires low latency and up to 10 Gbps throughput in a single availability zone. What configuration will best meet these requirements?
A. Create the Radiology/MRI instances in a Read Replica Group. B. Use a VPN for Radiology/MRI.
C. Create the Radiology/MRI instances in a Placement Group. D. Use Direct Connect for Radiology/MRI.

Explanation: A placement group is a logical grouping of instances within a single Availability Zone. Placement groups are recommended for applications that benefit from low network latency, high network throughput, or both. To provide the lowest latency, and the highest packet-per-second network performance for your placement group, choose an instance type that supports enhanced networking.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html Answer: C

Question No:46
### You have taken over an account where the client has an existing AWS cloud environment.They have an RDS backend using MySQL. They have a medium sized instance for their database and are using magnetic volumes for their storage. Due to a recent innovation by the company they are expecting an exponential increase in traffic on their website. You plan on scaling up by increasing the instance size of the database and adding read replicas. What other step can you take to scale up the environment?
A. Upgrade from Magnetic storage to General Purpose (SSD). B. Make sure backups are done during off peak hours.
C. Create a multi-AZ environment.
D. Use an Elastic Load Balancer to route traffic efficiently.

Explanation: To handle a higher load in your database, you can vertically scale up your master database quickly by moving to a larger instance size. If you are using magnetic storage you can scale up vertically by upgrading to General Purpose (SSD) storage or even Provisioned IOPS (SSD). To scale horizontally you can add read replicas to offload read traffic.
Reference: https://aws.amazon.com/blogs/database/scaling-your-amazon-rds-instance-vertically-and-h orizontally/  Answer: A

Question No:47
### You've been assigned to a client in the process of designing their AWS Virtual Private Cloud. The technical staff for the client has a basic knowledge of AWS. One of the admins is proposing the use of Network Address Translation (NAT) instances for use with private subnets. You bring up the more recent emergence of NAT Gateways to provide internet access to private subnets. What benefits can using a NAT Gateway instead of a NAT instance provide? (Choose 2 answers)
A. NAT Gateway provides better availability.
B. NAT Gateway provides higher bandwidth.
C. NAT Gateway requires less administrative effort than NAT instances. 
D. NAT Gateways provide auto scaling .

Explanation: NAT gateways provides better availability, and requires less administrative effort. For common use cases, it is recommend that you use a NAT gateway rather than a NAT instance. NAT gateways are in each Availability Zone and are implemented with redundancy. NAT instances use a script to manage failover. NAT Gateways are high bandwidth and support bursts of up to 10Gbps. NAT instance bandwidth is dependent on the bandwidth of the instance type but are typically lower bandwidth than NAT Gateways.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html Answer: A,C

Question No:48
### You've been placed in charge of your company's VPC. Part of your plan is to develop efficient use of auto scaling of EC2 instances and a key to this will be bootstrapping for newly created instances. You want to configure new instances as quickly as possible to get them in to service efficiently upon startup. What benefits of bootstrapping can you utilize? (Choose 3 answers)
A. Bootstrapping can enroll an instance into a directory service. 
B. Bootstrapping can install application software.
C. Bootstrapping can increase network throughput.
D. Bootstrapping can apply patches and OS updates.

Explanation: When you launch an instance in Amazon EC2, you have the option of passing user data to the instance that can be used to perform common automated configuration tasks and even run scripts after the instance starts. You can pass two types of user data to Amazon EC2: shell scripts and cloud-init directives.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/user-data.html Answer: A,B,D

Question No:49
### You are helping a client design a static website which will potentially grow exponentially in the first few years of existence. You outline the benefits of using S3 to host this Website. What characteristics of S3 elasticity and scalability can you feature? (Choose 2 answers)
A. S3 supports an unlimited number of files in a bucket.
B. S3 bucket names can be replicated in multiple regions.
C. S3 asynchronously replicates information to all availability zones within a region. 
D. S3 asynchronously replicates information to other regions.

Explanation: With Amazon S3, you can store as much data as you want and access it when needed. S3 supports and unlimited number of files in a bucket so it is not necessary to know your storage needs up front or try to estimate. S3 can be scaled quickly and appropriately to meet the storage demands of your environment. S3 asynchronously replicates information to all availability zones within a region. Amazon S3 scales to support very high request rates. If your request rate grows steadily, Amazon S3 automatically partitions your buckets as needed to support higher request rates.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/request-rate-perf-considerations.html Answer: A,C

Question No:50
### You run a stateless web application with the following components:
. An Elastic Load Balancer.
. Web/Application servers on EC2.
. A MySQL RDS database with 3000 provisioned IOPS.
You notice that the average response time for users is increasing. Looking at CloudWatch, you observe 97% CPU usage on the Web/Application servers and 20% CPU usage on the database. The average number of database disk operations varies between 1000 and 1500. How would you improve performance? (Choose 2 answers)
A. Use Auto Scaling to add additional Web/Application servers based on CPU load threshold 
B. Use Amazon RDS Read Replicas to improve your IOPS
C. Choose a different EC2 instance type for the Web/Application servers with a more appropriate CPU/Memory ratio
D. Increase your provisioned IOPS to 5000

Explanation: Because of the 97% CPU usage on the Web/Application servers using larger instance types or using auto scaling to add more servers will alleviate this problem.
You have 3000 provisioned IOPS and the average number of database disk operations varies between 1000 and 1500 so you do not need to change your database at all.
Reference: https://d0.awsstatic.com/whitepapers/aws-web-hosting-best-practices.pdf Answer: A,C

Question No:51
### You are setting up your company's Virtual Private Cloud (VPC). It is time to select the virtual hardware and the software to be provisioned for the instances you will launch within the VPC. You will do this by selecting the Instance Types and Amazon Machine Images (AMI). Which item is ```not defined``` by the AMI?
A. Virtual CPUs
B. Operating system
C. The initial state of any patches 
D. Application or System Software

Explanation: An Amazon Machine Image (AMI) is a template that contains a ```software configuration``` (for example, an operating system, an application server, and applications). The AMI includes the operating system, initial state of any patches, and any application software. For example, you can select an AMI that has SQL Server. The virtual CPUs are not part of the AMI but are defined by the instance type.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html Answer: A

Question No:52
### You are managing cloud storage for your company, which wants the technical staff to have some latitude in managing the buckets under your supervision. In an effort to increase visibility and accountability on bucket management, you'd like to know who is accessing the buckets, and to be notified of delete actions. What features can provide this information for S3 buckets? (Choose 2 answers)
A. Enable S3 server access logs on the buckets.
B. Enable bucket monitoring.
C. Turn on event notifications for delete actions. 
D. Enable CloudWatch on the buckets.

Explanation: S3 Event Notifications can be set up on objects stored in S3. An event could be set up to notify when a delete is performed. Logging is turned off by default but can be enabled. When enabled, they can track requests to your S3 bucket.
S3 Server Access Logging tracks detailed information not currently available with CloudWatch metrics or CloudTrail logs. To track requests for access to your bucket, you can enable access logging. Each access log record provides details about a single access request, such as the requester, bucket name, request time, request action, response status, and error code, if any. Access log information can be useful in security and access audits. It can also help you learn about your customer base and understand your Amazon S3 bill.
For more on server access logs (https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerLogs.html)
For more on event notifications (https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html)
Reference: https://aws.amazon.com/s3/faqs/ Answer: A,C

Question No:53
### You are deploying a two-tiered web application with web servers in a public subnet of your VPC and your database isolated in a private subnet. Your requirements call for the web tier to be highly available. Which services listed will be needed to make the web-tier highly available. (Choose 3 answers)
A. Route 53
B. Elastic Load Balancer 
C. Multi-AZ for RDS
D. Auto Scaling

Explanation: The key is that the requirement is for high availability at the web-tier. While multi-AZ deployments and cross-region replication can contribute to high availability, they are each at the storage tier. Route 53 with Health Checks and Failover, Elastic Load Balancer (with ealth checks and various forms of load balancing, and auto scaling groups create high availability at the web tier.
Reference: https://d0.awsstatic.com/whitepapers/AWS_Cloud_Best_Practices.pdf Answer: A,B,D

Question No:54
### You have been chosen to lead the design of an AWS cloud environment for an accounting firm. The firm needs high availability and scalability and your team is considering a multi-AZ deployment. In addition, the firm expects to need Online Analytics processing (OLAP) for their Actuarial Department. What AWS service is best to meet the OLAP requirement?
A. Amazon RDS with DynamoDB for caching 
B. Amazon Elasticahe
C. Amazon RDS
D. Amazon Redshift
 
Explanation: Amazon Redshift is a fast, fully managed data warehouse that makes it simple and cost-effective to analyze all your data using standard SQL and your existing Business Intelligence (BI) tools. It allows you to run complex analytic queries against petabytes of structured data, using sophisticated query optimization, columnar storage on high-performance local disks, and massively parallel query execution.
Reference: https://aws.amazon.com/redshift/ Answer: D

Question No:55
### You are working for a government contractor as an AWS Cloud Architect. You had to get a security clearance for the job and the company data is extremely sensitive. You need to design an environment which protects data at rest as well as in transit. The first step in your design is to use https (port 443) with server certificate authentication for data in transit. What other step can you take to secure data in transit?
A. Use Identity and Access Management roles. B. Use 7zip to encrypt data.
C. Use server-side encryption.
D. Use SSL/TLS for the database connection.

Explanation: AWS Certificate Manager is a service that lets you easily provision, manage, and deploy Secure Sockets Layer/Transport Layer Security (SSL/TLS) certificates for use with AWS services. You can use SSL from your application to encrypt a connection to a DB instance running MySQL, MariaDB, Amazon Aurora, SQL Server, Oracle, or PostgreSQL.
Reference: https://aws.amazon.com/certificate-manager/ Answer: D

Question No:56
### Amazon CloudWatch monitors your Amazon Web Services (AWS) resources and the applications you run on AWS in real time. You have been given the task of setting up a number of services to be used in conjunction with CloudWatch. Which of the following services could be used to accomplish your task? (Choose 3 answers)
A. Amazon Simple Notification Service (Amazon SNS) 
B. Auto Scaling
C. AWS Direct Connect
D. AWS Identity and Access Management (IAM)

Explanation: The following services are used in conjunction with Amazon CloudWatch:
. Amazon Simple Notification Service (Amazon SNS).
. Auto Scaling enables you to automatically launch or terminate Amazon EC2 instances based on user-defined policies, health status checks, and schedules.
. AWS CloudTrail enables you to monitor the calls made to the Amazon CloudWatch API for your account, including calls made by the AWS Management Console, AWS CLI, and other services. Reference: http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/WhatIsCloudWatch.html Answer: A,B,D

Question No:57
### You have been contracted by a client to move their compute environment to the cloud. They have several web servers and two MySQL databases in a multi-tier environment. They need all servers to be highly available.. They would like their database to have the speed and reliability of a high-end database but do not have the resources to convert their queries. Which RDS option best meets these requirements?
 
A. Aurora
B. Oracle
C. SQL Server 
D. MySQL

Explanation: Amazon supports MySQL but it is not the best option in this instance for speed and reliability. Oracle and SQL Server meet the requirement of speed and reliability but will require rewriting of most queries. Amazon Aurora is a relational database engine that combines the speed and reliability of high-end commercial databases with the simplicity and cost- effectiveness of open source databases. Amazon Aurora with MySQL-compatibility delivers up to five times the performance of MySQL without requiring any changes to most MySQL applications.
Reference: https://aws.amazon.com/rds/aurora/faqs/ Answer: A

Question No:58
### You are assigned to lead your company's migration to an AWS cloud environment. Your company has a large software development division and you are gathering requirements for their instances as well as EBS volumes. This department will often have multiple projects going on at one time, which calls for multiple dev, test, and prod environments. They want dev and test to simulate production loads so they will be moderately IO intensive. What type of EBS volume is best suited for dev and test environments?

A. Magnetic volumes
B. Instance Store volumes 
C. Provisioned IOPS SSD 
D. General purpose SSD

Explanation: Amazon RDS provides three storage types: magnetic, General Purpose (SSD), and Provisioned IOPS (input/output operations per second). They differ in performance characteristics and price, allowing you to tailor your storage performance and cost to the needs of your database workload. General Purpose (SSD), also called gp2, volumes offer cost-effective storage that is ideal for a broad range of workloads.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html Answer: D

Question No:59
### A media company has contracted you to design their AWS cloud environment. They host websites and have many well known bloggers who post daily and weekly blogs as well as podcasts. Your analysis of their existing traffic reveals that their database traffic will be nearly 90% read traffic. From this analysis your design will include read replicas so you know that you have to choose a database engine which supports read replicas. Which AWS RDS engines support read replicas?

A. Oracle and SQL Server
B. MySQL, MariaDB, PostgreSQL, Aurora 
C. They all support read replicas
D. MySQL, SQL Server, Oracle
 
Explanation: Amazon RDS Read Replicas provide enhanced performance and durability for database (DB) instances. This replication feature makes it easy to elastically scale out beyond the capacity constraints of a single DB Instance for read-heavy database workloads. You can create one or more replicas of a given source DB Instance and serve high-volume application read traffic from multiple copies of your data, thereby increasing aggregate read throughput. Read replicas can also be promoted when needed to become standalone DB instances.
Read replicas are available in Amazon RDS for MYSQL, MariaDB, PostgreSQL, and Aurora. Reference: https://aws.amazon.com/rds/details/read-replicas/ Answer: B

Question No:60
### Your client, a media company, wants to transfer large video files to AWS cloud storage. You recommend implementing multipart uploading and need to define an uploading policy for them. The policy needs to clearly define the parameters for when multipart uploading should be used. Which rules belong in this policy? (Choose 3 answers)

A. Multipart uploads must be used for objects greater than 5 GB.
B. Multipart uploads should be used for objects greater than 100 MB. 
C. Multipart uploads should be used when the object size is unknown.
D. Multipart uploads must be used for objects greater than 50 MB.
 
Explanation: In general, multipart upload should be used for objects greater than 100 MB. It must be used for objects greater than 5 GB. You can set an object lifecycle to delete incomplete multipart uploads after a certain period of time. This will save storage costs on uploads that have been aborted for various reasons.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html Answer: A,B,C

Question No:61
### A bucket owner from Account Red allows Account Blue's IAM users to upload or access objects in his bucket. An IAM user of Account Blue is trying to access an object created by the IAM user of account Red. What will happen in this scenario?

A. It is not possible to give permission to multiple IAM users
B. Amazon S3 will verify proper rights given by the owner of Account Blue to the IAM user, the permissions granted by bucket owner, as well as the permissions given by IAM user Red to the object.
C. It is not possible that the IAM user of one account accesses objects of the other IAM user 
D. The bucket policy may not be created as S3 will give error due to conflict of Access Rights

Explanation: If a IAM user is trying to perform some action on an object belonging to another AWS user’s bucket, S3 will verify whether the owner of the IAM user has given sufficient permission to him. It also verifies the policy for the bucket as well as the policy defined by the object owner.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-auth-workflow-object-ope ration.html Answer: B

Question No:62
### You are placed in charge of migrating a client to an AWS cloud environment. One of the first steps you want to take is getting a plan in place for user account, other accounts, and Identity and Access Management. You plan on creating administrator accounts then locking away the root account. You notice that the client has several Service Accounts for access to applications in their on-premises environment. Given that all their applications can be migrated to the cloud,

what would be an appropriate replacement for these service accounts? 
A. Cross-account access for access to the applications
B. Services Account should be migrated to AWS
C. Federation for access to the applications
D. Amazon EC2 roles for access to the applications

Explanation: Applications must sign their API requests with AWS credentials. Therefore, if you are an application developer, you need a strategy for managing credentials for your applications that run on EC2 instances. It is best practice to use IAM roles so that your applications can securely make API requests from your instances, without requiring you to manage the security credentials that the applications use.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/iam-roles-for-amazon-ec2.html Answer: D

Question No:63
### A user is accessing an EC2 instance on the SSH port from IP address 10.20.30.40/32. Which one is a secure way to configure that the instance can be accessed only from this IP address?

A. In the security group, open port 22 for IP 10.20.30.40/0 
B. In the security group, open port 22 for IP 10.20.30.40
C. In the security group, open port 22 for IP 10.20.30.40/32 
D. In the security group, open port 22 for IP 10.20.30.0

Explanation: In AWS EC2, while configuring a security group, the user needs to specify the IP address in CIDR notation. The CIDR IP range 10.20.30.40/32 says it is for a single IP 10.20.30.40. If the user specifies the IP as 10.20.30.40 only, the security group will not accept and ask for it in a CIDR format.Answer: C
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html
 
Question No:64
### If you do not specify a security group when launching an Amazon EC2 instance, the instance will be associated with the security group.

A. default
B. placement group 
C. account
D. subnet

Explanation: Your AWS account automatically has a default security group per VPC for EC2- VPC and per region for EC2-Classic. If you don't specify a security group when you launch an instance, the instance is automatically associated with the default security group. A default security group is named default, and it has an ID assigned by AWS. The default rules for such a security group are to allow all inbound traffic from other instances associated with the default security group, and all outbound traffic.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html#defau lt-security-group Answer: A

Question No:65
### You are asked to temporarily share AWS S3 bucket content within your organization. You begin setting up pre-signed URLs on individual buckets. For pre-signed URLs, you must provide several pieces of data. Which of the listed items must you provide? (Choose 3 answers)
A. Your bucket name
B. The availability zone of your bucket
C. The expiration date and time of the URL D. Your security credentials
Answer: A,C,D
Explanation: All Amazon S3 objects by default are private. But the object owner can share objects with others by using a pre-signed URL. The pre-signed URLs are valid only for a specified period of time.
 
AWS_SAA-C01 Exam
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/PresignedUrlUploadObject.html
Question No:66
Can you encrypt connections between your application and your MySQL DB Instance using SSL?
A. Yes, you can but only in certain regions. B. Yes, you can but only in VPC.
C. Yes
D. No
Answer: C
Explanation: Yes, you can encrypt connections between your application and your DB instance using SSL if your DB instance is one among MySQL, SQL Server, Oracle, and PostgreSQL engines.
Reference: http://aws.amazon.com/rds/faqs/
Question No:67
You are assigned to a new client that is moving from on-premises to a hybrid solution. The client insists that the cloud portion have a firewall. You explain that the firewall in the cloud is virtual and is called a Security Group. You've created new instances and have Security Groups attached to them. You are creating Security Group rules based on source/destination. What information can you provide for the source/destination? (Choose 2 answers)
A. Another Security Group
B. DNS names of instances
C. Another NACL
D. CIDR Block defining a range of IP addresses Answer: A,D
Explanation: You can control traffic with Security Groups based on port, protocol, and source/destination. With source/destination, you can specify the CIDR Block (x.x.x.x/x format)
 
AWS_SAA-C01 Exam
or another Security Group. When specifying another Security Group, the rule created applies to all instances attached to that Security Group.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html
Question No:68
You are managing an environment with a secured web application, running on an EC2 instance, which requires internal application access to put and get objects to/from an S3 bucket. Of the policies listed below, which allow puts and gets for an S3 bucket? (Choose 2 answers)
A. IAM Trust Policy to allow web application running on EC2 instance access to put/get objects
B. S3 Bucket Trust policy that allows EC2 instance to assume S3Admin role to put/get objects to this bucket
C. IAM Policy allows the allows the role assumed by EC2 instance access to put/get objects D. S3 Bucket policy that allows the role assumed by EC2 instance access to put/get objects Answer: C,D
Explanation: For internal communication with S3 from an application running on EC2 instance, you need two policies:
. An IAM trust policy that allows the EC2 instance to assume a role
. An IAM policy or S3 bucket policy that allows the role to get/put objects to the specific bucket So, the kind of policies that control access to S3 bucket are either an IAM Policy or S3 Bucket Policy. The IAM trust policy is required, but it doesn't control access to S3.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html
Question No:69
Authenticating a request in Amazon S3 includes the following three steps. 1. AWS creates an HMAC-SHA1 signature.
2. AWS retrieves a secret access key.
3. AWS compares signatures.
Which of the following lists those steps in the correct order?
A. 1, 3 and then 2 B. 3, 1 and then 2 C. 1, 2 and then 3
 
AWS_SAA-C01 Exam
D. 2, 1 and then 3
Answer: D
Explanation: When making a REST call, Amazon S3 will receive the request. The correct sequence is given below. AWS retrieves a secret access key. AWS creates an HMAC-SHA1 signature. AWS compares signatures.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/S3_Authentication2.html
Question No:70
Changing an instance's security groups in Amazon EC2-VPC changes the security groups associated with the instance’s primary .
A. IP address
B. virtual private cloud C. network interface D. storage volume Answer: C
Explanation: Security groups in Amazon EC2-VPC are associated with network interfaces. Changing an instance's security groups changes the security groups associated with the primary network interface (eth0).
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html#vpc-s ecurity-groups
Question No:71
A client has contracted you on a cloud storage project and have major compliance requirements that they need to meet. They've been directed by auditors to disperse backups geographically. You recommend S3 buckets with cross-region replication for backups. What would you need to do to implement cross-region replication? (Choose 3 answers)
A. Turn on versioning for the destination bucket. B. Turn on versioning for the source bucket.
C. Choose an Availability Zone within your region.
  
AWS_SAA-C01 Exam
D. Use an IAM Policy to permit S3 to replicate your objects.
Answer: A,B,D
Explanation: To enable cross-region replication, versioning must be turned on for the source and destination buckets. An IAM Policy must also be set up to give S3 permission to replicate objects on your behalf. Once turned on, cross-region replication will only replicate new objects. Existing objects must be manually copied.
Reference: https://aws.amazon.com/s3/faqs/
Question No:72
You are working with a client in the creation of an AWS cloud environment. Their network engineer has experience with wide area networks and routing but no AWS cloud experience. You explain some of the finer points about Amazon Virtual Private Cloud and how a VPC handles routing differently. What are some features of VPC routing that you can explain? (Choose 2 answers)
A. Your VPC has an implicit router.
B. You are limited to one route table per VPC.
C. Your VPC comes with a main route table that you can modify. D. You cannot replace the default route table.
Answer: A,C
Explanation: The following are the basic things that you need to know about route tables: . Your VPC has an implicit router.
. Your VPC automatically comes with a main route table that you can modify.
. You can create additional custom route tables for your VPC.
Each subnet must be associated with a route table, which controls the routing for the subnet. If you don't explicitly associate a subnet with a particular route table, the subnet is implicitly associated with the main route table. You cannot delete the main route table, but you can replace the main route table with a custom table that you've created (so that this table is the default table each new subnet is associated with).
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html
Question No:73
A user has stored his objects in an S3 bucket owned by a separate AWS account. Now this user
 
AWS_SAA-C01 Exam
wants to make those objects public. What can the AWS bucket owner do to allow the other user (and only this user) to make these objects public?
A. Grant the user access via object ACLs
B. Make the bucket public with full access
C. Create an IAM user with permission
D. Redefine the policy for the bucket to grant access to the user Answer: A
Explanation: An S3 object ACL is the only way to manage access to objects which are not owned by the bucket owner. An AWS account that owns the bucket can grant another AWS account permission to upload objects. The bucket owner does not own these objects. The AWS account that created the object must grant permissions using object ACLs.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/access-policy-alternatives-guidelines.ht ml
Question No:74
Your supervisor asks you to set up a NAT gateway so that your private subnets can communicate with the Internet. Which of the following are the things that you will need to do to ensure this works successfully? (Choose 3 answers)
A. Specify an Elastic IP address to associate with the NAT gateway when you create it
B. Open port 80 to all incoming traffic
C. Specify the public subnet in which the NAT gateway will reside.
D. Update the route table associated with one or more of your private subnets to point Internet-bound traffic to the NAT gateway
Answer: A,C,D
Explanation: To create a NAT gateway, you must specify the public subnet in which the NAT gateway will reside. You must also specify an Elastic IP address to associate with the NAT gateway when you create it. After you've created a NAT gateway, you must update the route table associated with one or more of your private subnets to point Internet-bound traffic to the NAT gateway. This enables instances in your private subnets to communicate with the Internet.
 
AWS_SAA-C01 Exam
Each NAT gateway is created in a specific Availability Zone and implemented with redundancy in that zone. You have a limit on the number of NAT gateways you can create in an Availability Zone.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-nat-gateway.html#nat-gate way-basics
Question No:75
A user has launched an AWS Linux EC2 instance with a key-pair file. The user needs to find where the public key (attached to the instance) is stored. In which folder should the user search for the public key file that will be used for SSH authentication?
A. ~/.ssh/keys/authorized_keys B. /ssh/ssh_keys
C. ~/.ssh/authorized_keys
D. /.ssh/authorized_keys Answer: C
Explanation: When the user launches an Amazon EC2 Linux instance using the cloud-init service, the new instance from a standard AWS AMI is launched and the public key of the Amazon EC2 key pair is appended to the initial operating system user's ~/.ssh/authorized_keys file.
Reference: https://d0.awsstatic.com/whitepapers/aws-security-best-practices.pdf
Question No:76
You have been handed a new scope of work from your manager which involves migrating an on-premise application architecture to AWS. During your design process you have to give consideration to current on-premise security and determine which security attributes you are responsible for on AWS and which is the responsibility of AWS. Which of the following is the responsibility of AWS as part of the shared responsibility model? (Choose 3 answers)
A. Virtualization infrastracture B. Edge Locations
C. Data Center Hardware
 
AWS_SAA-C01 Exam
D. Client side Encryption
Answer: A,B,C
Explanation: While AWS manages security of the cloud, security in the cloud is the responsibility of the customer. Customers retain control of what security they choose to implement to protect their own content, platform, applications, systems and networks, no differently than they would for applications in an on-site datacenter.
Reference: https://aws.amazon.com/compliance/shared-responsibility-model/
Question No:77
An Amazon IAM allows applications or users to securely make API requests from your EC2 instances without requiring you to manage the security credentials required for access.
A. group
B. role
C. permission D. policy Answer: B
Explanation: Applications must sign their API requests with AWS credentials. Therefore, if you are an application developer, you need a strategy for managing credentials for your applications that run on EC2 instances. It can be challenging, however, to securely distribute credentials to each instance, especially those that AWS creates on your behalf. Amazon IAM roles were designed to allow your applications to securely make API requests from your instances, without requiring you to manage the security credentials that the applications use.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/iam-roles-for-amazon-ec2.html
Question No:78
Which of the following would be considered identity-based permissions in relation to IAM? (Choose 2 answers)
A. You grant a user access to manage his own IAM security credentials.
B. You assign permissions to an IAM user, stating that he has permission to use the Amazon Elastic Compute Cloud (Amazon EC2) RunInstances action and that he has permission to get
 
AWS_SAA-C01 Exam
items from an Amazon DynamoDB table named MyCompany.
C. You grant all users in your AWS account read/write access to Amazon SQS queues
D. You grant users Ben and Jerry access to EC2 instances. Ben is granted read access whilst Jerry is granted Read/write access
Answer: A,B
Explanation: In AWS IAM permissions can be assigned in two ways. Those being identity-based and resource-based. Identity-based, or IAM permissions are attached to an IAM user, group, or role and let you specify what that user, group, or role can do whilst Resource-based permissions are attached to a resource.
Reference: http://docs.aws.amazon.com/IAM/latest/UserGuide/access_permissions.html
Question No:79
Amazon S3 Access Control Lists (ACLs) can be applied at the:
A. Bucket, Object and storage class level B. Object level only
C. Bucket and Object level
D. Bucket level only
Answer: C
Explanation: S3 ACLs allow identities to access specific objects within buckets a different layered approach than bucket policies which are applied at the bucket level only. ACLs allow you to set certain permissions on each individual object within a specific Bucket.
These ACLs do not follow that same format as the policies defined by IAM and Bucket policies, instead they are far less granular and different permissions can be applied depending if you are applying an ACL at the bucket or object level.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html
Question No:80
You are Lead Architect for your company's AWS cloud environment. The company has had a few bad quarters and you've been asked to cut some costs in the cloud environment. You make sure that your auto scaling groups are functioning efficiently and elastically and that you aren't over paying. You also write a Lambda function which will stop idle instances during off hours. Finally,
 
AWS_SAA-C01 Exam
you identify 10 EC2 reserved instances which are only being used sporadically. What can you do?
A. Convert these reserved instances to on-demand instances. B. Ask Amazon to void the contract on these instances.
C. Convert these reserved instances to spot instances.
D. Sell some of the reserved instances on Amazon Marketplace. Answer: D
Explanation: Selling unused reservations in the Reserved Instance Marketplace allows you to move to new configurations when your business needs change or if you have unneeded capacity. As soon as you list your Reserved Instances in the Reserved Instance Marketplace, they are available for potential buyers to find. All Reserved Instances are grouped according to the duration of the term remaining and the hourly price.
You own your Reserved Instance until it's sold. After the sale, you've given up the capacity reservation (if the Reserved Instances were purchased for an Availability Zone) and the discounted recurring fees. If you continue to use your instance, AWS charges you the On- Demand price starting from the time that your Reserved Instance was sold.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-selling-guide.html
Question No:81
Which of the following best describes a forecast in AWS billing account?
A. A prediction of how much you will use AWS over the next month, based on your past usage
B. A prediction of how much you will use AWS over the next three months, based on your past usage
C. A prediction of how much you will use AWS over the next six months, regardless of your past usage
D. A prediction of how much you will use AWS over the next nine months, regardless of your past usage
Answer: B
Explanation: With reference to forecasting with Cost Explorer in your AWS billing account, a
 
AWS_SAA-C01 Exam
forecast is a prediction of how much you will use AWS over the next three months, based on your past usage. Forecasting provides an estimate of what your AWS bill will be, which then enables you to use alarms and budgets for amounts that you are predicted to use, and because forecasts are predictions, the forecasted billing amounts are estimated, and might differ from youractual charges for each statement period.
Reference: http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-forecast.html
Question No:82
How many hs1.8xlarge Spot Instances can a user run in one region without any limit increase approval from AWS?
A. None B. 20
C. 5
D. 10 Answer: A
Explanation: In Amazon EC2, you are limited to running up to 20 On-Demand instances, purchasing 20 Reserved Instances, and requesting Spot Instances per your dynamic Spot limit per region. New AWS accounts may start with limits that are lower. For hs1.8xlarge, AWS does not support the Spot Instance.
Reference: https://aws.amazon.com/ec2/faqs/
Question No:83
In Amazon CloudFront, Public URLs allow users to access   .
A. only objects in an Amazon S3 bucket that end users must access through CloudFront but that don't require a signed URL
B. None of the answers are correct
C. only instances that separate multiple, non-overlapping instances of the same instance type D. copies of the static content in one of the edge locations that require a signed URL
Answer: A
 
AWS_SAA-C01 Exam
Explanation: When you create a distribution, you receive the CloudFront domain name associated with that distribution. You use that domain name when creating the links to your objects. If you have another domain name that you'd rather use (for example, www.example.com), you can add a CNAME alias. When you create URLs to give end users access to objects in your CloudFront distribution, the URLs are either public URLs or signed URLs. Public URLs allow users to access the following objects:
. Objects on which there are no restrictions
. Objects in an Amazon S3 bucket that end users must access through CloudFront but that don't require a signed URL.
. These objects can't be accessed using an Amazon S3 URL.
Reference: http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/LinkFormat.html
Question No:84
You want to get a simple website up and running. You will be the only user for the foreseeable future. Of the options available below, which of the following Amazon services would be the most appropriate in this situation? (Choose 2 answers)
A. One Elastic IP address
B. Three g2.8xlarge instances C. Amazon Redshift
D. One t2.micro instance Answer: A,D
Explanation: In this case, you don’t need a huge instance (so a t2.micro will suffice) and one instance can run the entire web stack (so you only need one instance total). You don’t need a separate database and Amazon Redshift is for data warehousing. Having an Elastic IP address and attaching it to your instance prevents the public DNS address for your instance from changing and breaking any installations you may have.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html
Question No:85
What is one function of an AWS Snowball?
A. To transfer petabyte-scale data into and out of the AWS cloud B. To transfer exabyte-scale data into and out of the AWS cloud
 
AWS_SAA-C01 Exam
C. To migrate databases into and out of AWS
D. To migrate thousands of on-premises workloads to AWS Answer: A
Explanation: AWS Snowball is a petabyte-scale data transport solution that can be used to securely transfer large amounts of data into and out of the AWS cloud.
Reference: https://aws.amazon.com/snowball/
Question No:86
An AWS account wants to be part of the consolidated billing of his organization’s payee account. How can the owner of that account achieve this?
A. The owner of the linked account requests the payee account to add his account to consolidated billing
B. The payee account has to request AWS support to link the other accounts with his account
C. The owner of the linked account should add the payee account to his master account list from the billing console
D. The payee account will send a request to the linked account to be a part of consolidated billing
Answer: D
Explanation: AWS consolidated billing enables the organization to consolidate payments for multiple Amazon Web Services (AWS) accounts within a single organization by making a single paying account. To add a particular account (linked) to the master (payee) account, the payee account has to request the linked account to join consolidated billing. Once the linked account accepts the request henceforth all charges incurred by the linked account will be paid by the payee account.
Reference: http://docs.aws.amazon.com/awsaccountbilling/latest/about/consolidatedbilling.html
Question No:87
You want to create an application that only runs when your shop is open (9am-5pm Monday through Thursday). What payment option would make the most sense for you?
A. Reserved Instances
 
AWS_SAA-C01 Exam
B. Spot Instances
C. Scheduled Instances D. Dedicated Instances Answer: C
Explanation: Scheduled Reserved Instances (Scheduled Instances) enable you to purchase capacity reservations that recur on a daily, weekly, or monthly basis, with a specified start time and duration, for a one-year term. You reserve the capacity in advance, so that you know it is available when you need it. Scheduled Instances are a good choice for workloads that do not run continuously, but do run on a regular schedule, hence why it would be fit for an application that needs to only run during regular business hours.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-scheduled-instances.html
Question No:88
Your client is an international travel company which serves users all over the world. Their website has high definition travel videos which help promote travel destinations. They have asked for improvements in the speed of delivering this content and you recommend CloudFront. They would like to restrict access of this content to premium level subscription customers as well as restrict specific countries. What techniques can be used to meet these requirements? (Choose 2 answers)
A. geo-restriction based on ip address B. sticky sessions
C. access control lists by username D. signed URLs
Answer: A,D
Explanation: Geo-restriction allows CloudFront to restrict access to request originating from certain IP addresses. Use this option to restrict access to all of the files that are associated with a distribution and to restrict access at the country level. Signed URLs can be distributed to appropriate users and will expire after a specified time.
Reference: https://aws.amazon.com/cloudfront/
 
AWS_SAA-C01 Exam
Question No:89
You have been assigned to a client who would like to do a large scale migration of their data to an AWS cloud environment. The expected size of this migration is 40-60 terabytes. You have proposed using AWS Import/Export services for this migration. What can you tell them about the AWS Import/Export services to ensure them that this is the correct service for this migration? (Choose 3 answers)
A. AWS Import/Export is a service that accelerates transferring data into and out of AWS using physical storage disks or appliances, bypassing the Internet.
B. You can load data to S3 in file sizes up to 5 GB.
C. The AWS Snowball service is a secure Import /Export appliance that can be used to transfer large amounts of data into and out of AWS.
D. You can load data to Amazon S3 in file sizes up to 5 TB.
Answer: A,C,D
Explanation: AWS Import/Export is a service that accelerates transferring large amounts of data into and out of AWS using physical storage appliances, bypassing the Internet. AWS Import/Export supports transfers data directly onto and off of storage devices you own using the Amazon high-speed internal network.
Reference: http://docs.aws.amazon.com/AWSImportExport/latest/DG/whatisdisk.html
Question No:90
Which one of the following directives tells Amazon CloudFront to keep an associated object in the CloudFront edge cache for one hour?
A. Cache-Control: timeout=1
B. Cache-Control: max-age=3600 C. Cache-Control: max-age=1
D. Cache-Control: timeout=3600 Answer: B
Explanation: In Amazon CloudFront, the Cache-Control max-age directive lets you specify how long (in seconds) you want the object to remain in the cache before CloudFront gets the object again from the origin server.
 
AWS_SAA-C01 Exam
Reference: http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html
Question No:91
You have a large number of objects stored on Amazon S3 and you noticed that the majority of the workload consists of GET requests.
Which service is recommended by AWS to use for performance optimization?
A. Amazon CloudFront B. AWS Storage Gateway C. Amazon EBS
D. Amazon ElastiCache Answer: A
Explanation: If your workload on Amazon S3 is mainly sending GET requests, you should consider using Amazon CloudFront for performance optimization. Integrating Amazon CloudFront with Amazon S3, you can distribute content to your users with low latency and a high data transfer rate. You will also send fewer direct requests to Amazon S3, which will reduce your costs.
For example, suppose you have a few objects that are very popular. Amazon CloudFront will fetch those objects from Amazon S3 and cache them. Amazon CloudFront can then serve future requests for the objects from its cache, reducing the number of GET requests it sends to Amazon S3.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/request-rate-perf-considerations.html
Question No:92
An organization is planning to create 5 different AWS accounts considering various security requirements. The organization wants to use a single payee account by using the consolidated billing option. Which of the below mentioned statements is true with respect to the above information?
A. Master (Payee) account will get only the total bill and cannot see the cost incurred by each account
B. Each AWS account needs to create an AWS billing policy to provide permission to the payee account
 
AWS_SAA-C01 Exam
C. Master (Payee) account can view only the AWS billing details of the linked accounts
D. It is not recommended to use consolidated billing since the payee account will have access to the linked accounts
Answer: C
Explanation: AWS consolidated billing enables the organization to consolidate payments for multiple Amazon Web Services (AWS) accounts within a single organization by making a single paying account. Consolidated billing enables the organization to see a combined view of the AWS charges incurred by each account as well as obtain a detailed cost report for each of the individual AWS accounts associated with the paying account. The payee account will not have any other access than billing data of linked accounts. Reference: http://docs.aws.amazon.com/awsaccountbilling/latest/about/consolidatedbilling.html
Question No:93
You are designing a cloud service based on AWS and your supervisor tells you to use Infrequent Access storage class on S3 instead of S3 standard storage. What considerations should you factor in when building your application around IA on S3 instead of S3 standard storage? (Choose 3 answers)
A. Both IA and standard storage class support SSL encryption of data in transit and at rest. B. IA provides 99.9% availability over a given year.
C. IA has the same low latency and high throughput performance of standard storage class. D. IA does not support support lifecycle management for automatic migration of objects Answer: A,B,C
Explanation: Amazon S3 Standard - Infrequent Access (Standard - IA) is an Amazon S3 storage class for data that is accessed less frequently, but requires rapid access when needed. Standard - IA offers the high durability, throughput, and low latency of Amazon S3 Standard, with a low per GB storage price and per GB retrieval fee. This combination of low cost and high performance make Standard - IA ideal for long-term storage, backups, and as a data store for disaster recovery. The Standard - IA storage class is set at the object level and can exist in the same bucket as Standard, allowing you to use lifecycle policies to automatically transition objects between storage classes without any application changes.
Reference: https://aws.amazon.com/s3/reduced-redundancy/
 
AWS_SAA-C01 Exam
Question No:94
An organization has been using AWS for a few months. The finance team wants to visualize the pattern of AWS spending. Which of the below AWS tools will help for this requirement?
A. AWS CloudWatch
B. AWS Cost Manager
C. AWS Cost Explorer
D. AWS Consolidated Billing Answer: C
Explanation: The AWS Billing and Cost Management console includes the Cost Explorer tool for viewing AWS cost data as a graph. It does not charge extra to user for this service. With Cost Explorer the user can filter graphs using resource tags or with services in AWS. If the organization is using Consolidated Billing it helps generate report based on linked accounts. This will help organization to identify areas that require further inquiry. The organization can view trends and use that to understand spend and to predict future costs.
Reference: http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/costexplorer.html
Question No:95
You have a new client that has configured AWS Services themselves, specifically EC2 instances on a trial basis. They have saved cost up front using On-Demand instances over hardware purchases. But they are disappointed in the operating costs and would like to have a morecost effective deployment. They are generally happy with the service and want to use AWS long term. They have 5 EC2 On-Demand instances dedicated to their accounting and purchasing applications. They also have 5 On-Demand instances dedicated to media transcoding applications which can recover if terminated unexpectedly. What deployment changes would you recommend for optimal performance and cost savings? (Choose 2 answers)
A. Use reserved instances for accounting and purchasing which will be cheaper than on-demand instances
B. Move to spot instances for the media transcoding for greatest savings
C. Use five on-demand instances backed by 5 spot instances for all applications D. Move to spot instances for accounting and purchasing for greatest savings Answer: A,B
 
AWS_SAA-C01 Exam
Explanation: If you require a capacity reservation, consider Reserved Instances. Reserved instances require a one or three year contract but are the cheapest option if you know you will need the instances for the length of the contract. Spot instances are a cost-effective choice if you can be flexible about when your applications run and if they can be interrupted. The key use case is can you afford to lose a spot instance server on short notice. So do not use spot instances for anything which has a short RTO/RPO.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-purchasing-options.html
Question No:96
If you specify only the general endpoint (autoscaling.amazonaws.com), Auto Scaling directs your request to the:
A. us-west-2 endpoint. B. eu-west-1 endpoint. C. eu-central-1.
D. us-east-1 endpoint. Answer: D
Explanation: If you just specify the general endpoint (autoscaling.amazonaws.com), Auto Scaling directs your request to the us-east-1 endpoint.
Reference: http://docs.aws.amazon.com/general/latest/gr/rande.html
Question No:97
You are leading the design of a client's AWS VPC environment. In a security design meeting your team is discussing using Access Control Lists in addition to security groups. It is important that the team understand the difference between the default NACL and any custom NACLs that you create. What features of default NACLs and custom NACLs do you need to understand? (Choose 2 answers)
A. Both the default NACL and custom NACLs initially deny all traffic. B. A custom NACL initially denies all inbound and outbound traffic. C. The default NACL allows all inbound and outbound traffic.
D. The default NACL denies all inbound and outbound traffic.
 
AWS_SAA-C01 Exam
Answer: B,C
Explanation: A network access control list (NACL) is an optional layer of security for your VPC that acts as a firewall for controlling traffic in and out of one or more subnets. Your VPC automatically comes with a modifiable default NACL. By default, it allows all inbound and outbound IPv4 traffic and, if applicable, IPv6 traffic. You can create a custom NACL and associate it with a subnet. By default, each custom NACL denies all inbound and outbound traffic until you add rules.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html#ACLs
Question No:98
You are managing a group of EC2 instances in your company's VPC. Your VPC has been experiencing much higher network traffic than expected and it is not expected to subside. You are considering using EC2 instances with enhanced networking capability. What benefits can enhanced networking instances provide? (Choose 3 answers)
A. More packets per second B. Less packet loss
C. Lower latency
D. Less jitter
Answer: A,C,D
Explanation: Enhanced networking uses single root I/O virtualization (SR-IOV) to provide high-performance networking capabilities on supported instance types. SR-IOV is a method of device virtualization that provides higher I/O performance and lower CPU utilization when compared to traditional virtualized network interfaces. Enhanced networking provides higher bandwidth, higher packet per second (PPS) performance, and consistently lower inter-instance latencies.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/enhanced-networking.html
Question No:99
As AWS grows, most of your clients' main concerns seem to be about security, especially when all of their competitors also seem to be using AWS. One of your clients asks you whether having a competitor who hosts their EC2 instances on the same physical host would make it easier for the competitor to hack into the client's data. Which of the following statements would be the best
 
AWS_SAA-C01 Exam
choice to put your client's mind at rest?
A. Different instances running on the same physical machine are isolated from each other via IAM permissions.
B. Different instances running on the same physical machine are isolated from each other viaa 256-bit Advanced Encryption Standard (AES-256).
C. Different instances running on the same physical machine are isolated from each other via the Hypervisor and via a 256-bit Advanced Encryption Standard (AES-256).
D. Different instances running on the same physical machine are isolated from each other via the Hypervisor.
Answer: D
Explanation: Amazon Elastic Compute Cloud (EC2) is a key component in Amazon’s Infrastructure as a Service (IaaS), providing resizable computing capacity using server instances in AWS’s data centers. Amazon EC2 is designed to make web-scale computing easier by enabling you to obtain and configure capacity with minimal friction.
You create and launch instances, which are collections of platform hardware and software. Different instances running on the same physical machine are isolated from each other via the Xen/KVM (dependent on instance family) hypervisor.
In addition, the AWS firewall resides within the hypervisor layer, between the physical network interface and the instance's virtual interface. All packets must pass through this layer, thus an instance’s neighbours have no more access to that instance than any other host on the Internet and can be treated as if they are on separate physical hosts. The physical RAM is separated using similar mechanisms.
Reference: http://d0.awsstatic.com/whitepapers/Security/AWS%20Security%20Whitepaper.pdf
Question No:100
You are setting up your company's Virtual Private Cloud (VPC). It is time to select the virtual hardware and the software to be provisioned for the instances you will launch within the VPC. You will do this by selecting the Instance Types and Amazon Machine Images (AMI). Which item is not defined by the AMI?
A. Application or System Software B. Operating system
C. The initial state of any patches
 
AWS_SAA-C01 Exam
D. Virtual CPUs
Answer: D
Explanation: An Amazon Machine Image (AMI) is a template that contains a software configuration (for example, an operating system, an application server, and applications). The AMI includes the operating system, initial state of any patches, and any application software. For example, you can select an AMI that has SQL Server. The virtual CPUs are not part of the AMI but are defined by the instance type.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html
Question No:101
You have a website which requires international presence and consequently you have set it up as follows.
. It is hosted on 30 EC2 instances.
. It is on in 15 regions around the globe.
. Each region has 2 instances.
. All the instances are a public hosted zone.
Which of the following is the best way to configure your site to maintain availability with minimum downtime if one of the 15 regions was to lose network connectivity for an extended period? (Choose 2 answers)
A. Create a Route 53 Failover Routing Policy and assign each resource record set a unique identifier and a relative weight.
B. Create a Route 53 failover routing policy and configure an active-passive failover.
C. Create a Route 53 Geolocation Routing Policy that resolves to an Elastic Load Balancer in each region and has the Evaluate Target Health flag set to false.
D. Create a Route 53 Latency Based Routing Record set that resolves to an Elastic Load Balancer in each region and has the Evaluate Target Health flag set to true.
Answer: B,D
Explanation: It is best to use the latency routing policy when you have resources in multiple Amazon EC2 data centers that perform the same function and you want Amazon Route 53 to respond to DNS queries with the resources that provide the best latency.
You could also use the failover routing policy (for public hosted zones only) when you want to configure an active-passive failover, in which one resource takes all traffic when it's available and the other resource takes all traffic when the first resource isn't available.
 
AWS_SAA-C01 Exam
Reference: http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-po licy-latency
Question No:102
You are working for a rapidly growing company that is using EC2 instances to process customer requests. There have been many instances of latency related to high demand on specific EC2 instances. You are designing changes to the environment, including an Elastic Load Balancer to manage traffic demands. What characteristics and best practices of an ELB must you keep in mind? (Choose 2 answers)
A. Note that ELB in a VPC supports both IPv4 and IPv6.
B. Always reference and ELB by it's MAC address instead of its DNS address.
C. For instances behind an ELB, do not bind an application to an the instances IP address. D. Always reference an ELB by it's DNS name instead of its IP address.
Answer: C,D
Explanation: You can build fault tolerant applications by placing your Amazon EC2 instances in multiple Availability Zones. To achieve even more fault tolerance with less manual intervention, you can use Elastic Load Balancing. You get improved fault tolerance by placing your compute instances behind an Elastic Load Balancer, as it can automatically balance traffic across multiple instances and multiple Availability Zones and ensure that only healthy Amazon EC2 instances receive traffic.
Reference: https://aws.amazon.com/elasticloadbalancing/
Question No:103
You are working as a Solutions Architect for a civil engineering company. You’ve been tasked with creating a Virtual Private Cloud to create a hybrid cloud solution. The cloud environment will need to connect to an on-premises application that cannot be migrated to the VPC. Your requirements are to get the connection setup as quickly as possible? Which option can you use to get the hybrid environment operational as quickly as possible?
A. VPN
B. Internet Gateway C. Direct Connect
 
AWS_SAA-C01 Exam
D. Redshift
Answer: A
Explanation: You can connect your VPC to remote networks by using a VPN connection. You can create an IPsec, hardware VPN connection between your VPC and your remote network. On the AWS side of the VPN connection, a virtual private gateway provides two VPN endpoints for automatic failover. You configure your customer gateway, which is the physical device or software application on the remote side of the VPN connection. A VPN connection is the fastest way to complete the connection between on-premises computing and your VPC. However, VPN is not as reliable or as fast as Direct Connect.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpn-connections.html
Question No:104
You have set up an AWS environment which contains several on-demand EC2 instances dedicated to a high profile client that your company is currently involved with. Unfortunately the project has been postponed due to the fact that the company is having a cash flow problem. Consequently you do not want to incur charges for these on-demand instances, but you also want to ensure that you do not lose all of your hard work and hence need to keep all the data that is currently contained on these instances. Which of the following will minimize charges for these instances whilst keeping all the data available for a later time when the project begins again? (Choose 2 answers)
A. Terminate all the instances and then make an image of all the instances.
B. Change all the instances to reserved instances and then terminate the instances. C. Stop all the instances.
D. Take a snapshot of all the instances and then terminate all the instances. Answer: C,D
Explanation: If you stop the instances you will not be charged and the data will still be kept. If you terminate the instances you will lose all your data. If you take a snapshot of all the instances and then terminate all the instances you will not be charged but will still have all your data in the snapshot which can be restored later.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html
 
AWS_SAA-C01 Exam
Question No:105
You have been contracted by an imaging company to design an AWS cloud solution for their business. Their website will process a large amount of high resolution images that will need to be batch processed. Once the photos are uploaded the AWS service needs to do a lot of processing of the photos, such as scaling them to different sizes, applying different filters, and extracting metadata. Which AWS service enables you to store this data for processing?
A. Amazon SQS
B. Amazon SNS
C. Amazon Cloudfront D. Amazon SWF Answer: A
Explanation: Amazon Simple Queue Service (Amazon SQS) is a web service that gives you access to message queues that store messages waiting to be processed. With Amazon SQS, you can quickly build message queuing applications that can run on any computer.
Amazon SQS offers a reliable, highly-scalable, hosted queue for storing messages in transit between computers. With Amazon SQS, you can move data between diverse, distributed application components without losing messages and without requiring each component to be always available.
Reference: https://aws.amazon.com/sqs/faqs/
Question No:106
You are designing an AWS RDS environment for a new client. You have designed in high availability for this environment and now you are reviewing scalability options and will meet with the client to review. Based on statistics you've received from the client you expect the database to roughly handle an equal number of reads and writes. How can you best scale for this situation?
A. Scale horizontally using a multi-AZ configuration. B. Scale vertically and horizontally.
C. Scale horizontally using read replicas.
D. Scale vertically with a larger instance.
Answer: D
 
AWS_SAA-C01 Exam
Explanation: You can scale vertically to address the growing demands of an application that uses a roughly equal number of reads and writes. Or you can scale horizontally for read-heavy applications. There are currently over 18 instance sizes that you can choose from when resizing your RDS MySQL, PostgreSQL, MariaDB, Oracle, or Microsoft SQL Server instance. For Amazon Aurora, you have 5 memory-optimized instance sizes to choose from.
Reference: https://aws.amazon.com/blogs/database/scaling-your-amazon-rds-instance-vertically-and-h orizontally/
Question No:107
You need to establish a site-to-site VPN connection from your on-premise network to the VPC (Virtual Private Cloud). For this to work successfully, which of the following need to be configured? (Choose 2 answers)
A. A physical appliance or software application as your customer gateway
B. A private IP address on the customer gateway for the on-premise network
C. Both a private IP address on the customer gateway for the on-premise network and a Public/Elastic IP to a VPG
D. A public IP address on the customer gateway for the on-premise network
Answer: A,D
Explanation: You are taking information (the public IP) from the on-premises network and configuring it inside of the VPC . When you configure a VPN, you're configuring it from the VPC and from the on-premises network. To use Amazon VPC with a VPN connection, you or your network administrator must designate a physical appliance or software application as your customer gateway and configure it.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html
Question No:108
One of your developers is creating an application that must upload large files to a S3 bucket. You suggest that they use the multipart upload feature. Which actions are required from the developer to complete a multipart upload? (Choose 2 answers)
A. Construct the final object from the parts.
B. Create ordered ETag values to label each part.
 
AWS_SAA-C01 Exam
C. Send a request to initiate a multipart upload.
D. Upload each part with an upload ID and a part number, Answer: C,D
Explanation: When you send a request to initiate a multipart upload, Amazon S3 returns a response with an upload ID, which is a unique identifier for your multipart upload. You must include this upload ID whenever you upload parts, list the parts, complete an upload, or abort an upload. When uploading a part, in addition to the upload ID, you must specify a part number that uniquely identifies a part and its position in the object you are uploading. Amazon S3 returns an ETag header in its response. For each part upload, you must record the part number and the ETag value for use in each subsequent request.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html
Question No:109
You are assigned to a new client that is moving from on-premises to a hybrid solution. The client insists that the cloud portion have a firewall. You explain that the firewall in the cloud is virtual and implemented as a Security Group. What characteristics of a Security Group should you detail for the client? (Choose 2 answers)
A. Security Groups control traffic at the instance level.
B. Security Groups are stateless.
C. Every instance must have at least one security group.
D. If there are multiple Security Groups, the most restrictive one is used. Answer: A,C
Explanation: Security Groups are essentially stateful firewalls at the instance level. Security Groups are associated with instances at launch time, and restrict or allow traffic based on port, protocol, and source/destination.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html
Question No:110
You have been contracted by a client to design their AWS cloud environment. This is a very large company with multiple requirements. They need a highly available website but also need another service for analytics reporting and data warehousing. Which AWS service is best suited
 
AWS_SAA-C01 Exam
for the data analytics and warehousing requirements? A. Amazon Redshift
B. Amazon Glacier
C. Amazon DynamoDB
D. Amazon Cloud Formation
Answer: A
Explanation: Amazon Redshift is a fast, fully managed data warehouse that makes it simple and cost-effective to analyze all your data using standard SQL and your existing Business Intelligence (BI) tools. It allows you to run complex analytic queries against petabytes of structured data, using sophisticated query optimization, columnar storage on high-performance local disks, and massively parallel query execution. Most results come back in seconds. Glacier generally takes 3 to 5 hours to return data and is not suited for production type environments. Cloud Formation is used to provision Amazon resources.
Reference: https://aws.amazon.com/redshift/faqs/
Question No:111
You have taken over an implementation and deployment project that is in the early requirements phase. You review the requirements and have some concerns, specifically the use of a t2.micro instance to host a MySQL database because you have concerns about performance. What recommendations should you make to change these requirements and ensure optimal performance? (Choose 2 answers)
A. Create a RAID 0 configuration.
B. Use SQL Server instead of MySQL.
C. Use a larger instance type to host the database.
D. Create a multi-AZ database to improve performance. Answer: A,C
Explanation: By upgrading to a larger t2 instance, you not only improve baseline compute power, you also improve the ability to handle bursts. Each T2 instance receives CPU Credits continuously at a set rate depending on the instance size. These credits provide the ability to handle bursts. You can also create a RAID 0 to maximize utilization of instance resources.
 
AWS_SAA-C01 Exam
Reference: https://aws.amazon.com/ec2/instance-types/
Question No:112
What was the recommended use case for S3 Reduced Redundancy storage before its deprecation was planned?
A. It was used to reduce storage costs for noncritical data at lower levels of redundancy.
B. It was used to reduce storage costs by providing 500 times the durability of a typical disk drive at lower levels of redundancy.
C. It was used to reduce storage costs for reproducible data at high levels of redundancy in a single facility .
D. It was used to reduce storage costs by allowing you to destroy any copy of your files outside a specific jurisdiction.
Answer: A
Explanation: Reduced Redundancy Storage (RRS) was introduced In order to reduce storage costs. When first developed, you could use reduced redundancy storage for noncritical, reproducible data at lower levels of redundancy than Amazon S3 provides with standard storage. Now Standard is a more affordable from a cost perspective, because Amazon is deprecating RRS and has changed the pricing structure.
Standard, for example, offers storage for the first 50 TB at $0.023/GB. Reduced Redundancy Storage offers rates of $0.024 or $0.0236 per/GB for the first 50 TB.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingRRS.html
Question No:113
A root account owner has created an S3 bucket testmycloud. The account owner wants to allow other AWS users with separate AWS accounts to upload objects, as well as enforce that the person who uploaded a given object should manage the permission for that object. Which is the easiest way to achieve this?
A. The root account should create an S3 Bucket ACL for the bucket allowing separate AWS accounts to upload content to the bucket.
B. The root account should create the IAM users for separate AWS accounts, and provide them the permission to upload content to the bucket.
C. The root account owner should create a bucket ACL policy allowing other account owners to
 
AWS_SAA-C01 Exam
set the object permissions for that bucket.
D. The root account owner should create a bucket ACL policy allowing specified IAM users with separate AWS accounts to upload content to the bucket.
Answer: A
Explanation: Each Amazon S3 bucket and object has an ACL (Access Control List) associated with it. An ACL is a list of grants identifying the grantee and the permission granted. The user can use ACLs to grant basic read/write permissions to other AWS accounts. ACLs use an Amazon S3–specific XML schema. The user cannot grant permissions to other users in his account. ACLs are suitable for specific scenarios. For example, if a bucket owner allows other AWS accounts to upload objects, permissions to these objects can only be managed using the object ACL by the AWS account that owns the object.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html
Question No:114
An account with an existing client who has an AWS VPC has been assigned to you. The documentation you've received and your own investigation reveals that the current configuration is pretty basic. Specifically, you see that the default group is in use. You would like to create a custom security group. To do this, you must be aware of what key difference between a default security group and a custom security group?
A. The default security group can be deleted; a custom security group cannot be deleted. B. The default security group rules override custom security group rules.
C. Instances in a security group can communicate with each other, but instances in a custom security group cannot communicate without adding the appropriate rules.
D. You can not alter the default security group, but you can alter a custom security group.
Answer: C
Explanation: A security group acts as a virtual firewall for your instance to control inbound and outbound traffic. When you launch an instance in a VPC, you can assign the instance to up to five security groups. Security groups act at the instance level, not the subnet level. Therefore, each instance in a subnet in your VPC could be assigned to a different set of security groups. Instances associated with a security group can't talk to each other unless you add rules allowing it (exception: the default security group has these rules by default).
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html
 
AWS_SAA-C01 Exam
Question No:115
Your company has begun deploying corporate resources to AWS. They want to ensure AWS compliance levels match their corporate requirements. Which actions reflect best practices for carrying out a security assessment of your environment on the cloud? (Choose 2 answers)
A. Request AWS to run a penetration test against your environment and generate assessment report with critical findings and best practices to resolve them
B. Request approval to perform relevant network scans and penetration tests of your systemon AWS.
C. Carry out a detailed audit and inventory of on-premise resources and operations.
D. Review applicable third-party AWS compliance reports and attestations and conduct gap analysis to find missing controls
Answer: B,D
Explanation: AWS Service Organization Control (SOC) Reports are independent third-party examination reports available to current AWS customers that provide a description of the AWS controls environment and external audit of AWS controls meeting the AICPA Trust Services Security and Availability Principles and Criteria. They provide customers and users who have a business need with an independent assessment of AWS' control environment relevant to system security and availability. Customer may also request authorization for penetration testing to or originating from any AWS resources (see aws.amazon.com/security/penetration-testing). Reference: https://aws.amazon.com/compliance/soc-faqs/
Question No:116
Your company is in the process of designing an Amazon cloud environment. You have been placed in charge of the design and begin reviewing the design artifacts. You notice that the proposed route table has two routes in it: 10.0.0.0/16 and 0.0.0.0/0. What do you know about these routes? (Choose 3 answers)
A. 10.0.0.0/16 is the local route for communication within the VPC
B. 0.0.0.0/0 is the route to the internet gateway to route internet traffic C. 10.0.0.0/16 is the route to the internet gateway to route internet traffic D. 0.0.0.0/0 is very permissive and routes all internet traffic
Answer: A,B,D
 
AWS_SAA-C01 Exam
Explanation: Any traffic destined for a target within the VPC (10.0.0.0/16) is covered by the local route, and therefore routed within the VPC. All other traffic from the subnet uses the Internet gateway. A route in the route table of 0.0.0.0/0 routes traffic to the internet gateway. This will route all traffic and is very permissive. A more secure approach would be to route traffic only within the address range of the company ip block.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html#RouteT ables
Question No:117
You've created your first load balancer and have registered your EC2 instances with the load balancer. Elastic Load Balancing routinely performs health checks on all the registered EC2 instances and automatically distributes all incoming requests to the DNS name of your load balancer across your registered, healthy EC2 instances. By default, the load balancer uses the
protocol for checking the health of your instances. A. ICMP
B. HTTPS C. HTTP D. TCP Answer: C
Explanation: In Elastic Load Balancing a health configuration uses information such as protocol, ping port, ping path (URL), response timeout period, and health check interval to determine the health state of the instances registered with the load balancer.
Currently, HTTP on port 80 is the default health check.
Reference: http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandK eyConcepts.html
Question No:118
Which of the choices below best describes what Auto Scaling is well suited for?
A. only for applications with a stable usage pattern but extremely high workload. B. only for applications that experience hourly, daily, or weekly variability in usage.
  
AWS_SAA-C01 Exam
C. Both for applications that have stable demand patterns and that experience hourly, daily, or weekly variability in usage.
D. Both for applications that use frameworks and SDKs to enhance its customer relationship.
Answer: C
Explanation: Auto Scaling is well suited to both applications that have stable demand patterns and that experience hourly, daily, or weekly variability in usage. Whether the demand is predictable or unpredictable auto scaling can be a good choice. If the demand is predictable and long term you may choose reserved instances. If the demand is unpredictable you may choose on-demand or even spot instance (if you can afford to have an instance lost unexpectedly). Reference: http://aws.amazon.com/autoscaling/
Question No:119
Your application is trying to upload a 25 GB file to Amazon Simple Storage Service (S3) and it receives the following error message:
"Your proposed upload exceeds the maximum allowed object size."
Which of the following would be a possible solution to resolve the error?
A. Change your user permissions.
B. Contact AWS support to increase your object size limit.
C. Use the Multipart Upload API to upload the object.
D. There is no solution to this as Simple Storage Service objects are limited to 5 GB. Answer: C
Explanation: The Multipart Upload API is designed to improve the upload experience for larger objects. You can upload objects in parts using this method. These object parts can be uploaded independently, in any order, and in parallel and you can use a Multipart Upload for objects between 5 MB to 5 TB in size. It is recommended that the Amazon S3 customers use Multipart Upload for objects greater than 100 MB.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/UploadingObjects.html
Question No:120
What happens when a user does not provide the security group while creating the Auto Scaling launch config?
 
AWS_SAA-C01 Exam
A. The Configuration Wizard creates one security group for that Auto Scaling service.
B. There is no security group attached to the instance.
C. The configuration wizard gives an error and a security group is not created.
D. The configuration wizard is created and the instance with the default security group of EC2 is launched.
Answer: A
Explanation: If a user does not select the security group while creating the launch config, the Launch Configuration wizard automatically defines the "launch-wizard-x" security group to allow the user to connect to the instance, which enables all IP addresses (0.0.0.0/0) to access the instance over the specified ports.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/launching-instance.html
Question No:121
You are leading a team in the design of an AWS environment for a client. This will be a hybrid environment requiring communication between on-premises application and the cloud environment, as well as private and public subnets which need internet access. You can connect the existing data center to the AWS VPC using either hardware or software VPN connections making the AWS VPC an extension of the data center. What services allow you to connect the corporate network to the VPC? (Choose 2 answers)
A. Internet Gateway
B. Customer Gateway
C. Virtual Private Gateway D. NAT Gateway
Answer: B,C
Explanation: By default, instances that you launch into a virtual private cloud (VPC) can't communicate with your own network. You can enable access to your network from your VPC by attaching a virtual private gateway to the VPC, creating a custom route table, and updating your security group rules. A customer gateway is the anchor on your side of that connection. It can be a physical or software appliance. The anchor on the AWS side of the VPN connection is called a virtual private gateway.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html
 
AWS_SAA-C01 Exam
Question No:122
You have been asked by your company to design a data warehousing solution. Your company has a huge amount of data it would like to warehouse. This will be an ongoing operation and the size of the data warehouse will continue to increase over time. You recommend AWS Redshift. What features of Redshift will provide the appropriate scaling for this design? (Choose 2 answers)
A. Additional nodes can easily be added to the Redshift cluster.
B. Auto scaling can add nodes to Redshift clusters.
C. Memcached nodes can be added to Redshift clusters.
D. Nodes can be added as read only while the existing cluster remains in service. Answer: A,D
Explanation: As your data warehousing capacity and performance needs change or grow, you can resize your cluster to make the best use of the computing and storage options that Amazon Redshift provides. You can scale the cluster in or out by changing the number of nodes. Or, you can scale the cluster up or down by specifying a different node type.
Reference: http://docs.aws.amazon.com/redshift/latest/mgmt/rs-resize-tutorial.html
Question No:123
You have been assigned to a client who have an existing AWS cloud environment. They are using EBS volumes for storage and underestimated their storage needs. They regularly backup these volumes to S3 using snapshots. In a design meeting you discuss the possibility of increasing the size of these volumes. What are two options for increasing the size of EBS volumes? (choose two)
A. increase the size of the volume dynamically using the Elastic Volume EBS feature. B. There is no option to increase the size of volumes.
C. Copy the data to an instance store volume. Create a new bigger EBS volume, Import the data from the instance store volume to the new EBS volume.
D. Create a new volume of a larger size from a snapshot of the existing volume. Answer: A,D
Explanation: With the EBS Elastic Volumes feature you can increase volume size, adjust performance, or change the volume type while the volume is in use. You can continue to use
 
AWS_SAA-C01 Exam
your application while the change takes effect.
You can restore an Amazon EBS volume with data from a snapshot stored in Amazon S3. You need to know the ID of the snapshot you wish to restore your volume from and you need to have access permissions for the snapshot. Snapshots can be used to increase the size of an EBS volume. You can do this by taking a snapshot of the volume, then creating a new volume of the desired sized from the snapshot. Then replace the original volume with the new volume. Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-restoring-volume.html
Question No:124
Which DB instance purchase options are available in RDS?
A. Reserved Instances
B. Spot Instances
C. Dedicated Instances
D. Dedicated Host Instances Answer: A
Explanation: Amazon RDS offers Reserved instances as a way to discount hourly instance charges by purchasing the instance for one or three years. EC2 offers spot instances, dedicated instances, and dedicated host instances, but these are not options in RDS.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithReservedDB Instances.html
Question No:125
You have been asked to set up a public website on AWS with the following criteria:
. You want the database and the application web server running on an Amazon VPC.
. You want the database to be able to connect to the Internet so that it can be automatically updated to the correct patch level.
. You do not want to receive any incoming traffic from the Internet to the database.
Which solution would satisfy all of the above requirements for your planned public website on AWS?
A. Deploy both the public website and the database in a public subnet. Create a network access control list (NACL) and attach to the public subnet that blocks all incoming requests from the Internet.
 
AWS_SAA-C01 Exam
B. Deploy the public website in a public subnet. Deploy the database in a private subnet which connects to the Internet via a NAT gateway.
C. Deploy both the public website and the database in a public subnet. Assign the database to a security group that only allows access from the IP of the public website.
D. Use CloudFront to sit in front of the database. Configure the database as the origin.
Answer: B
Explanation: You want the database to be able to connect to the Internet, so you need to either set it up on a public subnet or set it up on a private subnet which connects to the Internet via a NAT gateway.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Scenario2.html
Question No:126
Which of the following features can be used to restrict access to data in S3? (Choose 3 answers)
A. Set an S3 ACL on the bucket or the object
B. Create a CloudFront distribution for the bucket
C. Only have the bucket in a certain region and block access to that region
D. Set an S3 bucket policy
Answer: A,B,D
Explanation: There are a number of ways to restrict access to data in S3. However MFA is not one of them and you cannot block a region.
Question No:127
A user has applied an ACL and a policy on the S3 bucket. Then, the user enables CORS on the same bucket. Which of the following statements is true in this context?
A. With CORS, only an ACL can be applied.
B. It is not possible to have all three applied to the same bucket.
C. The ACLs and policies continue to apply when you enable CORS on the bucket.
 
AWS_SAA-C01 Exam
D. With CORS, only the policy can be applied.
Answer: C
Explanation: The CORS specification gives a user the ability to build web applications that make requests to domains other than the one which supplied the primary content. The ACLs and policies continue to apply when you enable CORS on the bucket.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html
Question No:128
You've been assigned to a client that has an autoscaling group behind an Elastic Load Balancer. The autoscaling group is handling traffic spikes well, but the client is concerned about cost. After reviewing statistics, you find that many instances are being launched for just a short time period (15 - 30 minutes) and you know that Amazon charges per second for the time these instances are running. You're concerned that sustained bursts outlive instances created due to these bursts. What steps can you take to maintain performance but reduce costs? (Choose 2 answers)
A. Create a scaling policy that scales out slowly and scales in quickly.
B. Create a scaling policy which scales out quickly and scales in slowly.
C. Use Trusted Advisor to terminate instances immediately when no longer needed. D. Create a cool down period for your autoscaling group.
Answer: B,D
Explanation: If an EC2 instance is started, you are automatically billed for the number of seconds the instance is running, or by the billing hour. If you have a permissive scaling policy that launches, terminates, and relaunches many instances, you are wasting money. It's best practice to scale out quickly and scale in slowly. Spot instances can be used in autoscaling, but only in specific use cases where you can recover easily from a terminated instance. Tightening up the scaling policy to save money is more appropriate in this situation. Trusted Advisor can alert you to cost saving opportunities but does not delete instances.
Reference: http://docs.aws.amazon.com/autoscaling/latest/userguide/Cooldown.html
Question No:129
A user is informed an issue occurred 1 week ago between 3 AM to 4 AM, and the EC2 server was not reachable. The user is checking the CloudWatch metrics of that instance. How can the user find the data using the CloudWatch console?
 
AWS_SAA-C01 Exam
A. The user can find the data by giving the exact values in the Absolute tab under CloudWatch metrics
B. The user can find the data by giving the exact values in the time Tab under CloudWatch metrics
C. It is not possible to find the exact time from the console. The user has to use CLI to provide the specific time
D. The user can find the data by filtering values of the last 1 week for a 1 hour period in the Relative tab under CloudWatch metrics
Answer: A
Explanation: If the user is viewing the data inside the CloudWatch console, the console provides options to filter values either using the relative period, such as days /hours or using the Absolute tab where the user can provide data with a specific date and time. The console also provides the option to search using the local timezone under the time range caption in the console.
Reference: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/modify_graph_date _time.html
Question No:130
You have been assigned to a client to design their AWS VPC environment. They have a very tight budget and want to limit costs wherever possible. They like the idea of using Instance stores where the cost is included with the EC2 instance. In addition to developing a robust backup policy, you need to educate the client on the scenarios where data will be lost from an instance store. What are these scenarios?
A. Disk drive failure, the instance reboots, the instance terminates. B. Disk drive failure, the instance stops, the instance reboots.
C. Disk drive failure, the instance stops, the instance terminates. D. Network failure, Disk drive failure, the instance terminates. Answer: C
Explanation: An instance store provides temporary block-level storage for your instance. This storage is located on disks that are physically attached to the host computer. Instance store is
 
AWS_SAA-C01 Exam
ideal for temporary storage of information that changes frequently, such as buffers, caches, scratch data, and other temporary content, or for data that is replicated across a fleet of instances, such as a load-balanced pool of web servers.
Data in the instance store is lost under the following circumstances:
. The underlying disk drive fails
. The instance stops
. The instance terminates
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html
Question No:131
You are hosting a design meeting for a client you are migrating to a cloud environment. They have a web application which serves high traffic and sends requests to an Oracle database. Their general requirements are high availability and scalability foremost within a cost-conscious design. You begin describing the benefits of Multi-AZ deployments with Amazon RDS. What benefit does a Multi-AZ deployment on Amazon RDS not provide?
A. synchronous replication
B. failover support
C. high availability
D. offload reads to the standby Answer: D
Explanation: Amazon RDS provides high availability and failover support for DB instances using Multi-AZ deployments. Amazon RDS uses several different technologies to provide failover support. In a Multi-AZ deployment, Amazon RDS automatically provisions and maintains a synchronous standby replica in a different Availability Zone. The high-availability feature is not a scaling solution for read-only scenarios; you cannot use a standby replica to serve read traffic. If you need extra capacity to accommodate spikes in read-only traffic, the solution is read replicas rather than Multi-AZ deployments.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.MultiAZ.html
Question No:132
You are in charge of the VPC for your company. You are developing an overall architectural document for the VPC including specifics about the VPC, Internet Gateway, ACLs and Security Groups, and EC2 instances. You want to provide details on public ip addresses and elastic ip addresses and when you might use one over the other. What can you detail about the benefits of
 
AWS_SAA-C01 Exam
elastic ip addresses? (Choose 3 Answers)
A. The Elastic IP address is not tied to the life of an EC2 instance.
B. The loose coupling provided by elastic ip addresses are helpful in failover situations. C. The Elastic IP address can be stretched across two EC2 instances at once.
D. The Elastic IP address can be moved to a new instance in the case of instance failure. Answer: A,B,D
Explanation: An Elastic IP address is a static IPv4 address designed for dynamic cloud computing. An Elastic IP address is associated with your AWS account. With an Elastic IP address, you can mask the failure of an instance or software by rapidly remapping the address to another instance in your account.
An Elastic IP address is a public IPv4 address, which is reachable from the Internet. If your instance does not have a public IPv4 address, you can associate an Elastic IP address with your instance to enable communication with the Internet; for example, to connect to your instance from your local computer.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html
Question No:133
You have been temporarily assigned to the company security team and have been tasked with tightening security on the company’s application by removing unused rules. This is a big task because the company is large and has a complex security structure with many rules. Unfortunately, because you are new to the project and the person you are temporarily replacing is on paternity leave, you do not have access to the in-depth knowledge of the application’s active ports on the company’s Amazon EC2 instances necessary to implement this tightening of security.
What is an alternative way to determine which rules are unused? Note: The company uses Amazon VPC.
A. By analyzing network terminations using Amazon CloudFront and VPC Flow Logs
B. By analyzing Lambda trigger metrics using VPC Flow Logs
C. By analyzing active network traffic using VPC Flow Logs
D. By analyzing how loads are distributed to Amazon Elastic Load Balancing and VPC Flow Logs
 
AWS_SAA-C01 Exam
Answer: C
Explanation: Unused rules can be determined by analyzing active network traffic using VPC Flow Logs that post to Amazon CloudWatch logs.
Question No:134
You are designing a service that aggregates clickstream data in batch and delivers reports to subscribers via email only once per week. Data is extremely spikey, geographically distributed, high-scale, and unpredictable. How should you design this system?
A. Use API Gateway invoking Lambdas which PutRecords into Kinesis, and EMR running Spark performing GetRecords on Kinesis to scale with spikes. Spark on EMR outputs the analysis to S3, which are sent out via email.
B. Use a CloudFront distribution with access log delivery to S3. Clicks should be recorded as querystring GETs to the distribution. Reports are built and sent by periodically running EMR jobs over the access logs in S3.
C. Use AWS Elasticsearch service and EC2 Auto Scaling groups. The Autoscaling groups scale based on click throughput and stream into the Elasticsearch domain, which is also scalable. Use Kibana to generate reports periodically.
D. Use a large RedShift cluster to perform the analysis, and a fleet of Lambdas to perform record inserts into the RedShift tables. Lambda will scale rapidly enough for the traffic spikes.
Answer: B
Explanation: Because you only need to batch analyze, anything using streaming is a waste of money. CloudFront is a Gigabit-Scale HTTP(S) global request distribution service, so it can handle scale, geo-spread, spikes, and unpredictability. The Access Logs will contain the GET data and work just fine for batch analysis and email using EMR.
Can I use Amazon CloudFront if I expect usage peaks higher than 10 Gbps or 15,000 RPS? Yes. Complete our request for higher limits here, and we will add more capacity to your account within two business days.
Reference: https://aws.amazon.com/cloudfront/faqs/
Question No:135
To understand how IAM works, it is important to understand how a policy is interpreted. In AWS, when a request is made, IAM determines whether a given request should be allowed or denied. The distinction between a request being denied or allowed by default, and an explicit deny in a policy, is important. Which of the following statements best describes this distinction? (Choose 2
 
AWS_SAA-C01 Exam
answers)
A. The order in which the policies are evaluated has an effect on the outcome of the evaluation. B. If a policy explicitly denies a request, that deny cannot be overridden.
C. By default, a request is allowed, but this can be overridden by a deny.
D. By default, a request is denied, but this can be overridden by an allow.
Answer: B,D
Explanation: When a request is made, the AWS service decides whether a given request should be allowed or denied. The evaluation logic follows these rules:
. By default, all requests are denied. (In general, requests made using the account credentials for resources in the account are always allowed.)
. An explicit allow overrides this default.
. An explicit deny overrides any allows.
The order in which the policies are evaluated has no effect on the outcome of the evaluation. All policies are evaluated, and the result is always that the request is either allowed or denied. Reference: http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html #policy-eval-denyallow
Question No:136
You have been asked to perform some penetration testing on your company's AWS infrastructure. However you are not sure who is responsible for this, your company or AWS? Which statements correctly describe the AWS policy in relation to penetration testing? (Choose 2 answers)
A. The information you share with AWS as part of this process is kept confidential within AWS. B. You need to employ a 3rd party specialist to do the testing.
C. You can do the testing with no prior AWS approval.
D. Permission is required from AWS for all penetration testing.
Answer: A,D
Explanation: There are several important things to note about penetration testing requests: . Permission is required for all penetration tests.
 
AWS_SAA-C01 Exam
. To request permission, you must be logged into the AWS portal using the root credentials associated with the instances you wish to test, otherwise the form will not pre-populate correctly.
. The AWS policy only permits testing of EC2 and RDS instances that you own. Tests against any other AWS services or AWS-owned resources are prohibited
. At this time, the AWS policy does not permit testing small or micro RDS instance types. Testing of m1.small, t1.micro or t2.nano EC2 instance types is not permitted.
Reference: http://aws.amazon.com/security/penetration-testing/
Question No:137
A customer enquires about whether all his data is secure on AWS, and is especially concerned about Elastic Map Reduce (EMR). You need to inform him of some of the security features in place for AWS. Which of the below statements is incorrect regarding EMR or S3?
A. Amazon EMR customers can choose to send data to Amazon S3 using the HTTPS protocol for secure transmission.
B. Amazon S3 provides authentication mechanisms to ensure that stored data is secured against unauthorized access.
C. Customers may encrypt the input data before they upload it to Amazon S3. D. Every packet sent in the AWS network uses Internet Protocol Security (IPsec). Answer: D
Explanation: Amazon S3 provides authentication mechanisms to ensure that stored data is secured against unauthorized access. Unless the customer who is uploading the data specifies otherwise, only that customer can access the data. Amazon EMR customers can also choose to send data to Amazon S3 using the HTTPS protocol for secure transmission. In addition, Amazon EMR always uses HTTPS to send data between Amazon S3 and Amazon EC2. For added security, customers may encrypt the input data before they upload it to Amazon S3 (using any common data compression tool); they then need to add a decryption step to the beginning of their cluster when Amazon EMR fetches the data from Amazon S3.
IPsec is a protocol suite for securing Internet Protocol (IP) communications by authenticating and encrypting each IP packet of a data stream. Amazon supports Internet Protocol security (IPsec) VPN connections, but does not protect all data packets at this level.
Reference: https://aws.amazon.com/elasticmapreduce/faqs/
Question No:138
You are leading the design of an AWS RDS database for a client's cloud environment. You have
 
AWS_SAA-C01 Exam
detailed the benefits of a multi-AZ configuration for high availability. You begin discussing scalability options. You again stress the importance of multi-AZ for a highly available, scalable environment. How does a multi-AZ configuration indirectly benefit scaling operations?
A. Total IOPS is the sum of IOPS for the primary and standby servers. B. There is minimal downtime when scaling up multi-AZ databases. C. Read traffic can be offloaded to the multi-AZ standby instance.
D. The standby instance can quickly be converted to a read replica. Answer: B
Explanation: To handle a higher load in your database, you can vertically scale up your master database with a simple push of a button. There are currently over 18 instance sizes that you can choose from when resizing your RDS MySQL, PostgreSQL, MariaDB, Oracle, or Microsoft SQL Server instance. For Amazon Aurora, you have 5 memory-optimized instance sizes to choose from. There is minimal downtime when you are scaling up on a Multi-AZ environment because the standby database gets upgraded first, then a failover will occur to the newly sized database. A Single-AZ instance will be unavailable during the scale operation.
Reference: https://aws.amazon.com/blogs/database/scaling-your-amazon-rds-instance-vertically-and-h orizontally/
Question No:139
The company that you are working for has a limited budget for on-premise hardware. They need to store large amounts of data that is easily accessible through a network share with on-premise for all their employees. Which of the following AWS solutions would be best for your company keeping in mind that low cost is a priority? (Choose 2 answers)
A. Configure a volume gateway in stored mode
B. Configure a storage gateway but use Glacier instead of S3 for the locally stored data
C. Configure a storage gateway with Gateway-Cached Volumes
D. Configure a volume gateway with Gateway-Cached Volumes
Answer: C,D
Explanation: Gateway-Stored volumes use S3 to backup the data but store locally, which means
 
AWS_SAA-C01 Exam
that you are limited to the amount of space you can allocate. With the Gateway-Cache volumes, you aren't limited in that way since you're storing all of the data on S3 and simply caching frequently-used data locally. With this mode, you can achieve substantial cost savings on primary storage, minimizing the need to scale your storage on-premises, while retaining low- latency access to your frequently accessed data.
A volume gateway and storage gateway are effectively the same thing. Hence both Configure a volume gateway with Gateway-Cached Volumes and Configure a storage gateway with Gateway-Cached Volumes are correct.
Reference: https://aws.amazon.com/storagegateway/details/
Question No:140
A user has enabled termination protection on an EC2 instance. The user has also set Instance initiated shutdown behavior to terminate. When the user shuts down the instance from the OS, what will happen?
A. It will terminate the instance
B. The OS will shutdown but the instance will not be terminated due to protection
C. It is not possible to set the termination protection when an Instance initiated shutdown is set to terminate
D. It will not allow the user to shutdown the instance from the OS
Answer: A
Explanation: It is always possible that someone can terminate an EC2 instance using the Amazon EC2 console, command line interface or API by mistake. If the admin wants to prevent the instance from being accidentally terminated, he can enable termination protection for that instance. The user can also setup shutdown behaviour for an EBS backed instance to guide the instance on what should be done when he initiates shutdown from the OS using Instance initiated shutdown behaviour. If the instance initiated behaviour is set to terminate and the user shuts off the OS even though termination protection is enabled, it will still terminate the instance.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/terminating-instances.html
Question No:141
Amazon S3 Access Control Lists (ACLs) can be applied at the:
A. Bucket, Object and storage class level
 
AWS_SAA-C01 Exam
B. Object level only
C. Bucket level only
D. Bucket and Object level Answer: D
Explanation: S3 ACLs allow identities to access specific objects within buckets a different layered approach than bucket policies which are applied at the bucket level only. ACLs allow you to set certain permissions on each individual object within a specific Bucket.
These ACLs do not follow that same format as the policies defined by IAM and Bucket policies, instead they are far less granular and different permissions can be applied depending if you are applying an ACL at the bucket or object level.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html
Question No:142
After configuring your first Amazon VPC for a client, you are encountering a minor issue. You have configured multiple web servers on EC2 instances in a public subnet behind an Elastic Load Balancer. You also have an RDS database server in a private subnet. You've also configured a bastion host to administer the database server. But you are now unable to RDP into one of the web servers. You've verified you're using the correct DNS name and also that your security group allows RDP access. What else could be the problem? (Choose 2 answers)
A. The web server does not have a public IP address
B. You need to get the encryption key from the Elastic Load Balancer C. Your firewall is not configured to allow access via RDP
D. You need an IAM Role to access the web server
Answer: A,C
Explanation: If you can't RDP into the web server try the following:
. Verify that you're using the correct public DNS hostname
. Verify that your instance has a public IPv4 address (if not, add an Elastic IP Address)
. To connect to your instance using an IPv6 address, check that your local computer has an IPv6 address and is configured to use IPv6
. Verify that your security group has a rule that allows RDP access
. Verify that the instance has passed status checks
. Verify that Windows Firewall, or other firewall software, is not blocking RDP traffic to the
 
AWS_SAA-C01 Exam
instance
Reference: https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/common-issues.html#rdp-iss ues
Question No:143
A client has requested additional compute power for end-of-year transaction processing. You estimate that they will need an additional 10 servers during a three-day period. You begin creating the servers by specifying the instance type and selecting an AMI. What two key features do the instance type and AMI encapsulate? (Choose 2 answers)
A. The number of virtual licenses for software provided
B. The software loaded on the instance
C. The key pair for the instance
D. The amount of virtual hardware dedicated to the instance Answer: B,D
Explanation: When creating an EC2 instance, by selecting the instance type and the Amazon Machine Image (AMI), you are selecting the the hardware type of the machine and the type of software you want on the machine, respectively. Various Linux types as well as Windows operating systems are available. In certain instances, you can also choose an AMI that comes with a database.
Reference: https://aws.amazon.com/ec2/instance-types/
Question No:144
Your company has migrated to the AWS cloud environment. You have been placed in charge of designing and implementing a disaster recovery strategy. You want to document the recovery process for any storage services in use in your environment. Your company is heavily using EBS volumes in the environment. How would you recover data on an EBS volume if the instance fails?
A. Make sure the DeleteOnTermination flag is set to false; attach the volume to another instance to read and recover.
B. Mitigate using other measures, because data will be lost if the instance fails. C. Contact AWS to recover data from the volume.
 
AWS_SAA-C01 Exam
D. Make sure the DeleteOnTermination flag is set to true; attach the volume to another instance to read and recover.
Answer: A
Explanation: When an instance is terminated, Amazon EC2 uses the value of the DeleteOnTermination attribute for each attached Amazon EBS volume to determine whether to preserve or delete the volume. By default, the DeletionOnTermination attribute for the root volume of an instance is set to true and set to false for all other volume types. You can change the DeleteOnTerminate attribute by using the EC2 console only when you launch an instance. You must use the AWS CLI when the instance already exists.
Reference: https://aws.amazon.com/premiumsupport/knowledge-center/deleteontermination-ebs/
Question No:145
You are preparing a proposal for a prospective new client. They would like their cloud environment to be able to expand and contract elastically to meet the demands of their end users. It is important that the environment is elastic to provide optimum performance but also remains cost effective. What general types of elasticity can you propose to them? (Choose 2 answers)
A. Time-based scaling
B. Load-based scaling C. Price-based scaling D. Vendor-based scaling Answer: A,B
Explanation: Scaling based on a schedule allows you to scale your application in response to predictable load changes. As your incoming traffic varies, your stack may have either too few instances to comfortably handle the load or more instances than necessary. You can save both time and money by using time-based or load-based instances to automatically increase or decrease a layer's instances so that you always have enough instances to adequately handle incoming traffic without paying for unneeded capacity.
Reference: http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html
Question No:146
In Amazon Web Services, which of the following URLs would be considered virtual-hosted–style
 
AWS_SAA-C01 Exam
URLs? (Choose 2 answers)
A. http://bucketname.s3-aws-region.amazonaws.com B. http://s3-aws-region.amazonaws.com/bucketname C. http://s3.amazonaws.com/bucketname
D. http://bucketname.s3.amazonaws.com
Answer: A,D
Explanation: Amazon S3 supports both virtual-hosted–style and path-style URLs to access a bucket. In a virtual-hosted–style URL, the bucket name is part of the domain name in the URL whilst in a path-style URL, the bucket name is not part of the domain (unless you use a region-specific endpoint).
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingBucket.html
Question No:147
You are helping a client design a static website which will potentially grow exponentially in the first few years of existence. In addition, the website will serve end users in multiple regions throughout the world. You propose using S3 to house this website. What benefits of S3 can you outline in handling a fast growing load as well as multi-region clients? (Choose 2 answers)
A. S3 can utilize cross-region replication to serve content.
B. S3 can scale to handle virtually any load given.
C. S3 can be integrated with CloudFront to deliver content throughout the world.
D. S3 can be integrated with CloudFormation to deliver content throughout the world. Answer: B,C
Explanation: You can store your content in an Amazon S3 bucket and use CloudFront to distribute the content.
If you store your objects in an Amazon S3 bucket, you can either have your users get your objects directly from S3, or you can configure CloudFront to get your objects from S3 and distribute them to your users.
Using CloudFront can be more cost effective if your users access your objects frequently because, at higher usage, the price for CloudFront data transfer is lower than the price for Amazon S3 data transfer. In addition, downloads are faster with CloudFront than with Amazon S3 alone
 
AWS_SAA-C01 Exam
because your objects are stored closer to your users.
Reference: http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/MigrateS3ToCloudF ront.html
Question No:148
You are in charge of the VPC for your company. You are developing an overall architectural document for the VPC including specifics about the VPC, Internet Gateway, ACLs and Security Groups, and EC2 instances. You would like to detail specifics about security groups to provide some reference for the current configuration as well as future changes. What details about Security Groups can you provide? (Choose 3 answers)
A. A security group is default deny.
B. Every instance must be associated with at least one security group.
C. Security groups are associated with instances when they are launched. D. Security groups can span regions.
Answer: A,B,C
Explanation: A security group acts as a virtual firewall for your instance to control inbound and outbound traffic. When you launch an instance in a VPC, you can assign the instance to up to five security groups. Security groups act at the instance level, not the subnet level. Therefore, each instance in a subnet in your VPC could be assigned to a different set of security groups. If you don't specify a particular group at launch time, the instance is automatically assigned to the default security group for the VPC.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html
Question No:149
A user had defined an IAM policy similar to the one given below on a bucket: {
"Version": "2012-10-17",
"Statement": [{
"Effect": "Allow",
"Principal": {
"AWS": "arn:aws:iam::12112112:user/test"
},
"Action": [
 
AWS_SAA-C01 Exam
"s3:GetBucketLocation", "s3:ListBucket", "s3:GetObject"
],
"Resource":
[ "arn:aws:s3:::examkille r"
]
}
]
}
What will this do?
A. It will allow all the IAM users of the account ID 12112112 to perform GetBucketLocation, ListBucket and GetObject on bucket examkiller
B. It will create an IAM policy for the user test
C. It will result in an error saying invalid policy statement
D. Allows the user test of the AWS account ID 12112112 to perform GetBucketLocation, ListBucket and GetObject on the bucket examkiller
Answer: D
Explanation: The IAM policy allows to test a user in the account 12112112 to perform: s3:GetBucketLocation
s3:ListBucket
s3:GetObject
Amazon S3 permissions on the examkiller bucket.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/access-policy-language-overview.html
Question No:150
You are leading a design meeting in your company to create an autoscaling group behind an Elastic Load Balancer in your VPC. There are very specific requirements coming about based on traffic and cost. Your management wants to scale out when necessary and scale in when instances are no longer needed to save on cost. What steps can you take to meet these requirements? (Choose 2 answers)
A. Create a policy using CloudWatch CPU Utilization that scales out if CPU utilization is greater than 75% for 2 minutes.
 
AWS_SAA-C01 Exam
B. Create a scaling policy that scales in during off hours.
C. Create a scaling policy that scales out during business hours.
D. Create a policy using CloudWatch CPU Utilization that scales in if CPU utilization is less than 40% for 2 minutes.
Answer: A,D
Explanation: You can associate more than one scaling policy with an autoscaling group. Having one policy to scale out and one policy to scale in is a viable option. Scaling out during business hours and scaling in during off hours could be fairly effective for performance and cost. But scaling out and in using CloudWatch metrics for CPU utilization would be much more precise for both performance and cost considerations.
Reference: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-polic y.html
Question No:151
Consider objects created with a well-defined lifecycle. Initially, the objects are frequently accessed for a period of 30 days. After the initial period, the frequency of access diminishes where objects are infrequently accessed for up to 90 days. After that, the objects are no longer needed. You may choose to archive or delete them. Which of the following actions defined by lifecycle configuration can be used in this scenario?
A. Versioning and transition
B. Authentication and versioning C. Expiration and versioning
D. Expiration and transition Answer: D
Explanation: Consider objects created with a well-defined lifecycle. Initially, the objects are frequently accessed for a period of 30 days. After the initial period, the frequency of access diminishes where objects are infrequently accessed for up to 90 days. After that, the objects are no longer needed. You may choose to archive or delete them. You can use a lifecycle configuration to define transition and expiration of objects that matches this example scenario (transition to STANDARD_IA 30 days after creation and transition to GLACIER 90 days after creation, and perhaps expire them after certain number of days).
 
AWS_SAA-C01 Exam
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html
Question No:152
A bucket owner from Account Red allows Account Blue's IAM users to upload or access objects in his bucket. An IAM user of Account Blue is trying to access an object created by the IAM user of account Red. What will happen in this scenario?
A. It is not possible to give permission to multiple IAM users
B. It is not possible that the IAM user of one account accesses objects of the other IAM user C. The bucket policy may not be created as S3 will give error due to conflict of Access Rights
D. Amazon S3 will verify proper rights given by the owner of Account Blue to the IAM user, the permissions granted by bucket owner, as well as the permissions given by IAM user Red to the object.
Answer: D
Explanation: If a IAM user is trying to perform some action on an object belonging to another AWS user’s bucket, S3 will verify whether the owner of the IAM user has given sufficient permission to him. It also verifies the policy for the bucket as well as the policy defined by the object owner.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-auth-workflow-object-ope ration.html
Question No:153
You have been assigned as a Solutions Architect to manage your company's VPC. Your predecessor's departure was sudden and you've been left with very little documentation. Without actually seeing the specific route table, what can you surmise from reviewing the existing route tables? (Choose 2 answers)
A. A route to a NAT instance indicates VPN communication with on-premises servers. B. A route to a virtual private gateway means that the subnet is public.
C. No route to an internet gateway or virtual private gateway indicates a private subnet. D. A route to an internet gateway means the subnet is public.
 
AWS_SAA-C01 Exam
Answer: C,D
Explanation: Your VPC has an implicit router and a main route table that you can modify. Each subnet you create must be associated with a route table. Adding an internet gateway and adding a route to that IGW facilitates traffic out to the Internet for a public subnet. NAT instance and NAT gateways are provided to allow instances in private subnets to gain internet access. Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html
Question No:154
Your company has put you in charge of moving their databases to the cloud using RDS. They wanted high availability which you have built into the design with a multi-AZ configuration. You have implemented your design and are just about ready to move it in to production. What additional step can you take to ensure a successful deployment?
A. Test failover for your DB instance and ensure that the read replica has been promoted to primary database in time to meet RTO objectives.
B. Test failover for your DB instance to see how long it takes and ensure that Amazon automatically facilitates the connection to the new database.
C. Test failover for your DB instance to see how long it takes and ensure that your programmatic connection to the new database is working.
D. Test failover for your DB instance and ensure that the autoscaling group spins up a new database instance to be the standby server.
Answer: C
Explanation: The Amazon RDS Service Level Agreement requires that you follow best practice guidelines. One of them is to test failover for your DB instance to understand how long the process takes for your use case and to ensure that the application that accesses your DB instance can automatically connect to the new DB instance after failover. Failover will occur in a multi-AZ configuration to a standby server. Read replicas are for scaling, not high availability, and are not involved in the failover process.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_BestPractices.html
Question No:155
Which of the following statements is true of an Auto Scaling group?
 
AWS_SAA-C01 Exam
A. An Auto Scaling group cannot span multiple regions.
B. An Auto Scaling group delivers log files within 30 minutes of an API call. C. Auto Scaling publishes new log files about every 15 minutes.
D. An Auto Scaling group cannot be configured to scale automatically. Answer: A
Explanation: An Auto Scaling group can contain EC2 instances that come from one or more Availability Zones within the same region. However, an Auto Scaling group cannot span multiple regions.
Reference: http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_AddAvailabilityZone.ht ml
Question No:156
An Auto Scaling group is running at the desired capacity of 5 instances and receives a trigger from the Cloudwatch Alarm to increase the capacity by 1. The cool down period is 5 minutes. Cloudwatch sends another trigger after 2 minutes to decrease the desired capacity by 1. What will be the count of instances at the end of 4 minutes?
A. 5
B. 6
C. 4
D. 7 Answer: B
Explanation: The cool down period is the time difference between the end of one scalingactivity (can be start or terminate) and the start of another one (can be start or terminate). During the cool down period, Auto Scaling does not allow the desired capacity of the Auto Scaling group to be changed by any other CloudWatch alarm. Thus, in this case the trigger from the second alarm will have no effect.
Reference: http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AS_Concepts.html#healthc heck
 
AWS_SAA-C01 Exam
Question No:157
Your new client is considering moving their compute environment to the cloud or at least a hybrid solution. You begin detailing the options available within a Virtual Private Cloud (VPC). The client's IT administrator is familiar with the concept of subnets but not fully versed on AWS subnets. What can you tell the admin about the types of AWS subnets available? (Choose 3 answers)
A. Public subnets B. Private subnets C. VPN subnets D. Hybrid subnets Answer: A,B,C
Explanation: When you create a VPC, it spans all the Availability Zones in the region. After creating a VPC, you can add one or more subnets in each Availability Zone. When you create a subnet, you specify the CIDR block for the subnet, which is a subset of the VPC CIDR block. Each subnet must reside entirely within one Availability Zone and cannot span zones. If a subnet's traffic is routed to an Internet gateway, the subnet is known as a public subnet. If a subnet doesn't have a route to the Internet gateway, the subnet is known as a private subnet. If a subnet doesn't have a route to the Internet gateway, but has its traffic routed to a virtual private gateway for a VPN connection, the subnet is known as a VPN-only subnet.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html
Question No:158
AWS provides two features that you can use to increase security in your VPC: security groups and network ACLs. Which of the following statements are true in relation to security groups and network ACLs in your VPC? (Choose 2 answers)
A. Security groups control inbound and outbound traffic for your instances B. Network ACLs control inbound and outbound traffic for your subnets.
C. Security groups control inbound and outbound traffic for your instances and for your subnets.
D. Network ACLs control inbound and outbound traffic for your subnets and outbound traffic for your instances
 
AWS_SAA-C01 Exam
Answer: A,B
Explanation: AWS provides two features that you can use to increase security in your VPC: security groups and network ACLs. Security groups control inbound and outbound traffic for your instances, and network ACLs control inbound and outbound traffic for your subnets. In most cases, security groups can meet your needs; however, you can also use network ACLs if you want an additional layer of security for your VPC.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Scenario2.html
Question No:159
You are working as a Solutions Architect for a healthcare company. You’ve been tasked with creating a Virtual Private Cloud to create a hybrid cloud solution. The cloud environment will need to connect to on-premises applications which can not be migrated to the VPC. Your requirements are to use the most reliable connection with the highest throughput possible? Which option can you use to get the hybrid environment operational to meet these requirements?
A. Internet Gateway
B. VPN
C. AWS Direct Connect D. AWS Redshift Answer: C
Explanation: Using AWS Direct Connect, you can establish private connectivity between AWS and your datacenter, office, or colocation environment, which in many cases can reduce your network costs, increase bandwidth throughput, and provide a more consistent network experience than Internet-based connections. Network latency over the Internet can vary given that the Internet is constantly changing how data gets from point A to B. With AWS Direct Connect, you choose the data that utilizes the dedicated connection and how that data is routed which can provide a more consistent network experience over Internet-based connections. Reference: https://aws.amazon.com/directconnect/
Question No:160
A user has created an Auto Scaling group using CLI. The user wants to enable CloudWatch detailed monitoring for that group. How can the user configure this?
A. Enable detail monitoring from the AWS console
 
AWS_SAA-C01 Exam
B. By default detailed monitoring is enabled for Auto Scaling
C. When the user sets an alarm on the Auto Scaling group, it automatically enables monitoring
D. Auto Scaling does not support detailed monitoring Answer: B
detail
 Explanation: CloudWatch is used to monitor AWS as well as the custom services. It provides either basic or detailed monitoring for the supported AWS products. In basic monitoring, a service sends data points to CloudWatch every five minutes, while in detailed monitoring a service sends data points to CloudWatch every minute. To enable detailed instance monitoring for a new Auto Scaling group, the user does not need to take any extra steps. When the user creates an Auto Scaling launch config as the first step for creating an Auto Scaling group, each launch configuration contains a flag named InstanceMonitoring.Enabled. The default value of this flag is true. Thus, the user does not need to set this flag if he wants detailed monitoring. Reference: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/as-metricscollected .html
Question No:161
Amazon Web Services (AWS) provides Elastic Load Balancing (ELB) to automatically distribute incoming web traffic across multiple Amazon Elastic Compute Cloud (Amazon EC2) instances. With Elastic Load Balancing, you can add and remove EC2 instances as your needs change without disrupting the overall flow of information. Which of the following is an incorrect statement in regards to Elastic Load Balancing?
A. ELB can distribute the requests to Amazon EC2 instances (servers) in multiple Availability Zones.
B. ELB can associate the load balancer with your domain name. C. ELB is free as you only pay for EC2 instances.
D. ELB supports the use of both the Internet Protocol version 4 (IPv4) and Internet Protocol version 6 (IPv6).
Answer: C
Explanation: As with all Amazon Web Services, you pay only for what you use. For Elastic Load Balancing, you pay for each hour or portion of an hour that the service is running, and you pay

AWS_SAA-C01 Exam
for each gigabyte of data that is transferred through your load balancer.
Reference: http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/SvcIntro.html
Question No:162
You are assisting an IT administrator for a client company over the phone. The administrator has created a public subnet and had added two EC2 instances to this subnet. But he is unable to access the Internet from these new EC2 instances and is asking for your assistance. What general checks can he make to ensure proper configuration and Internet access? (Choose 3 answers)
A. He should check that a jump box is created to route traffic from the EC2 instances to the Internet.
B. He should check to ensure Network ACLs and Security Groups allow ingress and egress.
C. He should check that an Internet Gateway is configured and that the route table routes Internet traffic to the Internet gateway.
D. He should check that the EC2 instances have either a public IP address or an Elastic IP address.
Answer: B,C,D
Explanation: To enable access to or from the Internet for instances in a VPC subnet, you must do the following:
. Attach an Internet gateway to your VPC.
. Ensure that your subnet's route table points to the Internet gateway.
. Ensure that instances in your subnet have a globally unique IP address (public IPv4 address, Elastic IP address, or IPv6 address).
. Ensure that your network access control and security group rules allow the relevant traffic to flow to and from your instance.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Internet_Gateway.html
Question No:163
You are involved in the design of a client's AWS cloud environment. A requirements meeting regarding storage leads to the need for EBS volumes in the design. Much of the design will require standard storage but there is a critical business application, which requires sustained IOPs performance. Which EBS storage option is best for critical apps that need high performance?
 
AWS_SAA-C01 Exam
A. General-purpose SSD B. Magnetic volumes
C. Provisioned IOPs SSD D. High IOPs SSD Answer: C
Explanation: Amazon RDS provides three storage types: magnetic, General Purpose (SSD), and Provisioned IOPS (input/output operations per second). Provisioned IOPS storage is designed to meet the needs of I/O-intensive workloads, particularly database workloads, that are sensitive to storage performance and consistency in random access I/O throughput. Provisioned IOPS volumes can range in size from 100 GB to 6 TB for MySQL, MariaDB, PostgreSQL, and Oracle DB engines.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html
Question No:164
An organization is planning to extend their data center by connecting their DC with the AWS VPC using the VPN gateway. The organization is setting up a dynamically routed VPN connection. Which of the below mentioned answers is not required to setup this configuration?
A. Border Gateway Protocol (BGP) Autonomous System Number (ASN) of the customergateway. B. The type of customer gateway, such as Cisco ASA, Juniper J-Series, Juniper SSG, Yamaha. C. Internet-routable IP address (static) of the customer gateway's external interface.
D. Elastic IP ranges that the organization wants to advertise over the VPN connection to the VPC. Answer: D
Explanation: The Amazon Virtual Private Cloud (Amazon VPC) allows the user to define a virtual networking environment in a private, isolated section of the Amazon Web Services (AWS) cloud. The user has complete control over the virtual networking environment. The organization wants to extend their network into the cloud and also directly access the internet from their AWS VPC. Thus, the organization should setup a Virtual Private Cloud (VPC) with a public subnet and a private subnet, and a virtual private gateway to enable communication with their data center network over an IPsec VPN tunnel. To setup this configuration the organization needs to use the Amazon VPC with a VPN connection. The organization network administrator must designate a physical appliance as a customer gateway and configure it. The organization would need the
 
AWS_SAA-C01 Exam
below mentioned information to setup this configuration:
. The type of customer gateway, such as Cisco ASA, Juniper J-Series, Juniper SSG, Yamaha
. Internet-routable IP address (static) of the customer gateway's external interface
. Border Gateway Protocol (BGP) Autonomous System Number (ASN) of the customer gateway, if the organization is creating a dynamically routed VPN connection.
. Internal network IP ranges that the user wants to advertise over the VPN connection to the VPC. Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html
Question No:165
When you force a failover of your DB instance in RDS, which of the following things does RDS do? (Choose 2 answers)
A. Automatically switches to a standby replica in another region
B. Updates the DNS record for the DB instance to point to the standby DB instance
C. Automatically switches to a standby replica in another Availability Zone if you have enabled Multi-AZ
D. Allocates a new Elastic IP which points to the new replica
Answer: B,C
Explanation: When you force a failover of your DB instance, Amazon RDS automatically switches to a standby replica in another Availability Zone if you have enabled Multi-AZ. The time it takes for the failover to complete depends on the database activity and other conditions at the time the primary DB instance became unavailable. Failover times are typically 60-120 seconds. However, large transactions or a lengthy recovery process can increase failover time. When the failover is complete, it can take additional time for the RDS console UI to reflect the new Availability Zone.
The failover mechanism automatically changes the DNS record of the DB instance to point to the standby DB instance. As a result, you will need to re-establish any existing connections to your DB instance.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.MultiAZ.html
Question No:166
You're tasked to set up an AWS media sharing framework for a new start up company. It will need a huge amount of persistent data storage for this framework, and data will be regularly uploaded, transferred and downloaded by customers. Which of the following storage options would be appropriate and cost effective for persistent storage in this case?
 
AWS_SAA-C01 Exam
A. Amazon Glacier or AWS Import/Export
B. AWS Import/Export or Amazon CloudFront C. Amazon EBS volumes or Amazon S3
D. AWS Import/Export or AWS Storage Gateway Answer: C
Explanation: Persistent storage—If you need persistent virtual disk storage similar to a physical disk drive for files or other data that must persist longer than the lifetime of a single Amazon EC2 instance, Amazon EBS volumes or Amazon S3 are more appropriate. There is also the cost of data uploads as well as frequent transfers and downloads. While Glacier would be an effective archival service, the data may be accessed frequently, which would get expensive quickly for this start up.
Reference: https://aws.amazon.com/products/storage/
Question No:167
Your company is going to a hybrid cloud environment. You have been tasked to lead the design and implementation of this effort. You recommend Route 53 as a DNS solution for the cloud environment. What features of Route 53 will enable seamless integration into your overall DNS solution? (Choose 3 answers)
A. Route 53 can handle on-premises DNS resolution on its own.
B. Route 53 can use geo-based, weighted, and latency-based routing. C. Route 53 can be configured for failover situations.
D. Route 53 can host public domain names for external web apps. Answer: B,C,D
Explanation: As you establish private connectivity between your on-premises networks and your AWS Virtual Private Cloud (VPC) environments, the need for Domain Name System (DNS) resolution across these environments grows in importance. One common approach used to address this need is to run DNS servers on Amazon EC2 across multiple Availability Zones (AZs) and integrate them with private on-premises DNS domains. Simple AD provides redundant and managed DNS services across AZs. These DNS services automatically forward requests for non-authoritative domains to the VPC-provided DNS. Therefore, they can be used to resolve DNS records stored in a Route 53 private hosted zone.
 
AWS_SAA-C01 Exam
Question No:168
One of your customers has EC2 instances in two different VPCs and you would like the instances in both VPCs to be able to easily communicate with each other. VPC peering seems like a good solution for doing this. However there are some things you need to consider. Which 2 of the following do you need to ensure are correct for this to work? (Choose 2 answers)
A. The VPCs are directly connected with a single peering connection. Transitive routing is not required.
B. The VPCs both need to have only public subnets
C. The VPCs both need to have EC2 instances with the same operating system D. The VPCs' CIDR blocks cannot overlap.
Answer: A,D
Explanation: To create a VPC peering connection with another VPC, you need to be aware of the following limitations and rules:
. You cannot create a VPC peering connection between VPCs that have matching oroverlapping IPv4 or IPv6 CIDR blocks. Amazon always assigns your VPC a unique IPv6 CIDR block. If your IPv6 CIDR blocks are unique but your IPv4 blocks are not, you cannot create the peering connection.
. Transitive routing is not supported - that is you cannot route traffic through a intermediate (shared) VPC.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/PeeringGuide/vpc-peering-overview.html#v pc-peering-limitations
Question No:169
You have set up a default VPC (Virtual Private Cloud) with default subnets, and have launched EC2 instances into those subnets. Which of the following statements are true regarding instances launched within a default VPC with default subnets? (Choose 2 answers)
A. A private IP address is assigned by default, you need to manually assign a public IP address B. You need to manually assign a private IP address and a public IP address
C. A public IP address is assigned by default.
D. A private IP address is assigned by default.
 
AWS_SAA-C01 Exam
Answer: C,D
Explanation: Instances that you launch into a default subnet receive both a public IPv4 address and a private IPv4 address. Instances in a default subnet also receive both public and private DNS hostnames. Instances that you launch into a non-default subnet in a default VPC don't receive a public IPv4 address or a DNS hostname.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/default-vpc.html
Question No:170
You've taken over management of your company's AWS cloud environment. You know very little about the environment and have been provided very little documentation. You have been given access to the environment and begin a discovery and documentation process. You begin looking at the route table and see the Default Route. What do you know about the Default Route? (Choose 2 answers)
A. The default route must point to the Internet Gateway.
B. The default route must be modified for a hybrid cloud environment. C. The default route can not be removed or modified.
D. The default route enables communication within the VPC.
Answer: C,D
Explanation: Each subnet in your VPC must be associated with a route table; the table controls the routing for the subnet. A subnet can only be associated with one route table at a time, but you can associate multiple subnets with the same route table. Every route table contains a local route for communication within the VPC over IPv4. If you've associated an IPv6 CIDR block with your VPC, every route table also contains a local route for communication within the VPC over IPv6. You cannot modify or delete these routes.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html
Question No:171
You are creating an application which stores extremely sensitive financial information. All information in the system must be encrypted at rest and in transit. Which of these is a violation of this policy?
A. ELB Using Proxy Protocol v1.
 
AWS_SAA-C01 Exam
B. CloudFront Viewer Protocol Policy set to HTTPS redirection. C. ELB SSL termination.
D. Telling S3 to use AES256 on the server-side.
Answer: C
Explanation: Terminating SSL terminates the security of a connection over HTTP, removing the S for "Secure" in HTTPS. This violates the "encryption in transit" requirement in the scenario. Reference: http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/elb-listener-confi g.html
Question No:172
You have been put in charge of your company's Virtual Private Cloud (VPC). The environment lacks sufficient documentation. You are investigating the VPC in an effort to document the environment. Your review includes the route tables. What relationships between route tables and subnets can you count on being present in the environment? (Choose 2 answers)
A. There must only be one subnet for one route table B. Subnets are not related to route tables
C. If a route table is not associated with a subnet, the subnet will be associated with the main route table
D. Each subnet must be associated with a route table
Answer: C,D
Explanation: Each subnet must be associated with a route table, which controls the routing for the subnet. If you don't explicitly associate a subnet with a particular route table, the subnet is implicitly associated with the main route table. A route in the route table to an Internet Gateway marks the subnet as a public subnet and no route to an Internet Gateway marks the subnet as private.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html
Question No:173
You have been assigned to improve security on your company's S3 buckets. You review the
 
AWS_SAA-C01 Exam
configuration and find a course grained security approach using Access Control Lists. What can you implement to offer a finer grained security approach? (Choose 3 answers)
A. Encrypted keys
B. AWS IAM Policies
C. S3 Bucket Policies
D. Query-string authentication Answer: B,C,D
Explanation: When you create a bucket or object in Amazon S3, only you have access. To give control to others you can use course grained controls (Access Control Lists), and fine grained controls (bucket policies, IAM policies, and query-string authentication)
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html
Question No:174
You are designing an AWS cloud environment for a small company with limited budget. They have decided to go with a single-AZ database deployment to ensure the implementation remains within budget. You have convinced them of the benefits of doing automatic backups andsaving incremental backups to Amazon S3. What would be the best time to perform these automatic backups?
A. Amazon will determine the best time B. After midnight
C. During the daily low in write IOPS
D. Two hours before the work day starts Answer: C
Explanation: It is best practice to enable automatic backups and set the backup window to occur during the daily low in write IOPS. Amazon RDS creates automated backups of your DB instance during the backup window of your DB instance. Amazon RDS saves the automated backups of your DB instance according to the backup retention period that you specify. If necessary, you can recover your database to any point in time during the backup retention period.
Reference:
 
AWS_SAA-C01 Exam
http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_BestPractices.html
Question No:175
A storage admin wants to encrypt all the objects stored in S3 using server side encryption. The user does not want to use the AES 256 encryption key provided by S3. How can the user achieve this?
A. The admin should use CLI or API to upload the encryption key to the S3 bucket. When making a call to the S3 API mention the encryption key URL in each request
B. S3 does not support client supplied encryption keys for server side encryption
C. The admin should upload his secret key to the AWS console and let S3 decrypt the objects D. The admin should send the keys and encryption algorithm information with each API call Answer: D
Explanation: Amazon S3 supports client side or server side encryption to encrypt all data at rest. The server side encryption can either have the S3 supplied AES-256 encryption key or the user can send the key along with each API call to supply his own encryption key. Amazon S3 never stores the user’s encryption key. The user has to supply it for each encryption or decryption call. Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.htm l
Question No:176
A user has configured a CloudWatch alarm to fire off when the CPU utilization metric goes over 50% with a time interval of 5 minutes for 10 consecutive periods. What will be the state of the alarm at the end of 30 minutes, if the CPU utilization is constant at 20%?
A. ALERT
B. ALARM
C. INSUFFICIENT_DATA D. OK
Answer: D
 
AWS_SAA-C01 Exam
Explanation: In this case the alarm watches a metric every 5 minutes for 10 intervals. Thus, it needs atleast 50 minutes to come to the state. Till then it will be in the OK state as the metric is within the defined threshold.
Reference: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/AlarmThatSendsE mail.html
Question No:177
An organization has setup Auto Scaling with ELB. Due to some manual error, one of the instances got rebooted. Thus, it failed the Auto Scaling health check. Auto Scaling has marked it for replacement. How can the system admin ensure that the instance does not get terminated?
A. It is not possible to change the status once it is marked for replacement
B. Change the health of the instance to healthy using the Auto Scaling commands
C. Update the Auto Scaling group to ignore the instance reboot event
D. Manually add that instance to the Auto Scaling group after reboot to avoid replacement Answer: B
Explanation: After an instance has been marked unhealthy by Auto Scaling, as a result of an Amazon EC2 or ELB health check, it is almost immediately scheduled for replacement as it will never automatically recover its health. If the user knows that the instance is healthy then he can manually call the SetInstanceHealth action (or the as-set-instance-health command from CLI) to set the instance's health status back to healthy. Auto Scaling will throw an error if the instance is already terminating or else it will mark it healthy.
Reference: http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-maintain-instance-level s.html
Question No:178
Can a user get a notification of each instance start/termination through Auto Scaling?
A. Yes, always
B. Yes, if configured SNS with the Auto Scaling group C. No
 
AWS_SAA-C01 Exam
D. Yes, if configured SNS with the Launch Config Answer: B
Explanation: The user can get notifications using SNS if he has configured the notifications while creating the Auto Scaling group.
Reference: http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/GettingStartedTutorial.htm l
Question No:179
A user has launched an EBS backed EC2 instance in the US-East-1a region. The user stopped the instance and started it back after 20 days. AWS throws up an ‘InsufficientInstanceCapacity’ error. What can be the possible reason for this?
A. AWS zone mapping is changed for that user account
B. There is some issue with the host capacity on which the instance is launched C. The user account has reached the maximum EC2 instance limit
D. AWS does not have sufficient capacity in that availability zone
Answer: D
Explanation: When the user gets an ‘InsufficientInstanceCapacity’ error while launching or starting an EC2 instance, it means that AWS does not currently have enough available capacity to service the user request. If the user is requesting a large number of instances, there might not be enough server capacity to host them. The user can either try again later, by specifying a smaller number of instances or changing the availability zone if launching a fresh instance. Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-capacity.html
Question No:180
You have been contracted by a radiology firm to move their compute environment to the AWS cloud. They have a customer facing website but also desktop applications, some of which can not be migrated to the cloud. This calls for a hybrid cloud solution. For the database, they need high availability and high performance. Your design will include and RDS database in a multi-AZ deployment for high availability. But the database also needs to be high performance (writing radiology images) and multi-AZ can introduce some latency due to synchronous replication. In addition to multi-AZ for high availability, what design consideration will provide high write performance?
 
AWS_SAA-C01 Exam
A. use read replicas to offload read traffic
B. Keep the DB on-premises and use Direct Connect
C. offload DB writes to the standby replica
D. DB instance classes that are optimized for Provisioned IOPS Answer: D
Explanation: DB instances using Multi-AZ deployments may have increased write and commit latency compared to a Single-AZ deployment, due to the synchronous data replication that occurs. You may have a change in latency if your deployment fails over to the standby replica, although AWS is engineered with low-latency network connectivity between Availability Zones. For production workloads, we recommend you use Provisioned IOPS and DB instance classes (m1.large and larger) that are optimized for Provisioned IOPS for fast, consistent performance. Reference: http://docs.aws.amazon.com/Ama...
Question No:181
You are leading the design of your company's AWS cloud network. It's clear that for some departments you will need to create some high performance clusters. You are at the preliminary design stages and need general guidelines for the creation of these clusters. What features will enable the creation of these clusters? (Choose 3 answers)
A. Use dedicated hosts.
B. Use Placement Groups.
C. Use instances with enhanced networking capability. D. Only use instance types with 10GB performance. Answer: B,C,D
Explanation: A placement group is a logical grouping of instances within a single Availability Zone. Placement groups are recommended for applications that benefit from low network latency, high network throughput, or both. To provide the lowest latency, and the highest packet-per-second network performance for your placement group, choose an instance type that supports enhanced networking.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html
 
AWS_SAA-C01 Exam
Question No:182
Which of the below mentioned statements is false with respect to the public DNS of an EC2 instance?
A. It is mapped to the primary network interface.
B. It is linked with the user AWS account.
C. The public DNS cannot be changed by the user.
D. It can be used to access the instance from the internet. Answer: B
Explanation: When a user has launched an EC2 instance, AWS assigns a public and a private DNS to the instance. Both the private and public DNS are mapped using NAT. The EBS backed instance, if started / stopped, will always have a new public and private DNS. However, an instance store backed AMI will have single only a public DNS throughout the lifecycle as they cannot be re-started / stopped.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-instance-addressing.html
Question No:183
Your client is a major U.S. sports league. Their Website has High Definition game content and special feature videos which they distribute to free and premium customers alike. They have asked for improvements in the speed of delivering this content and you recommend CloudFront. They would like to restrict access of a portion of this content to premium level subscription customers. What technique can you use to allow only premium customers to access certain content?
A. geo restriction
B. signed urls
C. S3 Access Control Lists D. third party geo-location Answer: B
Explanation: Many companies that distribute content via the Internet want to restrict access to documents, business data, media streams, or content that is intended for selected users, for
 
AWS_SAA-C01 Exam
example, users who have paid a fee. To securely serve this private content using CloudFront, you can do the following:
. Require that your users access your private content by using special CloudFront signed URLs or signed cookies.
. Require that your users access your Amazon S3 content using CloudFront URLs, not Amazon S3 URLs.
Reference: http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.htm l
Question No:184
You are authoring a Logical Technical Model for your company's AWS Virtual Private Cloud. This document will be a key reference for the technical team administering the VPC. You detail the steps to retrieve Instance metadata such as associated security groups, instance ID, instance type, and the AMI used to launch the instance. What URL will you document to retrieve this data?
A. http://169.254.169.254/latest/instance/meta-data/ B. http://169.254.169.254/latest/instance-meta-data/ C. http://254.169.254.169/latest/meta-data/
D. http://169.254.169.254/latest/meta-data/
Answer: D
Explanation: Instance metadata is data about your instance that you can use to configure or manage the running instance. Because your instance metadata is available from your running instance, you do not need to use the Amazon EC2 console or the AWS CLI. To view all categories of instance metadata from within a running instance, use the following URI: http://169.254.169.254/latest/meta-data/.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html
Question No:185
A company has contracted you to move their web application and database to the cloud. They also have on-premises applications that will remain and interact with their cloud environment in a hybrid solution. You are working with their IT security engineer in designing a secure solution. Specifically, you are reviewing Identity and Access Management (IAM) features of AWS. Which AWS IAM best practice provides an additional layer of protection for user identity verification?
 
AWS_SAA-C01 Exam
A. EC2 key pair login
B. Multifactor authentication C. Grant Least Privilege
D. Password policies Answer: B
Explanation: For extra security, enable multi-factor authentication (MFA) for privileged IAM users (users who are allowed access to sensitive resources or APIs). When you create IAM policies, follow the standard security advice of granting least privilege—that is, granting only the permissions required to perform a task. Determine what users need to do and then craft policies for them that let the users perform only those tasks. If you allow users to change their own passwords, require that they create strong passwords and that they rotate their passwords periodically. EC2 key pairs are not a part of IAM. You can configure EC2 instances and be given a key pair outside of any IAM policies you create.
Reference: http://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html
Question No:186
A user is running a critical batch process which runs for 1 hour and 50 mins every day at a fixed time. Which of the below mentioned options is the right instance type and costing model inthis case if the user performs the same task for the whole year?
A. EBS backed scheduled reserved instance with partial instance pricing. B. EBS backed instance with on-demand instance pricing.
C. Instance store backed instance with spot instance pricing.
D. EBS backed instance with standard reserved upfront instance pricing. Answer: B
Explanation: For Amazon Web Services, the reserved instance (standard or convertible) helps the user save money if the user is going to run the same instance for a longer period. Generally if the user uses the instances around 30-40% of the year annually it is recommended to use RI. Here as the instance runs only for 1 hour 50 minutes daily, or less than 8 percent of the year, it is not recommended to have RI as it will be costlier. At its highest potential savings, you are still paying 25 percent of an annual cost for a reserved instance you are you using less than 2 hours a day, (or less than 8 percent of each year) you are not saving money.
 
AWS_SAA-C01 Exam
Even a scheduled reserved instance has a key limitation, which is that it cannot be stopped or rebooted, only manually terminated with a possibility that it could be restarted. You would have to terminate and restart it within the 1 hour 50 minute window, otherwise you would need to wait until the next day. For a critical daily process, this is likely not an option.
Spot Instances are not ideal because the process is critical, and must run for a fixed length of time at a fixed time of day. Spot instances would stop and start based on fluctuations in instance pricing, leaving this process potentially unfinished.
The user should use on-demand with EBS in this case. While it has the highest cost, it also has the greatest flexibility to ensure that a critical process like this is always completed.
Reference: http://aws.amazon.com/ec2/purchasing-options/reserved-instances/
Question No:187
You are leading the design for your company’s new AWS cloud environment. Your company has always had on-premise database solutions and values having admin access to the database server at the OS level. But you've chosen an RDS for the back-end solution. Your CTO asks about the scalability of this solution. What features allow RDS to be able to scale efficiently? (Choose 3 answers)
A. You can scale IO performance by increasing the number of IOPs to the DB.
B. You can use multi-AZ to be able to change the instance size without downtime. C. You can utilize sharding to distribute workload over multiple DB instances.
D. You can administer the database at the operating system level.
Answer: A,B,C
Explanation: As a managed service, Amazon RDS takes care of the scaling of your relational database so your database can keep up with the increasing demands of your application or applications. There is minimal downtime when you are scaling up on a Multi-AZ environment because the standby database gets upgraded first, then a failover will occur to the newly sized database. A Single-AZ instance will be unavailable during the scale operation.
Question No:188
Is it possible to get a history of all EC2 API calls made on your account for security analysis and operational troubleshooting purposes?
A. Yes, you should turn on the CloudTrail in the AWS console. B. Yes, by default, the history of your API calls is logged.
 
AWS_SAA-C01 Exam
C. No, you can only get a history of VPC API calls.
D. No, you cannot store history of EC2 API calls on Amazon. Answer: A
Explanation: To get a history of all EC2 API calls (including VPC and EBS) made on your account, you simply turn on CloudTrail in the AWS Management Console.
Reference: https://aws.amazon.com/ec2/faqs/
Question No:189
How can you change the instance type used in an Auto Scaling Group?
A. By creating and attaching a new launch configuration with a new instance type to an AS group
B. By deleting and recreating the AS Group
C. By stopping instances and changing the type D. It is not possible to change the instance type. Answer: A
Explanation: A launch configuration is a template that the Auto Scaling group uses to launch Amazon EC2 instances. You create the launch configuration by including information such as the Amazon Machine Image ID to use for launching the EC2 instance, the instance type, key pairs, security groups, and block device mappings, among other configuration settings. When you create your Auto Scaling group, you must associate it with a launch configuration. You can attach only one launch configuration to an Auto Scaling group at a time.
Launch configurations cannot be modified. They are immutable.
If you want to change the launch configuration of your Auto Scaling group, you have to first create a new launch configuration and then update your Auto Scaling group by attaching the new launch configuration.
When you attach a new launch configuration to your Auto Scaling group, any new instances are launched using the new configuration parameters. Existing instances are not affected. Reference: http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/LaunchConfiguration.html
Question No:190
In general, when using EC2 On-Demand instances, you are billed per-second when .
  
AWS_SAA-C01 Exam
(Choose 2 answers)
A. your EC2 instance is in a running state
B. your instance has a Linux operating system.
C. EC2 instances stop
D. your instance has a Windows operating system. Answer: A,B
Explanation: You are billed per-second with a one-minute minimum for On-Demand, Spot and Reserved instances as long as your EC2 instance is in a running state, provided the instance is Linux (with some exceptions), and not a Windows operating system, in which case the instance would be billed per-hour.
Reference: http://aws.amazon.com/ec2/faqs/
Question No:191
Can you encrypt EBS volumes?
A. Yes, you can enable encryption when you create a new EBS volume using the AWS Management Console, API, or CLI.
B. No, you cannot encrypt EBS volumes.
C. Yes, but you must use a third-party API for encrypting data before it's loaded on EBS. D. Yes, you can encrypt with the special "ebs_encrypt" command through Amazon APIs. Answer: A
Explanation: With Amazon EBS encryption, you can now create an encrypted EBS volume and attach it to a supported instance type. Data on the volume, disk I/O, and snapshots created from the volume are then all encrypted. The encryption occurs on the servers that host the EC2 instances, providing encryption of data as it moves between EC2 instances and EBS storage. EBS encryption is based on the industry standard AES-256 cryptographic algorithm.
To get started, simply enable encryption when you create a new EBS volume using the AWS Management Console, API, or CLI. Amazon EBS encryption is available for all the latest EC2 instances in all commercially available AWS regions.
Reference: https://aws.amazon.com/about-aws/whats-new/2014/05/21/Amazon-EBS-encryption-now-
 
AWS_SAA-C01 Exam
available/
Question No:192
AWS uses the term
easily, with minimal friction.
A. Elastic
B. Flexible
C. Large-scale D. N+1 Answer: A
to describe the ability to scale computing resources up and down
  Explanation: Amazon AWS is based on the concept of elasticity: it means that you can use instances and other AWS resources without any restrictions on scalability or limits on the amount of available resources.
Reference: http://aws.amazon.com/ec2/
Question No:193
What's the size limit of an Amazon EBS Magnetic volume?
A. 4 TB
B. 1 TB
C. 100 GB D.16 TB Answer: B
Explanation: You can create EBS Magnetic volumes from 1 GiB to 1 TB in size. Although they are a previous generation volume, they are still available. You can, however, create EBS General Purpose (SSD) and Provisioned IOPS (SSD) volumes up to 16 TiB in size.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html
Question No:194

AWS_SAA-C01 Exam
You have been assigned to review an AWS VPC which houses web servers and an RDS database. The client is having difficulty with auto scaling and has noted that the auto scaling group doesn't appear to be scaling up appropriately. The auto scaling group is set to have of minimum of three instances and a maximum of six instances. You also notice several scheduled scaling actions. You notice that there is a scale up activity at 7:30 pm and also a scale down activity at 7:30 pm. What will happen in this situation?
A. There will be an error message noting the conflict at 7:30 pm.
B. A time conflict is resolved by scaling up.
C. A time conflict is resolved by scaling down.
D. The scaling actions will be executed in the order they are in the auto scaling group. Answer: A
Explanation: When you create a scheduled action, keep the following in mind.
. Auto Scaling guarantees the order of execution for scheduled actions within the same group, but not for scheduled actions across groups.
. A scheduled action generally executes within seconds. However, the action may be delayed for up to two minutes from the scheduled start time. Because Auto Scaling executes actions within an Auto Scaling group in the order they are specified, scheduled actions with scheduled start times close to each other can take longer to execute.
. You can create a maximum of 125 scheduled actions per Auto Scaling group.
. A scheduled action must have a unique time value. If you attempt to schedule an activity at a time when another scaling activity is already scheduled, the call is rejected with an error message noting the conflict.
. Cooldown periods are not supported.
Reference: http://docs.aws.amazon.com/autoscaling/latest/userguide/schedule_time.html
Question No:195
Which choice below accurately describes the 'warm standby' disaster recovery method?
A. Storing critical systems as a template, from which resources can be scaled out in the event of a disaster.
B. A duplicate version of only your business-critical systems that is always running, in case you need to divert your workloads to them in the event of a disaster.
C. Keeping data backed up to tape and sent offsite regularly, from which all data can be restored in the event of a disaster.
 
AWS_SAA-C01 Exam
D. A complete duplicate of your entire system, to which all traffic can be directed in the event of a disaster.
Answer: B
Explanation: Warm standby is essentially ready to go with all key services running in the most minimal possible way, essentially a smaller version of the production environment. In the event of a disaster, the standby environment will be scaled up for production load quickly and easily. DNS records will be changed to route all traffic to the AWS environment.
Reference: https://d1.awsstatic.com/whitepapers/aws-disaster-recovery.pdf
Question No:196
A gaming company comes to you and asks you to build them infrastructure for their site. They are not sure how big they will be as with all start ups they have limited money and big ideas. What they do tell you is that if the game becomes successful, like one of their previous games, it may rapidly grow to millions of users and generate tens (or even hundreds) of thousands of writes and reads per second. After considering all of this, you decide that they need a fully managed NoSQL database service that provides fast and predictable performance with seamless scalability. Which of the following databases do you think would best fit their needs?
A. Amazon DynamoDB
B. Any non-relational database. C. Amazon Redshift
D. Amazon RDS
Answer: A
Explanation: Amazon DynamoDB is a fully managed NoSQL database service that provides fast and predictable performance with seamless scalability. Amazon DynamoDB enables customers to offload the administrative burdens of operating and scaling distributed databases to AWS, so they don't have to worry about hardware provisioning, setup and configuration, replication, software patching, or cluster scaling.
Today's web-based applications generate and consume massive amounts of data. For example, an online game might start out with only a few thousand users and a light database workload consisting of 10 writes per second and 50 reads per second. However, if the game becomes successful, it may rapidly grow to millions of users and generate tens (or even hundreds) of thousands of writes and reads per second. It may also create terabytes or more of data per day. Developing your applications against Amazon DynamoDB enables you to start small and simply dial-up your request capacity for a table as your requirements scale, without incurring
 
AWS_SAA-C01 Exam
downtime. You pay highly cost-efficient rates for the request capacity you provision, and let Amazon DynamoDB do the work over partitioning your data and traffic over sufficient server capacity to meet your needs. Amazon DynamoDB does the database management and administration, and you simply store and request your data. Automatic replication and failover provides built-in fault tolerance, high availability, and data durability. Amazon DynamoDB gives you the peace of mind that your database is fully managed and can grow with your application requirements.
Reference: http://aws.amazon.com/dynamodb/faqs/
Question No:197
Content and Media Server is the latest requirement that you need to meet for a client.
The client has been very specific about his requirements such as low latency, high availability, durability, and access control. Potentially there will be millions of views on this server and because of “spiky” usage patterns, operations teams will need to provision static hardware, network, and management resources to support the maximum expected need. The Customer base will be initially low but is expected to grow and become more geographically distributed. Which of the following would be a good solution for content distribution?
A. Amazon S3 as the origin server and Amazon CloudFront for caching
B. Amazon S3 as both the origin server and for caching
C. AWS Storage Gateway as the origin server and Amazon EC2 for caching D. AWS CloudFront as both the origin server and for caching
Answer: A
Explanation: As your customer base grows and becomes more geographically distributed,using a high- performance edge cache like Amazon CloudFront can provide substantial improvements in latency, fault tolerance, and cost.
By using Amazon S3 as the origin server for the Amazon CloudFront distribution, you gain the advantages of fast in-network data transfer rates, simple publishing/caching workflow, and a unified security framework.
Amazon S3 and Amazon CloudFront can be configured by a web service, the AWS Management Console, or a host of third-party management tools.
Reference: http://media.amazonwebservices.com/architecturecenter/AWS_ac_ra_media_02.pdf
Question No:198
Making use of a(n)   when creating instances in Amazon EC2 is your best solution for
 
AWS_SAA-C01 Exam
providing the lowest latency network communication between multiple instances in EC2. A. virtual cluster
B. cluster placement group
C. virtual private cloud
D. isolated network
Answer: B
Explanation: A cluster placement group is a logical grouping of instances within a single AWS Availability Zone. Placement groups are recommended for applications that benefit from low network latency, high network throughput, or both. To provide the lowest latency, and the highest packet-per-second network performance for your placement group, choose an instance type that supports enhanced networking.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html
Question No:199
You are designing a cloud implementation for a client. They have requested a database that will serve data to a website as well as perform some complex reporting in a Data Warehouse. They are also looking for a durable location to store session state. Which design choices would meet the client's requirements? (Choose 3 answers)
A. Amazon Redshift for Data Warehousing/Reporting B. MySQL database to serve data to the website
C. DynamoDB for session state
D. An Instance Store for session state
Answer: A,B,C
Explanation: An RDS database such as MySQL is a good choice as the back end for a web server. Amazon Redshift is often paired with RDS to offload Data Warehousing/Reporting traffic. DynamoDB is a good choice for managing session state, shopping cart data, or time-series data. Reference: https://aws.amazon.com/products/databases/
Question No:200
 
AWS_SAA-C01 Exam
You are designing a cloud solution for a new client. They have a multi-tier application and would like high availability at both the Web and Database tiers. The database will be MySQL and will be a highly available, multi-AZ configuration. You describe the failover process to the client including how the failover mechanism automatically changes the DNS record of the DB instance to point to the standby DB instance. What additional step must you discuss with the clients technical team?
A. re-establishing connections to the DB instance
B. asynchronously replicating the primary database to the standby database C. converting read replicas to multi-AZ standbys
D. transferring MySQL license to the standby server
Answer: A
Explanation: In the event of a planned or unplanned outage of your DB instance, Amazon RDS automatically switches to a standby replica in another Availability Zone if you have enabled Multi-AZ. Failover times are typically 60-120 seconds. The failover mechanism automatically changes the DNS record of the DB instance to point to the standby DB instance. As a result, you will need to re-establish any existing connections to your DB instance.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.MultiAZ.html
Question No:201
The AWS “shared responsibility model” defines specific operational and security boundaries that you and AWS share in managing AWS resources within your account. Under this model, what term is used to define services such as Amazon S3 and Amazon DynamoDB?
A. container services
B. infrastructure services C. controlled services
D. abstracted services Answer: D
Explanation: For abstracted services, AWS operates the infrastructure layer, the operating system, and platforms and you access the endpoints to store and retrieve data. You are
 
AWS_SAA-C01 Exam
responsible for managing your data (including classifying your assets), and for using IAM tools to apply ACL-type permissions to individual resources at the platform level, or permissions based on user identity or user responsibility at the IAM user/group level.
Reference: https://d0.awsstatic.com/white...
Question No:202
A small business owner wants to create a static website for his business using S3. He is having difficulty in configuration and contracts you for ongoing support. Which steps should you put in place to host a static website on S3? (Choose 3 answers)
A. Specify index and error docs. B. Create an IIS service.
C. Make all files world readable. D. Enable static website hosting. Answer: A,C,D
Explanation: Configuring an S3 bucket for static website hosting requires creating a bucket with the same name as the desired website hostname. To host a static website you need to configure a bucket for website hosting and then upload the content of the static website to the bucket. Reference: https://d0.awsstatic.com/whitepapers/Security/AWS_Security_Best_Practices.pdf
Question No:203
A user has launched an EBS backed EC2 instance with a Windows operating system. Which statement below is accurate regarding how instances are billed when rebooted or stopped and restarted?
A. For every reboot or start/stop, the user will be charged as a separate hour.
B. Every reboot is charged by AWS as a separate hour, while multiple start/stop actionsduring a single hour will be counted as a single hour.
C. For rebooting AWS charges extra only once, while for every stop/start the user will be charged as a separate hour.
D. For rebooting AWS does not charge a new instance hour, while every stop or restart will be charged fee for a new instance hour as a separate hour.
 
AWS_SAA-C01 Exam
Answer: D
Explanation: For an EC2 instance launched with an EBS backed Windows AMI, each time the instance state is changed from stop to start/ running, AWS charges restart a new per-hour charge. Effective October 2, 2017, charges are calculated on a per-second basis for On-Demand, Spot and Reserved instances with Linux operating systems, with a minimum one-minute charge. Regardless of operating system, rebooting an instance AWS does not incur a charge an hour or one-minute minimum charge.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html
Question No:204
You are working with a large public library to transfer their archives to the cloud. A majority of their data does not need to be available immediately, and can be appropriately stored in AWS Glacier. However, this will be an ongoing migration involving huge amounts of data. What features of Glacier will ensure it can scale appropriately? (Choose 3 answers)
A. Each archive can store up to 40 TB of data.
B. Auto scaling can be used for Glacier archives.
C. Unlimited amount of data stored when used with multiple archives.
D. Glacier automatically scales based off of demand without need to provision more disk space. Answer: A,C,D
Explanation: There is an unlimited amount of data stored when used with multiple archives. Glacier automatically scales based off of demand without need to provision more disk space. There is no maximum limit to the total amount of data that can be stored in Amazon Glacier. Individual archives are limited to a maximum size of 40 terabytes.
Reference: https://aws.amazon.com/glacier/faqs/
Question No:205
You have taken on a client that has experience with the AWS cloud environment. They do not want a VPN connection because of bandwidth limitations and do not want to incur the expense of Direct Connect. However, they want a connection between their VPC and other AWS services without availability concerns or bandwidth constraints. What AWS service can help you meet these requirements?
A. Storage Gateway
 
AWS_SAA-C01 Exam
B. VM Import/Export
C. VPC Endpoints
D. Elastic Load Balancer Answer: C
Explanation: A VPC endpoint enables you to create a private connection between your VPC and another AWS service without requiring access over the Internet, through a NAT device, a VPN connection, or AWS Direct Connect. Endpoints are virtual devices. They are horizontally scaled, redundant, and highly available VPC components that allow communication between instances in your VPC and AWS services without imposing availability risks or bandwidth constraints on your network traffic.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-endpoints.html
Question No:206
An online gaming site asked you if you can deploy a database that is a fast, highly scalable NoSQL database service in AWS for a new site that he wants to build. Which database should you recommend?
A. Amazon RDS
B. Your choice of relational AMIs on Amazon EC2 and EBS C. Amazon Redshift
D. Amazon DynamoDB
Answer: D
Explanation: Amazon DynamoDB is ideal for database applications that require very low latency and predictable performance at any scale but don’t need complex querying capabilities like joins or transactions. Amazon DynamoDB is a fully-managed NoSQL database service that offers high performance, predictable throughput and low cost. It is easy to set up, operate, and scale.
With Amazon DynamoDB, you can start small, specify the throughput and storage you need, and easily scale your capacity requirements on the fly. Amazon DynamoDB automatically partitions data over a number of servers to meet your request capacity. In addition,DynamoDB automatically replicates your data synchronously across multiple Availability Zones within an AWS Region to ensure high-availability and data durability.
Reference: https://aws.amazon.com/running_databases/#dynamodb_anchor
 
AWS_SAA-C01 Exam
Question No:207
Your Linux EC2 instance suddenly fails to boot after you installed some software. What can you do to fix it?
A. Reboot the instance until it works again.
B. Contact AWS Support.
C. Create a snapshot and launch a newly created snapshot instead.
D. Launch a new EC2 instance, unmount failed EBS, mount it to the new one, fix the software issue and replace it back to the original instance.
Answer: D
Explanation: Some software can make your Linux EC2 instance crash. It is a good practice to create a snapshot before installing or doing something that might affect the entire system. For advanced users, the EBS Detach-Attach Technique is the best way to fix the problem, otherwise you have to contact AWS Support to assist you on the issue.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-snapshot.html
Question No:208
You have been placed in charge of a client's Virtual Private Cloud (VPC). The environment is currently a hybrid environment with communication between on-premises applications and resources within the VPC. The next phase of implementation is to provide specific EC2 instances with internet access and you know an Internet Gateway needs to be created. What features will an Internet Gateway provide? (Choose 2 answers)
A. The Internet Gateway provides network address translation for instances with public IP addresses.
B. The Internet Gateway can route traffic from public and private subnets.
C. The Internet Gateway can be configured to allow egress and ingress on specified ports. D. The Internet Gateway provides a target in the route tables for Internet routable traffic. Answer: A,D
Explanation: An Internet gateway is a horizontally scaled, redundant, and highly available VPC component that allows communication between instances in your VPC and the Internet. An
 
AWS_SAA-C01 Exam
Internet gateway serves two purposes: to provide a target in your VPC route tables for Internet- routable traffic, and to perform network address translation (NAT) for instances that have been assigned public IPv4 addresses.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Internet_Gateway.html
Question No:209
A client has contacted you about their AWS cloud environment. They have a VPC with two public subnets and a private subnet. They are using Network Access Control Lists to provide security for their VPC. However, they would like to have a bit more security at the instance level so you recommend security groups. What features of security groups are true for an Amazon VPC? (Choose 2 answers)
A. Security Groups are stateless.
B. You can change the security group that an instance is associated with after launch and the changes will take effect immediately.
C. Instances associated with the same security group can always communicate.
D. Instances associated with the same security group can not talk to each other unless rules are added specifically allowing communication.
Answer: B,D
Explanation: Instances associated with a security group can't talk to each other unless you add rules allowing it (exception: the default security group has these rules by default). By default, a security group includes an outbound rule that allows all outbound traffic. You can remove the rule and add outbound rules that allow specific outbound traffic only. If your security group has no outbound rules, no outbound traffic is allowed.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html
Question No:210
You have setup an Auto Scaling group. The cool down period for the Auto Scaling group is 7 minutes. The first scaling activity request for the Auto Scaling group is to launch two instances. It receives the activity question at time "t", and the first instance is launched at t+3 minutes, while the second instance is launched at t+4 minutes. How many minutes after time "t" will Auto Scaling accept another scaling activity request?
A. 14 minutes
 
AWS_SAA-C01 Exam
B. 7 minutes C. 11 minutes D. 10 minutes Answer: C
Explanation: If an Auto Scaling group is launching more than one instance, the cool down period for each instance starts after that instance is launched. The group remains locked until the last instance that was launched has completed its cool down period. In this case the cool down period for the first instance starts after 3 minutes and finishes at the 10th minute (3+7 cool down), while for the second instance it starts at the 4th minute and finishes at the 11th minute (4+7 cool down). Thus, the Auto Scaling group will receive another request only after 11 minutes. Reference: http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AS_Concepts.html
Question No:211
In EC2, what happens to the data in an instance store if an instance reboots (either intentionally or unintentionally)?
A. Data in the instance store will be lost.
B. Data persists in the instance store.
C. Data is deleted from the instance store for security reasons. D. Data is partially present in the instance store.
Answer: B
Explanation: The data in an instance store persists only during the lifetime of its associated instance. If an instance reboots (intentionally or unintentionally), data in the instance store persists. However, data on instance store volumes is lost under the following circumstances:
. Failure of an underlying drive
. The instance is stopped
. Terminating an instance
Reference: http://docs.amazonwebservices.com/AWSEC2/latest/UserGuide/InstanceStorage.html
Question No:212
 
AWS_SAA-C01 Exam
A user has enabled versioning on an S3 bucket. The user applies server side encryption for data at Rest. If the user is supplying his own keys for encryption (SSE-C), which of the below mentioned statements is true?
A. Amazon S3 does not allow the user to upload his own keys for server side encryption B. The SSE-C does not work when versioning is enabled
C. The user should use the same encryption key for all versions of the same object
D. It is possible to have different encryption keys for different versions of the same object Answer: D
Explanation: Amazon S3 supports client side or server side encryption to encrypt all data at rest. The server side encryption can either have the S3 supplied AES-256 encryption key, or the user can send the key along with each API call to supply his own encryption key (SSE-C). If the bucket is versioning-enabled, each object version uploaded by the user using the SSE-C feature can have its own encryption key. The user is responsible for tracking which encryption key was used for which object's version
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.htm l
Question No:213
Your company has decided to use EC2 Systems Manager to manage servers in a hybrid environment, with some virtual machines in AWS and others in another cloud provider. Your DevOps manager has asked you to create an IAM service role for your VMs in your hybrid environment, using AWS Tools for Windows PowerShell. In order to do so, which steps would you take?
A. (1) Create a trust policy that grants AssumeRole trust to the SSM service, and (2) use New- IAMRole to create a service role and enable the SSMServiceRole to create a session token.
B. (1) Use New-IAMRole to create a service role, and (2) use Register-IAMRolePolicy to grant AssumeRole trust to the SSM service and enable the SSMServiceRole to create a session token.
C. (1) Use the New-IAMRole to create a service role that grants the AssumeRole trust to the SSM service and (2) use Register-IAMRolePolicy to enable the SSMServiceRole to create a session token.
D. (1) Create a trust policy that grants AssumeRole trust to the SSM service, (2) use
 
AWS_SAA-C01 Exam
New-IAMRole to create a service role, and (3) use Register-IAMRolePolicy to enable the SSMServiceRole to create a session token.
Answer: D
Explanation: Servers and VMs in a hybrid environment require an IAM role to communicate with the Systems Manager SSM service. The role grants AssumeRole trust to the SSM service.
To create an IAM service role for servers and VMs in your hybrid environment using AWS Tools for Windows PowerShell, follow these steps.
1) Create a text file (in this example it is named SSMService-Trust.json) with the following trust policy. Save the file with the .json file extension.
{
"Version": "2012-10-17", "Statement":
{ "Effect":
"Allow",
"Principal": {"Service": "ssm.amazonaws.com"}, "Action": "sts:AssumeRole"
} }
2) Use New-IAMRole as follows to create a service role. This example creates a role named SSMServiceRole.
New-IAMRole -RoleName SSMServiceRole -AssumeRolePolicyDocument (Get-Content -raw SSMService-Trust.json)
3) Use Register-IAMRolePolicy as follows to enable the SSMServiceRole to create a session token. The session token gives your managed instance permission to execute commands using Systems Manager.
Register-IAMRolePolicy -RoleName SSMServiceRole -PolicyArn arn:aws:iam::ssm:policy/service-role/AmazonEC2
Reference: http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/systems-manager-managedins tances.html
Question No:214
A user has suspended the Auto Scaling process and updates the desired capacity of the Auto Scaling group. Which statements below is correct regarding this update?
A. The Auto Scaling will not allow modification of the desired capacity during the suspended process state
B. The desired capacity will get updated, but the scaling activity will not happen
 
AWS_SAA-C01 Exam
C. The desired capacity will not get updated as scaling is frozen
 
AWS_SAA-C01 Exam
D. The scaling activity will happen as this is manual scaling
Answer: B
Explanation: The user may want to stop the automated scaling processes on the Auto Scaling groups either to perform manual operations or during emergency situations. To perform this, the user can suspend one or more scaling processes at any time. When the process is suspended and the user changes the desired capacity, the changes will take effect, but Auto Scaling will not be executed. Thus, the scaling activity will not happen even though there is a difference between the desired capacity and the current capacity.
Reference: http://docs.aws.amazon.com/autoscaling/latest/userguide/WhatIsAutoScaling.html
Question No:215
You are architecting a VPC for a large organisation and you have configured an Amazon VPC for Elastic Load Balancing but you now want to create a Classic Internal Load Balancer. What would be the most logical thing to do first when creating this Classic Internal Load Balancer?
A. Select the subnets in which to launch your load balancer.
B. Configure the listeners for your load balancer by specifying the ports and protocols to use for front-end connection and back-end connection.
C. Configure a health check for your Amazon EC2 back-end instances. D. Add Amazon EC2 instances to your load balancer.
Answer: B
Explanation: Creating a Classic Internal Load Balancer in VPC involves the following steps:
1. Configure the listeners for your load balancer by specifying the ports and protocols to use for front-end connection (client to load balancer) and back-end connection (load balancer to back- end instance).
2. Configure a health check for your Amazon EC2 back-end instances.
3. Select the subnets in which to launch your load balancer.
4. Select security groups to assign to your load balancer.
5. Add Amazon EC2 instances to your load balancer.
6. [optional] Add tags to your load balancer.
7. Review settings.
8. Create your load balancer.
Reference: http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/USVPC_creating_
 
AWS_SAA-C01 Exam
basic_lb.html
Question No:216
You are running a legacy application in AWS that has a hard-coded IP address for your app. Which of the following scenarios would successfully provide a High Availability solution for the instance that is running the application? (Choose 2 answers)
A. Use spot instances to be allocated if the instance becomes unavailable.
B. Have a backup instance running with Elastic Load Balancing and configure Amazon Route 53 to check the health of your resources and respond to DNS queries using only the healthy resources
C. You don't need to do anything as it is hard-coded and hence will always be highly available.
D. Assign an elastic IP address to the EC2 instance and have a backup instance running. In the event of failure, move the Elastic IP from the primary instance to the backup instance.
Answer: B,D
Explanation: Amazon Route 53 lets you configure DNS failover in active-active, active-passive, and mixed configurations to improve the availability of your application. When you have more than one resource performing the same function, you can configure Amazon Route 53 to check the health of your resources and respond to DNS queries using only the healthy resources. Another solution would be to assign an elastic IP address to the EC2 instance and have a backup instance running. In the event of failure, move the Elastic IP from the primary instance to the backup instance.
Reference: http://docs.aws.amazon.com/quickstart/latest/exchange/design-ha.html
Question No:217
Your company is providing support to a media streaming company. The media company is streaming a sporting event during an Olympic year and expects increased traffic, but cannot rely on a good metric on how much additional traffic to expect. They have an autoscaling group behind an Elastic Load Balancer for streaming events. What steps can you take to insure the event is streamed successfully and also to maximize profits? (Choose 2 answers)
A. Add read replicas to your RDS.
B. Create a CloudWatch metric to send an alarm when reaching a bandwidth limit. C. Add additional reserved instances to your autoscaling group.
 
AWS_SAA-C01 Exam
D. Create a dynamic scaling policy.
Answer: B,D
Explanation: Dynamic scaling allows you to define parameters that control the autoscaling process in a scaling policy. The policy can add more EC2 instances when a bandwidth threshold is met, which can be tied to a CloudWatch alarm. Dynamic scaling is ideal to handle traffic spikes, whether expected or unexpected, and when you don't know the size of the spike. Reference: http://docs.aws.amazon.com/autoscaling/latest/userguide/autoscaling-load-balancer.html
Question No:218
You've been assigned to a client whose IT team has some basic knowledge of AWS cloud technology. They have deployed some EC2 instances in the cloud but now have requested expert assistance on a possible redesign. Your investigation of their cloud environment has revealed that they are using the default VPC provided by Amazon. What features of the default VPC can you be sure are in place? (Choose 2 answers)
A. There is one default subnet per region in the default VPC.
B. There is one default subnet per availability zone in the default VPC. C. There is one default VPC per region.
D. There is one default VPC per availability zone.
Answer: B,C
Explanation: A default VPC is ready for you to use — you can immediately start launching instances into your default VPC without having to perform any additional configuration steps. You can use a default VPC as you would use any other VPC; you can add subnets, modify the main route table, add additional route tables, associate additional security groups, update the rules of the default security group, and add VPN connections. You can also create additional VPCs.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/default-vpc.html
Question No:219
You need to develop and run some new applications on AWS and you know that Elastic Beanstalk and CloudFormation can both help as a deployment mechanism for a broad range of AWS resources. Which of the following is true when describing the differences between Elastic Beanstalk and CloudFormation?
 
AWS_SAA-C01 Exam
A. Elastic Beanstalk supports AWS CloudFormation application environments as one of the AWS resource types.
B. You can design and script custom resources in CloudFormation.
C. Elastic Beanstalk automates and simplifies the task of repeatedly and predictably creating groups of related resources that power your applications. CloudFormation does not.
D. AWS Elastic Beanstalk introduces two concepts: the template, a JSON or YAML-format, text-based file.
Answer: B
Explanation: These services are designed to complement each other. AWS Elastic Beanstalk provides an environment to easily deploy and run applications in the cloud. It is integrated with developer tools and provides a one-stop experience for you to manage the lifecycle of your applications. AWS CloudFormation is a convenient provisioning mechanism for a broad range of AWS resources. It supports the infrastructure needs of many different types of applications such as existing enterprise applications, legacy applications, applications built using a variety of AWS resources and container-based solutions (including those built using AWS Elastic Beanstalk). AWS CloudFormation supports Elastic Beanstalk application environments as one of the AWS resource types. This allows you, for example, to create and manage an AWS Elastic Beanstalk– hosted application along with an RDS database to store the application data. In addition to RDS instances, any other supported AWS resource can be added to the group as well. Reference: https://aws.amazon.com/cloudformation/faqs/
Question No:220
An organization is setting up a multi-site solution where the application runs on premise as well as on AWS to achieve the minimum recovery time objective (RTO). Which of the below mentioned configurations will not meet the requirements of the multi-site solution scenario?
A. Keep an application running on premise as well as in AWS with full capacity. B. Setup a single DB instance which will be accessed by both sites.
C. Setup a weighted DNS service like Route 53 to route traffic across sites.
D. Configure data replication based on RTO.
Answer: B
Explanation: AWS has many solutions for DR (Disaster recovery) and HA (High Availability).
 
AWS_SAA-C01 Exam
When the organization wants to have HA and DR with multi-site solution, it should setup two sites: one on premise and the other on AWS with full capacity. The organization should setup a weighted DNS service which can route traffic to both sites based on the weightage. When one of the sites fails it can route the entire load to another site. The organization would have minimal RTO in this scenario. If the organization setups a single DB instance, it will not work well in failover.
Instead they should have two separate DBs in each site and setup data replication based on RTO (recovery time objective) of the organization.
Reference: http://d36cz9buwru1tt.cloudfront.net/AWS_Disaster_Recovery.pdf
Question No:221
You are on a team designing and implementing your company's AWS cloud environment. It is a hybrid cloud environment with public and private subnets. It will require an Internet Gateway, and Virtual Private Gateway, and the team has decided to use NAT instances. What features of NAT instances will come in to play in this environment? (Choose 3 answers)
A. Forwards traffic to the Virtual Private Gateway.
B. Forwards internet traffic to the Internet Gateway.
C. NAT instances accept traffic from private subnets.
D. Translate the source IP address to the public IP address of the NAT instance. Answer: B,C,D
Explanation: You can use a network address translation (NAT) instance in a public subnet in your VPC to enable instances in the private subnet to initiate outbound IPv4 traffic to the Internet or other AWS services, but prevent the instances from receiving inbound traffic initiated by someone on the Internet. The NAT instance sends the traffic to the Internet gateway for the VPC. The traffic is attributed to the Elastic IP address of the NAT instance. The NAT instance specifies a high port number for the response; if a response comes back, the NAT instance sends it to an instance in the private subnet based on the port number for the response.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html
Question No:222
Amazon Elastic Load Balancing is used to manage traffic on a fleet of Amazon EC2 instances, distributing traffic to instances across all availability zones within a region. Elastic Load Balancing has all the advantages of an on-premises load balancer, plus several security benefits. Which of the following would be considered a security feature of Amazon Elastic Load
 
AWS_SAA-C01 Exam
Balancing?
A. Background virus scans of EBS volumes and EBS snapshots
B. Replication of data across multiple AWS Regions
C. AES-256 encryption of data stored on any shared storage device
D. Takes over the encryption and decryption work from the Amazon EC2 instances and manages it centrally on the load balancer
Answer: D
Explanation: Elastic Load Balancing has all the advantages of an on-premises load balancer, plus several security benefits:
. Takes over the encryption and decryption work from the Amazon EC2 instances and manages it centrally on the load balancer
. Offers clients a single point of contact, and can also serve as the first line of defense against attacks on your network
. When used in an Amazon VPC, supports creation and management of security groups associated with your Elastic Load Balancing to provide additional networking and securityoptions
. Supports end-to-end traffic encryption using TLS (previously SSL) on those networks that use secure HTTP (HTTPS) connections. When TLS is used, the TLS server certificate used to terminate client connections can be managed centrally on the load balancer, rather than on every individual instance.
Reference: https://d0.awsstatic.com/whitepapers/aws-security-whitepaper.pdf
Question No:223
A client contacts you to troubleshoot an issue with their company's VPC. An initial review of an architectural diagram appears to call for an Internet-facing load balancer and two auto scaling groups within a VPC. After logging in, you recognize that health checks are not reaching the EC2 instances launched in the VPC because the front-end connection (client to load balancer) has timed out.
What series of AWS recommended troubleshooting steps would likely resolve this issue? (Choose 3 answers)
A. Disable source/destination checks on the load balancer. B. Adjust the health check interval settings.
C. Verify the issue by connecting directly with the instance.
 
AWS_SAA-C01 Exam
D. Adjust response timeouts in your load balancer health check configuration.
Answer: B,C,D
Explanation: It is critical before making any major changes to your health checks to verify whether you can connect manually to the EC2 instances in question. Once you’ve verified you can connect to them manually, you can begin altering the health check settings.
Reference: http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/ts-elb-healthcheck.html#ts- elb-healthcheck-publickey
Question No:224
You've been assigned to assist a client in the creation of their AWS Virtual Private Cloud (VPC). You are shadowing their IT admin to allow the admin to create the VPC, learn, and benefitfrom your guidance. Which VPC components come automatically upon creation of the VPC. (Choose 3 answers)
A. Internet Gateways B. Security Groups C. Subnets
D. Route Tables Answer: B,C,D
Explanation: When you
. default subnet in each Availability Zone.
. main route table
. default security group
. default network access control list (ACL)
Associate the default DHCP options set for your AWS account with your default VPC. Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/default-vpc.html
Question No:225
You are working as a Solutions Architect for a Medical Insurance company. You’ve been tasked with creating a Virtual Private Cloud for a new Insurance application. However, the application will need to connect to an on-premises application which can not be migrated to the VPC. Your requirements are to get the connection setup as quickly as possible but speed and reliability are ultimate requirements as well. Which options can you use, first to meet short term requirements,
 creates a VPC, the following is created with it:

AWS_SAA-C01 Exam
and ultimately long term requirements of speed and reliability? (Choose 2 answers) A. Direct Connect
B. VPN
C. Gateway Stored Volumes
D. Bastion Host
Answer: A,B
Explanation: A VPN connection is the fastest way to complete the connection between on- premises computing and your VPC. However, VPN is not as reliable or as fast as Direct Connect. VPN would satisfy the requirement to establish the connection as quickly as possible. You can subsequently request a Direct Connect connection that is not subject to inconsistencies of the internet and will be faster and more reliable than VPN. Direct Connect can ultimately replace the VPN connection and all requirements will be satisfied.
Reference: https://aws.amazon.com/directconnect/faqs/
Question No:226
You client has asked for a caching solution in their AWS cloud. Their servers are processing more data than can be handled and bottlenecks are developing. You recommend Elasticacheas a solution and detail its scalability. What benefits of Elasticache can you detail? (Choose 2 answers)
A. You can add or delete nodes from a caching cluster on demand. B. You can scale by adding nodes for additional caching storage. C. Read replicas can be created for Elasticache nodes.
D. Multi-AZ Elasticache can be set up for scalability.
Answer: A,B
Explanation: By using Amazon ElastiCache you can scale to meet current demand, paying only for what you use. ElastiCache enables you to scale your cache to match demand. Memcached clusters comprises from 1 to 20 nodes. Scaling a Memcached cluster out and in can be accomplished by adding or removing nodes from the cluster.
Reference: http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Scaling.Memcached.htm
 
AWS_SAA-C01 Exam
l
Question No:227
Which of the following is true of Amazon EBS-backed Amazon Machine Images (AMI) and Amazon EC2 instance store-backed Amazon Machine Images (AMI)?
A. Amazon EBS-backed AMIs launch faster than Amazon EC2 instance store-backed AMIs.
B. With an Amazon EBS-backed AMI, all the parts have to be retrieved from Amazon Simple Storage Service (S3) before the instance is available.
C. When you launch an Amazon EC2 instance store-backed AMI, only the parts required to boot the instance need to be retrieved from the snapshot before the instance is available.
D. Amazon EC2 instance store-backed AMIs launch faster than Amazon EBS-backed AMIs.
Answer: A
Explanation: Amazon EBS-backed AMIs launch faster than Amazon EC2 instance store-backed AMIs. The reason for this is that when you launch an Amazon EC2 instance store-backed AMI, all the parts have to be retrieved from Amazon S3 before the instance is available. However, with an Amazon EBS-backed AMI, only the parts required to boot the instance need to be retrieved from the snapshot before the instance becomes available.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html
Question No:228
What choice below accurately describes the 'pilot light' disaster recovery method?
A. Storing critical systems as a template from which resources can be scaled out in the eventof a disaster.
B. Keeping data backed up to tape and sent offsite regularly, from which all data can be restored in the event of a disaster.
C. A duplicate version of only your business critical systems that is always running, in case you need to divert your workloads there in the event of a disaster.
D. A complete duplicate of your entire system, to which all traffic can be directed in the event of a disaster.
Answer: A
 
AWS_SAA-C01 Exam
Explanation: The pilot light method generally requires storing critical systems as a template within a database. In the event of a disaster, resources can be scaled out from around our ‘pilot light’. Instances can be launched using Amazon machine images, and databases can be resized to handle production data as required
Reference: https://d1.awsstatic.com/whitepapers/aws-disaster-recovery.pdf
Question No:229
If your AWS data must meet specific regulations such as the EU Data protection laws, what must you do?
A. Architect your environment to meet these security requirements
B. Move your data somewhere else so you don’t have to worry about extra security
C. Be aware that they exist and comply to them when and if you have time to do so
D. Keep that data on-premise and do not move it to the cloud under any circumstance Answer: A
Explanation: Some laws require specific security controls, retention requirements, etc, dependent on the data being stored. Other legislations exist where certain data may have to remain within a specific region and can not be transferred out of those boundaries. You need to architect your environment to meet these security requirement and mitigate the risk of data being stored in a geographic location that’s restricted. Breaches to this legislation could have a legal impact and lead to additional risks against your organization, so it's fundamental that you are aware of your data privacy and storage location laws and regulations.
Question No:230
After moving an E-Commerce website for a client from a dedicated server to AWS you have also set up auto scaling to perform health checks on the instances in your group and replace instances that fail these checks. Your client has come to you with his own health check system that he wants you to use as it has proved to be very useful prior to his site running on AWS. What do you think would be an appropriate response to this given all that you know about auto scaling and CloudWatch?
A. It is possible to implement your own health check system and then send the instance's health information directly from your system to CloudWatch.
B. It is possible to implement your own health check system and then send the instance's health information directly from your system to CloudWatch but only in the US East (N. Virginia)
 
AWS_SAA-C01 Exam
region.
C. It is not possible to implement your own health check system due to compatibility issues.
D. It is not possible to implement your own health check system. You need to use AWSs health check system.
Answer: A
Explanation: Auto Scaling periodically performs health checks on the instances in your group and replaces instances that fail these checks. By default, these health checks use the results of EC2 instance status checks to determine the health of an instance. If you use a load balancer with your Auto Scaling group, you can optionally choose to include the results of Elastic Load Balancing health checks.
Auto Scaling marks an instance unhealthy if the calls to the Amazon EC2 action DescribeInstanceStatus returns any other state other than running, the system status shows impaired, or the calls to Elastic Load Balancing action DescribeInstanceHealth returns OutOfService in the instance state field.
After an instance is marked unhealthy because of an Amazon EC2 or Elastic Load Balancing health check, it is scheduled for replacement.
You can customize the health check conducted by your Auto Scaling group by specifying additional checks or by having your own health check system and then sending the instance's health information directly from your system to Auto Scaling.
Reference: http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/healthcheck.html
Question No:231
A user has configured two security groups which allow traffic as given below:
1: SecGrp1:
Inbound on port 80 for 0.0.0.0/0
Inbound on port 22 for 0.0.0.0/0
2: SecGrp2:
Inbound on port 22 for 10.10.10.1/32
If both the security groups are associated with the same instance, which of the below mentioned statements is true?
A. It allows inbound traffic for everyone on both ports 22 and 80
B. It is not possible to have more than one security group assigned to a single instance C. It allows inbound traffic on port 22 for IP 10.10.10.1 and for everyone else on port 80
 
AWS_SAA-C01 Exam
D. It is not possible to create the security group with conflicting rules. AWS will reject the request
Answer: A
Explanation: A user can attach more than one security group to a single EC2 instance. In this case, the rules from each security group are effectively aggregated to create one set of rules. AWS uses this set of rules to determine whether to allow access or not. Thus, here the rule for port 22 with IP 10.10.10.1/32 will merge with IP 0.0.0.0/0 and open ports 22 and 80 for all.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html
Question No:232
You have been put in charge of your company's AWS RDS environment. You have begun designing a highly available RDS database using MySQL. You've designed the failover solution using multi-AZ. Additionally, you would like to design a proactive environment that self corrects before a failover occurs. You are reviewing ways to increase the I/O capacity of a DB instance. Which method is not an appropriate way to increase I/O for a database?
A. Convert the database from MySQL to MariaDB.
B. Migrate to a DB instance class with High I/O capacity.
C. Convert from standard storage to either General Purpose or Provisioned IOPS storage.
D. If you are already using Provisioned IOPS storage, provision additional throughput capacity. Answer: A
Explanation: If your database workload requires more I/O than you have provisioned, recovery after a failover or database failure will be slow. To increase the I/O capacity of a DB instance, do any or all of the following:
. Migrate to a DB instance class with High I/O capacity.
. Convert from standard storage to either General Purpose or Provisioned IOPS storage, depending on how much of an increase you need.
. If you convert to Provisioned IOPS storage, make sure you also use a DB instance class that is optimized for Provisioned IOPS.
. If you are already using Provisioned IOPS storage, provision additional throughput capacity. Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_BestPractices.html
Question No:233
 
AWS_SAA-C01 Exam
A user has enabled instance protection for an auto scaling group that has spot instances. When scaling in, if Auto Scaling wants to terminate instances in this auto scaling group, due to a CloudWatch trigger unrelated to bid price or a failed health check, what will happen?
A. Auto scaling overwrites the instance protection attribute and terminates the instances.
B. Auto Scaling will remove the instance from the protected Auto scaling group, and then terminate them.
C. The EC2 instance will not be terminated because instance protection from scale-in is enabled. D. Auto Scaling will notify the user for the next action.
Answer: C
Explanation: Auto Scaling protects instances from termination during scale-in events. This means that Auto Scaling instance protection will receive the CloudWatch trigger to delete instances, and delete instances in the Auto Scaling group that do not have instance protection enabled. However, instance protection won't protect spot instance termination triggered due to market price exceeding bid price.
Reference: http://docs.aws.amazon.com/autoscaling/latest/userguide/as-instance-termination.html#ins tance-protection
Question No:234
Your company has a VPC with one public and one private subnet. You have been asked to troubleshoot some Internet access problems with the EC2 instances in the private subnet. First, you verify that the Security Groups are configured properly and that the EC2 instance in the public subnet can access the Internet. It also appears that the NAT instance can access the Internet. The ACL has one line allowing inbound HTTP traffic.
What steps can you take to enable the private EC2 instances to access the Internet? (Choose 2 answers)
A. Allow outbound HTTP traffic in the ACL rules.
B. Disable Source/Destination check on the EC2 instances. C. Enable Source/Destination check on the NAT instance. D. Disable Source/Destination check on the NAT instance. Answer: A,D
 
AWS_SAA-C01 Exam
Explanation: There are a number of issues that could cause EC2 instances in a VPC to be unable to reach the Internet, including the following. An Internet Gateway must attached to the VPC for a public subnet. Ingress and egress for Security Groups and Access Control Lists must be correct. EC2 instances in a private subnet need a NAT instance or a NAT Gateway and for a NAT instance source/destination checks must be turned off. EC2 instances in a public subnet must have a route to the Internet Gateway in the route table.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html
Question No:235
You are managing a group of S3 buckets and have begun implementing a more fine grained control of your S3 buckets. You need to place restrictions on S3 buckets on a case-by-case basis. Which restrictions can you implement? (Choose 3 answers)
A. Restrict by IP Address. B. Restrict by time of day. C. Restrict by CIDR block. D. Restrict by AD group. Answer: A,B,C
Explanation: Using an S3 Bucket Policy, you can specify who can access the bucket, what time of day the can access, from which CIDR block, and by IP address.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html
Question No:236
You are building a system to distribute confidential documents to employees across the world. Using CloudFront, what method could be used to serve content that is stored in S3, but not publically accessible from S3 directly?
A. Create an Identity and Access Management (IAM) User for CloudFront and grant access to the objects in your S3 bucket to that IAM User.
B. Create a S3 bucket policy that lists the CloudFront distribution ID as the Principal and the target bucket as the Amazon Resource Name (ARN).
C. Add the CloudFront account security group “amazon-cf/amazon-cf-sg” to the appropriate S3 bucket policy.
 
AWS_SAA-C01 Exam
D. Create an Origin Access Identity (OAI) for CloudFront and grant access to the objects in your S3 bucket to that OAI.
Answer: D
Explanation: You restrict access to Amazon S3 content by creating an origin access identity, which is a special CloudFront user. You change Amazon S3 permissions to give the origin access identity permission to access your objects, and to remove permissions from everyone else. When your users access your Amazon S3 objects using CloudFront URLs, the CloudFront origin access identity gets the objects on your users' behalf. If your users try to access objects using Amazon S3 URLs, they're denied access. The origin access identity has permission to access objects in your Amazon S3 bucket, but users don't.
Reference: http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-rest ricting-access-to-s3.html
Question No:237
You are leading the design and implementation of an AWS cloud environment for a Marketing firm. Their on-premises environment is a standard three-tier web application. The database tier is an Oracle database. They would like a highly available, multi-AZ solution. Using the BYOL (bring your own license) model, how many Oracle licenses are needed?
A. 0 licenses: "bring your own license" is not supported by Amazon
B. Three licenses: one for the primary db, onefor the standby, and one for the read replica C. One license for the primary db
D. Two licenses: one for the primary db and one for the standby db
Answer: D
Explanation: Amazon RDS provides high availability and failover support for DB instances using Multi-AZ deployments. Amazon RDS uses several different technologies to provide failover support. Multi-AZ deployments for Oracle, PostgreSQL, MySQL, and MariaDB DB instances use Amazon's failover technology. SQL Server DB instances use SQL Server Mirroring. Amazon Aurora instances stores copies of the data in a DB cluster across multiple Availability Zones in a single region, regardless of whether the instances in the DB cluster span multiple Availability Zones. When using the BYOL licensing model, you must have a license for both the primary instance and the standby replica.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.MultiAZ.html
 
AWS_SAA-C01 Exam
Question No:238
To ensure secure services, AWS offers shared responsibility models for each of the different type of services that they offer which you need to be aware of. Which of the following services are the responsibility of AWS? (Choose 3 answers)
A. Network infrastructure
B. Physical security of hardware C. Amazon Machine Images (AMIs) D. Virtualization infrastructure Answer: A,B,D
Explanation: AWS is responsible for what is known as Security ‘of’ the Cloud. This covers their global infrastructure elements – Regions, Availability Zones, and Edge Locations, and also the foundations of their services covering Compute, Storage, Database, and Network
Question No:239
A user wants to build a self-resilient highly available application. Which of the following AWS services will help achieve these features?
A. Auto Scaling and Elastic Load Balancing
B. Amazon DynamoDB and Cloudwatch health check C. Amazon Glacier and Cloudwatch health check
D. EC2 and Redshift
Answer: A
Explanation: Amazon Elastic Compute Cloud (Amazon EC2) is a web service within Amazon Web Services that provides computing resources literally server instances that you use to build and host your software systems. Amazon EC2 is a natural entry point to Amazon Web Services for your application development. You can build a highly reliable and fault-tolerant system using multiple EC2 instances using the tools and ancillary services such as Auto Scaling and Elastic Load Balancing.
Reference: http://media.amazonwebservices.com/AWS_Building_Fault_Tolerant_Applications.pdf
 
AWS_SAA-C01 Exam
Question No:240
What is the meaning of pay-as-you-go, when related to Amazon Web Services?
A. You pay only when your instance is doing very intense computation
B. You pay the Cloud provider only when your product is profitable.
C. You have no upfront costs, but rather pay on a monthly basis, based on usage. D. You pay only when you leave the service.
Answer: C
Explanation: The concept of pay-as-you-go means that you pay only for a specific amount of resources that you use in a specific amount of time used in a given month. For instance, you can use a Amazon EC2 Instance only for 30 minutes and you will be charged only for that time, without any upfront costs to launch or terminate the instance.
Reference: http://aws.amazon.com/ec2/pricing/
Question No:241
One security benefit of utilizing the Elastic Load Balancer is its ability to .
A. provide encrypted data storage for use in application development
B. perform network address translation
C. block network traffic based on heuristic analysis
D. provide TLS/SSL termination as well as centralized certificate management Answer: D
Explanation: The Elastic Load Balancer can integrate with the AWS Certificate Manager to provide a central method of managing your TLS/SSL certificates. It allows you to renew, deploy and configure your TLS/SSL certificates for your application or website from a single location. Reference: https://aws.amazon.com/elasticloadbalancing
Question No:242
You are creating a Route53 DNS failover to direct traffic to two groups of EC2 instances in two separate regions. If one region fails, you would like Route 53 to direct traffic to the instances in the other region. There is a classic elastic load balancer routing traffic between instances in that
  
AWS_SAA-C01 Exam
region. What is the best way for you to configure the Route 53 health check?
A. Route 53 does not support a classic load balancer with an internal health check. You need to create your own Route 53 health check for the load balancer.
B. Route 53 natively supports ELB with an internal health check. Turn "Evaluate targethealth" off. Turn "Associate with Health Check" on, and Route 53 will use the load balancer's internal health check.
C. Route 53 doesn't support a classic load balancer with an internal health check. You need to associate your resource record set for the load balancer with your own health check.
D. Route 53 natively supports ELB with an internal health check. Turn "Evaluate target health" on. Turn "Associate with Health Check" off, and Route 53 will use the load balancer's internal health check.
Answer: D
Explanation: With DNS Failover, Amazon Route 53 can help detect an outage of your website and redirect your end users to alternate locations where your application is operating properly. When you enable this feature, Route 53 uses health checks—regularly making Internet requests to your application’s endpoints from multiple locations around the world—to determine whether each endpoint of your application is up or down.
To enable DNS Failover for an ELB endpoint, create an Alias record pointing to the load balancer and set the "Evaluate Target Health" parameter to true. Route 53 creates and manages the health checks for your load balancer automatically. You do not need to create your own Route 53 health check of the load balancer. You also do not need to associate your resource record set for the load balancer with your own health check, because Route 53 automatically associates it with the health checks that Route 53 manages on your behalf. The load balancer health check will also inherit the health of your backend instances behind it.
Reference: https://aws.amazon.com/blogs/aws/amazon-route-53-elb-integration-dns-failover/
Question No:243
As the new Security Engineer for your company's AWS cloud environment you are responsible for developing best practice guidelines. In addition to data security, such as encryption, you need to develop a plan for Security Groups, Access Control Lists, as well as IAM Policies. You want to roll out best practice policies for IAM. What is NOT an IAM best practice?
A. Share access keys for cross-account access. B. Use policy conditions for extra security.
 
AWS_SAA-C01 Exam
C. Rotate credentials regularly.
D. Delegate by using roles instead of by sharing credentials. Answer: A
Explanation: To the extent that it's practical, define the conditions under which your IAM policies allow access to a resource. For example, you can write conditions to specify a range of allowable IP addresses that a request must come from. Remove IAM user credentials (that is, passwords and access keys) that are not needed. For example, an IAM user that is used for an application does not need a password (passwords are necessary only to sign in to AWS websites). Change your own passwords and access keys regularly, and make sure that all IAM users in your account do as well. That way, if a password or access key is compromised without your knowledge, you limit how long the credentials can be used to access your resources. Sharing access keys for cross-account access is not a best practice.
Reference: http://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#create-iam-users
Question No:244
Amazon Elastic Block Store (Amazon EBS) provides block level storage volumes for use with EC2 instances. EBS volumes are highly available and reliable storage volumes that can be attached to any running instance that is in the same Availability Zone. Which of the following would be considered a feature of EBS? (Choose 3 answers)
A. EBS volumes behave like raw, unformatted block devices. You can create a file system on top of these volumes, or use them in any other way you would use a block device (like a hard drive).
B. You can use encrypted EBS volumes to meet a wide range of data-at-rest encryption requirements for regulated/audited data and applications.
C. Your account does not have a limit on the number of EBS volumes that you can use, and the total storage available to you is also unlimited.
D. You can create point-in-time snapshots of EBS volumes, which are persisted to Amazon S3. Snapshots protect data for long-term durability, and they can be used as the starting point for new EBS volumes.
Answer: A,B,D
Explanation: The following are some of the features of EBS volumes.
EBS volumes behave like raw, unformatted block devices. You can create a file system on top of these volumes, or use them in any other way you would use a block device (like a hard drive).
 
AWS_SAA-C01 Exam
You can use encrypted EBS volumes to meet a wide range of data-at-rest encryption requirements for regulated/audited data and applications.
You can create point-in-time snapshots of EBS volumes, which are persisted to Amazon S3. Snapshots protect data for long-term durability, and they can be used as the starting point for new EBS volumes.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AmazonEBS.html
Question No:245
You have been contracted by a company to design and implement their AWS cloud environment. The company has a very tight budget and would like to maximize savings wherever possible. They've gotten a 5 year government contract and the workload is expected to remain steady throughout the length of the contract. What type of instance will best meet there computing needs while providing maximum savings?
A. On-Demand instances
B. Reserved instances, 1 year commitment, No upfront
C. Reserved instances, 3 year term commitment, all upfront D. Spot instances
Answer: C
Explanation: When you purchase a Reserved Instance, choose a payment option, term, and an offering class that suits your needs. Generally speaking, you can save more money choosing Reserved Instances with a higher upfront payment. There are three payment options (No Upfront, Partial Upfront, All Upfront), two term lengths (one-year or three-years), and two offering classes (Convertible and Standard). No Upfront and Partial Upfront Reserved Instances are billed for usage on an hourly basis, regardless of whether they are being used. All Upfront Reserved Instances have no additional hourly charges.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-inst ances.html
Question No:246
You are designing an AWS RDS solution for a new medical supply company. This is a brand new company and they do not have an existing on-premises database. They would like to use Oracle for their new database. With a brand new database, which licensing model will you use for Oracle?
 
AWS_SAA-C01 Exam
A. License included
B. Pay per core licensing C. Optional licensing
D. Bring your own license Answer: A
Explanation: You can run Amazon RDS for Oracle under two different licensing models – “License Included” and "Bring-Your-Own-License (BYOL)". In the "License Included" service model, you do not need separately purchased Oracle licenses; the Oracle Database software has been licensed by AWS.
Reference: https://aws.amazon.com/rds/oracle/
Question No:247
A client has contracted you to review and update their AWS cloud environment after the results of an audit. Specifically, they need to make some major security improvements to bring them within compliance. One of the issues pointed out were concerns about the IAM administrator accounts and certain vulnerabilities. Which item is not a security measure for IAM administrator account?
A. Add multi-factor authentication to the accounts.
B. Create a policy granting permission based on IP Address. C. Attach a password policy for the accounts.
D. Perform CAPTCHA checks on the accounts.
Answer: D
Explanation: For extra security, enable multi-factor authentication (MFA) for privileged IAM users (users who are allowed access to sensitive resources or APIs). With MFA, users have a device that generates a unique authentication code (a one-time password, or OTP). Users must provide both their normal credentials (like their user name and password) and the OTP. AWS- managed policies are designed to support common tasks. They typically provide access to a single service or a limited set of actions. CAPTCHA checks are not a part of IAM.
Reference: http://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#bp-use-aws-defined -policies
 
AWS_SAA-C01 Exam
Question No:248
A block device is a storage device that moves data in sequences. How many types of block devices does Amazon EC2 support?
A. 2 - instance store volumes and EBS volumes
B. 3 - instance store volume, EBS volume, S3 bucket C. 1 - instance store volumes
D. 3 - instance store volume, EBS volume, EFS volume Answer: A
Explanation: A block device is a storage device that moves data in sequences of bytes or bits (blocks). These devices support random access and generally use buffered I/O. Examples include hard disks, CD-ROM drives, and flash drives. A block device can be physically attached to a computer or accessed remotely as if it were physically attached to the computer. Amazon EC2 supports two types of block devices:
Instance store volumes (virtual devices whose underlying hardware is physically attached to the host computer for the instance)
EBS volumes (remote storage devices)
EFS and Amazon S3 are storage options, but they are file and object storage, not block storage. Reference: http://docs.amazonwebservices.com/AWSEC2/latest/UserGuide/block-device-mapping-conc epts.html
Question No:249
You have been hired by a large news organization to design their web application. This application will eventually scale to over 400,000 concurrent users during peak hours (U.S. Eastern time zone). Your major requirements are high availability, scalability, and consistent handling of a very large session state for all those users. Which technology is best equipped to handle this session state?
A. Amazon S3
B. Amazon Redshift
C. Amazon DynamoDB D. Amazon RDS
 
AWS_SAA-C01 Exam
Answer: C
Explanation: Tomcat applications often store session-state data in memory. However, this approach doesn't scale well because once the application grows beyond a single web server, the session state must be shared among servers. A common solution is to set up a dedicated session-state server with MySQL. However, this approach also has drawbacks: you must administer another server, the session-state server is a single pointer of failure, and the MySQL server itself can cause performance problems.
DynamoDB, which is a NoSQL database store from AWS, avoids these drawbacks by providing an effective solution for sharing session state across web servers.
Reference: http://docs.aws.amazon.com/sdk-for-java/v1/developer-guide/java-dg-tomcat-session-mana ger.html
Question No:250
You receive the following request from a client to quickly deploy a static website for them, specifically on AWS. The requirements are low-cost, reliable, online storage, and a reliable and cost-effective way to route customers to the website, as well as a way to deliver content with low latency and high data transfer speeds so that visitors to his website don't experience unnecessary delays. What do you think would be the minimum AWS services that could fulfill the client's request?
A. Amazon S3, Amazon Route 53 and Amazon RDS
B. Amazon S3, Amazon Route 53 and Amazon CloudFront
C. Amazon S3 and Amazon Route 53.
D. Amazon S3, Amazon Route 53, Amazon CloudFront and Elastic Load Balancing Answer: B
Explanation: You can easily and inexpensively use AWS to host a website that uses client-side technologies (such as HTML, CSS, and JavaScript) and does not require server-side technologies (such as PHP and ASP.NET). This type of site is called a static website, and is used to display content that does not change frequently.
Before you create and deploy a static website, you must plan your architecture to ensure that it meets your requirements. Amazon S3, Amazon Route 53, and Amazon CloudFront would be required in this instance.
Reference:
http://docs.aws.amazon.com/gettingstarted/latest/swh/website-hosting-intro.html
 
AWS_SAA-C01 Exam
Question No:251
You are running an AMI with as Amazon EBS-backed instance with a Windows operating system. The hourly instance charge for your instance is $14. You’ve asked your team to stop the instance when they aren’t using it in an effort to save money. However, when the bill comes, you’re surprised to realize that there was an hour where you were charged $42 for the instance. How could this be?
A. No one ever stopped the instance like they were supposed to when they weren’t using it. B. That instance was stopped and restarted twice within that hour.
C. Too many people attempted to access that instance in that particular hour, resulting in a higher bill.
D. That instance was stopped and never started again, resulting in a premature termination fee.
Answer: B
Explanation: When an Amazon EBS-backed instance is stopped, you're not charged for instance usage; however, you're still charged for volume storage. Amazon charges a full instance hour for every transition from a stopped state to a running state, even if you transition the instance multiple times within a single hour. In this scenario, the charge was $42, which is three times more than $14. This suggests that you stopped and restarted that instance twice during that hour (the initial $14, plus 2 x $14 for each restart).
Although some instances now have per-second billing available, this new billing structure does not apply to Windows instances at this point.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html
Question No:252
Your client has submitted a change request to improve security on their S3 buckets. You've decided to allow two administrators to manage the buckets and are setting up an IAM role for the admins. Which operations would you allow this role to perform? (Choose 3 answers)
A. Edit object metadata. B. List keys in a bucket. C. Create/delete a bucket. D. Delete an object. Answer: B,C,D
 
AWS_SAA-C01 Exam
Explanation: The Amazon S3 API is intentionally simple with only a handful of common operations. They include: create/delete a bucket, write an object, read an object, delete an object, and list keys in a bucket.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/API/Welcome.html
Question No:253
You have many IAM users with the ability to create EC2 volumes. Most of the data your team works with is sensitive, so you would like to make sure all volumes are encrypted. How might you facilitate this requirement?
A. Create an AWS KMS policy and attach it to all IAM users that can create EC2 volumes
B. Use AWS Config and create a rule that requires all volumes, upon creation, be encrypted. C. Use AWS Config to send out reminders to IAM users every time they create an EC2 volume. D. Set EC2 to notify creators to encrypt their EC2 volumes.
Answer: B
Explanation: AWS Config is used to evaluate the configuration settings of many AWS resources. When an EC2 volume in created, AWS Config can evaluate the volume against a rule that requires volumes to be encrypted. If the volume is not encrypted, AWS Config flags the volume and the rule as noncompliant.
Reference: http://docs.aws.amazon.com/config/latest/developerguide/evaluate-config.html
Question No:254
A national auto parts chain contracted your firm to design and implement their AWS environment. It is a very large scale system that handles order processing, accounting, stocking and logistics. This system spans multiple availability zones which dictated a multi-AZ environment for high availability. The system has been implemented and you need to test the database failover mechanism. It is imperative that the failover occur within the specified RTO. How can you consistently test database failover?
A. Contact Amazon to conduct a failover test.
B. Reboot the primary database instance.
C. Backup then delete the primary database instance.
D. Amazon has thoroughly tested failover and customers can not test failover.
 
AWS_SAA-C01 Exam
Answer: B
Explanation: If you are looking to use replication to increase database availability while protecting your latest database updates against unplanned outages, consider running your DB instance as a Multi-AZ deployment. When you create or modify your DB instance to run as a Multi-AZ deployment, Amazon RDS will automatically provision and manage a “standby” replica in a different Availability Zone (independent infrastructure in a physically separate location). In the event of planned database maintenance, DB instance failure, or an Availability Zone failure, Amazon RDS will automatically failover to the standby so that database operations can resume quickly without administrative intervention. Multi-AZ deployments utilize synchronous replication, making database writes concurrently on both the primary and standby so that the standby will be up-to-date in the event a failover occurs.
Reference: https://aws.amazon.com/rds/faqs/
Question No:255
In Amazon EC2, if you no longer wish to be charged for your instance, you must   the instance to avoid being billed for additional time.
A. "delete"
B. "stop" or "terminate" C. "avoid"
D. "exit" or "quit" Answer: B
Explanation: EC2 instances are billed for any time your instances are in a “running” state. If you no longer wish to be charged for your instance, you must "stop" or "terminate" the instance to avoid being billed. Billing starts when an instance transitions into the running state. AWS recently changed its billing process from per-hour to per-second, with a minimum one-minute charge, for certain instance types and Linux operating systems.
Reference: https://aws.amazon.com/ec2/faqs/
Question No:256
You have been checking some Auto Scaling events that you previously set up and notice that an application is scaling up and down multiple times within the hour. Which of the following design changes could you make to optimize cost whilst preserving elasticity? (Choose 2 answers)
A. Change the scale down CloudWatch metric to a higher threshold
 
AWS_SAA-C01 Exam
B. Add a lifecycle hook to the Auto Scaling group
C. Create a Lambda function to handle Auto Scaling events to launch reserved instances D. Add more EC2 instances
Answer: A,B
Explanation: Each CloudWatch alarm watches a single metric and sends messages to Auto Scaling when the metric breaches a threshold that you specify in your policy. Changing the scale down CloudWatch metric to a higher threshold will not cost any more.
Auto Scaling also supports adding life-cycle hooks to Auto Scaling groups. These hooks enable you to control how instances launch and terminate within an Auto Scaling group; you can perform actions on the instance before it is put into service or before it is terminated. This is also cost efficient and hence also a correct answer.
All the other answers will not optimize cost.
Reference: http://docs.aws.amazon.com/autoscaling/latest/userguide/policy_creating.html
Question No:257
Your company asks you to create a static website for common, high demand information utilized by clients. Your design calls for an S3 bucket as a static website host. You are expecting it to be a very high traffic GET-intensive site. What can you include in your design to reduce latency? (Choose 2 answers)
A. Use a random hash key to prefix key names.
B. Use a multi-AZ configuration to serve requests in parallel.
C. Use a CloudFront distribution as a caching layer in front of the bucket. D. Use Elastic Beanstalk on the front end to serve traffic.
Answer: A,C
Explanation: If you're using S3 for static website hosting and expect heavy traffic, it is a good design to use a CloudFront distribution as a caching layer in front of the S3 bucket. To support high request rates, it is a best practice technique to use random hash prefixes to key names. Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html
Question No:258
A user has enabled versioning on an S3 bucket. The user is using server side encryption for data
 
AWS_SAA-C01 Exam
at rest. If the user is supplying his own keys for encryption (SSE-C), what is recommended to the user for the purpose of security?
A. The user should not use his own security key as it is not secure
B. Configure S3 to store the user’s keys securely with SSL
C. Keep rotating the encryption key manually at the client side
D. Configure S3 to rotate the user’s encryption key at regular intervals Answer: C
Explanation: Amazon S3 supports client side or server side encryption to encrypt all data at Rest. The server side encryption can either have the S3 supplied AES-256 encryption key or the user can send the key along with each API call to supply his own encryption key (SSE-C). Since S3 does not store the encryption keys in SSE-C, it is recommended that the user should manage keys securely and keep rotating them regularly at the client side version.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.htm l
Question No:259
A user is currently building a website that will require a large number of instances in six months, when a demonstration of the new site will be given upon launch.
Which of the choices below allows the user to obtain the resources beforehand, and not worry about infrastructure availability during the demonstration?
A. Schedule all the instances beforehand as reserved instances to be available in 6 months. B. Pre-warm all the instances one month prior to ensure resource availability.
C. Ask AWS now to create the dedicated instances in 6 months.
D. Launch all the instances as part of the cluster group to ensure resource availability. Answer: A
Explanation: Amazon Web Services has massive hardware resources at its data centers, but they are finite. The best way for users to maximize their access to these resources is by reserving a portion of the computing capacity that they require. This can be done through reserved instances. With reserved instances, the user literally reserves the computing capacity in the
 
AWS_SAA-C01 Exam
Amazon Web Services cloud.
Reference: http://media.amazonwebservices.com/AWS_Building_Fault_Tolerant_Applications.pdf
Question No:260
Can Amazon RDS manage synchronous data replication across Availability Zones?
A. Yes, Amazon RDS can manage this but only for certain DB instance types. B. No, Amazon RDS does so only for certain AZs.
C. No
D. Yes
Answer: D
Explanation: Yes, in the Multi-AZ Deployment option, Amazon RDS manages synchronousdata replication across Availability Zones and automatic failover.
Reference: http://aws.amazon.com/rds/faqs/
Question No:261
With detailed monitoring enabled on an EC2 instance, how often is metric data sent to CloudWatch?
A. Every 30 seconds B. Every minute
C. Every 45 seconds D. Every 5 minutes Answer: B
Explanation: By default, Amazon EC2 metric data is automatically sent to CloudWatch in 5- minute periods. However, you can, enable detailed monitoring on an Amazon EC2 instance, which sends data to CloudWatch in 1-minute periods
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html
 
AWS_SAA-C01 Exam
Question No:262
You have a client who wants you to build them a highly available web application. One of their requirements is that the web servers should be stateless. Which of the options below would be suitable for this? (Choose 2 answers)
A. Security Groups
B. Amazon ElastiCache C. Amazon CloudWatch D. Network ACLs Answer: B,D
Explanation: A stateless app is an application program that does not record data generated in one session, such as information about user settings and events that occurred for use in the next session with that user, such as Elasticache.
An NACL is stateless as return traffic must be explicitly allowed by rules whilst a Security Group is stateful as return traffic is automatically allowed, regardless of any rules.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Security.html
Question No:263
A user has configured the Auto Scaling group with the minimum capacity as 3 and the maximum capacity as 5. When the user configures the auto scaling group, how many instances will Auto Scaling launch?
A. 5
B. 2
C. 0
D. 3 Answer: D
Explanation: When the user configures the launch configuration and the Auto Scaling group, the Auto Scaling group will start instances by launching the minimum number (or the desired number, if specified) of EC2 instances. If there are no other scaling conditions attached to the Auto Scaling group, it will maintain the minimum number of running instances at all times. Reference:
 
AWS_SAA-C01 Exam
http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-maintain-instance-level s.html
Question No:264
You are managing the deployment of a VPC, which consists of an Elastic Load Balancer and an Auto Scaling Group of EC2 instances with a multi-AZ configured MySQL Database. AWS has many security measures in place. Which ones will be your responsibility as a manager? (Choose 3 answers)
A. Installation of EC2, ELB and RDS security patches B. Protection against IP Spoofing
C. Data encryption
D. EC2 instance security
Answer: A,C,D
Explanation: AWS is responsible for the security of the cloud in general, in areas such data security and protection against IP spoofing. The customer is responsible for security in the cloud in areas such as data encryption, installing security patches on EC2 instances, and IAM best practices. It is very important to understand this concept to avoid any lapses in your security measures.
Reference: https://aws.amazon.com/compliance/shared-responsibility-model/
Question No:265
is a useful and powerful tool within Billing and Cost Management. It allows you to view
historical billing information in a graphical format giving you greater insight to your AWS spend A. Cost Explorer
B. Budgets
C. Cost Allocation Tags
D. Consolidated Billing
Answer: A
Explanation: Cost Explorer, this is a useful and powerful tool within Billing and Cost
  
AWS_SAA-C01 Exam
Management. It allows you to view historical billing information in a graphical format giving you greater insight to your AWS spend. A valuable tool that can help to identify where you should be focusing your cost optimization efforts. It also has the ability to forecast your estimated spend up to two months ahead using existing data as a reference. If you can see that your estimated future bills are becoming too high, you have the time now to identify where you can make and initiate cost reduction mechanisms to help mitigate the risk.
Cost Explorer comes configured with three pre-defined views which are commonly used to analyse spending across your account:
Monthly Spend by Service view - This covers the current and previous two months and is grouped by AWS services
Monthly Spend by Linked Account View - This covers the current and previous two months and is grouped by Linked Accounts
Daily Spend view - This covers the the daily spend over the previous 60 days
Reference: http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-explorer-what-is.html
Question No:266
Your company allows technical personnel to manage their own S3 buckets. But there have been too many instances of users deleting important project related data. What additional steps can you take to prevent accidental deletion or overwriting of data? (Choose 3 answers)
A. Add versioning.
B. Add cross-region replication. C. Create read replicas.
D. Add MFA Delete.
Answer: A,B,D
Explanation: Amazon S3 storage offers very high durability, but it is still a best practice to protect against user level deletion or overwriting of data using versioning, cross-region replication, and MFA Delete.
Reference: https://aws.amazon.com/s3/faqs/
Question No:267
Your company has tasked you to design their new AWS cloud environment. The design needs to be highly available. It will be a hybrid design due to an important application on-premises that can not be moved to the cloud. You need to design a highly available database tier and have confidence in Amazon's failover technology. Which databases can you choose that utilize
 
AWS_SAA-C01 Exam
Amazon's failover technology?
A. DynamoDB, Oracle
B. SQL Server, Oracle, MySQL
C. Oracle, PostgreSQL, MySQL, and MariaDB DB D. Oracle, PostgreSQL, MySQL, and DynamoDB Answer: C
Explanation: Amazon RDS provides high availability and failover support for DB instances using Multi-AZ deployments. Amazon RDS uses several different technologies to provide failover support. Multi-AZ deployments for Oracle, PostgreSQL, MySQL, and MariaDB DB instances use Amazon's failover technology. SQL Server DB instances use SQL Server Mirroring. DynamoDB is not an RDS service.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.MultiAZ.html
Question No:268
You are placed in charge of a client's existing AWS cloud environment. They have several web servers in a public subnet and three database servers in a private subnet. The database is an RDS solution using SQL Server. AWS limits the types of changes the customer can make to the underlying infrastructure. What change will you be responsible for when administering this RDS database?
A. Performing daily database backups
B. Patching the database instance operating system
C. Setting up database accounts and privileges for non-admin D. Deploying virtual infrastructure
Answer: C
Explanation: Amazon RDS manages the work involved in setting up a relational database: from provisioning the infrastructure capacity you request to installing the database software. Once your database is up and running, Amazon RDS automates common administrative tasks such as performing backups and patching the software that powers your database. With optional multi-AZ deployments, Amazon RDS also manages synchronous data replication across
 
AWS_SAA-C01 Exam
Availability Zones with automatic failover.
Since Amazon RDS provides native database access, you interact with the relational database software as you normally would. This means you're still responsible for managing the database settings that are specific to your application. You'll need to build the relational schema that best fits your use case and are responsible for any performance tuning to optimize your database for your application’s workflow.
Reference: https://aws.amazon.com/rds/faqs/
Question No:269
Which AWS disaster recovery method has the lowest RTO and RPO, but the highest cost required to maintain resources?
A. Multi-site
B. Backup and restore C. Pilot light
D. Warm standby Answer: A
Explanation: Multi-site is the quickest disaster recovery method, with minimal time to recover and minimal data loss, but with the highest overall cost in comparison to backup and restore, pilot light or warm standby methods. This method is ideal for highly transactional online businesses, whose potential losses in terms of revenue and reputation far outweigh any costs required to maintain a duplicate production environment in a separate AWS region.
Reference: https://d1.awsstatic.com/whitepapers/aws-disaster-recovery.pdf
Question No:270
A user wants to use an EBS-backed Amazon EC2 instance for a temporary job. Based on the input data, the job is most likely to finish within a week. Which one of the following is the best way to terminate the instance automatically once the job is finished?
A. Configure the Auto Scaling schedule activity that terminates the instance after 7 days.
B. Configure the CloudWatch alarm on the instance such that it should perform the termination action once the instance is idle.
C. Configure the EC2 instance with ELB to terminate the instance when it remains idle.
 
AWS_SAA-C01 Exam
D. Configure the EC2 instance with a stop instance to terminate it.
Answer: B
Explanation: Auto Scaling can start and stop the instance at a pre-defined time. Here, the total running time is unknown. Thus, the user has to use the CloudWatch alarm, which monitors the CPU utilization. The user can create an alarm that is triggered when the average CPU utilization percentage has been lower than 10 percent for 24 hours, signaling that it is idle and no longer in use. When the utilization is below the threshold limit, it will terminate the instance as a part of the instance action.
Reference: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/UsingAlarmActions .html
Question No:271
You are leading the design for a client's AWS cloud network. Your design team is discussing the design and implementation of a VPC. The creation of a VPC offers a great deal of flexibility and many of the features are in the control of the customer. What features of the VPC are you able to define and create? (Choose 3 answers)
A. Customer Gateway B. Network Gateways C. IP address range D. Subnets
Answer: B,C,D
Explanation: A virtual private cloud (VPC) is a virtual network dedicated to your AWS account. It is logically isolated from other virtual networks in the AWS cloud. You can launch your AWS resources, such as Amazon EC2 instances, into your VPC. You can configure your VPC; you can select its IP address range, create subnets, and configure route tables, network gateways, and security settings.
You can not create Availability zones. These are created by AWS and you are free to create your cloud environment in these availability zones. Also, you select the CIDR block that is right for your needs based on size, but they are already created and defined.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Introduction.html
 
AWS_SAA-C01 Exam
Question No:272
You are configuring a new VPC for one of your clients for a cloud migration project, and only a public subnet will be in place. After you have created your VPC, you created a new subnet, a new internet gateway, and attached your internet gateway to your VPC. When you launched your first instance into your VPC, you realized that you aren't able to connect to the instance, even if it is configured with an elastic IP. What should be done to get this instance internet connectivity?
A. Attach another ENI to the instance and connect via the new ENI.
B. A route should be created as 0.0.0.0/0 with your internet gateway as the target.
C. A NAT instance should be created, and all traffic should be forwarded to NAT instance. D. A NACL should be created that allows all outbound traffic.
Answer: B
Explanation: All traffic should be routed via internet gateway, so a route should be created with 0.0.0.0/0 as a source, and with your Internet Gateway as the target.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Scenario1.html
Question No:273
You are designing a AWS cloud environment for a client who has a contract with a federal government agency. The cloud environment will have multiple VPCs and be in multiple regions. The government agency wants to whitelist only a handful of instances in your organization. This will dictate that these instances have static IP addresses. Elastic ip addresses can be used to keep a fixed set of IP addresses. How can the Elastic IP addresses (EIP) be used in this environment?
A. EIPs can be moved from one instance to another in multiple VPCs and multiple regions B. EIPs can be moved from one instance to another in multiple VPCs within the same region C. EIPs can be moved from one instance to another within the same Availability Zone
D. EIPs are attached to an instance and exist only for the life of that instance
Answer: B
Explanation: An Elastic IP address is associated with your AWS account. With an Elastic IP address, you can mask the failure of an instance or software by rapidly remapping the address to another instance in your account. You can disassociate an Elastic IP address from a resource,
 
AWS_SAA-C01 Exam
and reassociate it with a different resource. A disassociated Elastic IP address remains allocated to your account until you explicitly release it. An Elastic IP address is for use in a specific region only.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html
Question No:274
While EC2 is performing the volume status checks on an Amazon EBS volume, if all checks pass, the status of the volume is ok. If a check fails, the status of the volume is .
A. inconsistent B. impaired
C. aborted
D. a warning Answer: B
Explanation: Volume status checks enable you to better understand, track, and manage potential inconsistencies in the data on an Amazon EBS volume. Volume status checks are automated tests that run every 5 minutes and return a pass or fail status. If all checks pass, the status of the volume is ok. If a check fails, the status of the volume is impaired.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html
Question No:275
You have been placed in charge of your company's existing AWS cloud environment. Your company is very large and you have a team of 5 engineers. You are managing IAM with one of your team members as a backup. You will assign two team members to manage the RDS databases and will need two team members managing the VPC and the EC2 instances within it. How can you give your team members the ability to administer the EC2 instances (Choose 2 Answers)?
A. Create a role granting EC2:* actions on all resources, and assign the associated policy to each of your team members.
B. Create cross-account access to the VPC which houses the EC2 instances.
C. Create a policy granting EC2:* actions on all resources, and assign that policy to each of your
  
AWS_SAA-C01 Exam
team members.
D. Create a login key pair for the EC2 instances and provide this to your team. Answer: A,C
Explanation: Using IAM, you apply permissions to IAM users, groups, and roles by creating policies. You can create two types of IAM policies: Managed Policies and Inline Policies. Managed policies are standalone policies that you can attach to multiple users, groups, and roles in your AWS account. Managed policies apply only to identities (users, groups, and roles) - not resources. Inline policies are policies that you create and manage, and that are embedded directly into a single user, group, or role.
Reference: http://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_managed-vs-inline.html
Question No:276
Which of the below mentioned options are the two major components of AWS ELB?
A. Controller Service AND Load Balancer
B. Load Balancer AND Health Check Device
C. Load Distribution Service AND Health Check Device D. Health Check Device AND Controller Service Answer: A
Explanation: AWS ELB consists of two major components: Load Balancer and Controller Service. The Load Balancer component monitors the network traffic and handles requests that come from the Internet. The Controller Service monitors the Load Balancers.
Reference: http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/SvcIntro_HowEL BWorks.html
Question No:277
A favored client needs you to quickly deploy a database that is a relational database service with minimal administration as he wants to spend the least amount of time administering it. Which database would be the best option?
A. Amazon Redshift
 
AWS_SAA-C01 Exam
B. Amazon DynamoDB
C. Your choice of relational AMIs on Amazon EC2 and EBS. D. Amazon RDS
Answer: D
Explanation: Amazon Relational Database Service (Amazon RDS) is a web service that makes it easy to set up, operate, and scale a relational database in the cloud. It provides cost-efficient and resizable capacity while managing time-consuming database administration tasks, freeing you up to focus on your applications and business.
Amazon RDS gives you access to the capabilities of a familiar MySQL, Oracle, SQL Server, or PostgreSQL database engine. This means that the code, applications, and tools you already use today with your existing databases can be used with Amazon RDS. Amazon RDS automatically patches the database software and backs up your database, storing the backups for a user- defined retention period and enabling point-in-time recovery.
SimpleDB, DynamoDB and NoSQL Databases, and Amazon Redshift is a data warehouse tool, so RDS is the best answer in this case. EC2 can be used to host relational databases, but does not provide is not a managed service like Amazon RDS.
Reference: https://aws.amazon.com/running_databases/#rds_anchor
Question No:278
You have been assigned to a new client who has an existing AWS cloud environment. They have a web application in a public subnet and an RDS database in a private subnet. In addition, they have several applications which need to interact with their cloud environment. They have one application which uses an AWS SDK and they need the application to be able to be authenticated as a principal to access AWS cloud services. How would you accomplish this authentication?
A. Create an IAM user and store the user name/password in the application. B. Use an SSL connection between the application and the AWS cloud.
C. Assign the application an IAM role and run it on an EC2 instance.
D. Use Direct Connect between the application and AWS cloud.
Answer: C
Explanation: Applications that run on an Amazon EC2 instance need credentials in order to access other AWS services. To provide credentials to the application in a secure way, use IAM
 
AWS_SAA-C01 Exam
roles. A role is an entity that has its own set of permissions, but that isn't a user or group. Roles also don't have their own permanent set of credentials the way IAM users do. In the case of Amazon EC2, IAM dynamically provides temporary credentials to the EC2 instance, and these credentials are automatically rotated for you.
Reference: http://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#use-roles-with-ec2
Question No:279
An organization has setup an application on AWS. The organization wants to achieve scalability and HA for the application, which should scale up and down to address workload changes on the application. Which of the below mentioned configurations is not required to be performed in this scenario?
A. Setup schedule to shut off the instance when the instance is not in use.
B. Create an AMI of a running instance and configure that AMI with AutoScaling. C. Setup bootstrapping to start the web and DB servers on instance boot.
D. Setup ELB with instances to distribute the load on the web server.
Answer: A
Explanation: AWS EC2 allows the user to launch On-Demand instances. AutoScaling offers automation which can scale up or down resources as per the configured policy. To setup AutoScaling, the organization must first create an AMI. The organization should setup bootstrapping with AMI so that whenever the instance starts it will automatically start the app server and DB server. The organization should also setup ELB with instances to distribute the incoming load. AutoScaling should be configured to scale up and down based on the application load and not on a particular schedule.
Reference: http://d36cz9buwru1tt.cloudfront.net/AWS_Disaster_Recovery.pdf
Question No:280
You have a client in the financial industry who is moving to AWS for their IT infrastructure and applications. They need to become PCI compliant to protect their client’s card information. Amazon has many processes in place for PCI compliance. What steps do you need to take to help them become compliant? (Choose 3 answers)
A. Encrypt data in transit.
B. Monitor access with CloudTrail and VPC Flow Logs.
 
AWS_SAA-C01 Exam
C. Secure private subnets with ACLs and Security Groups. D. Use server side encryption to protect card holder data. Answer: A,B,D
Explanation: AWS provides customers with a PCI-compliant environment and the necessary tools to secure their environment. PCI compliance falls very much in line with the shared responsibility model. But ultimately, it is the customers responsibility to build and maintain a PCI-compliant environment.
Reference: https://aws.amazon.com/compliance/pci-dss-level-1-faqs/
Question No:281
Your team has been assigned to a client to design and implement the client's AWS RDS database solution. There is a requirement to have a highly available and scalable solution. One of their main services provided is an extremely popular political blog. It is expected to receive very high read traffic with minimal write traffic. Most of their services appear to be more read heavy. You expect read replicas would address most of the requirements, but which tasks can read replicas not accomplish?
A. Offload Data Warehousing scenarios.
B. Handle read traffic while the source DB is unavailable.
C. Heavy read workloads are beyond the capacity of a single DB. D. Scale up for more IOPS.
Answer: D
Explanation: Amazon RDS Read Replicas provide enhanced performance and durability for database (DB) instances. This replication feature makes it easy to elastically scale out beyond the capacity constraints of a single DB Instance for read-heavy database workloads. You can create one or more replicas of a given source DB Instance and serve high-volume application read traffic from multiple copies of your data, thereby increasing aggregate read throughput. Read replicas can also be promoted when needed to become standalone DB instances. Reference: https://aws.amazon.com/rds/details/read-replicas/
Question No:282
You have been put in charge of designing your company's AWS RDS environment. You are currently dealing with high level requirements such as high availability and scalability. You
 
AWS_SAA-C01 Exam
want to be able to scale the database efficiently with minimal interruptions. You are considering specific scenarios for scaling. It's likely you will have a very read-heavy application. How can you best scale for this situation?
A. Scale vertically and horizontally. B. Scale vertically.
C. Scale horizontally.
D. You do not have to scale for reads. Answer: C
Explanation: You can scale vertically to address the growing demands of an application that uses a roughly equal number of reads and writes. Or you can scale horizontally for read-heavy applications. A good option to scale horizontally for a read-heavy application is to add read replicas. RDS MySQL, PostgreSQL, and MariaDB can have up to 5 read replicas, and Amazon Aurora can have up to 15 read replicas.
Reference: https://aws.amazon.com/blogs/database/scaling-your-amazon-rds-instance-vertically-and-h orizontally/
Question No:283
You are leading a design meeting with a new customer who needs a highly available web application. You are reviewing the features of Amazon EC2 instances. The technical lead for the client asks about shared tenancy, and the discussion leads to the client being very averse to shared tenancy. What AWS option allows instances to run on any hardware that's dedicated to a single customer account?
A. Reserved instances
B. Dedicated host
C. On-Demand instances D. Dedicated instances Answer: D
Explanation: Dedicated Instances are Amazon EC2 instances that run in a VPC on hardware that's dedicated to a single customer. Dedicated instances are physically isolated at the host
 
AWS_SAA-C01 Exam
hardware level from instances that belong to other AWS accounts. Dedicated instances may share hardware with other instances from the same AWS account that are not Dedicated instances. Conversely with Dedicated Hosts, the customer has complete control over which host an instance launches on. The key term in this question is 'any hardware'. Dedicated instances may launch on any hardware allocated to the customer.
Reference: https://aws.amazon.com/ec2/purchasing-options/dedicated-instances/
Question No:284
You've been assigned a new client with an existing AWS cloud configuration. They are using four EC2 reserved instances for one of their proprietary applications. You examine their requirements and determine that an extreme traffic spike occurs during their fiscal year processing in late June. Additionally, they have two reserved instances reading from a queue. What changes can you make to maintain reliability, improve performance, and reduce cost? (Choose 2 answers)
A. Add spot instances for the expected traffic spike in June.
B. Add on-demand instances for the expected traffic spike in June.
C. Use a Load Balancer for the queuing.
D. Replace the reserved instances with spot instances to interact with the queue for cost savings. Answer: B,D
Explanation: Reserved instances are the best value for a steady traffic over an extended period. Licensing agreements for reserved instances can be 1 or 3 years. On-demand instances are perfect for handling short term traffic spikes. Spot instances are the best value for non-critical applications that can afford to be stopped. Trusted Advisor can provide valuable information on your instance utilization relative to cost savings.
Reference: https://aws.amazon.com/ec2/pricing/reserved-instances/pricing/
Question No:285
You have been assigned to move a client from an on-premises solution to a hybrid cloud solution. After creating a VPC, you'd like to get some EC2 instances created quickly. What are your options to avoid creating EC2 instances from scratch? (Choose 2 answers)
A. Import virtual instances from AMIs.
B. Import Virtual Machines from on-premises using VM Import/Export.
 
AWS_SAA-C01 Exam
C. Copy AMIs over to the cloud using Remote Desktop. D. Create a bootstrap script to mass produce instances. Answer: A,B
Explanation: You can import virtual instances as AMIs or use VM Import/Export to import Virtual Machines from your existing environment. They can also be exported back to your on- premises environment if the need should arise. AMIs can not be exported back to your on- premises environment.
Reference: https://aws.amazon.com/ec2/vm-import/
Question No:286
You have taken on a client that has been configured for AWS cloud and is fully operational. Your investigation of the environment reveals that your predecessor was a highly skilled AWS Architect. You view one instance that handles Internet traffic but also handles back end database traffic in a private subnet. This one instance is configured as a full management network attached to both a public subnet and a private subnet. What AWS device will enable such a configuration for a single instance?
A. Elastic ip address
B. Elastic Load Balancer
C. Auto scaling group
D. Elastic Network Interface Answer: D
Explanation: You can create a management network using network interfaces. In this scenario, the secondary network interface on the instance handles public-facing traffic and the primary network interface handles back-end management traffic and is connected to a separate subnet in your VPC that has more restrictive access controls. The public-facing interface, which may or may not be behind a load balancer, has an associated security group that allows access to the server from the Internet while the private facing interface has an associated security group allowing SSH access only from an allowed range of IP addresses either within the VPC or from the Internet, a private subnet within the VPC or a virtual private gateway.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html Question No:287
 
AWS_SAA-C01 Exam
You are leading a design meeting on security in your company's new AWS VPC. Your team is debating the merits of using security groups, Access Control Lists or both. It is important to be aware of the benefits of each and how that might interact if deployed together. Whatdifferences between security groups and Access Control Lists must you be aware of before deploying? (Choose 2 answers)
A. Security Groups operate at the instance level and support allow rules only. B. ACLs operate at the instance level and support allow and deny rules.
C. ACLs operate at the subnet level and support allow and deny rules.
D. ACLs operate at the subnet level and support deny rules only.
Answer: A,C
Explanation: You can secure your VPC instances using only security groups; however, you can add network ACLs as a second layer of defense. Security groups — Act as a firewall for associated Amazon EC2 instances, controlling both inbound and outbound traffic at the instance level . Network access control lists (ACLs) — Act as a firewall for associated subnets, controlling both inbound and outbound traffic at the subnet level . Security Groups supports allow rules only while Access Control Lists support allow and deny rules.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Security.html
Question No:288
George has launched three EC2 instances inside the US-East-1a zone with his AWS account. Ray has launched two EC2 instances in the US-East-1a AZ from his AWS account. Which statement below is true regarding the concept of Availability Zones?
A. The instances of George and Ray will be running in the same data centre
B. All the instances of George and Ray can communicate over a private IP without any cost
C. The physical location of the US-East-1a availability zone for George and Ray can be different. D. The location of the US-East-1a AZ are the same for George, Ray, and all other AWS users Answer: C
Explanation: Each AWS region has multiple, isolated locations known as Availability Zones. To ensure that the AWS resources are distributed across the Availability Zones for a region, AWS independently maps the Availability Zones to identifiers for each account. In this case the
 
AWS_SAA-C01 Exam
Availability Zone US-East-1a where George’s EC2 instances are running might not be the same location as the US-East-1a zone of Ray’s EC2 instances. There is no way for the user to coordinate the Availability Zones between accounts.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.ht ml
Question No:289
Which of the following choices has to be included while creating the launch configuration in Auto Scaling?
A. Related EBS volumes ID B. Commands to be used C. Security groups
D. Resource allocation Answer: C
Explanation: You create the launch configuration by including information such as theAmazon Machine Image (AMI) ID to use for launching the EC2 instance, the instance type, key pairs, security groups, and block device mappings, among other configuration settings.
Reference: http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/GettingStartedTutorial.htm l
Question No:290
You have taken on a client with an existing AWS VPC environment. They run a small website and for 3 days a month they need to produce over 500,000 bar codes . In reviewing their current configuration you notice that the term is ending in a week on the reserved instances they've purchased. You convince them that spot instances are much more economical for the bar code work but need to educate them on the conditions which the spot instances will keep running or be terminated. Under which scenario will the spot instances not be terminated?
A. The spot price becomes higher than the customer's bid price B. CPU utilization goes under 10%
C. The customer chooses to terminate them
 
AWS_SAA-C01 Exam
D. There is not enough unused capacity to meet the demand for spot instances
Answer: B
Explanation: Spot instances allow customers to bid on unused EC2 capacity and run those instances for as long as their bid exceeds the current Spot Price. The Spot Price changes periodically based on supply and demand, and customers whose bids meet or exceed it gain access to the available Spot instances. If the Spot Price moves higher than a customer’s maximum price, the customer’s instance will be shut down by Amazon EC2. The customer can terminate spot instances. Cloudwatch alarms can be set on CPU utilization for instances in an auto scaling group but this is not an out of the box feature of spot instances.
Reference: https://aws.amazon.com/ec2/faqs/
Question No:291
You have started your own consulting business and have been contracted by a doctors office to help move their outdated scheduling and billing system to the cloud. One feature you have offered at low cost is a disaster recovery solution that will keep their offices operational with minimal downtime. You've configured a standby EC2 instance that can be spun up in minutes. What feature can be quickly attached to the standby EC2 instance in a failover situation, to get the standby operational as quick as possible?
A. Elastic Load Balancer
B. IPv6 address
C. MAC address
D. Elastic Network Interface Answer: D
Explanation: An elastic network interface is a virtual network interface that you can attach to an instance in a VPC. Network interfaces are available only for instances running in a VPC. If one of your instances serving a particular function fails, its network interface can be attached to a replacement or hot standby instance pre-configured for the same role in order to rapidly recover the service.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html
Question No:292
Which of the following should you consider implementing if you or one of your clients is concerned about storing sensitive data in the cloud? (Choose 3 answers)
 
AWS_SAA-C01 Exam
A. Use strong passwords and group IAM accounts
B. Encrypt the file system on an EBS volume using Linux tools C. Enable S3 Encryption
D. Enable EBS Encryption
Answer: B,C,D
Explanation: Encryption is the best way to protect data at rest. You have the following options of protecting data at rest in Amazon S3.
Use Server-Side Encryption – You request Amazon S3 to encrypt your object before saving it on disks in its data centers and decrypt it when you download the objects.
Use Client-Side Encryption – You can encrypt data client-side and upload the encrypted data to Amazon S3. In this case, you manage the encryption process, the encryption keys, and related tools.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingEncryption.html
Question No:293
In ELB, the time-to-live ensures that the IP addresses can be remapped quickly in response to changing traffic. What is the time-to-live (TTL) limit specified by a DNS entry?
A. 10 seconds B. 5 seconds C. 40 seconds D. 60 seconds Answer: D
Explanation: The DNS entry specifies the time-to-live (TTL) as 60 seconds, which ensures that the IP addresses can be remapped quickly in response to changing traffic.
Reference: http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandK eyConcepts.html
Question No:294
An existing client has called you with a change request. Currently, there is a web server in a
 
AWS_SAA-C01 Exam
public subnet which connects to a database in a private subnet. Additionally there are several EC2 instances in the public subnet. The client has determined that it wants two of these instances in a private subnet to allow them to get updates from the internet but otherwise limited internet access. It was easier for you to just delete these 2 instances in the public subnet and create two new instances in the private subnet. You also set up a NAT instance in the public subnet to manage and facilitate the private instances internet access. After everything is configured you find that your ping from the private instances to a company internet website is not working. You verify that the route table and security groups are correct and that source/destination check is disabled on the NAT instance. What else could be wrong?
A. You need to disable source/destination check on the EC2 instances. B. Ping only works from instances in public subnets.
C. The ICMP port is not open on the Bastion host.
D. Ensure that you are pinging a website that has ICMP enabled. Answer: D
Explanation: From your private instance, test that you can connect to the Internet by running the ping command.
If the ping command fails, check the following information:
. Check that your NAT instance's security group rules allow inbound ICMP traffic from your private subnet. If not, your NAT instance cannot receive the ping command from your private instance.
. Check that you've configured your route tables correctly.
. Ensure that you've disabled source/destination checking for your NAT instance.
. Ensure that you are pinging a website that has ICMP enabled. If not, you will not receive reply packets. To test this, perform the same ping command from the command line terminal on your own computer.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html#nat-te st-configuration
Question No:295
An organization is planning to implement a scalable web application with AWS EC2. The organization is planning to achieve HA with multi AZ features. The application requires an app server and may require a load which will be catered by 2 large instances.
Which of the below mentioned configurations is better choice for HA and DR in this scenario?
A. Launch 4 small instances in separate AZs using Auto Scaling group and load balance them
 
AWS_SAA-C01 Exam
with ELB.
B. Launch 8 small EC2 instances with two instances in each zone for better HA and DR and load balance each with ELB.
C. Launch only one large instance and setup Auto Scaling with ELB.
D. Launch two large instances in separate AZs and load balance them with ELB. Answer: A
Explanation: The organization can always launch multiple EC2 instances in the same region across multiple AZs for HA and DR. It is recommended that the application should be load balanced with ELB for better load distribution. When the organization requires two large instances for the app server it is recommended to distribute the load by creating four small instances across AZs. The two large instances give only 50% redundancy while the four small instances give 75% redundancy. As cost wise both the scenarios are the same it is recommended to run four small instances across AZs.
Reference: http://www.awsarchitectureblog.com/2014/03/aws-and-compartmentalization.html
Question No:296
You are migrating a client's on-premises environment to the cloud. Their database is Microsoft SQL Server, which is the back end to a web server. The web server will be placed in a public subnet and the database in a private subnet. What are the best methods to migrate the database to the cloud environment? (Choose 2 answers)
A. Create an AWS VM and use the Import/Export service.
B. Use AWS Elastic Beanstalk.
C. Create a backup of the SQL Database and migrate it into the Amazon RDS. D. Use AWS Database Migration Service.
Answer: C,D
Explanation: On-premises databases can be migrated to Amazon RDS using native tools and techniques that vary depending on the engine. You can also use the AWS Database Migration Service, which uses a graphical interface that simplifies migration. Finally, AWS Database Migration Service can convert databases from one database to another.
Reference: https://aws.amazon.com/dms/faqs/
 
AWS_SAA-C01 Exam
Question No:297
You've been contracted by a client to improve the resiliency of their VPC in preparation for increased Disaster Recovery requirements with shorter RTO and RPOs. One thing you'd like to improve upon is resource and application monitoring. Which services used together will allow for the monitoring of application logs on EC2 and the overall health of AWS resources? (Choose 2 answers)
A. Cloudwatch
B. SNS
C. Trusted Advisor D. CloudFront Answer: A,B
Explanation: Amazon SNS and CloudWatch are integrated so you can collect, view, and analyze metrics for every active Amazon SNS notification. By configuring CloudWatch for Amazon SNS, you can gain better insight into the performance of your Amazon SNS topics, push notifications, and SMS deliveries.
Reference: http://docs.aws.amazon.com/sns/latest/dg/MonitorSNSwithCloudWatch.html
Question No:298
An organization is planning to host a scalable web application on EC2. The application is configured with ELB and Auto Scaling. There will be a minimum of 1 instance and a maximum of 7 instances with Auto Scaling based on the load. The ELB distributes the load among the registered instances. Which of the below mentioned options will be a durable and cost effective implementation in this scenario?
A. The organization should buy 3 Reserved Instances (RI)and Auto Scaling should launch an instance in the same zone for which the RI was purchased.
B. Auto Scaling should be configured to launch Reserved Instances. C. Auto Scaling should be configured to launch spot instances.
D. Auto Scaling should launch on-demand instances only.
Answer: D
Explanation: AWS EC2 allows the user to launch instances in three pricing categories: Spot,
 
AWS_SAA-C01 Exam
On-Demand and Reserved. The Reserved Instance would result in only 30-60% of price savings when the instances are running for an overall 3-4 months. Spot Instances are not for a production system as they can be terminated anytime. In this scenario the load variation is not known and the organization does not know how long an additional instance launched by Auto Scaling runs. Thus, it is recommended to configure Auto Scaling only with On-Demand instances.
Reference: http://aws.amazon.com/ec2/purchasing-options/
Question No:299
One of your clients has an Amazon VPC with multiple EC2 instances in both public and private subnets. They have called you because they are unable to connect to one of the EC2 instances, which is their web server. The web server is in a public subnet. When they try to connect to the web server via SSH, they are getting the message 'Network Error: Connection timed out'. What is not a valid troubleshooting step in this case?
A. Replace the Public IP address with an Elastic IP address. B. Check the route table for the subnet.
C. Check the network access control list (ACL) for the subnet. D. Check your security group rules.
Answer: A
Explanation: The network ACLs must allow inbound and outbound traffic from your local IP address on the proper port. The default network ACL allows all inbound and outbound traffic. Check the route table for the subnet. You need a route that sends all traffic destined outside the VPC to the Internet gateway for the VPC. Check your security group rules. You need a security group rule that allows inbound traffic from your public IPv4 address on the proper port. Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesConnecti ng.html#TroubleshootingInstancesConnectionTimeout
Question No:300
A client has contracted you to design and implement their AWS VPC. The design called for several web servers in an auto scaling group behind an Elastic Load Balancer (ELB) in a public subnet. The database tier is in a private subnet. The client has sensitive data and would like to have it encrypted. You've decided to configure a public key on the ELB to handle SSL encryption but the public key authentication is failing. What is a possible cause?
 
AWS_SAA-C01 Exam
A. The route table needs to contain a reference path to the SSL certificate. B. Update the SSL certificate and re-install it on your load balancer.
C. Each EC2 instance must be configured for SSL not the ELB.
D. The auto scaling policy needs to contain an SSL certificate.
Answer: B
Explanation: A load balancer configured to use the HTTPS or SSL protocol with back-end authentication enabled fails public key authentication it's probable that the public key on the SSL certificate does not match the public key configured on the load balancer. You might need to update your SSL certificate. If your SSL certificate is current, try re-installing it on your load balancer.
Reference: http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/ts-elb-healthcheck.html#ts- elb-healthcheck-autoscaling
Question No:301
What is the minimum duration when setting an alarm on a detailed monitoring metric in CloudWatch?
A. 30 seconds B. 1 day
C. 1 minute D. 5 minutes Answer: C
Explanation: When creating an alarm, select a period that is greater than or equal to the frequency of the metric to be monitored. For example, basic monitoring for Amazon EC2 provides metrics for your instances every 5 minutes. When setting an alarm on a basic monitoring metric, select a period of at least 300 seconds (5 minutes). Detailed monitoring for Amazon EC2 provides metrics for your instances every 1 minute. When setting an alarm on a detailed monitoring metric, select a period of at least 60 seconds (1 minute).
Reference: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_conce pts.html#Metric
 
AWS_SAA-C01 Exam
Question No:302
A client has contacted you about designing their AWS cloud environment. They want to fully migrate their compute environment to the cloud. Their biggest requirement is that they need high availability at both the web and database tiers. Their current database is MySQL. How might you best design high availability for their environment with cost being a consideration as well?
A. Cross-region replication B. Auto scaling
C. Read Replicas
D. Multi-AZ Deployment Answer: D
Explanation: Amazon RDS provides high availability and failover support for DB instances using Multi-AZ deployments. Amazon RDS uses several different technologies to provide failover support. Multi-AZ deployments for Oracle, PostgreSQL, MySQL, and MariaDB DB instances use Amazon's failover technology. SQL Server DB instances use SQL Server Mirroring. Amazon Aurora instances stores copies of the data in a DB cluster across multiple Availability Zones in a single region, regardless of whether the instances in the DB cluster span multiple Availability Zones.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.MultiAZ.html
Question No:303
You have been assigned to work with a manufacturing company that wants to migrate to a Virtual Private Cloud. Their technical lead is very proactive and and would like to use EC2 Spot instances wherever possible for cost efficiency. He also wants to use Instance Stored volumes where possible. You need to educate the technical lead about EBS backed volumes versus Instance Stored volumes. What are some of the advantages of EBS volumes? (Choose 3 answers)
A. If the instance is terminated, your data is not lost. B. EBS volumes are more cost-effective.
C. EBS based instances can be stopped and restarted. D. EBS instances boot faster.
 
AWS_SAA-C01 Exam
Answer: A,C,D
Explanation: An EBS volume is off-instance storage that can persist independently from the life of an instance. You continue to pay for the volume usage as long as the data persists. EBS instances can be stopped and re-started. And EBS volumes boot faster than instance store volumes often by an order of magnitude.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html
Question No:304
A user has launched two EBS backed EC2 instances in the US-East-1a region. The user wants to change the zone of one of the instances. How can the user change it?
A. From the AWS EC2 console, select the Actions - > Change zones and specify new zone B. The zone can only be modified using the AWS CLI
C. Create an AMI of the running instance and launch the instance in a separate AZ
D. Stop one of the instances and change the availability zone
Answer: C
Explanation: With AWS EC2, when a user is launching an instance he can select the availability zone (AZ) at the time of launch. If the zone is not selected, AWS selects it on behalf of the user. Once the instance is launched, the user cannot change the zone of that instance unless he creates an AMI of that instance and launches a new instance from it.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.ht ml
Question No:305
You have just started working for a very large company that has a huge existing AWS cloud environment. The environment is diverse using many different services such as EC2, RDS, DynamoDB, Elasticache, Glacier, Redshift, and S3. Moving forward you've been instructed to place cost savings first when designing new VPC environment. One way to save money on long term deployments is to use reserved instances. For which AWS services can you purchase reserved instances? (Choose 3 answers)
A. Elasticache Nodes B. S3
 
AWS_SAA-C01 Exam
C. EC2
D. RDS Answer: A,C,D
Explanation: Amazon RDS Reserved Instances give you the option to reserve a DB instance for a one or three year term and in turn receive a significant discount compared to the On-Demand Instance pricing for the DB instance. Amazon ElastiCache Reserved Nodes give you the option to make a low, one-time payment for each cache node you want to reserve and in turn receive a significant discount on the hourly charge for that Node. Amazon ElastiCache provides three ElastiCache Reserved Node types (Light, Medium, and Heavy Utilization Reserved Nodes) that enable you to balance the amount you pay upfront with your effective hourly price.
Reference: https://aws.amazon.com/rds/reserved-instances/
Question No:306
A user has enabled the CloudWatch alarm at $50 for the estimated usage of every service and overall total of AWS charges in the US East (N. Virginia) region. When does CloudWatch trigger the alarm?
A. When the total AWS usage is $49
B. None of these
C. When the US East (N. Virginia) region usage is more than $50 D. When the total AWS usage is more than $50
Answer: D
Explanation: You can choose to receive alerts by email when charges have exceeded a certain threshold. These alerts are triggered by CloudWatch and messages are sent using Amazon Simple Notification Service (Amazon SNS). In this case, when the usage exceeds $50, CloudWatch triggers the alarm.
The metric isn't specific to US East (N. Virginia) because billing is a worldwide metric, not specific to any region.
Reference: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/gs_monitor_estima ted_charges_with_cloudwatch.html
Question No:307
 
AWS_SAA-C01 Exam
You are leading a design meeting on security in your company's new AWS VPC. Your team is debating the merits of using security groups, Network Access Control Lists or both. It is important to be aware of the benefits of each and how that might interact if deployed together. What differences between security groups and Network Access Control Lists must you be aware of before deploying? (Choose 2 answers)
A. Security Groups are stateful, return traffic is allowed regardless of any rules.
B. NACLs are stateful, return traffic is allowed regardless of any rules.
C. NACLs are stateless, return traffic must be explicitly allowed by rules.
D. Security Groups are stateless, return traffic must be explicitly allowed by rules. Answer: A,C
Explanation: You can secure your VPC instances using only security groups; however, you can add NACLs as a second layer of defense.
Security groups — Act as a firewall for associated Amazon EC2 instances, controlling both inbound and outbound traffic at the instance level. Network access control lists (NACLs) — Act as a firewall for associated subnets, controlling both inbound and outbound traffic at the subnet level. Security Groups are stateful, return traffic is automatically allowed, regardless of any rules. NACLs are stateless, return traffic must be explicitly allowed by rules.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Security.html
Question No:308
You have been given the task of scaling up some existing infrastructure which currently has 8 EC2 instances running in a Placement Group. All these 8 instances were initially launched at the same time and seem to be performing as expected. You decide that you need to add 3 new instances to the group. However, when you attempt to do this you receive a capacity error. Which of the following actions will most likely fix this problem? (Choose 2 answers)
A. Increase the capacity of the placement group
B. Stop and restart the instances in the Placement Group and then try the launch again
C. Stop all the old instances in the placement group. Add the new ones then start them all at the same time
D. You can only have 10 EC2 instances in a placement group so you will need to remove one of the new ones
 
AWS_SAA-C01 Exam
Answer: B,C
Explanation: If you stop an instance in a placement group and then start it again, it still runs in the placement group. However, the start fails if there isn't enough capacity for the instance. If you receive a capacity error when launching an instance in a placement group, stop and restart the instances in the placement group, and then try the launch again.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html
Question No:309
You've been assigned to assist a client in the creation of their AWS Virtual Private Cloud (VPC). You are shadowing their IT admin to allow the admin to create the VPC, learn, and benefitfrom your guidance. Which VPC components are optional and should be created at the discretion of the customer? (Choose 3 answers)
A. Route Tables
B. Internet Gateways
C. NAT Gateways
D. Virtual Private Gateways Answer: B,C,D
Explanation: The optional components of a VPC are available for situational use in the VPC. An internet gateway needs to be created to give instances within the VPC internet access. By creating the Internet Gateway and creating a route in the route table to the Internet Gateway the instances will be able to access the internet. NAT Gateway perform a similar function to Internet Gateways but they are used for instances within private subnets. Virtual Private Gateways facilitate connectivity between the VPC and an on-premises network.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Networking.html
Question No:310
A user has configured the Dev/Test environment with AWS and created the IAM users with EC2, AS, ELB, and CloudWatch access. The CFO wants to save money on Dev/Test and terminate all the idle instances. Which of the following is the best possible solution for the user to terminate the idle instances?
A. Use Cloud Watch Alarms actions to automatically terminate the idle instances.
 
AWS_SAA-C01 Exam
B. Provide the user using the AWS account with EC2DescribeInstanceRecoveryAttribute access for idle instances to terminate automatically.
C. Launch all the instances with the IAM Role and activate CloudWatch to automatically terminate the idle instances.
D. Use AS to automatically call the CloudWatch alarm when idle instances are encountered.
Answer: A
Explanation: Using Amazon CloudWatch alarm actions, you can create alarms that automatically stop, terminate, reboot, or recover your Amazon Elastic Compute Cloud (Amazon EC2) instances. You can use the stop or terminate actions to help you save money when you no longer need an instance to be running.
Reference: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/UsingAlarmActions .html
Question No:311
You have been given a scope by a client to build a new mobile weather application which will use DynamoDB as a database. The application needs permissions for each user to communicate and store data in DynamoDB tables. What is the best method for granting each mobile device that installs your application access to DynamoDB tables for storage when required? (Choose 3 answers)
A. When the user signs in, grant temporary security credentials using STS.
B. Create an IAM role with the proper permission policy to communicate with the DynamoDB table.
C. Use web identity federation, which assumes the IAM role using AssumeRoleWithWebIdentity. D. Use groups to assign permissions to IAM users.
Answer: A,B,C
Explanation: All of the following combined would be the best method for granting each mobile device that installs your application access to DynamoDB tables
Use web identity federation, which assumes the IAM role using AssumeRoleWithWebIdentity, when the user signs in, granting temporary security credentials using STS.
Reference: http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_ena
 
AWS_SAA-C01 Exam
ble-create.html
Question No:312
You are designing an AWS RDS environment for a new client. You have designed in high availability for this environment and now you are reviewing scalability options and will meet with the client to review. You need to make them aware of vertical scaling options and considerations when choosing larger instance sizes. They are using a commercial database (SQL Server). What commercial consideration is required when vertically scaling the database?
A. Make sure you have the correct database vendor licensing in place before scaling vertically. B. Make sure you understand multi-AZ for SQL Server.
C. Make sure automatic backups have run before scaling vertically.
D. Make sure end users are signed out before scaling vertically.
Answer: A
Explanation: To handle a higher load in your database, you can vertically scale up your master database. Before you scale, make sure you have the correct licensing in place for commercial engines (SQL Server, Oracle) especially if you Bring Your Own License (BYOL). One important thing to call out is that for commercial engines, you are restricted by the license, which is usually tied to the CPU sockets or cores.
Reference: https://aws.amazon.com/blogs/database/scaling-your-amazon-rds-instance-vertically-and-h orizontally/
Question No:313
You are designing your company's new RDS database environment. Your design include multi-AZ for high availability and you have intentions of reviewing scalability options. But first, you need to determine which storage option meets your performance and cost requirements. You expect to have a small database that could grow to medium sized over time. You also want to have burst performance to meet short term spikes. Which storage option is best for you?
A. Magnetic
B. General Purpose (SSD) C. Provisioned IOPS (SSD)
 
AWS_SAA-C01 Exam
D. Dual core processors
Answer: B
Explanation: Amazon RDS provides three storage types: magnetic, General Purpose (SSD), and Provisioned IOPS (input/output operations per second). They differ in performance characteristics and price, allowing you to tailor your storage performance and cost to the needs of your database workload. General purpose is good for small to medium sized databases and has the burst to handle spikes.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html
Question No:314
In Amazon ElastiCache, what does it mean to run a Redis cache node as a read replica?
A. After its failover, the read replica is replaced by the Redis cache node, and accepts your future cache operations.
B. The Redis cache node replaces the read replica after the read replica completes its operations.
C. The read replica acts as a standby, and in failover scenarios, it is promoted to primary and accepts your cache operations.
D. The read replica is only used for read operations when there is a failure.
Answer: C
Explanation: In Amazon ElastiCache, read replicas serve two purposes in Redis: failure handing and read scaling. When you run a cache node with a read replica, the primary serves both writes and reads. The read replica acts as a standby which is promoted in failover scenarios. After failover, the standby becomes the primary and accepts your cache operations.
Reference: http://aws.amazon.com/elasticache/faqs/
Question No:315
You have a long running application on EC2 instances behind an Elastic Load Balancer. There have been errors in the application that require an immediate patch. How can you apply updates to your EC2 instances? (Choose 2 answers)
A. AWS can apply this patch for you as part of the Shared Responsibility model. B. Deregister the EC2 instances that are behind the load balancer manually.
 
AWS_SAA-C01 Exam
C. Register newly launched EC2 instances that have the new patch installed. D. The Elastic Load Balancer can apply the patch to the EC2 instances. Answer: B,C
Explanation: When using EC2 instances running behind an Elastic Load Balancer, you can deregister the EC2 instances manually and then register newly launched EC2 instances that have a new update applied. Elastic Load Balancer supports Health Checks to test the status of the EC2 instances.
Reference: https://aws.amazon.com/elasticloadbalancing/
Question No:316
A user has launched an EBS backed EC2 instance in the US-East-1a region. The user wants to achieve Disaster Recovery (DR) for that instance by creating another instance in Europe. How can the user achieve DR?
A. Use the “Launch more like this” option to copy the instance from one region to another
B. Create an AMI of the instance and copy the AMI to the EU region. Then launch the instance from the EU AMI
C. Copy the instance from the US East region to the EU region
D. Copy the running instance using the “Instance Copy” command to the EU region Answer: B
Explanation: To launch an EC2 instance it is required to have an AMI in that region. If the AMI is not available in that region, then create a new AMI or use the copy command to copy the AMI from one region to the other region.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html
Question No:317
Is it recommended to shutdown your EC2 instance when you create a snapshot of EBS volumes that serve as root devices?
A. No, the snapshot would turn off your instance automatically. B. No, you only need to shutdown an instance before deleting it.
 
AWS_SAA-C01 Exam
C. No
D. Yes Answer: D
Explanation: To create a snapshot for Amazon EBS volumes that serve as root devices, it is recommended to shutdown the instance before taking the snapshot.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-snapshot.html
Question No:318
By default, EBS volumes that are created and attached to an instance at launch are deleted when that instance is terminated. You can modify this behavior by changing the value of the flag
to false when you launch the instance. A. RemoveOnDeletion
B. DeleteWhenTerminated C. RemoveOnTermination D. DeleteOnTermination Answer: D
Explanation: An EBS volume is off-instance storage that can persist independently from the life of an instance. You continue to pay for the volume usage as long as the data persists.
By default, EBS volumes that are created and attached to an instance at launch are deleted when that instance is terminated. You can modify this behavior by changing the value of the flag DeleteOnTermination to false when you launch the instance.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/EBSVolumes.html
Question No:319
You create a two-tiered web application for a client with Elastic Load Balancer, two Web Servers, and a MySQL database. You begin getting complaints of poor response times and notice that the requests to the database are increasing weekly. The result is queries that are taking longer and longer. What steps can you take to speed up database performance? (Choose 2 answers)
A. Scale your web-tier vertically.
  
AWS_SAA-C01 Exam
B. Create a read replica and offload some read traffic to it. C. Use ElastiCache to cache queries.
D. Scale your web-tier horizontally
Answer: B,C
Explanation: Read replicas can be used to offload some read requests from the main DB server. Even more effective in improving performance is to use ElastiCache to cache frequently requested queries. Another effective technique is to shard the database and distribute the load between shards.
Reference: http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_BestPractices.html
Question No:320
A user is planning to host a scalable dynamic web application on AWS. Which of the services is not required by the user to achieve automated scalability?
A. AutoScaling
B. CloudWatch C. EFS
D. EC2 instances Answer: C
Explanation: The user can achieve automated scaling by launching different EC2 instances and making them a part of an ELB. Cloudwatch will be used to monitor the resources and based on the scaling need it will trigger policies. AutoScaling is then used to scale up or down the instances.
Reference: http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/WhatIsAutoScaling.html
Question No:321
You have designed an image manipulation application in which your users take a picture, upload it to your app, and request filters to be added to the image.
You need to decouple the application so your users are not waiting for the image processing to take place. Which of the following could be used as part of the process for doing this? (Choose 2
 
AWS_SAA-C01 Exam
answers)
A. Use Amazon Kinesis Analytics to process and analyze the images with standard SQL
B. Use Amazon Elastic Block Store (Amazon EBS) to provide block level storage volumes for use with EC2 instances
C. Use S3 to store the image, and Auto Scaling to determine when to fire off more worker instances based on queue size.
D. Use Amazon SQS to store the requests using metadata and JSON in the message.
Answer: C,D
Explanation: Amazon SQS can help you build a distributed application with decoupled components, working closely with the Amazon Elastic Compute Cloud (Amazon EC2) and other AWS infrastructure web services(eg. S3). You can create Auto Scaling policies that configure your Auto Scaling group to scale based on the number of messages in your SQS queue. The Amazon SQS message contains the subject and message that were published to the topic along with metadata about the message in a JSON document.
Reference: http://docs.aws.amazon.com/autoscaling/latest/userguide/as-using-sqs-queue.html
Question No:322
You are preparing a proposal for a prospective new client. They would like their cloud application environment to be highly scalable. Your proposal includes the benefits of scalability on AWS. What characteristics of scalability on AWS can you feature in your proposal? (Choose 2 answers)
A. More EC2 instances will ultimately pay for themselves in performance. B. Increasing resources will have a proportional increase in performance. C. Cost is inversely proportional to throughput.
D. The environment becomes more cost effective as it grows.
Answer: B,D
Explanation: Dynamic scaling can provide a very robust scaling option. But it is not the only option and not always the best option in all scenarios. Manual scaling and scheduled scaling also have use cases where they may be a better choice than dynamic scaling. Increasing resources to improve performance is certainly the most common use case for scaling. However, it
 
AWS_SAA-C01 Exam
is important also to be aware of the effects of scaling on cost. Utilizing auto scaling in conjunction with Cloudwatch monitoring can help insure that resources are scaled in and out appropriately and that money is not wasted on idle or underused resources.
Reference: http://docs.aws.amazon.com/autoscaling/latest/userguide/WhatIsAutoScaling.html
Question No:323
General Purpose SSD volumes smaller than 1 TB provide the ability to burst to IOPS per volume, independent of volume size, to meet the performance needs of most applications.
A. 2,500 B. 3,000 C. 10,000 D. 5,000 Answer: B
Explanation: Amazon EBS provides three volume types: General Purpose SSD, Provisioned IOPS SSD, and Magnetic.
General Purpose SSD volumes are the default EBS volume type for Amazon EC2 instances. GP2 volumes smaller than 1 TB can burst up to 3,000 IOPS. I/O is included in the price of gp2, so you pay only for each GB of storage you provision. GP2 is designed to deliver the provisioned performance 99% of the time. If you need a greater number of IOPS than gp2 can provide, or if you have a workload where low latency is critical or you need better performance consistency, we recommend that you use io1.
Reference: http://aws.amazon.com/ebs/details/#piops
Question No:324
You are leading a team in the design of an AWS environment for a client. This will be a hybrid environment requiring communication between on-premises application and the cloud environment, as well as private and public subnets which need internet access. The team has chosen to use NAT instances to provide internet access to the instances in the private subnets. What features does a NAT instance provide to our instances in the private subnet? (Choose 2 answers)
A. Allows all inbound internet traffic to the private subnet
B. Allows instances in private subnets to send outbound internet traffic
  
AWS_SAA-C01 Exam
C. Prevents instances in private subnets from receiving inbound traffic initiated by someone on the internet
D. Perform load balancing for traffic inbound to the private subnet
Answer: B,C
Explanation: You can use a network address translation (NAT) instance in a public subnet in your VPC to enable instances in the private subnet to initiate outbound IPv4 traffic to the Internet or other AWS services, but prevent the instances from receiving inbound traffic initiated by someone on the Internet. The NAT instance sends the traffic to the Internet gateway for the VPC. The traffic is attributed to the Elastic IP address of the NAT instance.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html#EIP_Di sable_SrcDestCheck
Question No:325
In Amazon Elastic Load Balancing, how many load balancers can you define per region?
A. 5
B. 20
C. 10
D. Infinite
Answer: B
Explanation: You can define up to 20 load balancers in Amazon Elastic Load Balancing. Reference: http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html
Question No:326
You are reviewing a plan for storage tiering on S3 buckets. The plan calls for infrequently accessed data to be moved from on-premise storage to standard S3 storage. The data will be moved from S3 standard to S3-IA . Finally, after 20 days, the data can be archived to Glacier. What problems do you see with this plan? (Choose 2 answers)
A. Infrequently accessed data should be archived to Redshift. B. Data stored in S3-IA must be retained for 30 days.
 
AWS_SAA-C01 Exam
C. Infrequently accessed data should go straight to S3-IA. D. Data must be encrypted in-flight to Glacier.
Answer: B,C
Explanation: AWS Standard S3 storage offers high durability, high availability for general purpose use. AWS S3-IA (infrequently Accessed) comes at a lower monthly cost but has a minimum duration of 30 days. Glacier storage is for archiving data that does not need real-time access. Recovert time is three to five hours.
Reference: https://aws.amazon.com/s3/storage-classes/
Question No:327
A user has launched an EC2 instance store backed instance in the US-East-1a zone. The user created AMI #1 and copied it to the Europe region. After that, the user made a few updates to the application running in the US-East-1a zone. The user makes an AMI#2 after the changes. If the user launches a new instance in Europe from the AMI #1 copy, which of the below mentioned statements is true?
A. The new instance will have the changes made after the AMI copy as AWS just copies the reference of the original AMI during the copying. Thus, the copied AMI will have all the updated data
B. The new instance will have the changes made after the AMI copy since AWS keeps updating the AMI
C. The new instance in the EU region will not have the changes made after the AMI copy D. It is not possible to copy the instance store backed AMI from one region to another Answer: C
Explanation: Within EC2, when the user copies an AMI, the new AMI is fully independent of the source AMI; there is no link to the original (source) AMI. The user can modify the source AMI without affecting the new AMI and vice a versa. Therefore, in this case even if the source AMI is modified, the copied AMI of the EU region will not have the changes. Thus, after copy the user needs to copy the new source AMI to the destination region to get those changes.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html
Question No:328
You are leading the design of your company's new AWS cloud environment. Your team is
 
AWS_SAA-C01 Exam
focusing on the options for instances within a VPC. You present the concept of tenancy options for instances to the team. It is important to understand tenancy options and use cases foreach option. What tenancy options are provided for Amazon EC2 instances? (Choose 3 answers)
A. Multi tenancy
B. Dedicated instances C. Shared tenancy
D. Dedicated hosts Answer: B,C,D
Explanation: Shared tenancy is the default tenancy model for all Amazon EC2 instances, regardless of instance type or pricing model. Shared tenancy means that a single host machine may host instances from different customers. Dedicated instances are Amazon EC2 instances that run in a virtual private cloud (VPC) on hardware that's dedicated to a single customer. Your dedicated instances are physically isolated at the host hardware level from instances that belong to other AWS accounts. An Amazon EC2 Dedicated Host is a physical server with EC2 instance capacity fully dedicated to your use.
Reference: https://aws.amazon.com/ec2/dedicated-hosts/
Question No:329
A client has called you about an autoscaling group behind an Elastic Load Balancer your company had configured for them over a year ago. Their company is being featured on national news and they are expecting a very large spike to their website within several hour. What immediate steps can you take to prepare for this spike? (Choose 2 answers)
A. Manually increase the maximum setting of your autoscaling group. B. Create a VPN for higher network throughput.
C. Contact AWS to pre-warm your Load Balancer.
D. Add read replicas to your RDS.
Answer: A,C
Explanation: Manual scaling is a basic way to scale resources. You can specify the change in the maximum, minimum, or desired capacity of your autoscaling group. This can be useful toscale resources for an infrequent or unexpected event. Pre-warming load balancers in such instances
 
AWS_SAA-C01 Exam
is also a viable strategy.
Reference: http://docs.aws.amazon.com/autoscaling/latest/userguide/autoscaling-load-balancer.html
Question No:330
In a design meeting with your Senior AWS Architect you are asked to create a dual homed network. The client has been using AWS cloud for a few years and has staff who are fairly well versed in AWS technology. They have offered a preliminary design, which calls for dual homed web servers attached to an application server. This setup is also dual homed to connect to a backend database server. Which AWS device will enable such a dual homed scenario?
A. Elastic IP Address
B. Elastic Load Balancer
C. Elastic Network Interface D. Dual Channel VPN Answer: C
Explanation: You can place a network interface on each of your web servers that connects to a mid-tier network where an application server resides. The application server can also be dual- homed to a back-end network (subnet) where the database server resides. Instead of routing network packets through the dual-homed instances, each dual-homed instance receives and processes requests on the front end, initiates a connection to the back end, and then sends requests to the servers on the back-end network.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html
Question No:331
In S3, how is storage class analysis intended to improve data lifecycle management?
A. Identify data that can be stored in Reduced Redundancy Storage instead of Standard B. Identify data to transition from Standard Storage to Glacier storage class
C. Identify data in all storage classes that may benefit from increased redundancy
D. Identify data to transition from Standard Storage to Standard-IA storage class Answer: D
 
AWS_SAA-C01 Exam
Explanation: By using Amazon S3 analytics storage class analysis you can analyze storage access patterns to help you decide when to transition the right data to the right storage class. This new Amazon S3 analytics feature observes data access patterns to help you determine when to transition less frequently accessed STANDARD storage to the STANDARD_IA (IA, for infrequent access) storage class.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/analytics-storage-class.html
Question No:332
Your client is a legal firm with offices in New York and Boston. You have gathered all of the requirements and have started designing their AWS cloud environment. The design calls for a VPC for the New York office and a VPC for the Boston office. The client wants this separation for billing purposes and other considerations. But they have a need for interoperability between the two VPCs. How can you best meet this requirement?
A. Place an Internet Gateway between the two VPCs. B. Set up a vpn between the two VPCs.
C. Set up a VPC Peering connection.
D. Set up Direct Connect between the two VPCs. Answer: C
Explanation: A VPC peering connection is a networking connection between two VPCs that enables you to route traffic between them using private IPv4 addresses or IPv6 addresses. Instances in either VPC can communicate with each other as if they are within the same network. You can create a VPC peering connection between your own VPCs, or with a VPC in another AWS account. In both cases, the VPCs must be in the same region.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-peering.html
Question No:333
Can we attach an EBS volume to more than one EC2 instance at the same time?
A. Yes, we can only for EC2-optimized EBS volumes. B. No
C. Yes, we can only in read-only mode.
D. Yes
 
AWS_SAA-C01 Exam
Answer: B
Explanation: No, we cannot attach an EBS volume to more than one EC2 instance at the same time. EC2 does not support mounting a single EBS volume on multiple instances under any circumstances.
Reference: https://forums.aws.amazon.com/message.jspa?messageID=117349
Question No:334
You have been assigned to a client to design their AWS VPC environment. They have a very tight budget and want to limit costs wherever possible. They like the idea of using Instance stores where the cost is included with the EC2 instance. But you've convinced them to use EBS volumes and to take regular snapshots of the volumes to store in S3. They are concerned about the costs of taking snapshots. What are those costs?
A. You pay for storage costs of snapshot data and there is a set cost per snapshot B. You pay a nominal fee per snapshot
C. You pay for storage costs of snapshot data and for the bandwidth used
D. You pay only for the storage costs of the snapshot data
Answer: D
Explanation: You can back up the data on your EBS volumes to Amazon S3 by taking point- in-time snapshots. Snapshots are incremental backups, which means that only the blocks on the device that have changed after your most recent snapshot are saved. The action of taking a snapshot is free, you pay only for the storage costs of the snapshot.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html#ebs-snapshot -overview
Question No:335
Your client has a need to store data which could grow quickly but unpredictably. You recommend EBS as a storage solution. But they have voiced concerns about scalability. What features of EBS canyou highlight to provide assurances of its elasticity and scalabilty? (Choose 3 answers)
A. EBS volumes are redundantly replicated on different hardware within the same AZ. B. You can quickly provision additional capacity by adding new EBS volumes.
 
AWS_SAA-C01 Exam
C. EBS can replicate synchronously to Instance Stores.
D. You can resize an existing volume by creating a snapshot and launching a new (larger volume) from the snapshot.
Answer: A,B,D
Explanation: AWS can be quickly provisioned for additional capacity by adding new EBS volumes. Existing volumes can be resized by creating a snapshot and launching a new (larger volume) from the snapshot. Each Amazon EBS volume is automatically replicated within its Availability Zone to protect you from component failure, offering high availability and durability. Amazon EBS is designed for application workloads that benefit from fine tuning for performance, cost and capacity.
Reference: https://aws.amazon.com/ebs/
Question No:336
You have ten instances running on the same subnet. All your instances have been compromised by a trojan that wants to initiate an outside TCP session on port 420. What is the easiest way to block this traffic?
A. You can block the traffic using a Network ACL.
B. You can block the traffic using a security group and a network ACL. C. You can block the traffic using a security group.
D. All outbound traffic are blocked by default.
Answer: A
Explanation: Amazon VPC provides three features that you can use to increase and monitor the security for your VPC. One among the three is the network access control lists (ACLs). They act as a firewall for associated subnets, controlling both inbound and outbound traffic at the subnet level.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Security.html#VPC_Securi ty_Comparison
Question No:337
You are assigned a new client and told to investigate an issue they are encountering with ElastiCache. The only information you are given is that their SwapUsage metric is at 60 MB and
 
AWS_SAA-C01 Exam
growing. What can you deduce immediately from this information? (Choose 2 answers) A. You should increase SwapUsage.
B. They are using the Memcached engine.
C. You should increase redis_connections_overhead.
D. You should increase the memcached_connections_overhead
Answer: B,D
Explanation: The two engines ElastiCache uses are Memcached and Redis. Memcached uses a metric called SwapUsage and if SwapUsage exceeds 50 MB, you need to increase the memcached_connections_overhead parameter. Redis does not use SwapUsage but instead, uses the reserved-memory metric.
Reference: https://aws.amazon.com/elasticache/
Question No:338
When your developers use an SSH connection to connect to a newly deployed EC2 instance, they receive connectivity errors about issues connecting to the instance. What steps should you take to identify the source of this problem? (Choose 3 answers)
A. Reconfirm that the private key being used matches the key pair that was assigned at launch. B. Recheck the public IP address.
C. Confirm that the EC2 instance is associated with the desired IAM role.
D. Reconfirm your logon information.
Answer: A,B,D
Explanation: The public-private key selected during deployment of an instance must match the public-private key used when authenticating at logon.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html
Question No:339
When a user moves an object to a Glacier archive from an S3 bucket, Glacier adds extra storage for the metadata. Does Glacier charge the user for that additional storage?
 
AWS_SAA-C01 Exam
A. No, it does not since the storage is added by Glacier for internal tracking. B. Yes, it does.
C. No, Glacier does not add additional metadata.
D. Yes, Glacier charges $10 for each MB of additional storage.
Answer: B
Explanation: For each object archived to Amazon Glacier, Amazon S3 uses 8 KB of storage for the name of the object and other metadata. Amazon S3 stores this metadata so that you can get a real-time list of your archived objects by using the Amazon S3 API (see Get Bucket (List Objects)). You are charged standard Amazon S3 rates for this additional storage. Amazon S3 adds 8 KB of storage to each object for the name and other metadata. When this is moved to Glacier, Glacier has 32 KB of storage and metadata. Glacier will charge for the additional metadata.
Reference: http://docs.aws.amazon.com/AmazonS3/latest/dev/lifecycle-transition-general-consideration s.html
Question No:340
You have been assigned to work with a manufacturing company which wants to migrate to a Virtual Private Cloud. They currently have four operating systems in which they would like to continue working: Mac, Windows, Linux, and Windows with SQL Server. Their technical lead is very proactive and also knows that the company is very cost conscious. To that end, she would like to use EC2 spot instances wherever possible for the greatest savings, including in the company's time and attendance systems. What issues must you make the technical lead aware of in using spot instances exclusively? (Choose 3 answers)
A. Spot instances can be taken away at any time and are not appropriate for time and attendance systems.
B. EC2 Spot instances are more suited to office environments than in the manufacturing shop floor.
C. EC2 Spot instances do not support Windows with SQL Server. D. EC2 Spot instances do not support Mac OS.
Answer: A,C,D
 
AWS_SAA-C01 Exam
Explanation: Spot instances provide the ability for customers to purchase compute capacity with no upfront commitment, at hourly rates usually lower than the On-Demand rate. Spot instances allow you to specify the maximum hourly price that you are willing to pay to run a particular instance type. If the Spot Price moves higher than a customer’s maximum price, the customer’s instance will be shut down by Amazon EC2. Spot instances do not support Mac OS or Windows with SQL Server.
Reference: https://aws.amazon.com/ec2/faqs/#spot-instances
Question No:341
You are placed in charge of your company's cloud storage and need to deploy new EBS Volumes. You are concerned about an initial performance hit when the new volumes are first accessed. You are considering initializing these volumes (formerly known as pre-warming). What characteristics of initializing volumes must you consider? (Choose 2 answers)
A. New EBS volumes created from scratch receive their maximum performance immediately and do not require initialization
B. New EBS volumes created from snapshots receive their maximum performance immediately and do not require initialization.
C. New EBS volumes created from scratch need to be initialized by reading from them.
D. New EBS volumes created from snapshots need to be initialized by reading from them. Answer: A,D
Explanation: Initializing volumes (formerly known as pre-warming) has changed from its prior functionality. Formerly, you would have to initialize (pre-warm) a newly created volume from scratch. This is no longer necessary. Newly created volumes created from snapshots still need to be pre-warmed by reading from the blocks that contain data.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-initialize.html
Question No:342
You have successfully created your first WordPress blog that is hosted on an Amazon EC2 instance. You’ve noticed that when the public DNS address for your instance changes, it breaks your installation. What could you do to prevent this? (Choose 3 answers)
A. If you have a domain name, update the DNS record for the domain name to point to your Elastic IP address.
B. If you have a domain name, update your Elastic IP address to point to the DNS record for your
 
AWS_SAA-C01 Exam
domain name.
C. If you don’t have a domain name, use Amazon Route 53 and associate your instance’s Elastic IP address with your domain name.
D. Allocate an Elastic IP address for your Amazon instance.
Answer: A,C,D
Explanation: To prevent the public DNS address for your instance from changing and breaking your installation, you can associate an Elastic IP address (EIP) to the instance you are using. You need to allocate an Elastic IP address for that instance (the first association is free). If you own a domain name and you want to use it for your blog, you can update the DNS record for the domain name to point to your EIP address. If you don't already have a domain name for your blog, you can register a domain name with Amazon Route 53 and associate your instance's EIP address with your domain name.
Reference: http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hosting-wordpress.html
Question No:343
You are leading a team in the design of an AWS environment for a client. This will be a hybrid environment requiring communication between on-premises application and the cloud environment, as well as private and public subnets which need internet access. The team has chosen to use NAT Gateways to provide internet access to the instances in the private subnets. What configuration steps must be taken to enable internet access for instances in the private subnets via the NAT Gateway? (Choose 2 answers)
A. Allocate an Elastic IP address and associate it with the NAT Gateway.
B. Create a route in the route table to direct traffic from the private subnet to the Internet Gateway.
C. Disable source/destination check on the private subnet.
D. Create a route in the route table to direct traffic from the private subnet to the NAT Gateway. Answer: A,D
Explanation: You can use a network address translation (NAT) gateway to enable instances in a private subnet to connect to the Internet or other AWS services, but prevent the Internet from initiating a connection with those instances. To create a NAT gateway, you must specify the public subnet in which the NAT gateway will reside. You must also specify an Elastic IP address to associate with the NAT gateway when you create it. After you've created a NAT gateway, you
 
AWS_SAA-C01 Exam
must update the route table associated with one or more of your private subnets to point Internet-bound traffic to the NAT gateway. Disabling source/destination checks is a feature of NAT Instances not NAT Gateways.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-nat-gateway.html#nat-gate way-basics
Question No:344
You've taken over management of your company's AWS cloud environment. You know very little about the environment and have been provided very little documentation. You have been given access to the environment and begin a discovery and documentation process. You begin by looking at the route table. Without seeing the specific route table, what information do you know it contains about the subnets in the VPC? (Choose 2 answers)
A. The default mask of the subnet can be identified.
B. Subnets that do not direct traffic to an Internet Gateway are private. C. The subnets availability zone is indicated.
D. Subnets that direct traffic to an Internet Gateway are public. Answer: B,D
Explanation: A route table contains a set of rules, called routes, that are used to determine where network traffic is directed.
Each subnet in your VPC must be associated with a route table; the table controls the routing for the subnet. A subnet can only be associated with one route table at a time, but you can associate multiple subnets with the same route table. When you add an Internet gateway, an egress-only Internet gateway, a virtual private gateway, a NAT device, a peering connection, or a VPC endpoint in your VPC, you must update the route table for any subnet that uses these gateways or connections.
Reference: http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html
Question No:345
When considering STS, what benefits can be gained from its use? (Choose 2)
A. Grant access to AWS resources without having to create an IAM identity for them. B. Temporary security credentials can be extended indefinitely.
 
AWS_SAA-C01 Exam
C. Since credentials are temporary, you don't have to manually rotate or revoke them. D. Temporary security credentials can be restricted to a specific region.
E. Automatic termination of EC2 instances when credentials expire.
Answer: A,C
Explanation: The benefits of STS include no embedding long-term security credentials in an application; the ability to grant access to AWS resources without having to create an IAM identity for them; and since credentials are temporary, you don't have to rotate or revoke them. Please note, like and IAM credentials, STS credentials are global and cannot be restricted to a region.
Question No:346
Which of the following are managed using IAM? (Choose 2)
A. Multi-Factor Authentication B. Bucket Policies
C. Billing Reports
D. Roles
E. Security Groups
Answer: A,D
Explanation: IAM is used to manage users and their access to AWS, and AWS service, as well as access from one AWS resource to another including: Users, Groups, Roles, Access Policies, API Keys, Password Policies, Multi-Factor Authentication.
Question No:347
What best describes an IAM role?
A. A role is used when configuring multi-factor authentication.
B. A role is a policy that determines an IAM user's access to AWS resources.
C. A role is something that a user, application or service can "assume" to receive temporary
 
AWS_SAA-C01 Exam
security credentials that provide access to a resource.
D. A role is a policy that is applied directly to an AWS resource, such as an EC2 instance. Answer: C
Question No:348
API Access Keys are required in which scenarios below? (Choose 2)
A. Retrieving data from an ElastiCache cluster.
B. On premise servers connecting to RDS databases C. AWS CLI
D. Windows PowerShell
E. Managing AWS resources through the AWS console Answer: C,D
Explanation: Option B: You can connect to an RDS database using database users and permissions. This is outside of IAM.
Option C: API keys are needed when working "programmatically" through the CLI, PowerShell, Direct HTTP calls, and SDK API access.
Question No:349
You are the lead Solutions Architect for a healthcare company and are managing an application running on multiple EC2 instances. Those EC2 instances must have the ability to access other AWS resources. What is the best way to manage this access?
A. Use an IAM user to manage temporary credentials for applications that run on an EC2 instance. The user will supply temporary permissions that applications can use when they make calls to other AWS resources.
B. Use an IAM PassRole to restrict which role a user can pass to an EC2 instance when the user launches the instance. This way you can eliminate the need for credentials.
C. Use an IAM role to manage temporary credentials for applications that run on an EC2 instance. The role will supply temporary permissions that applications can use when they make calls to other AWS resources.
 
AWS_SAA-C01 Exam
D. Have your developers store AWS credentials directly within the EC2 instance and allow applications in that instance to use those credentials. Developers can manage the credentials and ensure that they securely pass the credentials to each instance and update each EC2 instance when it's time to rotate the credentials.
Answer: C
Explanation: Option B: The PassRole permission is needed to launch an instance with a role. It does not eliminate the need for credentials which come when the instance assumes the role. Option C: For best security practice, you should never store or pass IAM credentials to an EC2 instance. Using IAM roles has several benefits. Because role credentials are temporary and rotated automatically, you don't have to manage credentials, and you don't have to worry about long-term security risks. In addition, if you use a single role for multiple instances, you can make a change to that one role and the change is propagated automatically to all the instances.
Question No:350
Which of the following is NOT required as part of AWS's suggested "best practices" for new accounts?
A. Delete the root account
B. Create individual IAM users
C. Use user groups to assign permissions D. Apply an IAM password policy Answer: A
Explanation: Option A: Root accounts cannot be deleted, but their access keys can be deleted. Option C: Using groups to assign permissions is best practice as it allows you more easily and quickly grand/remove permissions from large groups of users.
Question No:351
What best describes the "Principle of Least Privilege"?
A. Users should always have a little more access granted to them than they need, just in case they end up needing it in the future.
B. All users should have the same baseline permissions granted to them to use basic AWS services.
 
AWS_SAA-C01 Exam
C. Users should be granted permission to access only the resources they need to do their assigned job.
D. Users should submit all access request in writing so that there is a paper trail of who needs access to different AWS resources.
Answer: C
Explanation: Option C: "Principal of Least Privilege" is viewed as a security best practice by only allowing for users to have the exact amount of access they need to do their job.
Option D: Although this may be a good idea for record/auditing - it does not describe the "Principle of Least Privilege".
Question No:352
When requested through an STS API call, credentials are returned with what components?
A. Signed URL, Security Token, Username
B. Security Token, Access Key ID, Secret Access Key, Expiration C. Security Token, Secret Access Key, Personal Pin Code
D. Security Token, Access Key ID, Signed URL
Answer: B
Explanation: Option B: To get STS credentials, you need to request them through an STS API call. The returned credentials include a Security Token, an Access Key ID, a Secret Access Key and an Expiration timestamp. These are short-term, temporary credentials.
Option D: The returned credentials include a Security Token, an Access Key ID, and a Secret Access Key. It does not include a signed URL.
Question No:353
If you are running an application in a production environment and must add a new EBS volume with data from a snapshot, what could you do to avoid degraded performance during the volume's first use?
A. Attach the volume to an EC2 instance
B. Nothing – EBS volumes do not suffer from degraded performance.
 
AWS_SAA-C01 Exam
C. Make a snapshot of the volume
D. Initialize the data by reading each storage block on the volume Answer: D
Explanation: Option C: Taking additional snapshots of EBS volumes does not resolve the performance issue associated with new EBS volumes created from snapshots.
Option D: Volumes created from an EBS snapshot must be initialized. Initializing occurs the first time a storage block on the volume is read, and the performance impact can be impacted by up to 50%. You can avoid this impact in production environments by pre-warming the volume by reading all of the blocks.
Question No:354
If you are running a legacy application that has hard-coded static IP addresses and is running on an EC2 instance; what is the best failover solution that allows you to keep the same IP address on a new instance?
A. Just use private IP addresses
B. Edit the application's code each time a new instance is used
C. Elastic IP addresses
D. Make sure public IP addresses are enabled in the subnet settings Answer: C
Explanation: Option C: Elastic IP addresses (EIPs) are designed to be attached/detached and moved from one EC2 instance to another. They are a great solution for keeping a static IP address and moving it to a new instance if the current instance fails. This will reduce or eliminate any downtime uses may experience.
Option D: Public IP addresses will be different on the new instance.
Question No:355
Which feature of Intel processors help to encrypt data without significant impact on performance?
A. TSX
B. AES-NI
 
AWS_SAA-C01 Exam
C. Turbo Boost
D. AVX
Answer: B
Explanation: Option B: AES-NI provide hardware acceleration of encryption.
Option C: Turbo Boost allows the processor to temporarily run at a higher clock speed.
Question No:356
What command should you run on an instance if you want to view its bootstrap script?
A. curl http://localhost/latest/user-data
B. curl http://localhost/latest/meta-data/bootstrap C. curl http://169.254.169.254/latest/user-data
D. curl http://254.169.254.169/latest/user-data Answer: C
Question No:357
You are a Solutions Architect and your company is interested in moving some workload to AWS. You are concerned that it will be very challenging to manage and control all of the EC2 servers that will need to be deployed – specifically, how to ensure that fellow employees are installing the company approved operating system version with the right libraries and runtimes and with the proper configuration settings. What EC2 feature will best allow you to control this?
A. You can create an IAM policy that restricts that launching instances with only a custom Amazon Machine Image (AMI), which specifies exactly which software and associated settings you want to have installed on every new EC2 instance.
B. You can set up an alert when a new instance is launched and have SNS send you the configuration parameters for the new instance. You can then manually review these parameters to make sure the user is following the company policies.
C. Create a CloudWatch alarm to monitor instance launch activity and shutdown launches that attempt to install unauthorized applications.
D. Through the use of IAM, you can create a policy that will dictate what users can install after
 
AWS_SAA-C01 Exam
launching a new instance.
Answer: A
Explanation: Option A: AMIs are what dictate the instance's operating system and other software settings. You can customize the instance that you launch from a public AMI and then save that configuration as a custom AMI. You can assign an IAM policy to users that will allowlaunching instances with your custom AMIs and deny all others.
Option B: This would be helpful, but you also need to create custom AMIs to ensure the correct configuration.
Question No:358
If you are designing an application that requires fast (10 - 25Gbps), low-latency connections between EC2 instances, what EC2 feature should you use?
A. Snapshots
B. Instance store volumes
C. Placement groups
D. IOPS provisioned instances. Answer: C
Explanation: Option B: EC2 Instance store volumes do not have an impact on the degree of latency between instances.
Option C: Placement groups are a clustering of EC2 instances in one Availability Zone with fast (up to 25Gbps) connections between them. This feature is used for applications that need extremely low-latency connections between instances.
Question No:359
What best describes the characteristics of EBS volumes?
A. They will be deleted anytime the instance is stopped or terminated B. They are persistent and can live past the lifetime of the instance C. They are ephemeral and wiped when an instance is stopped
D. They cannot be used as an instance's root storage device
 
AWS_SAA-C01 Exam
Answer: B
Explanation: Option B: EBS volumes are network-attached, persistent storage volumes. When Delete on Termination is disabled they live past the life of an EC2 instance.
Option D: They are commonly used as root storage devices.
Question No:360
How can you improve the performance of your Elastic File System?
A. Use an instance-store backed EC2 instance.
B. Mount to targets in the same AZ as your instance.
C. Provision higher IOPs for your EFS.
D. Divide your files system into multiple smaller file systems. Answer: B
Explanation: Option B: EFS allows you to create multiple mount targets that you can distribute across AZs.
Option D: This may actually reduce performance since performance scales with the amount of data stored in each file system.
Question No:361
A new CRM application is ready for its first release into production. You want to make sure that the Production Environment will not be reachable from the Development Environment. What is the easiest way to isolate these two environments?
A. Put them in separate VPCs
B. Move the Development Environment into Private Subnets
C. Deploy in separate subnets and remove the routes in the route table between them D. Launch the Production Environment into Private Subnets
Answer: A
Explanation: Option A: VPCs are isolated networks, so by default, there will be no network communication between them.
 
AWS_SAA-C01 Exam
Option B: Private subnets mean that the instances will not be reachable from the public network, which may not be what you want. Also, Private subnets alone would not satisfy the requirement. It would also require configuring security groups and/or NACLS.
Question No:362
What are two things that must be configured to allow public access to an EC2 Instance in a VPC? (choose 2)
A. Public IP or Elastic IP or IPv6 address
B. Route in the subnet route table with 0.0.0.0/0 as the destination and the Internet Gateway as the target
C. Private IP
D. A NAT gateway is required to forward incoming requests to the instance. E. An IAM Role that allows HTTP traffic to the instance
Answer: A,B
Explanation: An Internet routable address is required.
Question No:363
You are running a public web service on and EC2 instance with a Public IP. The application seems to be running slow, so you recommend to the administrator that he restart it. He decides it would be best to stop and start the instance. When the instance restarts, users are unable to reach it. What could be the problem?
A. The security group is no longer associated with the instance. B. The instance has launched in a private subnet.
C. The ENI needs to be reattached.
D. The Public IP has changed.
Answer: D
Explanation: Option B: Stopping and starting the instance would not change its subnet. Option D: When an instance is stopped the Public IP is reclaimed by AWS. A new one is assigned
 
AWS_SAA-C01 Exam
when the instance starts. An Elastic IP should be used instead.
Question No:364
A solutions architect has been tasked with deploying a stateful security firewall for their customer's application instances. These instances will be deployed across several publically accessible subnets in the VPC. Which AWS service could be used to meet the requirement?
A. Network Access Control Lists B. Auto Scaling
C. Security Groups
D. AWS Shield
Answer: C
Explanation: Option A: Network Acces Control Lists are a stateless security firewall.
Option C: Security Groups are a stateful security service, and the instances could all be members of the same Security Group no matter what subnet they are deployed in.
Question No:365
The customer has requested that all instances deployed in the public subnet of the VPC be accessible from the internet. What must be configured to ensure that this requirement is met?
A. Network Access Control Lists
B. Nothing, public subnets are always accessible from the internet C. Customer Gateway
D. Route Table
Answer: D
Explanation: Option B: Subnets are private by default and depend a custom route table with a route to the Internet to become public.
Option D: A Route Table with a route to the internet must be associated with the subnet before instances will be accessible from the internet.
 
AWS_SAA-C01 Exam
Question No:366
What happens if you launch an EC2 instance without specifying a subnet?
A. You must specify a subnet, so it will not launch.
B. It will be launched as an EC2 Classic instance.
C. It will launch as a spot instance.
D. It gets launched into a default subnet in the default VPC. Answer: D
Question No:367
A company is expecting a large increase in web traffic to EC2 instances within their VPC. A concern has been raised about the Internet Gateway's ability to handle a sudden increase in traffic. What needs to be done to address this concern?
A. Raise a ticket with AWS to pre-warm your Internet Gateway to prepare for this increase in traffic.
B. Replace the existing Internet Gateway with a High Capacity Internet Gateway which has a larger bandwidth limit.
C. Provision an additional Internet Gateway in the VPC so it can handle twice the load of your current configuration.
D. Nothing would need to be done with the Internet Gateway to prepare for an increase in traffic to the VPC.
Answer: D
Explanation: Option C: Only one Internet Gateway can be provisioned in a VPC. Internet Gateways will scale automatically to meet all traffic demands.
Option D: Internet Gateways have no bandwidth limit, are highly available and will scale automatically to meet any traffic demands.
Question No:368
A Solutions Architect is tasked with assigning static private IPs to three EC2 instances in the VPC. If the CIDR block of the VPC is 10.1.0.0/16, which two sets of IP addresses would be in the correct range?
 
AWS_SAA-C01 Exam
A. 10.1.0.10, 10.1.0.20, 10.1.0.30
B. 10.1.1.10, 10.2.1.20, 10.1.1.30
C. 10.1.0.100, 10.1.0.200, 10.1.0.300 D. 10.1.1.10, 10.1.2.10, 10.1.3.10
E. 10.1.1.1, 10.2.1.1, 10.3.1.1 Answer: A,D
Explanation: All three IP addresses fall within the CIDR block of 10.1.0.0/16 and are valid IPv4 addresses.
10.1.0.300 is not a valid IPv4 address. The maximum value in any octet of an IP address is 255.
Question No:369
Your marketing department would like to hold a Flash Sale on your e-commerce site. They anticipate that the sale will generate 100 times normal traffic the moment the sale begins. Which type of load balancer would you choose for this application?
A. HA Proxy Load Balancer B. Classic ELB
C. Network Load Balancer
D. Application Load Balancer Answer: C
Question No:370
What is the proper solution you should enact to prevent your application from crashing due to an unexpected increase in demand?
A. Auto Scaling
B. Elastic Load Balancing C. Multi-AZ failover
 
AWS_SAA-C01 Exam
D. Scaling policies
Answer: A
Explanation: Auto Scaling is what provides your architecture with the ability to automate the process of adding more instances to avoid crashes (if the case of sudden increase in demand). This is to mitigate effects of an Availability Zone going down, not to handle demand increases.
Question No:371
You are tasked with reducing the monthly EC2 charges and you notice that an application is running in an autoscaling group with three AZs, a minimum group size of three and a maximum group size of twelve. Before recommending any changes what should you consider?
A. Can you switch the architecture to EC2-Classic?
B. Can the application run in one AZ instead of three?
C. Does the application need to be Highly Available or Fault Tolerant? Based upon the finding, consider reducing the minimum group size.
D. Are twelve instances ever necessary? If not, reduce the maximum group size. Answer: C
Question No:372
A company has requested that their web application server and database server be highly available when deployed to AWS. Which subnet configuration would meet this requirement?
A. Two public subnets in different availability zones and two private subnets in different availability zones.
B. Two public subnets in different availability zones and one private subnet spanning two availability zones.
C. One public subnet for the application instance, and one private subnet for the database backend instance.
D. Two public subnets in the same availability zone to ensure the application can quickly failover.
Answer: A
 
AWS_SAA-C01 Exam
Explanation: Option A: This would fulfill the requirement as instances in public or private subnets could be configured to failover to instances in the other subnet in the event a single availability zone goes offline.
Option D: Subnets should be configured in multiple availability zones to ensure the application remains available in the event a single availability zone goes offline.
Question No:373
Your team is trying to migrate a busy application to the cloud. They have established a VPN to an AWS VPC. While they are provisioning the EC2s in the VPC they want to see if it is possible to continue to route traffic to the on-premise servers using a load balancer inside of the VPC. What would you suggest?
A. Use a Classic ELB to route traffic to internal DNS names of the on-prem servers.
B. Use a Classic ELB to route traffic to EC2 instances configured to forward all traffic to the on-prem servers.
C. Provision a NAT Gateway for Network Address Translation and attach it to your VPN. Use a Network Load Balancer to distribute traffic to the NAT Gateway. Unregister the NAT Gateway when the migration is complete.
D. Configure a target group with IP addresses as the target type. Add the private IP addresses of the on-prem servers to the target group. Configure an ALB or NLB to route to the target group.
Answer: D
Explanation: Option C: A NAT Gateway is not an allowable target for a Network Load Balancer. Option D: Target groups can include IP addresses of servers that are on-premise.
Question No:374
You are designing an environment that requires a complex balancing of traffic to EC2 instances using content-based rules, such as host-based or path-based. Which of the following AWS services would you choose?
A. Classic Elastic Load Balancer
B. Application Elastic Load Balancer C. AutoScaling Group
D. Launch Configuration
 
AWS_SAA-C01 Exam
Answer: B
Explanation: Application Elastic Load Balancers allow us to configure content-based rules to balance traffic based on different content-based rules. None of the remaining answers would accomplish this task.
AutoScaling does not balance traffic
Question No:375
Which of the following AWS services are inherently Fault Tolerant? (choose 2)
A. EC2
B. Route 53
C. VPC
D. DynamoDB
E. RDS
Answer: B,D
Explanation: Because of the global deployment of Route 53 across > 100 edge locations, it is fault tolerant.
Question No:376
You are having trouble deploying an application in an Autoscaling Group because it is stateful. What two things must you do to make it stateless?
A. Replace the ELB with an HA Proxy Instance
B. Have developers rewrite the application to use a NoSQL database for state information C. Create an EBS volume and share it across the instances in the group
D. Enable the ELB Sticky Session feature to stop users from losing their session data
E. Provision a NoSQL database such as DynamoDB or ElastiCache
Answer: B,E
 
AWS_SAA-C01 Exam
Explanation: Option B: They would need to make the appropriate API calls to put and get the session data from the NoSQL table.
Option C: EBS volumes are not shareable
Option E: A NoSQL database such as DynamoDB or ElastiCache is ideal for session storage due to high performance and scalability.
Question No:377
You can use Route 53 for everything below except:
A. Creating a DNS record for a mail server B. Weighting traffic to two endpoints
C. Caching documents at edge locations D. Registering a new domain name Answer: C
Question No:378
What are two primary benefits of using a CloudFront web distribution?
A. Users experience lower latency and faster content load time B. Automates deployment of your infrastructure
C. Sends bulk emails to a distribution list
D. Reduces load on your application's resources
E. Monitors your infrastructure in near real time Answer: A,D
Explanation: Option A: Cached content is delivered from edge locations close to the user Option C: That is called SES (Simple Email Service)
Option D: Since static content is cached, there are fewer requests made to the origin servers
Question No:379
An RTMP distribution is for ....
 
AWS_SAA-C01 Exam
A. distributing notification messages to remote team members B. streaming Adobe Flash media files from an S3 bucket origin. C. Accessing a cluster of relational databases
D. queuing messages for backend processing
Answer: B
Explanation: Option B: An RTMP is a type of CloudFront distribution for Adobe Flash Media. Option D: That is the Simple Queuing Service (SQS)
Question No:380
Which of the following will help to offload requests to your S3 bucket? (choose 2)
A. Route 53 Cache Distribution B. Regional Edge Caches
C. S3 Transfer Acceleration
D. AWS WAF
E. CloudFront Distribution configured to cache static content Answer: B,E
Explanation: Cached objects ejected from an Edge Location are cached in Regional Edge Caches, so CloudFront does not need to request the object from the origin when it is requested.
Question No:381
What is required when configuring an S3 bucket for Route 53 DNS failover?
A. The record set must be of type "MX"
B. The bucket name must match the domain name
C. The record set cannot use an alias and must point to the IP address of the S3 endpoint D. The S3 bucket must be in the same region as the hosted zone
 
AWS_SAA-C01 Exam
Answer: B
Explanation: To use an S3 bucket for Route 53 DNS failover, the bucket name must match the domain name.
DNS records are global, not regional.
Question No:382
Your CloudFront distribution is performing well, but you are still getting too many requests at the origin locations. What could be one way to increase CloudFront performance?
A. Configure CloudFront to cache based upon query string parameters. B. Create an "invalidation" for all your objects and recache them
C. Increase the default TTL
D. Change the origin location from an S3 bucket to an ELB
Answer: C
Explanation: Option C: If your default Time to Live (TTL) is too short, you may have requests from the edge location to the origin occurring when they are not required. If you increase the TTL, you should experience fewer hits to the origin.
Option D: This would make no difference since the problem is that objects are not being served from the cache.
Question No:383
Which two solutions are suitable for storing session state information for your application?
A. RDS
B. Redis on ElastiCache C. Neptune
D. DynamoDB
E. Aurora
Answer: B,D
 
AWS_SAA-C01 Exam
Explanation: DynamoDB is widely used for key-value storage of session information and to make your applications stateless.
Question No:384
You need to retain backups of the database for your CRM application for two quarters. The database is currently running on RDS. Which option should you consider?
A. Migrate from RDS onto an EC2 so you can manage backups yourself
B. Take manual snapshots of the database and retain them for six months before deleting
C. Use the Automated Snapshot feature of RDS
D. Use the standard backup mechanisms for the database engine and save the backup files on the local filesystem of the RDS DB instance
Answer: B
Explanation: Manual snapshots are durably stored in S3 and you can retain them for as long as you need.
You have no access to the local filesystem of an RDS DB instance.
Question No:385
Which database service allows you to access your data with a choice of open source APIs?
A. DynamoDB
B. Neptune
C. RDS
D. Redshift
Answer: B
Explanation: Neptune allows you to choose either Tinkerpop Gremlin or RDF SPARQL. RDS databases use SQL as the query language
Question No:386
During peak load, the latency for queries running on the MySQL database for your application
 
AWS_SAA-C01 Exam
gets long and users are complaining. What two things could you try that would not require the developers to make changes to the application?
A. Add an additional MySQL primary instance B. Migrate the database to Aurora.
C. Cache the result sets in ElastiCache
D. Add a Read Replica
E. Vertically scale the DB instance to a larger size or more performant type (higher memory, CPU)
Answer: B,E
Explanation: Aurora is a drop-in replacement for MySQL with 5 times the performance.
The developers would have to modify their code to check the cache before each query is run on the DB.
Changing the instance size and type will increase the compute and memory available for the database without code changes.
Question No:387
What database service on AWS is optimized for querying the relationships between entities?
A. Neptune
B. RDS
C. Redshift
D. DynamoDB Answer: A
Explanation: Neptune is a Graph Database service, optimized for graph structures such as nodes (data entities), edges (relationships), and properties to represent and store data. DynamoDB is optimized for flat table structures. It doesn't have a concept of relationships between tables.
Question No:388
 
AWS_SAA-C01 Exam
When or why would you use Redshift Spectrum?
A. To analyze the light from receding stars using a 1000+ node cluster
B. When you need a petabyte-scale Datawarehouse
C. To migrate an Oracle database into Aurora
D. To query structured, semi-structured, or unstructured data stored in S3 using SQL and joining that with your Redshift tables
Answer: D
Question No:389
Which engine for ElastiCache would you choose if you needed good durability, snapshots, and high availability of your data?
A. Redshift
B. Memcached C. Redis
D. S3
Answer: C
Explanation: Memcached does not have shapshot capability, data persistence, nor data replication.
Redis does have shapshot capability, data persistence, and data replication.
Question No:390
Which database service should you choose if you need a petabyte-scale data warehouse?
A. RDS
B. ElastiCache C. DynamoDB D. Redshift
 
AWS_SAA-C01 Exam
Answer: D
Explanation: DynamonDB is a NoSQL database and does not support SQL queries or relationships between tables.
Redshift is for petabyte-scale data warehousing.
Question No:391
What can you use to automatically delete old versions of your objects in S3?
A. A scheduled function to automatically delete S3 snapshots over a certain age B. Lifecycle Policies
C. MFA Delete
D. Bucket Policies
Answer: B
Explanation: Using Lifecycle Policies, you can automatically expire the current version of your object, and permanently delete old versions once they pass a certain age.
Multi Factor Authentication is used as an extra layer of authentication before a person can delete an object.
Question No:392
You work for a hospital that is required to store patient's medical records for a minimum of 10 years. Most of these records will never be accessed but must be made available upon request (within a few hours). What is the most cost-effective storage option?
A. AWS Snowball
B. S3 Standard Storage
C. Glacier
D. S3-IA (infrequent access) Answer: C
Explanation: Glacier is an AWS solution for archival storage, which is designed for long-term storage of data that is very rarely accessed.
 
AWS_SAA-C01 Exam
IA storage is good, but Glacier is lower cost and meets the requirements.
Question No:393
Which transfer method is required to PUT a 5GB object into S3?
A. Snowball
B. S3 Transfer Acceleration C. Direct Connect
D. Multipart Upload Answer: D
Explanation: S3 Transfer Acceleration is an optional feature that speeds delivery of your object, but you are still required to use Multipart Upload.
Multipart Upload is required for objects >= 5GB but recommended for objects >= 100 MB
Question No:394
How long will it take to retrieve an archive from Glacier using standard retrieval if the vault is locked?
A. You can't retrieve the data since the vault is locked
B. One to five minutes
C. Just the time to download it
D. Three to five hours to restore it and then the time to download. Answer: D
Explanation: The archive has to be restored before you can begin downloading.
Time to first byte is 3 to 5 hours. You can be notified by SNS when you can start the download.
Question No:395
What AWS solution will automatically back up your local data to S3 and can recover it when a disk volume fails?
 
AWS_SAA-C01 Exam
A. Snowball
B. Glacier
C. EFS
D. Storage Gateway Answer: D
Question No:396
When transitioning S3 objects into cheaper storage classes, what characteristic is reduced?
A. Compression
B. Availability
C. Encryption
D. Durability
Answer: B
Explanation: Standard is 99.99%, IA is 99.9%, Single Zone IA is 99.5% Durability is 99.999999999% for all storage classes
Question No:397
You want to offload your web servers by moving all the static content (CSS, JS, images, fonts) into an S3 bucket. What will you have to do to avoid browser security errors?
A. Make the objects public
B. Serve the content from CloudFront
C. Enable CORS on the bucket
D. Store the objects in a folder with execute permissions Answer: C
 
AWS_SAA-C01 Exam
Question No:398
Which implementation of Storage Gateway allows you to access your files as objects in S3 and preserves their metadata?
A. Volume Gateway - Cached Volume mode B. Tape Gateway
C. File Gateway
D. Volume Gateway - Stored Volume mode Answer: C
Explanation: File Gateway is the only implementation that allows you direct access to your objects in S3.
EBS snapshots are stored in S3. These are used to recover lost data locally, but can also be used to recover your data onto EBS volumes. You don't have access to the files until you recover them onto a volume.
Question No:399
What two components are required to establish a hardware VPN connection?
A. Storage Gateway and Customer Gateway
B. Virtual Private Gateway and Direct Connection C. Direct Connection and Customer Gateway
D. Virtual Private Gateway and Customer Gateway Answer: D
Explanation: A Virtual Private Gateway is required to be attached to the VPC.
The VPG and Customer Gateway are the two "connectors" on both sides of the VPN connection (and both are required).
Question No:400
You are a global organization and have deployed VPCs in four regions around the world. Servers in your datacenter in the U.S. need connect to instances in these VPCs. How could you most easily make a private connection from your datacenter that could reach each VPC?
 
AWS_SAA-C01 Exam
A. Create a Direct Connect to a region close to your datacenter and make a private VIF connection to Direct Connect Gateway
B. This is not possible at this time
C. Make separate Direct Connects to each region
D. Create a Direct Connect to a VPC configured as a Transit VPC, which is peered to the other VPCs
Answer: A
Explanation: Direct Connect Gateway allows you to connect to any of your VPCs from a single Direct Connect.
Possibly, but this is more complex and costly than Direct Connect Gateway.
Question No:401
VPC1 has an active VPN connection to an on-premise datacenter. We now want VPC2 to connect to the datacenter as well. How could we most easily accomplish this?
A. Attach the VPN connection to a Direct Connect Gateway and create private VIFs for each VPC B. Create a separate VPN connection to VPC2
C. Configure a NAT Gateway in VPC1 and route the requests from VPC2 through it
D. Setup VPC peering between VPC 1 and 2 so VPC2 can use VPC1's VPN connection.
Answer: B
Explanation: Since you can't share the existing connection, you need to create a new one. Sharing the VPN connection is not allowed via VPC peering.
Question No:402
You are trying to establish a VPC peering connection but are having difficulties locating the other VPC. What is most likely the cause?
A. The other VPC doesn't have an IGW
B. The other VPC has to have a public subnet
 
AWS_SAA-C01 Exam
C. The other VPC doesn't have an EC2 instance in it D. The other VPC has the same CIDR Block Range Answer: D
Question No:403
If you need a dedicated, connection with consistent network performance to AWS from your on-premises data center, what solution should you choose?
A. AWS Virtual Private Network B. AWS Virtual Private Gateway C. AWS Storage Gateway
D. AWS Direct Connect Answer: D
Explanation: A Virtual Private Gateway attachment is required on the VPC side of a VPN connection from your datacenter or Direct Connect.
AWS Direct Connect is a service that provides a dedicated network connection between your data center and one of AWS's Direct Connect locations. It provides more consistent network performance than connections that use the Internet.
Question No:404
You have been asked to set up architecture that extends the AWS VPC to your company's on- premises data center using private IP addresses. What do you need to set up to accomplish this?
A. VPC Peering
B. Storage Gateway
C. Virtual Private Network D. Internet Gateway Answer: C
 
AWS_SAA-C01 Exam
Explanation: You will need to set up and configure a virtual private network. A VPN is what allows you to extend subnets inside your VPC to your on-premises data center.
Internet Gateway provides an Internet connection for your VPC.
Question No:405
You want to send an email message containing a 5 MB attachment to 1000 subscribers. Which service should you choose?
A. SNS
B. SES
C. API Gateway
D. SWF
Answer: B
Explanation: You can send email messages with attachments using the Simple Email Service. API Gateway is a front door for your backend services
Question No:406
How long will SNS retain an email message before pushing it out?
A. Messages are batched and sent out at 15 minute intervals
B. You can configure the hold time on a topic
C. Messages are pushed out immediately
D. This depends upon the message priority, with higher priority messages going out immediately and low priority messages waiting up to one hour
Answer: C
Explanation: Messages are pushed out immediately, however you can configure delays for retries.
Messages in SNS do not have priorities.
Question No:407
 
AWS_SAA-C01 Exam
You have three sets of worker instances performing different functions. You want them to all receive the same message and process it in parallel. How could you “fan out” the message?
A. There should be an SQS queue for set of workers and each queue should subscribe to the same SNS topic.
B. Use a standard queue and set visibility timeout to > 300 seconds.
C. Use a FIFO queue and target each group of workers for the message. D. Set the queue delivery count to three.
Answer: A
Explanation: You can use SNS to fan out to multiple SQS queues.
Question No:408
Besides CloudFront, what are two ways API Gateway can block DDOS attacks from reaching your backend?
A. Request Throttling
B. Caching API Responses
C. API Gateway will automatically update your NACLs with deny rules to block attackers
D. API Gateway will scaled to any volume of requests, so blocking DDOS attacks is not necessary
E. API Gateway will trigger your Autoscaling Group to scale out in case of a high volume of requests
Answer: A,B
Explanation: You can limit how many requests per second your API gateway can receive By caching the API responses, the backend services will not receive repeated requests. The backend services will potentially get overloaded, or at least increase your bill
Question No:409
Which messaging services can send a message to multiple subscribers simultaneously?
A. API Gateway
 
AWS_SAA-C01 Exam
B. Kinesis Streams C. Amazon MQ
D. SQS
E. SNS
Answer: C,E
Explanation: Amazon MQ can publish a message to multiple subscribers
Question No:410
How does SWF know what task to perform next?
A. Each task returns to SWF the next task that should be preformed
B. Tasks are run in parallel, so SWF does not need to decide on the next task
C. It queries a task list in an S3 bucket
D. Your decider code looks at the workflow history between each task and determines the next task
Answer: D
Question No:411
Which of the following would be suitable to deploy as a Lambda Function?
A. An e-commerce application with multiple features and functions B. An application that resizes an image and saves it in S3
C. A bastion service that allows you to connect to private instances D. A CRM application for a global sales team
Answer: B
Explanation: Option B: This is a very common use for a Lambda function. It can be triggered by an S3 upload, retrieve and process the image, save it back to S3, and then quit.
 
AWS_SAA-C01 Exam
Option D: A CRM is typically a large monolithic application that would have to be broken up into microservices to deploy on Lambda.
Question No:412
In general, what are two reasons that running a microservice on Lambda is likely a better option than an EC2 instance?
A. Microservices on EC2 instances cannot be directly called by API gateway
B. Lambda is cost optimized because you only pay for compute time, not for 24/7 capacity
C. Lambda functions are automatically scanned for viruses by AWS
D. EC2 instances cannot run .Net applications
E. Lambda is fully managed by AWS, so they are responsible for scaling to make sure it gets invoked even when request volumes are high
Answer: B,E
Explanation: EC2 instances have to be turned off when not in use and have to be optimized for instance type and size.
Question No:413
How do microservices on AWS communicate with one another?
A. Microservices on AWS use SNS to make requests to one another
B. SSH over secure VPN connections
C. They use Netflix Eureka for service discovery and message brokering
D. Each microservice has their own custom API which the others call directly or via a message queue or broker
Answer: D
Question No:414
What service(s) could you use to run a microservice on AWS?
 
AWS_SAA-C01 Exam
A. Lambda
B. ECS (containers) C. All of these
D. Elastic Beanstalk Answer: C
Explanation: Elastic Beanstalk can provide a highly available and autoscaling capability for your microservice.
These are all possible choices. You would choose Lambda if your microservice is a simple function that can execute and quit. Otherwise you can leverage the infrastructure management capabilities of Elastic Beanstalk or ECS to keep your service available for requests.
Question No:415
For which of the following would a Lambda function require permissions granted by an IAM role? Choose 2.
A. Running a query on an RDS instance in a private VPC subnet B. Accessing a public webservice on the Internet
C. Saving interim data into a DynamoDB table
D. Making a call to a service via API Gateway
E. Getting an image from an S3 bucket Answer: C,E
Explanation: Lambda would need permissions to write to your table which would have to be granted by a role
Question No:416
Which of the following is not a possible trigger for a Lambda function?
A. None of these
B. Kinesis Streams
 
AWS_SAA-C01 Exam
C. Scheduled Events D. S3
E. DynamoDB Answer: A
Explanation: By enabling DynamoDB streams on a table, Lambda can observe changes in the stream and invoke a Lambda function
These can all trigger Lambda functions
Question No:417
How could you automatically add tags to instances when they are first launched?
A. Create cron job to check instances for tags once per day.
B. Add ab alarm in CloudWatch to count the number of tags on instances C. Create a Lambda function triggered by a CloudWatch Event
D. Use AWS Config to add the tags when new instances launch
Answer: C
Question No:418
Where can you find a log of failed API authorizations?
A. CloudWatch Logs B. CloudTrail Logs C. S3 Access Logs D. VPC Flow Logs Answer: B
Explanation: CloudTrail will show the API request and the status of Failed for each failed request S3 Access logs are only for S3
 
AWS_SAA-C01 Exam
Question No:419
We have a web application that is using Auto Scaling and an ELB. We would like to monitor the application to make sure that it maintains a good quality of service for our customers, defined by the application’s page load time. What metric within CloudWatch can we use for this?
A. The ELB RequestCount
B. Networking for the web tier
C. CPU utilization for our web application tier D. The latency that is reported by the ELB Answer: D
Explanation: CPU utilization may not always correlate with page load times. For example, a memory-intensive application may spillover to disk.
The ELB latency metric is directly related to page load times, so it is a good metric to monitor in this case.
Question No:420
Customers are complaining that your site is not rendering properly. You determine that a CSS file has been moved and is returning a 404 error. What two things could you do to automatically detect this type of issue without waiting on customers to complain?
A. Enable CloudTrail logs integration with CloudWatch to create a custom metric B. Create a rule in AWS Config to detect the movement of the CSS file
C. Create a custom CloudWatch metric to count the number of 404 errors in the Apache log file stream and trigger an alarm
D. Create a custom CloudWatch metric from the VPC Flow log and trigger an alarm
E. Install the CloudWatch Logs Agent on your web server instance(s)
Answer: C,E
Explanation: You can stream your Apache log file for CloudWatch for monitoring the 404errors
Question No:421
 
AWS_SAA-C01 Exam
You are having issues connecting to an EC2 instance and can't figure out why. Which AWS log should you use to investigate to troubleshoot the issue?
A. Cloudtrail Logs
B. CloudWatch Alarm Logs C. IAM access Logs
D. VPC Flow Logs
Answer: D
Question No:422
You are a solutions architect for a software development company. You have noticed that the business is currently running a lot of small admin scripts written in python on a C3 instance type which is running 24/7/365 using on-demand billing. The scripts run once per hour, complete is around 45 seconds each, and utilise around 88MB while running. You have been asked to design a way to optimise the costs of this platform. It's worth noting that the business is about to launch a new product which would mean 100's or 1000's of these C3 instances. It's essential that these scripts run when scheduled.
A. Migrate all the scripts to run on spot instances to reduce costs.
B. Ask the developers to migrate the scripts to AWS Lambda functions. Use timed events to schedule the invocation of these functions.
C. Combine all scripts for all clients onto a single EC2 instance and purchase a reservation for this instance.
D. Purchase instance reservations to reduce the costs of the existing instance, make a forecast for how many instances you will need and purchase reservations in advance for future instances
Answer: B
Explanation: Lambda is a perfect solution. The scripts are already written in a supported runtime (python), you have in-house developers. The runtime is short and the memory utilisation is low. Lambda is ultra scalable and so fits the need perfectly.
EC2 is not the right solution in this case, the scripts have short runtimes and low memory needs. Additionally purchasing instance reservations by guessing future capacity is a bad idea.
 
AWS_SAA-C01 Exam
Question No:423
You have designed a small VPC deployment for a highly available web application. The VPC is in a 3 AZ region and you have created 9 subnets, 3 private one per AZ, 3 public 1 per AZ, and 3 database subnets - 1 per AZ. You have provisioned the 3 web servers in the public subnets, 3 application servers in the private subnets and 3 node Aurora cluster. How many load balancers do you need to create and in what subnets should they be placed to ensure each tier is highly available. (choose one)
A. 9 - one placed in each subnet in each tier
B. 3 - 1 placed in each tier
C. 2 - 1 placed in the public subnets, the other in the private. D. 2 - 1 placed in the private subnet, 1 placed in the DB subnet Answer: C
Explanation: Option C: This will achieve the aim of high availability, the public classic load balancer will load balance across the web servers, the one placed in the private tier will do the same for the app servers. The database doesn't need an elb, it is HA via its cluster DNS name. Option D: The Web servers should have a public facing classic load balancer in the public tier, and the app servers need 1 in the private tier. Aurora doesn't need a load balancer, the cluster HA is built in.
Question No:424
You are running an application on an EC2 instance that is extremely sensitive to variations on network performance - specifically the variation in PING times/latency (jitter). The application also heavily uses CPU and you need to implement a solution that removes any risk of network performance degradation. What option works in this scenario.
A. Ensure the instance is EBS optmised
B. Ensure you are using an X1 instance
C. Ensure the VPC is running in dedicated tenancy mode
D. Ensure the instance has enhanced networking
Answer: D
Explanation: Dedicated tenancy won't change network performance as required in this scenario
 
AWS_SAA-C01 Exam
Enhanced networking (https://aws.amazon.com/premiumsupport/knowledge-center/enable-configure-enhanced-ne tworking/) allows high performance networking by bypassing the need for CPU involvement in virtualising a network interface. This increases Packets per second and decreases the variability in network performance.
Question No:425
A client has asked you to advise them on some AWS cost related questions. The client has over 1000 EC2 instances that are preconfigured and used during peak periods of the year for their application. The client has decided to perform an upgrade of their application before the next peak period and so has terminated all 1000 EC2 instances. They report still being charged a fee on an ongoing basis. Which option below is a possible reason.
A. The machines are in an autoscaling group, which has a base charge, even if it contains no running instances
B. The instances have been un-terminated and started up without your knowledge, potentially by an IT support engineer for backup verification reasons.
C. When terminating an EC2 instance - you can either terminate attached volumes, or not. EBS is a potential cause of the charges via non deleted volumes.
D. Terminations take 30 days to process - billing continues for 30 days post termination. Answer: C
Explanation: Instances cannot be 'unterminated'
make sure that all attached EBS volumes are removed if required when terminating instances.
Question No:426
You business has two EC2 instance, one is located in us-east, the other is us-west. You need to allow both machines to communicate for an application integration project you are consulting for. What solution would you recommend.
A. Communication between VPC's in different regions is not possible with AWS.
B. Configure a Hardware VPC VPN between the VPC in us-east-1 and the VPC in us-west-1. Configure the application to communicate using the private IP addresses of the instances.
C. Configure an inter-region VPC peer between the VPC's and allow communications using the private IP addresses of the instances.
 
AWS_SAA-C01 Exam
D. Ensure that each VPC has a IGW attached and each machine has a public IP address. Configure communications between those public IP addresses.
Answer: C
Explanation: Option C: This is the recommended solution in this case.
Option D: This is possible, but not recommended unless it's the only option as it exposes the machines publicly.
Question No:427
Why does stopping and starting an instance (usually) fix a System Status Check error?
A. None of the these
B. Stopping and starting an instance reboots the operating system.
C. Stopping and starting an instance causes the instance to be provisioned on different AWS hardware.
D. Stopping and starting an instance causes the instance to change the AMI. Answer: C
Explanation: Unless you have dedicated tenancy enabled, stopping and starting an instance will generally cause it to be launched onto different AWS host hardware.
Stopping and starting an instance does not have any impact on the AMI being used.
Question No:428
Your company has been thinking about moving its networking resources over to AWS. Your boss is particularly interested in the AWS shared responsibility model, as it will allow him to offload some traditional responsibilities to AWS. He says that he is happy that AWS will now handle the following responsibilities listed below. However, you know that he is wrong and that AWS does not handle all of them as part of the shared responsibility model. Which of the following four (4) items do you need to tell him are not handled by AWS? (Choose 2)
A. Datacenter Access
B. Security groups
C. Storage Device Decommissioning
 
AWS_SAA-C01 Exam
D. Change Management of Host Servers E. Applying an SSL Certificate to an ELB Answer: B,E
Explanation: In the shared responsibility model, AWS is NOT responsible for managing security groups, applying an SSL certificate to an ELB, and the installation of custom firewall software. Emergency, non-routine, and other configuration changes to existing AWS infrastructure are authorized, logged, tested, approved, and documented in accordance with industry norms for similar systems.
In the shared responsibility model, AWS is NOT responsible for managing security groups, applying an SSL certificate to an ELB, and the installation of custom firewall software.
Question No:429
Which EC2 features can help mask the failure of an instance? (Choose 2 )
A. AWS CloudFail
B. AWS Glue
C. NAT Gateway
D. EC2 Autorecovery
E. Elastic IP
Answer: D,E
Explanation: An Elastic IP can be remapped from a failed instance to a replacement instance. Thereby not requiring any application or DNS changes.
Question No:430
You have two large EC2 instances running in the same VPC and are concerned that you are not achieving the maximum network throughput between the instances as the instance is capable of. What two factors could explain the lower then expected performance.
A. The instances are not capable or enabled for enhanced networking
B. There is a network interface throttle value set on one or both of the instances
 
AWS_SAA-C01 Exam
C. The instances are not within a placement group
D. Instances can only achieve max performance when running in dedicated tenancy mode Answer: A,C
Explanation: Enhanced networking is required to remove the CPU as a bottleneck when high throughput networking is required
High throughput generally requires instances to be placed in the same placement group to ensure physical closeness.
Question No:431
You have millions of objects in an S3 bucket. Which of the following storage classes is the cheapest SUITABLE class to use when you are storing original data .. i,e. cant be remade. realtime access to the data is required sometimes.
A. Amazon S3 Standard
B. Amazon Glacier
C. Amazon S3 Standard-Infrequent Access D. Amazon S3 One Zone-Infrequent Access Answer: C
Question No:432
You have implemented an application used by millions of people worldwide. As people use the application they interact with S3 - adding, deleting and modifying objects on S3. Objects on S3 have the following format YYYYMMDD-ObjectID.dat - your users are experiencing performance issues at scale. What would you suggest to resolve the issue. (Choose one)
A. Add random data at the start of the object name.
B. Purchase reserved capacity for S3
C. Add random data at the end of the object name.
D. Increase the read and write allocation on the S3 bucket. Answer: A
 
AWS_SAA-C01 Exam
Explanation: Object partition in S3 is selected based on the object name left to right ... adding random data at the start of the name will improve performance by increasing the spread of partitions on which objects are stored.
Reserved capacity for S3 isn't a thing.
Question No:433
You are designing infrastructure for an application which handles HUGE data volumes, multiple petabytes per month of data transfer. It's utilised by customers globally and you have been asked to develop a solution to provide the lowest costs and best user experience. The data consists of static large video clips. You already have datacenter infrastructure and the business is keep to re-use that if possible Which option would you suggest to meet the requirements.
A. Migrate the media to AWS S3 and Configure CloudFront to use that server as an origin.
B. Migrate the media to an EC2 instance, store the media on an attached PIOPS EBS volume and configure CloudFront to use that server as an origin.
C. Use internal servers within your datacenter and serve the content from a single location
D. Store the media on an on-premises web server and configure CloudFront to use that server as an origin.
Answer: A
Explanation: S3 is a very economical storage system and benefits from free transfer from IT, to CloudFront (known as origin fetch). This is the best option for cost and for user experience - even accounting for NOT using existing infrastructure. Note given the data volume - transfer costs are likely to be MUCH more important.
Given the volume or data transfer it's safe to assume the volume of data will be large. PIOPS is a very un-economical place to store data which doesn't need that level of performance.
Question No:434
What happens if you reboot an instance-store backed EC2 instance with a Public IP?
A. The instance remains in the running state
B. The Public IP changes and the instance store volume is wiped C. The instance store volume is wiped
D. The Public IP changes
 
AWS_SAA-C01 Exam
Answer: A
Explanation: Rebooting only restarts the operating system. It does not stop the instance. The instance store volume is not affected by a reboot.
Question No:435
You have been asked to advise a junior colleague how to explicitly DENY traffic from an EC2 instance to a specific remote internet FQDN - what advice would you give.
A. Use a security group attached to the instance and explicitly DENY traffic to the FQDN B. Use a security group attached to the VPC and explicitly DENY traffic to the FQDN
C. Implement a proxy service in the VPC, adjust route tables and use the proxy server to DENY access to the remote hostname.
D. Use a NACL on the subnet the EC2 instance is on - DENY traffic from the EC2 instance to the FQDN.
Answer: C
Question No:436
You've been tasked with building out a duplicate environment in another region for disaster recovery purposes. Part of your environment relies on EC2 instances with preconfigured software. What step(s) would you take to configure the instances in another region?
A. Make the EC2 instance shareable among other regions through IAM permissions B. Share the EBS volume across regions
C. Create a custom AMI of the EC2 instance and copy the AMI to the desired region D. Create an custom AMI of the EC2 instance
Answer: C
Explanation: Creating an AMI of the EC2 instance allows you to create an image with the required preconfigured software in place. You can then copy the AMI to the desired region to use to begin deploying instances that contain the required software within the duplicated environment.
You also need to copy the AMI to the second region, because AMIs are only stored in a single
 
AWS_SAA-C01 Exam
region.
Question No:437
You have recently worked with a development team to implement a resilient web application running on 4 EC2 instances behind a load balancer. Performance is great, and limited failover testing has occurred with good feedback. A number of days ago a real failover event happened where the host an EC2 instance was running on fails. Customers connected via the load balancer to alternative instances - but they have to log in to the system again. What suggestions can you make to resolve this inconvenience.
A. Use the 'sticky sessions' feature of the load balancer
B. Ask the customers of the website to click the 'save password' button in their web browser.
C. Use application generated cookies
D. Ask the developers to migrate the 'session state' component of the application off the individual EC2 instances to DynamoDB
Answer: D
Question No:438
What steps are required to allow an EC2 instance to access the internet while being as secure as possible. Assume all security rules/ACL's and subnets are in place already.
A. Attach an internet gateway to the VPC
B. Add a NAT gateway
C. Provide the instance with a Public or Elastic IP address
D. Create a default route from the EC2 instance's subnet to the Nat Gateway
E. Create a default route from the EC2 instance's subnet to the internet gateway F. Create a default route from the NAT gateways subnet to the Internet Gateway Answer: A,B,D,F
Explanation: Option A: This is required either to provide incoming and outgoing access to the instance, or to provide only outgoing via a NAT gateway
 
AWS_SAA-C01 Exam
Option B: This is required to allow a private instance to have internet access
Option C: This is only needed for incoming access - which isn't a requirement.
Option D: This directs traffic from the EC2 instance to the NAT gateway to be translated Option F: required to allow the NAT gateway to have internet access
Question No:439
You are designing an application with 3 components. An app server, running on EC2, a media store running on S3, and a database running on DynamoDB. You have been asked to make sure your design allows a single AZ to fail without impacting service. Which option is correct.
A. Leave EC2 setup using defaults, enable AZ replication on S3 and setup master/slave replication on DynamoDB
B. S3 and DynamoDB are resilient to an AZ failure by design. Provision EC2 using a Launch Configuration and Auto scaling group to ensure it can cope with an AZ failure and auto-heal if needed.
C. Edit the configuration of the EC2 instance, enable the AZ roaming option and pick all the availability zones.
D. No specific changes are required. EC2, S3 and DynamoDB are all region resilient and will operate fine if an AZ fails.
Answer: B
Explanation: EC2 is the only component which needs to have resilience added - LC and ASG are the products which achieve this.
S3 and DynamoDB can cope with failure of a region, but EC2 runs in a single subnet in a single AZ so will fail if an AZ fails.
Question No:440
You are designing the implementation of a new application deployment. The application is capable of using a number of different DB engines - including MySQL, PostgreSQL and Microsoft SQL Server. You have been informed that the resilience of the application is critical - it needs to operate in three availability zones, and have the ability to cope with the failure of two and still operate effectively. Which DB platform should you select.
A. Using the MySQL engine, ensure that Multi-AZ is enabled and that at least three AZ's are selected within the HA configuration.
B. Pick MySQL running on an EC2 instance that is enabled from cross-az roaming.
 
AWS_SAA-C01 Exam
C. Select Aurora as the DB platform
D. Pick RDS using the MySQL engine, selecting to use Multi-AZ Answer: C
Question No:441
You have an EC2 instance located in a private subnet. The instance is using an private IP Version 4 address in the 10.0.0.0/24 range and has no public IP or elastic IP attached. How can you provide this instance with access to the internet for updates.
A. Attach an internet gateway to the VPC and update routes
B. Attach an internet gateway to the VPC, and provision a NAT gateway, then update routes. C. Use privatelink to access AWS provided update servers
D. Provision a NAT gateway into the VPC
Answer: B
Explanation: By adding an internet gateway the NAT gateway can itself access the internet and provide this to private instances after routes have been added or updated.
A NAT gateway will help, but it needs an internet gateway to function.
Question No:442
Which of the following AWS storage services are able to be natively 'mounted' as mount points on a linux system.
A. Instance Store, EBS, S3, Glacier and EFS B. Instance Store, EBS and EFS
C. Glacier, Instance Store and EBS
D. EBS and Instance Store only
Answer: B
Explanation: Instance Store, EBS and EFS are all capable of being mounted to EC2 instances. Using EFS (NFS) is not currently supported on windows instance.
 
AWS_SAA-C01 Exam
EFS can also be mounted
Question No:443
To maintain compliance with HIPPA laws, all data being backed up or stored on Amazon S3 needs to be encrypted at rest. What two things should you do for storing the healthcare-related (PHI) data in a compliant manner?
A. Enable SSE on an S3 bucket to make use of AES-256 encryption
B. Store the data in encrypted EBS snapshots
C. S3 is not a HIPAA Eligible Service
D. Store the data on EBS volumes with encryption enabled instead of using Amazon S3
E. Set the bucket policy to Deny puts of objects without the server side encryption attribute Answer: A,E
Explanation: PHI data must be encrypted at rest. S3 Server Side Encryption provides that capability.
S3 is on the list of HIPAA Eligible services, however, you must PHI information stored in it is encrypted at rest.
A bucket policy can prevent accidentally storing the data without encryption
Question No:444
An application that retrieves data from an external web site is running on a single m5 large instance with a private IP. During peek loads, users report very long delays and timeouts. CloudWatch reports the CPU never climbs about 60%. What could be causing the issue?
A. The ELB may need to be resized.
B. The ENI for the instance could be at maximum capacity. You need multiple ENIs to get the maximum network performance for an instance.
C. A larger instance is needed to increase the CPU capacity.
D. The instance could be sending outbound requests through a NAT instance which may be undersized.
Answer: D
 
AWS_SAA-C01 Exam
Explanation: Multiple ENIs do not add network capacity to an instance.
If the NAT is running on an EC2 with low network performance, it could be a bottleneck.
Question No:445
You are the solutions architect for a busy photo management website. You business receives about 200 high resolution photo uploads per minute and you store these in an S3 bucket. The business wants to do some analysis on all uploaded photos and store the metadata into DynamoDB. They have asked you to suggest the cheapest option which is able to scale as the business grows.
A. Use data pipeline to constantly scan S3 and run an EMR cluster to perform the analysis.
B. Create a lambda function which is capable of processing metadata, configure it to be invoked in an event driven way every time a new object is uploaded to S3, the data from processing will be uploaded into DynamoDB
C. Create an EC2 instance running the AWS CLI. Have it constantly poll the S3 Bucket listing the objects in the S3 bucket, locating new images and processing them all before terminating.
D. Create a lambda function which is capable of processing metadata. Have it scheduled to run once a minute, listing the objects in the S3 bucket, locating new images and processing them all before terminating.
Answer: B
Explanation: Option B: This is an ideal solution. No over head of polling S3 and since its event driven it runs when an object is uploaded, it doesn't need to track new v's old objects. Because it's built on lambda - it's scalable. It's serverless meaning 0 maintenance.
Option D: This is a inefficient method - listing objects is intensive, identifying new objects more so - there is no guarantee it will be able to finish processing before it terminates.
Question No:446
You are designing a VPC for a small application which will operate in a private subnet and needs internet access to software updates and other communications with internet IP's. Your security team is happy for there to be no restrictions in the application servers internet access. Which AWS products are needed to allow this solution - the priority being the least amount of services. Assume the EC2 instance and any NACL's, routes and Security groups are included implicitly.
A. VPC, Subnets, Route Tables, VPC Peering & Virtual Private Gateway B. VPC, Subnets, Route Table(s), Nat Gateway, Internet Gateway
 
AWS_SAA-C01 Exam
C. VPC, Subnets, Route Table(s), Internet Gateway D. VPC, Subnets, Route Table(s), Nat Gateway Answer: B
Explanation: Option B: this is the minimum requirement to provide internet access to a private EC2 instance.
Option C: the scenario explains the EC2 instance is in a private subnet, an internet gateway along isn't enough to provide internet access.
Question No:447
Your company has moved a legacy application from an on-premises data center to the cloud. The legacy application requires a static IP address hard-coded into the backend. What options do you have to maximize the availability of this application? (choose 2)
A. Create an AMI of the instance and launch it using Auto Scaling, which will deploy the instance again if it becomes unhealthy
B. Do not migrate the application to the cloud until it can be converted to work with the ELB and Auto Scaling
C. Associate an Elastic IP with a Network Load Balancer and target multiple instances in the AZ running the application.
D. Associate an Elastic IP address to an instance running the application. Enable EC2 Auto- recovery.
E. Associate an Elastic IP with a CloudFront distribution that uses an EC2 instance running your application as the origin for all requests
Answer: C,D
Explanation: An Elastic IP is a static public IP associated with your account. EC2 Auto-recovery will relaunch a failed instance and preserve the IP addresses.
Question No:448
Your development team run a web application which provides dynamic content using query strings. They have requested a solution to provide better performance globally for the application, at the lowest running and maintenance costs. What should you suggest.
 
AWS_SAA-C01 Exam
A. Run the application from S3 using its web hosting feature
B. Provision multiple EC2 instances in all regions where the application is used
C. Configure CloudFront to cache dynamic content with query strings. Run the EC2 instance the most appropriate region to be accessed by the dev team.
D. Use S3 acceleration and static hosting for the application Answer: C
Question No:449
Which of the following suggestions could help reduce DynamoDB running costs
A. Use SCAN rather than query operations B. Utilise indexes
C. Limit the attributes read from a table D. Increase RCU
Answer: B
Explanation: Indexes are sparse and only contain items from a table which applies to those indexes. Additionally you can chose to populate (project) only certain attributes into indexes. They can be a useful tool to limit the size and thus cost of reads.
Regardless what what attributes are read - the read costs the full item
Question No:450
One of your environments utilises a DynamoDB as a database. You need to ensure that it can only be accessed from a select number of people using specific IP addresses. What design changes do you suggest?
A. Configure IAM users for each of the people who need access. Give those people access to the DynamoDB operations they need, but add a 'condition' to the policy so that it has to match the specific IP address registered for each user.
B. Using the AWS console or CLI, edit the table(s) requiring the restrictions, set the default security to Deny and add the IP's who require access.
 
AWS_SAA-C01 Exam
C. Create a security group, add allow rules for the IP's who need access and attach the SG to DynamoDB
D. Create a isolated VPC not connected to the internet, provision a private DynamoDB instance in the VPC and allow those who need access to connect to the VPC using a VPN.
Answer: A
Explanation: Option A: This is the best solution. By default nobody has access to the DynamoDB tables, unless granted. Grants can be allowed via IAM users, who have policies with conditions matching specific IP addresses.
Option D: DynamoDB is a service which utilises public endpoints, it cannot be created as a 'private' instance in the VPC.
Question No:451
A solution you are working on within AWS requires the use of a hadoop cluster for big data analysis. What AWS service is an appropriate selection.
A. Athena
B. EMR
C. Redshift
D. Elasticache Answer: B
Explanation: EMR or elastic map reduce is a AWS managed implementation of Hadoop Elasticache is an AWS managed implementation of the Redis or Memcached caching products, no a hadoop cluster
Question No:452
You are consulting for a company with a limited budget for on-premises hardware. Their tape- based backup system has reached end-of-life and needs an immediate upgrade. What AWS solution could replace their tape system with minimal or no configuration changes?
A. S3 Buckets with Encryption and Versioning Enabled B. S3 Buckets configured as Tape Libraries
 
AWS_SAA-C01 Exam
C. Glacier
D. Storage Gateway in Tape Gateway configuration Answer: D
Question No:453
You information security officer has for modifications to an application running on an EC2 instance to ensure that it uses regular key rotation for its interaction with AWS. What should you tell her?
A. The application is running on an EC2 instance and uses an instance role - key rotation is automatic and handled by IAM/STS.
B. The application is running on an EC2 instance and uses the access keys of an IAM user. Key rotation is automatic with this configuration.
C. The application is running on an EC2 instance and uses the IAM username and passwordof a service account to login to AWS. The account options can be modified to enable key rotation.
D. The application is running on an EC2 instance and uses the access keys of an IAM user. The account options can be modified to enable key rotation.
Answer: A
Explanation: key rotation is handled automatically if you are using an instance role
It's not possible for an application to login using IAM an username and password - this is for console access only. There are no options to enable key rotation automatically
Question No:454
Which of the following EC2 metrics will NOT be automatically collected by CloudWatch?
A. Instance Store IOPS
B. T2 Credit Balance
C. CPU Utilization
D. Number of running processes on the instance E. Average Memory Utilization
 
AWS_SAA-C01 Exam
Answer: D,E
Question No:455
Which of the following services/service features is 'natively' highly available in a region and can cope with a AZ failure without itself failing.
A. EC2
B. VPC Subnet C. DynamoDB D. S3
Answer: C,D
Explanation: S3 operates across AZ's a region - unless you explicitly store objects in a one-zone storage class. Even so, the service will be fully functional even if you lose some objects stored in that class.
Question No:456
You have been asked to design some scaling upgrades on a legacy web application which utilises a MySQL RDS instance. The application is suffering from increasing reports of performance issues during peak periods. The application is used for archival information storage; data is reviewed constantly and very rarely updated. Which option provides the best possibility of performance improvements for the least cost.
A. Enable Multi-AZ - this adds a second read/wrote instance and has the benefit of adding resiliency for no extra cost.
B. Add additional read/write nodes to the MySQL cluster, picking disks with read performance preference.
C. Add RDS read replicas, and adjust the application to move a percentage of reads to the read-replica
D. Upgrade the application server instance and the DB instance - picking a side 4 or 8x the size to allow for ongoing growth.
Answer: C
 
AWS_SAA-C01 Exam
Explanation: Option C: for applications where reads happen more frequently than writes, read- replicas allow performance scaling without significant expense.
Option D: this adds significant expense, better options exist
Question No:457
You've been asked to upgrade an old AWS environment which is suffering from slow internet throughout. Which option below represents a potential solution (choose one)
A. Change the Nat instance from a T2 large instance to a T2 medium instance B. Add a virtual private gateway to the VPC
C. Replace the NAT instance in the VPC with a Nat Gateway
D. Enable enhanced networking on the Nat instance
E. Add another internet gateway to the VPC for a total of two - providing 2x internet throughput. Answer: C
Explanation: Nat gateways auto scale based on demand - replacing a NAT instance which would have a fixed bandwidth with a NAT gateway offers a potential solution.
Enhanced networking is not available on the T series
Question No:458
Your business stores high resolution media imaging in one of its S3 buckets accessible internally to it's applications. The number of objects increase daily, and approximately 100,000 objects are added daily. After discussing the situation with your medical consultants you have learned a few things. Firstly, images are used extensively for 7 days, after that there maybe be some images accessed extensively for up to 60 days after arrival. Beyond that point, images are rarely accessed, only for scheduled consultations. How could you best design a solution to these mounting costs - at the lowest cost.
A. Transition images from Standard to Standard_IA after 30 days. After a further 30 transition from Standard_IA to Glacier. Glacier objects are accessed from the S3 console.
B. Implement an S3 lifecycle policy to move images between storage classes, Standard, Standard_IA and glacier. Train staff to access images via the glacier console once archived.
C. Transition Images from S3 Standard to Glacier after 7 days.
 
AWS_SAA-C01 Exam
D. Hire a small team of admin staff to move images to archival storage when they are no longer used.
Answer: A
Explanation: Option A: this solution design will provide the best value to the business while matching the requirements. Objects transitioned to glacier from S3 classes are accessed viathe S3 console.
Option B: S3 STANDARD objects moved to glacier are accessed via the S3 console.
Question No:459
Your internal development team want to create an API and have it accessible over the internet. They have no infrastructure skills and so want the option with the least infrastructure requirements and maintenance needs. Which set of AWS products meets this requirement.
A. API Gateway + Lambda
B. API Gateway + EC2
C. Opsworks, CloudFormation & API Gateway D. Elastic Beanstalk + API Gateway
Answer: A
Explanation: API Gateway and Lambda offer a serverless way to host API's - it scales, it's low cost and requires no infrastructure skills
Opsworks and CloudFormation are infrastructure services which the development team have no skills in.
Question No:460
You have an application which needs to perform 100 reads per second from DynamoDB. Each read is 7KB is size. What is the minimum number of RCU required to meet this demand.
A. 200 B. 350 C. 700 D. 100
 
AWS_SAA-C01 Exam
Answer: D
Explanation: Writes are 1KB , reads are 4KB
Assuming eventual consistent reads are value, then 100 is enough ... each read is 2 RCU (7KB rounded to 8KB). But eventually consistent reads are half the cost.
Question No:461
You are asked to perform a security audit on a company’s AWS environment. You log in to their AWS account with the root user credentials and discover that they are using a VPN to connect to and manage their private EC2 instances. Upon further inspection, you find that they are not regularly patching their RDS instances. Finally, you notice that they are using IAM policies rather than bucket policies to manage access to their S3 buckets. What do you cite as themost critical security risk in your report?
A. The company is not using bucket policies to manage S3 bucket access
B. The company has not been patching their RDS instances
C. The company allows people to log in with their AWS account’s root user
D. The company’s employees are not using a bastion host to connect to their private EC2 instances
Answer: C
Question No:462
You are the system administrator for your company's AWS account of approximately 200 IAM users. A new company policy has just been introduced that will change the access of 50 of the IAM users to have unlimited access to S3 buckets. How can you implement this effectively so that there is no need to apply the policy at the individual user level?
A. Create an S3 bucket policy with unlimited access which includes each user's AWS account ID B. Create an IAM group, add the 50 users, and apply the policy to group
C. Create a new role and add each user to the IAM role
D. Create a policy and apply it to multiple users using a JSON script
Answer: B
 
AWS_SAA-C01 Exam
Explanation: IAM Groups are the easiest way to maintain permissions that apply to multiple users.
The question says not to apply the policy to individual users.
Question No:463
You have a requirement to design a security architecture in AWS capable of allowing IP traffic using stateful intelligence from an EC2 instance. That is, for outgoing traffic which is allowed, then also allow the incoming return communicates. Which AWS product allows stateful security control ...
A. AWS Shield
B. NACL
C. Security Groups D. AWS WAF Answer: C
Question No:464
Which of the following services allow the administrator access to the underlying operating system? (pick 2)
A. Amazon EC2 B. DynamoDB C. ElastiCache D. Amazon EMR E. Amazon RDS Answer: A,D
Explanation: You can SSH/RDP to the operating system of your EC2 instances. EMR allows you to SSH into the Master Node
RDS provides APIs for RDS operations, and SQL access for the data.
 
AWS_SAA-C01 Exam
Question No:465
You are a consultant and have been asked to perform an audit of the AWS environment for a medical company concerned about security compliance. The company administrator provides you with the root login to the AWS account. After beginning the audit, you discover that the Nurses that work for the company are all using a shared single login account called nurse_user1 to upload and download daily shift change reports from S3. After further investigation, you discover that the nurse_user1 account has full administrator privileges to EC2 and S3. When you document your findings, what security issues would you note in the report and what suggestion would you make to resolve the problem? Choose 2.
A. There are three security issues: 1. You were given access to the root account. 2. The nurses are sharing an account and 3. The nurses have full administrator privileges to EC2 and S3.
B. To resolve the security issues you would recommend the following: 1. Create individual accounts for the nurses and put all of the nurse accounts into a group. 2. Grant read/write permissions for the newly created group to the appropriate S3 bucket.
C. To resolve the security issues you would recommend the following: 1. Create individual accounts for the nurses and put all of the nurse accounts into a group. 2. Grant read/write permissions for the newly created group to the appropriate S3 bucket. 3. Recommend as a best practice that temporary accounts be created for consultants.
D. There are two security issues: 1. The nurses are sharing an account. 2. The nurses have full administrator privileges to EC2 and S3.
E. There is only one security issue: The nurses should not have full privileges to all EC2 instances and S3.
Answer: A,C
Explanation: AWS recommends granting access based on the principle of least privilege so there are three security issues. 1. As a consultant, you were given access to the root account. 2. The nurses have full access to all EC2 and S3 services. 3. The nurses are sharing one IAM account.
Question No:466
You just created a VPC. For security purposes you are using NACLs and Security Groups. You launched an EC2 into a subnet where you have set an Inbound Rule for SSH (22) in the SG and both inbound and outbound rules for Port 22 on the subnet NACL. However, you are not able to SSH to the instance. What is the most likely issue?
A. The NACL needs an outbound rule for the high ephemeral port range (1024-65535)
 
AWS_SAA-C01 Exam
B. An outbound rule allowing SSH for the Security Group needs to be added. C. You have not enabled IPv6 for the VPC.
D. Your IAM User does not have SSH permissions.
Answer: A
Question No:467
You have been asked how to provide another organisation with access to an S3 bucket in your companies account. The bucket is owned by your company and all files within it must be owned by your company. The bucket will be accessed by about 10,000 users of the otherorganisation. What solution matches these requirements.
A. Provision each member of the remote organisation with an IAM user account, and set a policy allowing them to manage their own account.
B. Use an S3 bucket policy to provide full access to the account ID of the remote organisation
C. Provision a single group for the remote organisation. Generate access keys for the group, and provide this to a member of the remote organisation.
D. Create an IAM role within your AWS account with access rights to the bucket. Using a TRUST policy, trust the account number of the remote organisations AWS account.
Answer: D
Explanation: Option A: There are account limits for the number of IAM users - this places a huge admin overhead on your company to manage all accounts for the remote organisation - delegation via a ROLE would be much better.
Option D: This solution is the easiest to manage, staff of the remote organisation can assume the role, and any objects uploaded will be owned by your account.
Question No:468
You have been asked to design a upgrade to a legacy environment running in an AWS VPC. The environment is currently using a single NAT instance running on EC2. The region the environment is in has 4 AZ's and the VPC has 8 subnets, 4 private (one in each AZ) and 4 public (one in each AZ). You have been asked to ensure the solution uses NAT gateways and that if any AZ fails, instance in the other AZ's can ALWAYS access the internet. What is the minimum number of NAT Gateways required.
 
AWS_SAA-C01 Exam
A. 2 - each located in a single public subnet, but not the same one, private subnets set to round robin across them both.
B. 4 - each located in a single , but different public subnet. Each private subnet set to use the NAT gateway in the same AZ.
C. 2 - each spanning 2 different public subnets, private subnets set to round robin across them both.
D. 1 - spanning all 4 public subnets. All private subnets use the single NAT gateway Answer: B
Question No:469
As an AWS consultant, you have been tasked with finding ways to quickly lower a client's AWS monthly bill. What is the first thing you should ask them for? (Choose the best answer)
A. Ask them to create an IAM User in their account and send you the password. B. Ask them to enable S3 access logs so you can find out about S3 storage usage. C. Ask them to run a complete inventory breakdown in AWS Config.
D. Ask them to run a Trusted Advisor report and send you the results.
Answer: D
Explanation: Option C: A complete inventory would be helpful at some point, but would require a lot of research to determine what every resource is for.
Option D: This is easy for the customer to run and it will immediately recommend approaches for cost optimization including instance reservation, and unused, idle, and underutilized resources.
Question No:470
You have been asked to provide a recommendation on the most resilient database solution available within AWS. The business requirements are that the data is structured. They require multiple availability zones and VERY low latency between mirrors. Right now, 2 AZ resilience is required, but whatever solution is selected needs to be able to cope with 3 or more. Which product would you recommend ?
A. Aurora
 
AWS_SAA-C01 Exam
B. RDS
C. Athena
D. DynamoDB Answer: A
Explanation: Aurora supports more than 2 AZ replicas and use a shared storage platform - it's the most suitable candidate
Athena is used to query data stored on S3 .. it's not suitable for structured data, and for a resilient scenario like this.
Question No:471
A client has asked you to advise them on some AWS cost related questions. The client has over 1000 EC2 instances that are preconfigured and used during peak periods of the year for their application. They are currently in a STOPPED state, but they still have cost incurred in that region. What's a possible reason for this?
A. Every EC2 instance performs automatic snapshots as a backup mechanism, The costs are for snapshots on S3
B. The cost is for the VPC that the instances operate in.
C. The instances have attached EBS volumes which have a monthly /G charge while those volumes exist.
D. EC2 instances in a stopped state still have an hourly cost, terminated the instances to resolve this
Answer: C
Question No:472
Your CIO has approached you with a problem to solve. You currently run a technical teaching business and provide online learning to students. The service is hosted on-premise and youare unable to expand capacity. A full migration into AWS is not an option - the business needs time to adjust to the idea and you have no infrastructure configured inside your recently created AWS account. The business needs to resolve the performance issues on the media delivery server, at the lowest cost point and ideally improve performance to international students. What should you suggest?
 
AWS_SAA-C01 Exam
A. There is no solution to this problem if the business doesn't want to do a full migration. CloudFront can only cache from AWS endpoints.
B. Leave the media on-premises, order an AWS Direct Connect and utilise CloudFront to Cache Content from an EC2 instance acting as a proxy server.
C. Ensure the media server in your on premises network has a public IP address. Provision CloudFront and configure it to globally cache content.
D. Migrate the media to an EC2 instance and use Amazon S3 as a content delivery network (CDN)
Answer: C
Explanation: CloudFront can use non AWS origins.
CloudFront can be configured with a custom origin that can be a non AWS server. It requires no other AWS services. This option is the quickest and lowest cost option for the business.
Question No:473
Ten students have just been employed by your company for one week, and it is your task to provide them with access to AWS through IAM. Your supervisor has come to you and said that he wants to be able to track these students as a group, rather than individually. Because of this, he has requested for them to all have the same login ID but completely different passwords. Which of the following is the best way to achieve this?
A. Use Multi Factor Authentication to verify each user and they will all be able to use the same login
B. It isn't possible to have the same login ID for multiple IAM users of the same account
C. Create various groups and add each user with the same login ID to different groups. The user can login with their own group ID
D. Create a separate login ID, but give each IAM user the same alias so that each one can login with their alias
Answer: B
Question No:474
Your business has a image processing application. It runs on a single EC2 instance - a x1.16xl. The instance is extremely expensive and operations staff have noticed that it fluctuates between
 
AWS_SAA-C01 Exam
100% cpu and memory usage and around 20-30% during non busy periods. The application consists of two components, an application allowing uploading, and one which processes the images. You have been asked to rearchitect the application, to reduce costs and help optimise performance. What AWS products would you select (choose all that apply)
A. Cloudwatch
B. EMR
C. Auto Scaling Group D. SQS
E. Launch Configuration F. Elastic Transcoder
G. CloudTrail
Answer: A,C,D,E
Explanation: used to monitor load on all instances on the platform and the SQS queue
Used to increase or decrease instance count based on load identified by cloudwatch - this can be CPU usage, memory usage or items on the SQS queue.
SQS is used to decouple the parts of the application. The uploaded adds items to the queue which need processing. The consumer is the processing component of the application. This allows the two parts to be split from each other - so they can scale better.
Question No:475
You are in the middle of a design for a database processing application which runs on a fleet of EC2 instances. You need to make a choice on the most suitable EBS disk type to utilise. The business is concerned first about meeting its performance requirements and second about being as cost effective as possible.
The business needs storage which can provide 20,000 IOPS on a single volume. Which storage type should be used.
A. io1 B. gp2 C. sc1
 
AWS_SAA-C01 Exam
D. st1 Answer: A
Explanation: io1 (provisioned IOPS SSD) is the only volume type which can provide the 20,000 IOPS needed. While its expensive, because of the demands its the only single volume option. HDD's are incapable of delivering the IOPS required in the scenario.
Question No:476
Your autoscaling group launches instances that use provisioned IOPS EBS secondary data volumes in a RAID 0 configuration for serving 20TB of files. Whenever new instances are added to the group they perform very slowly compared to the already running instances. What is the most likely problem?
A. The EBS volumes have run out of credits B. The EBS volumes are being encrypted
C. The Elastic Network Interface takes several minutes to provide full network throughput capacity
D. The EBS volumes containing the files are created from snapshots Answer: D
Explanation: ENIs perform at peak capacity immediately
Brand new EBS volumes perform well as soon as they are created. However, if they are created from snapshots, reads will be slow the first time a block is read.
Question No:477
You need to design a VPC which is resilient to AZ failure from an internet access perspective. The VPC is in a four AZ region. How many Internet gateways are required to ensure multiple AZ failures wont disrupt internet connectivity.
A. 4 B. 0 C. 2 D. 1
 
AWS_SAA-C01 Exam
Answer: D
Explanation: Only one IGW can be attached to a VPC - only one IGW is needed to provide resilience to ALL subnets in ALL AZ's in a VPC
An IGW is resilient by design, only 1 needs to be attached to a VPC to provide all subnets in all AZ's with resilient internet connectivity.
Question No:478
Currently, you're helping design and architect a highly-available application. After building the initial environment, you've found that part of your application does not work correctly until port 443 is added to the security group. After adding port 443 to the appropriate security group, how much time will it take before the changes are applied and the application begins working correctly?
A. Immediately after a reboot of the EC2 instances belong to that security group
B. Generally, it takes 2-5 minutes for the rules to propagate
C. It will take 60 seconds for the rules to apply to all Availability Zones within the region
D. Changes apply instantly to the security group, and the application should be able to immediately respond to 443 requests
Answer: D
Question No:479
A custom CloudWatch metric has determined that your web application is returning a high number of 404 errors. How could you automatically create a message in your online Help Desk system for your webmaster? (choose 2)
A. Create an SNS topic and subscribe the Create Ticket url for your Help Desk to the topic.
B. Use the Zen Desk plugin for CloudWatch
C. Set an alarm for the metric that sends a notification to an SNS topic.
D. Run a report in AWS Config to find the source of the error and send a message to an SNS topic
E. Run a scan with Amazon Inspector to locate the source of the error and send a message to an SNS topic
 
AWS_SAA-C01 Exam
Answer: A,C
Explanation: You can subscribe HTTP and HTTPS endpoints to an SNS topic. CloudWatch doesn't have plugins
Create an alarm by setting a maximum number of errors per period
Question No:480
You are designing the storage needs for a movie processing application. Large videos are uploaded to your website and stored on S3. These master copies are processed using AWS Elastic Transcoder and multiple sizes are output and also stored on S3. There are over 20 size and bitrate variations for each master movie file. 90% of users of your website use only 2 of these size variants. Storage costs are increasing rapidly and you have been asked to optimise the running costs.
A. Store the master video files on Glacier Immediately, and all resized versions on S3 Standard
B. Store the master video files on Glacier Immediately, and all resized versions on 'S3 One Zone-IA'
C. Store the master video files on 'S3 Standard-IA' and migrate to Glacier after 12 months. Store the popular resized versions on S3 Standard and the less popular resized versions on 'S3 One Zone-IA'
D. Store the master video files on 'S3 One Zone-IA' and migrate to Glacier after 12 months. Store the resized versions on 'S3 Standard-IA'
Answer: C
Question No:481
You run a single instance application on an EC2 instance in AWS. Your architecture team are looking to make changes and move the application to operate on multiple servers. The app runs on linux and currently accesses millions of flat file data files in the /data/.... folder structure. This database is stored on an EBS volume attached to the EC2 instance. How can this be moved to work in a multi server way, with as little application changes as possible. What product would you suggest.
A. EMR & HDFS B. EFS
C. S3
 
AWS_SAA-C01 Exam
D. EBS - Mount the existing volume on all the new instances Answer: B
Explanation: EFS is a network file system and could be utilised to provide access to the database files to all instances AND it can be mounted as a mount point on linux systems.
S3 cant natively be mounted as a file system (without unreliable addons). The application may be able to be migrated to use object storage but this would need changes.
Question No:482
You are consulting for a finance company that has specific backup and archiving policies. Financial documents for the past six months may need to be accessed frequently. You need to configure a setup that allows for all documents that are 6 months or older to be sent automatically for archiving in a lower-cost but highly durable archive environment. Given that the company is using a Storage Gateway in File Gateway configuration, which of the following would be the best setup to reach the objectives?
A. Enable an S3 lifecycle policy to integrate into Amazon EBS for a good backup solution
B. Enable an S3 lifecycle policy to immediately send all objects added to the bucket to Glacier
C. Enable S3 versioning with a lifecycle policy that sends objects older than 6 months to Amazon Glacier
D. Enable versioning on the S3 connected bucket to the Gateway Storage configuration Answer: C
Question No:483
One of your systems is suffering from performance problems. It's a critical system and you have been asked to design an upgrade to resolve the issues. Checking CloudWatch you can see historically the instance is running at 20% CPU and 99% Memory utilisation. It currently runs on the 2nd smallest C type instance. What should your suggestion be for the best value way to resolve the performance issues.
A. Power down the instance and change the instance to a memory optimised instance type.
B. Rebuild the application, reinstalling all components and the data into a new memory optimised instance type.
C. Increase the size of the instance moving from the current C class instance to next step.
 
AWS_SAA-C01 Exam
D. Edit the EC2 instance properties and select the custom memory option - add additional memory until the performance issues are resolved.
Answer: A
Explanation: memory optimised instances sacrifice vCPU and provide more memory allocation for a similar cost price. You will generally achieve better value for a memory intensive application by moving to a memory optimised instance type.
custom memory is not a EC2 feature.
Question No:484
Your development team is building an application. It will be used for student registrations at a nearby university. it will receive heavy use a few times a year before term-time and light usage for the remainder of the year. The data being stored is standard ID information such as name, address, DOB, government ID number, subjects being taken. The data is private and no public access should be allowed.
Given the usage profile, and from a cost optimisation perspective - what DB solution would you suggest the development team use for the product.
A. A Dynamically auto-scaling RDS PostgresSQL instance B. A large Aurora instance
C. Redshift
D. One or more tables within DynamoDB
E. A small RDS MySQL Instance Answer: D
Explanation: Dynamic auto-scaling isn't an option for RDS
DynamoDB offers a usage model - and it can be configured to scale based on demand - either automatically, or manually. While it is a public facing database, it can be restricted as with all AWS products.
Question No:485
You have been asked to renew the design for an existing application to reduce costs. The system consists of 4 instances of the same size which are powered on 24/7 365 days a year, and are currently using an on-demand billing model. The CIO wants to reduce costs, but also reserve the capacity the 4 instances use so that in the event of an AZ failure the instances in the remaining
 
AWS_SAA-C01 Exam
AZ's have running priority. What suggestion should you make?
A. Purchase Region scoped reserved instances
B. Purchase AZ scoped reserved instances
C. You should inform the CIO that the environment is efficient as is, there are no efficiencies to be made.
D. Change the on-demand model to use Spot instances ... the cost savings are always substantial.
Answer: B
Explanation: AZ scoped reservations reserve capacity in that AZ and reduce costs
spot instances are NOT always cheaper, they often are, but if capacity is low the price can spike. Additionally, spot instances are the lowest priority for startup - if an AZ fails in a busy region, spot instance availability can decrease to 0.
Question No:486
As part of a project implementation, you need to block IP traffic from a subnet to a specific internet IP address. How can this be accomplished.
A. Create a Security group, add a deny rule, and attach to the subnet B. Attach a NACL to the subnet and add a DENY rule
C. Create a Security group, add a deny rule and attach to any resources in the subnet which need the DENY rule applied
D. Attach a NACL to the VPC and add a DENY rule Answer: B
Explanation: NACLS are attached to subnets not a VPC object
add a suitable DENY rule and ensure the NACL is associated with the required subnet
 

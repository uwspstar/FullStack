
# AWS Certified Solutions Architect - Associate

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
  It's actually just a sort of a smaller location that NWS have 
  and its use for caching content and there's always going to be more edge locations 
  than there are regions currently there's over 150 edge locations around the world.
```
- understand the difference between a region and availability zone and an edgy location
```
A region is a physical location in the world which combines two or more availability zones.
And so you have a London region you have a Sydney region Singapore region et cetera 
and availability zone is one or more discrete data centers 
each with redundant power networking connectivity housed in separate facilities 
and then an edge location is just an endpoint for AWB which is used for cachin content.
Typically this consists of cloud front which is Amazon's content delivery network
```
- ```VPC``` stands for ```Virtual Private Cloud```
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
that user will be able to interact with AWS 
using their *** access key ID ***  and *** Secret access key *** using the API, CLI, or the AWS SDKs.
```
- To access the console you use an account and password combination. 
- To access AWS programmatically you use a Key and Secret Key combination
- Which statement best describes IAM
  ```
  IAM allows you to manage 
  users, groups, roles, and their corresponding level of access to the AWS Platform
  ```
- Using ```SAML``` (Security Assertion Markup Language 2.0), you can give your federated users ```single sign-on (SSO)``` access to the AWS Management Console.
- In what language are ```policy documents``` written? ```JSON```
- In what language are policy documents written?
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
- What level of access does the "root" account have? ```Administrator Access```
- Power User Access allows
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
- Every user you create in the IAM systems starts with ```No Permissions```
- ``` Policy``` is a document that provides a formal statement of one or more permissions.
- You have created a new AWS account for your company, and you have also configured multi-factor authentication on the root account. You are about to create your new users. What strategy should you consider in order to ensure that there is good security on this account.
  ```
  Enact a strong password policy: user passwords mush be changed every 45 days, 
  with each password containing a combination of capital letters, lower case letters, numbers 
  and special symboles
  ```
- S3
  ```
  can be anywhere from 0 bytes all the way up to 5 TB terabytes.
  ``
- Bucket ```bucket``` is basically just a folder.
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
  














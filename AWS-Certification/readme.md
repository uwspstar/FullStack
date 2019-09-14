
# AWS Certified Solutions Architect - Associate

- AWS certified Solutions Architect associate exam.
  - security identity 
  - compute
  - storage
  - databases
  - network and content delivery compute is mostly

- region
```
a region or region is just simply a geographical area.
So each region consists of two or more availability zones.
```
- availability zone
```
one availability zone could be two or three data centers that are all within say a couple of miles
```
- edge location
```
an edge location or locations are endpoints for the US 
which you use for caching content so typically this consists of cloud front
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



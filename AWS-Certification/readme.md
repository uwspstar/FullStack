
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

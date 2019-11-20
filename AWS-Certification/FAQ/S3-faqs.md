
# S3 
- https://aws.amazon.com/s3/faqs/

### Amazon S3 is object storage (not for install OS, not for database ), only for files
### Amazon S3 objects can range in size from a minimum of 0 bytes to a maximum of 5 terabytes.
### 6 storage classes https://aws.amazon.com/s3/storage-classes/
```
Amazon S3 offers a range of storage classes designed for different use cases. 
These include 
1) S3 Standard for general-purpose storage of frequently accessed data; 
2) S3 Intelligent-Tiering for data with unknown or changing access patterns; 
3) S3 Standard-Infrequent Access (S3 Standard-IA) and 
4) S3 One Zone-Infrequent Access (S3 One Zone-IA) for long-lived, but less frequently accessed data; and Amazon 
5) S3 Glacier (S3 Glacier) and Amazon 
6) S3 Glacier Deep Archive (S3 Glacier Deep Archive) for long-term archive and digital preservation. 

Amazon S3 also offers capabilities to manage your data throughout its lifecycle. Once an S3 Lifecycle policy is set, your data will automatically transfer to a different storage class without any changes to your application.  
```
- The S3 Intelligent-Tiering storage class is designed to optimize costs by automatically moving data to the most cost-effective access tier, without performance impact or operational overhead. 
- The S3 Standard storage class is designed for 99.99% availability, the S3 Standard-IA storage class is designed for 99.9% availability, and the S3 One Zone-IA storage class is designed for 99.5% availability.
- Amazon S3’s massive scale enables us to spread load evenly, so that no individual application is affected by traffic spikes
- Does Amazon S3 offer a Service Level Agreement (SLA)? Yes. The Amazon S3 SLA provides for a service credit if a customer's monthly uptime percentage is below our service commitment in any billing cycle.
- Where is my data stored? You specify an AWS Region when you create your Amazon S3 bucket. For S3 Standard, S3 Standard-IA, and S3 Glacier storage classes, your objects are automatically stored across multiple devices spanning a minimum of three Availability Zones, each separated by miles across an AWS Region. Objects stored in the S3 One Zone-IA storage class are stored redundantly within a single Availability Zone in the AWS Region you select.
- Within each AWS Region, S3 operates in a minimum of three AZs, each separated by miles to protect against local events like fires, floods, etc.
- For objects larger than 100 megabytes, customers should consider using the Multipart Upload capability.
- S3 You can use access control mechanisms such as bucket policies and Access Control Lists (ACLs) to selectively grant permissions to users and groups of users.
- SSE-S3 provides an integrated solution where Amazon handles key management and key protection using multiple layers of security. You should choose SSE-S3 if you prefer to have Amazon manage your keys.
- Use SSE-C if you want to maintain your own encryption keys, but don’t want to implement or leverage a client-side encryption library.
- You can limit access to your bucket from a specific Amazon VPC Endpoint or a set of endpoints using Amazon S3 bucket policies. S3 bucket policies now support a condition
### Amazon S3 is a simple key-based object store. 
```
When you store data, you assign a unique object key that can later be used to retrieve the data. 
Keys can be any string, and they can be constructed to mimic hierarchical attributes. 
Alternatively, 
you can use S3 Object Tagging to organize your data across all of your S3 buckets and/or prefixes
```
### charged for accessing Amazon S3 through the AWS Management Console
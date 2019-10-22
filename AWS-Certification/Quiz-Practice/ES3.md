# ES3
- AWS S3 storage is virtually unlimited. No need to provision any storage upfront.

- we need to calculate the "UsageValue" of the S3 BUCKET and one of the criteria for determining this is "The number of requests during the specified time period"

- If the images need to be highly available and frequently accessed, choose STANDARD. 
- If the images need not be highly available but frequently accessed, choose REDUCED_REDUNDANCY class.
- If the images need to be highly available but not frequently accessed, choose STANDARD_IA class.
- If the images need not be highly available and not frequently accessed, choose ONEZONE_IA  

- S3 is a managed service and not part of VPC. So enabling VPC flow logs does not report traffic sent to S3 bucket.

- Using the information collected by ```CloudTrail```, you can determine what request was made to Amazon S3, the source IP address from which the request was made, who made the request, when it was made, and so on. This information helps you to track changes made to your AWS resources and to troubleshoot operational issues

- Server access logging provides detailed records for the requests that are made to a bucket. Server access logs are useful for many applications. For example, access log information can be useful in security and access audits

- Amazon EBS is a storage for the drives of your virtual machines. It stores data as blocks of the same size and organizes them through the hierarchy similar to a traditional file system. 

- EBS is not a standalone storage service like Amazon S3 so you can use it only in combination with Amazon EC2.

- recommends using multi-part uploads for larger objects

- Amazon S3 automatically scales to high request rates. For example, your application can achieve at least 3,500 PUT/POST/DELETE and 5,500 GET requests per second per prefix in a bucket. There are no limits to the number of prefixes in a bucket. It is simple to increase your read or write performance exponentially. For example, if you create 10 prefixes in an Amazon S3 bucket to parallelize reads, you could scale your read performance to 55,000 read requests per second.

- All objects by default are private. Only the object owner has permission to access these objects. However, the object owner can optionally share objects with others by creating a pre-signed URL, using their own security credentials, to grant time-limited permission to download the objects.

- Anyone who receives the pre-signed URL can then access the object. For example, if you have a video in your bucket and both the bucket and the object are private, you can share the video with others by generating a pre-signed URL.

- The File Gateway presents a file interface that enables you to store files as objects in Amazon S3 using the industry-standard NFS and SMB file protocols, and access those files via NFS and SMB from your datacenter or Amazon EC2, or access those files as objects with the S3 API.

- with Cached Volumen Gateway, you store your data in Amazon Simple Storage Service (Amazon S3) and retain a copy of frequently accessed data subsets locally. we can take incremental backups, called snapshots of the storage volume in S3.  All gateway data and snapshot data for cached volumes is stored in Amazon S3 and encrypted at rest using server-side encryption (SSE). However, you can't access this data with the Amazon S3 API or other tools such as the Amazon S3 Management Console.

- with stored volumes, you store the entire set of volume data on-premises and store periodic point-in-time backups (snapshots) in AWS. In this model, your on-premises storage is primary, delivering low-latency access to your entire dataset. AWS storage is the backup that you can restore in the event of a disaster in your data center.

- AWS provides strong consistency for DynamoDB, not for S3
- EFS provides read-after-write consistency.
- Eventual consistency is for overwrite PUTS and DELETES.
- Amazon S3 provides read-after-write consistency for PUTS of new objects in your S3 bucket in all regions with one caveat. The caveat is that if you make a HEAD or GET request to the key name (to find if the object exists) before creating the object, Amazon S3 provides eventual consistency for read-after-write
- Amazon S3 offers eventual consistency for overwrite PUTS and DELETES in all regions.
- AWS does not provide strong consistency for DELETES.
- Storage class property is at object level, not at bucket level. Following are different storage classes.
- metadata is at object level property, not bucket level.For detailed information on object metadata

### All objects by default are private. Only the object owner has permission to access these objects. However, the object owner can optionally share objects with others by creating a pre-signed URL, using their own security credentials, to grant time-limited permission to download the objects.

Anyone who receives the pre-signed URL can then access the object. For example, if you have a video in your bucket and both the bucket and the object are private, you can share the video with others by generating a pre-signed URL.
### Which of the following ```default``` settings are ```incorrect``` for a newly created S3 bucket? (choose 2 options) ```BD```
```
A. Encryption is not enabled.
B. Transfer Acceleration is enabled.
C. No bucket policy exists.
D. Versioning is enabled.
```

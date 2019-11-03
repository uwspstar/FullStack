
# ES3
### Which of the following does Amazon S3 provide?
```
A. A transient storage in the cloud
B. A highly encrypted virtual disk in the cloud C. A virtual server in the cloud
D. A highly-scalable cloud storage
```
### Does Amazon S3 provide a filesystem?
```
A. Yes, NFS (Network File System).
B. Yes, any Filesystem of your choice.
C. No, it only stores streams of data
D. No, it's an object store, with buckets and objects
```
### Which of the following happens when a bucket is created?
A. By default, versioning is disabled.
B. By default, versioning is enabled for the US Standard region buckets. 
C. By default, versioning is enabled.
D. By default, versioning is disabled only for the local region of the user.

- Cross-region replication is a bucket-level configuration that enables automatic, asynchronous copying of objects across buckets in different AWS Regions. We refer to these buckets as source bucket and destination bucket. These buckets can be owned by different AWS accounts.

- AWS CloudFront can be used to improve the performance of your website where network latency is an issue.
- Amazon S3 Transfer Acceleration enables fast, easy, and secure transfers of files over long distances between your client and an S3 bucket. Transfer Acceleration takes advantage of Amazon CloudFront’s globally distributed edge locations. As the data arrives at an edge location, data is routed to Amazon S3 over an optimized network path.

- The Amazon S3 notification feature enables you to receive notifications when certain events happen in your bucket. To enable notifications, you must first add a notification configuration identifying the events you want Amazon S3 to publish, and the destinations where you want Amazon S3 to send the event notifications.

- DELETE call on object does not delete latest version unless DELETE call is made with latest version id.

- When versioning is enabled, a simple DELETE cannot permanently delete an object. Instead, Amazon S3 inserts a delete marker in the bucket, and that marker becomes the current version of the object with a new ID. When you try to GET an object whose current version is a delete marker, Amazon S3 behaves as though the object has been deleted (even though it has not been erased) and returns a 404 error.
- To permanently delete versioned objects, you must use DELETE Object versionId.

The following figure shows that deleting a specified object version permanently removes that object.
- When you delete an object in a versioning-enabled bucket, all versions remain in the bucket and Amazon S3 creates a delete marker for the object. To undelete the object, you must delete this delete marker.

To undelete an object, you must delete the delete marker. Select the check box next to the delete marker of the object to recover, and then choose delete from the More menu.
- When versioning is enabled on S3 bucket and a new version is added to an existing object, remember that older version still remains and AWS charges same price for old verions and new versions.

- AWS S3 bucket policy does not grant permissions based on the web application URLs. However, you can setup a condition in the policy to restrict access only if the request is being sent from a certain URL using “aws:Referer” context-key.

- Content-Length and Content-MD5 are system metadata for object. They are set during creating/uploading an object. However, these paramaters do not enable web application to send requests to S3 bucket.

- enabling public access will not enable web application to send requests to S3 bucket. Further more, AWS does not recommend enabling public access on an S3 bucket unless you are hosting static assets which can be accessed by all.

- Cross-origin resource sharing (CORS) defines a way for client web applications that are loaded in one domain to interact with resources in a different domain. With CORS support, you can build rich client-side web applications with Amazon S3 and selectively allow cross-origin access to

your Amazon S3 resources.
- public access is not required to be enabled for writing logs into S3 bucket. Only access required is PutObject for Log Delivery group.

- although by default, Log Delivery group permission is disabled, permission will be granted when the bucket is selected as target for logging.

- S3 buckets would often be restricted using bucket policy with Effect as Deny except for whitelisted IAM resources who would require access.

- Server access logging provides detailed records for the requests that are made to a bucket. Server access logs are useful for many applications. For example, access log information can be useful in security and access audits.

- System metadata:
```
Metadata such as object creation date is system controlled where only Amazon S3 can modify the value.

Other system metadata, such as the storage class configured for the object and whether the object has server-side encryption enabled, are examples of system metadata whose values you control. If your bucket is configured as a website, sometimes you might want to redirect a page request to another page or an external URL. In this case, a webpage is
an object in your bucket. Amazon S3 stores the page redirect value as system metadata whose value you control.
When you create objects, you can configure values of these system metadata items or update the values when you need to
```
- User-defined metadata:
```
When uploading an object, you can also assign metadata to the object. You provide this optional information as a name-value (key-value) pair when you send a PUT or POST request to create the object. When you upload objects using the REST API, the optional user-defined metadata names must begin with "x-amz-meta-" to distinguish them from other HTTP headers
```
- AWS S3 bucket objects contain two kinds of metadata, system metadata and user-defined metadata.
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

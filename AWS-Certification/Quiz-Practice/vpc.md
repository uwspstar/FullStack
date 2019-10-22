# VPC
### All objects by default are private. Only the object owner has permission to access these objects. However, the object owner can optionally share objects with others by creating a pre-signed URL, using their own security credentials, to grant time-limited permission to download the objects.

Anyone who receives the pre-signed URL can then access the object. For example, if you have a video in your bucket and both the bucket and the object are private, you can share the video with others by generating a pre-signed URL.
### Which of the following ```default``` settings are ```incorrect``` for a newly created S3 bucket? (choose 2 options) ```BD```
```
A. Encryption is not enabled.
B. Transfer Acceleration is enabled.
C. No bucket policy exists.
D. Versioning is enabled.
```

### You are the AWS Architect at YCDIT2, Inc. Your client plans to connect their Data Center to their AWS VPC in preparation for an application launch in few months. The application they are launching is chatty and has components in AWS and in the data center, and will be hosted in private AWS subnets in their AWS VPC. It also requires bandwidth and latency guarantees at all times. The solution has to be fault tolerant. Which connectivity method would you recommend for them? ```C```
```
A- One VPN connection with two tunnels between one Customer Gateway 
and one VGW router on AWS side     

B- Two Public VIFs over two Direct connect connections. From two Customer routers 
to two different DX routers    

C- Two Direct connect connections using two Customer routers and two private VIFs 
to two different Direct connect routers

D- One direct connect connection with one private VIF, and a backup VPN connection 
from two customer routers   
```

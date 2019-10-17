
### S3 https://aws.amazon.com/s3/faqs/
### EC2 https://aws.amazon.com/ec2/faqs/

- The S3 Intelligent-Tiering storage class is designed to optimize costs by automatically moving data to the most cost-effective access tier, without performance impact or operational overhead. 
- The S3 Standard storage class is designed for 99.99% availability, the S3 Standard-IA storage class is designed for 99.9% availability, and the S3 One Zone-IA storage class is designed for 99.5% availability.
- Amazon S3’s massive scale enables us to spread load evenly, so that no individual application is affected by traffic spikes
- Does Amazon S3 offer a Service Level Agreement (SLA)? Yes. The Amazon S3 SLA provides for a service credit if a customer's monthly uptime percentage is below our service commitment in any billing cycle.
- Where is my data stored? You specify an AWS Region when you create your Amazon S3 bucket. For S3 Standard, S3 Standard-IA, and S3 Glacier storage classes, your objects are automatically stored across multiple devices spanning a minimum of three Availability Zones, each separated by miles across an AWS Region. Objects stored in the S3 One Zone-IA storage class are stored redundantly within a single Availability Zone in the AWS Region you select.
- Within each AWS Region, S3 operates in a minimum of three AZs, each separated by miles to protect against local events like fires, floods, etc.
- For objects larger than 100 megabytes, customers should consider using the Multipart Upload capability.

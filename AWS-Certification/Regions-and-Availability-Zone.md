# AWS Global Infrastructure - Regions and Availability Zone
- https://www.udemy.com/course/aws-certified-solutions-architect-associate-saa-c01/learn/lecture/13531398?start=0#overview
- use route 53 to build faultless applications across exactly regions
- for higher availability and disaster recovery why would I use a route 53 because the ECB cannot help
### AWS Regions
- AWS has regions all around the world (us-east-1)
- Each region has availability zones (useast-1a, us-east-1b…)
- Each ```availability zone``` is a physical data center in the region, but separate from the other ones (so that they’re isolated from ```disasters```)
• AWS Consoles are region scoped (```except IAM, S3 & Route53```)

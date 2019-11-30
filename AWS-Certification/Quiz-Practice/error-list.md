- Power User Access allows Access to all AWS services except the management of groups and users within IAM.

- You run a meme creation website where users can create memes and then download them for use on their own sites. The original images are stored in S3 and each meme's metadata in DynamoDB. You need to decide upon a low-cost storage option for the memes, themselves. If a meme object is unavailable or lost, a Lambda function will automatically recreate it using the original file from S3 and the metadata from DynamoDB. Which storage solution should you use to store the non-critical, easily reproducible memes in the most cost-effective way?
```
S3 – OneZone-IA is the recommended storage for when you want cheaper storage for infrequently accessed objects. 
It has the same durability but less availability. 
There can be cost implications if you use it frequently or use it for short lived storage. 
Glacier is cheaper, 
but has a long retrieval time. 
RRS has effectively been deprecated. 
It still exists but is not a service that AWS want to sell anymore.
```
- You work for a health insurance company that amasses a large number of patients' health records. Each record will be used once when assessing a customer, and will then need to be securely stored for a period of 7 years. In some rare cases, you may need to retrieve this data within 24 hours of a claim being lodged. Given these requirements, which type of AWS storage would deliver the least expensive solution?
```
The recovery rate is a key decider. 
The record shortage must be; safe, durable, low cost, and the recovery can be slow. 
All features of Glacier
```
- What is the availability of S3 – OneZone-IA?
```
99.50%, OneZone-IA is only stored in one Zone. While it has the same Durability, 
it may be less Available than normal S3 or S3-IA.
```
- You work for a major news network in Europe. They have just released a new mobile app that allows users to post their photos of newsworthy events in real-time, which are then reviewed by your editors before being copied to your website and made public. Your organization expects this app to grow very quickly, essentially doubling its user base each month. The app uses S3 to store the images, and you are expecting sudden and sizable increases in traffic to S3 when a major news event takes place (as users will be uploading large amounts of content.) You need to keep your storage costs to a minimum, and it does not matter if some objects are lost. With these factors in mind, which storage media should you use to keep costs as low as possible?
```
The key driver here is cost, 
so an awareness of cost is necessary to answer this. 
Full S3 is quite expensive at around $0.023 per GB for the lowest band. 
S3 standard IA is $0.0125 per GB, 
S3 One-Zone-IA is $0.01 per GB, 
and Legacy S3-RRS is around $0.024 per GB for the lowest band. 
Of the offered solutions SS3 One-Zone-IA is the cheapest suitable option. 
Glacier cannot be considered as it is not intended for direct access, 
however it comes in at around $0.004 per GB. 
Of course you spotted that RRS is being deprecated, 
and there is no such thing as S3 – Provisioned IOPS. 
In this case OneZone
```

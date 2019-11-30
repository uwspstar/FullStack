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

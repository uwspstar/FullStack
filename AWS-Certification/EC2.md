# EC2 (Elastic Compute Cloud)
- one pysical server is host
- one virtualize server inside a host is EC2
- shared hardware
- shared host vs dedicated host
- operate system ( linux and windows)
- ECS servce provides resizable compute capacity in the cloud
- you have root aaccess to each of your EC2 instances
- you can stop restart reboot, or terminate your instance
- EC2 availablity SLA is 99.95 % for each region during any monthly billing period ( 22 minutes per month)
- you can provision your EC2 instances on shared or dedicated hosts ( physical servers)
### EC@ instance access
- to access an instance you need a key and key pair name (public key vs private key)
- when you launch a new EC2 instance, you can create a public private key pair
- you can download the private key only once, save it in a safe place so you won't loose it
- private key only display at first time, you can dowload
- user keep the private key in safe place
- user use private key + key name to call AWS server
- the public key is saved by AWS to match it to the key pair name, and private key when you try to login to the EC2 instance
- if you launch you instance without a key pair, you will not be able to access it (via RDP or SSH)

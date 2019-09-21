### What’s AWS?
- AWS (Amazon Web Services) is a Cloud Provider
- They provide you with servers and services that you can use on demand and scale easily

### AWS Regions
- AWS has regions all around the world
(us-east-1)
- Each region has availability zones (us-east-1a, us-east-1b…)
- Each availability zone is a physical data center in the region, 
but separate from the other ones (so that they’re isolated
from disasters)
- AWS Consoles are region scoped
(except IAM, S3 & Route53)

### IAM
- IAM (Identity and Access Management)
- Your whole AWS security is there: 
  - Users
  - Groups
  - Roles
  - Policies
  ```
    - Users: Usually a physical person
    - Groups: Functions (admins, devops) Teams (engineering, design…) Contains users!
    - Roles: Internal usage within AWS resources
    - Policies: (JSON Documents) Defines what each of the above can and cannot do
  ```
- Root account should never be used (and shared)
- Users must be created with proper permissions
- IAM is at the center of AWS
- Policies are written in JSON (JavaScript Object Notation)

### IAM
- IAM has a global view
- Permissions are governed by Policies (JSON)
- MFA (Multi Factor Authentication) can be setup
- IAM has predefined “managed policies”
- We’ll see IAM policies in details in the future
- It’s best to give users the minimal amount of permissions they need to perform their job (least privilege principles)

### IAM Federation
- Big enterprises usually integrate their own repository of users with IAM
- This way, one can login into AWS using their company credentials
- Identity Federation uses the SAML standard (Active Directory)


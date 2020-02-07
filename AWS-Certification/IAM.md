# Identity and Access Management (IAM)
- IAM has a ```global view```
- authenticated ( register user )
- authorized (before you do action )
- Creating Users in a Group , Assigning Group membership and Permissions
- Group, Policy, add user
### IAM Introduction
- IAM (Identity and Access Management) and IAM has a global view
- Users
- Groups
- Roles
- Root account should never be used (and shared)
- Users must be created with proper permissions
- IAM is at the center of AWS
- Policies are written in JSON (JavaScript Object Notation) and ```Permissions``` are governed by Policies (JSON)
- MFA (Multi Factor Authentication) can be setup
- IAM has predefined “managed policies”
- It’s best to give users the minimal amount of permissions they need to perform their job (```least privilege principles```)
### Users
- Usually a physical person
### Groups
- Functions (admins, devops)
- Teams (engineering, design…)
- Contains users!
### Roles
- Internal usage within AWS resources
### Policies (JSON Documents)
- Defines what each of the above can and cannot do
- Permissions are governed by Policies (JSON)

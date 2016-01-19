# WCF Security Prototype
A prototype demonstrating Transport Security with Certificate Authentication and Message Security with Mutual Certificates.

For more information see https://msdn.microsoft.com/en-us/library/ms731074(v=vs.110).aspx and https://msdn.microsoft.com/en-us/library/ms733102(v=vs.110).aspx

## Getting Started
1. Clone the repository
2. Create a certificate for your service make sure the cn=*.secureservice.com and add to the Computer Account (Local Computer) Personal Store
3. Create a certificate for your client make sure the cn=secureclient.com and add to the Computer Account (Local Computer) Personal Store
4. Create an IIS site for Secure.Service bound to https://api.secureservice.com using the certificate from step 1
5. Run the client
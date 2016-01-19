# WCF Security Prototype
A prototype demonstrating Transport Security with Certificate Authentication and Message Security with Mutual Certificates.

For more information on Transport Security with Certificate Authentication see https://msdn.microsoft.com/en-us/library/ms731074(v=vs.110).aspx
For more information on Message Security with Mutual Certificates see https://msdn.microsoft.com/en-us/library/ms733102(v=vs.110).aspx
A great how to on creating certificates with OpenSSL for IIS see http://twentyeighttwelve.com/setting-up-your-own-certificate-authority-on-iis7-using-openssl-and-securing-your-web-api-with-client-certificates/

## Getting Started
1. Clone the repository
2. Create a certificate for your service make sure the cn=*.secureservice.com and add to the Computer Account (Local Computer) Personal Store
3. Create a certificate for your client make sure the cn=secureclient.com and add to the Computer Account (Local Computer) Personal Store
4. Create an IIS site for Secure.Service bound to https://api.secureservice.com using the certificate from step 1
5. Run the client
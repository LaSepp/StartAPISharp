# StartAPISharp
C# Implementation of StartAPI from StartCom - https://startssl.com/StartAPI

## Getting Started

To use the API you need:
* Account on StartSSL
* StartAPI Certificate and Password
* StartAPI Token

###### Connecting to API

```c#
String certFile = "api-certificate.p12";
String certPassword = "certificatepassword123";
String token = "tk_XXXX";
X509Certificate2 cert = new X509Certificate2();
cert.Import(certFile, certPassword, X509KeyStorageFlags.PersistKeySet);
APISession session = new APISession(cert, token, true);
```

Note: The third parameter "true" in the APISession constructor redirects access to the API testing server

###### Example: Requesting all validated Email Adresses

```c#
ListResponse response = session.QueryValidatedEmails();
if (response.successs)
    {
        foreach(String email in response.data)
        {
            Console.WriteLine(email);
        }
    }
```

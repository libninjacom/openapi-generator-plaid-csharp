# Org.OpenAPITools.Model.JWKPublicKey
A JSON Web Key (JWK) that can be used in conjunction with [JWT libraries](https://jwt.io/#libraries-io) to verify Plaid webhooks

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** | The alg member identifies the cryptographic algorithm family used with the key. | 
**Crv** | **string** | The crv member identifies the cryptographic curve used with the key. | 
**Kid** | **string** | The kid (Key ID) member can be used to match a specific key. This can be used, for instance, to choose among a set of keys within the JWK during key rollover. | 
**Kty** | **string** | The kty (key type) parameter identifies the cryptographic algorithm family used with the key, such as RSA or EC. | 
**Use** | **string** | The use (public key use) parameter identifies the intended use of the public key. | 
**X** | **string** | The x member contains the x coordinate for the elliptic curve point. | 
**Y** | **string** | The y member contains the y coordinate for the elliptic curve point. | 
**CreatedAt** | **int** | The timestamp when the key was created, in Unix time. | 
**ExpiredAt** | **int?** | The timestamp when the key expired, in Unix time. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


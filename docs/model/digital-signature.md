# **digitalSignature**

Signature in file.             

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|Comments|String|true|false |  |The purpose to signature.|
|SignTime|String|true|false |  |The time when the document was signed.|
|Id|String|true|false |  |Specifies a GUID which can be cross-referenced with the GUID of the signature line stored in the document content. Default value is Empty (all zeroes) Guid.|
|Password|String|true|false |  |Specifies the text of actual signature in the digital signature. Default value is Empty.            |
|Image|Array|true|false |  |Specifies an image for the digital signature. Default value is null.|
|ProviderId|String|true|false |  |Specifies the class ID of the signature provider. Default value is Empty (all zeroes) Guid.            |
|IsValid|Boolean|true|false |  |If this digital signature is valid and the document has not been tampered with, this value will be true.|
|XAdESType|String|true|false |  |XAdES type. Default value is None(XAdES is off).|


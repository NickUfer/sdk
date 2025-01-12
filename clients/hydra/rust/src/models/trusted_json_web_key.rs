/*
 * ORY Hydra
 *
 * Welcome to the ORY Hydra HTTP API documentation. You will find documentation for all HTTP APIs here.
 *
 * The version of the OpenAPI document: v1.11.0
 * 
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct TrustedJsonWebKey {
    /// The \"key_id\" is key unique identifier (same as kid header in jws/jwt).
    #[serde(rename = "kid", skip_serializing_if = "Option::is_none")]
    pub kid: Option<String>,
    /// The \"set\" is basically a name for a group(set) of keys. Will be the same as \"issuer\" in grant.
    #[serde(rename = "set", skip_serializing_if = "Option::is_none")]
    pub set: Option<String>,
}

impl TrustedJsonWebKey {
    pub fn new() -> TrustedJsonWebKey {
        TrustedJsonWebKey {
            kid: None,
            set: None,
        }
    }
}



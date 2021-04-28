/*
 * Ory Kratos
 *
 * Welcome to the ORY Kratos HTTP API documentation!
 *
 * The version of the OpenAPI document: v0.5.5-alpha.4
 * 
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct CompleteSelfServiceLoginFlowWithPasswordMethod {
    /// Sending the anti-csrf token is only required for browser login flows.
    #[serde(rename = "csrf_token", skip_serializing_if = "Option::is_none")]
    pub csrf_token: Option<String>,
    /// Identifier is the email or username of the user trying to log in.
    #[serde(rename = "identifier", skip_serializing_if = "Option::is_none")]
    pub identifier: Option<String>,
    /// The user's password.
    #[serde(rename = "password", skip_serializing_if = "Option::is_none")]
    pub password: Option<String>,
}

impl CompleteSelfServiceLoginFlowWithPasswordMethod {
    pub fn new() -> CompleteSelfServiceLoginFlowWithPasswordMethod {
        CompleteSelfServiceLoginFlowWithPasswordMethod {
            csrf_token: None,
            identifier: None,
            password: None,
        }
    }
}


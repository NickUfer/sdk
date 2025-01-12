# ory_client
Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed
with a valid Personal Access Token. Public APIs are mostly used in browsers.


This Dart package is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v0.0.1-alpha.188
- Build package: org.openapitools.codegen.languages.DartDioClientCodegen

## Requirements

Dart 2.7.0 or later OR Flutter 1.12 or later

## Installation & Usage

### Github
If this Dart package is published to Github, please include the following in pubspec.yaml
```
name: ory_client
version: 0.0.1-alpha.188
description: OpenAPI API client
dependencies:
  ory_client:
    git: https://github.com/ory/sdk.git
      version: 'any'
```

### Local
To use the package in your local drive, please include the following in pubspec.yaml
```
dependencies:
  ory_client:
    path: /path/to/ory_client
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```dart
import 'package:ory_client/api.dart';


final api = MetadataApi();

try {
    final response = await api.getVersion();
    print(response);
} catch (e) {
    print("Exception when calling MetadataApi->getVersion: $e\n");
}

```

## Documentation for API Endpoints

All URIs are relative to *https://playground.projects.oryapis.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*MetadataApi* | [**getVersion**](doc/MetadataApi.md#getversion) | **GET** /version | Return Running Software Version.
*MetadataApi* | [**isAlive**](doc/MetadataApi.md#isalive) | **GET** /health/alive | Check HTTP Server Status
*MetadataApi* | [**isReady**](doc/MetadataApi.md#isready) | **GET** /health/ready | Check HTTP Server and Database Status
*ReadApi* | [**getCheck**](doc/ReadApi.md#getcheck) | **GET** /relation-tuples/check | Check a relation tuple
*ReadApi* | [**getExpand**](doc/ReadApi.md#getexpand) | **GET** /relation-tuples/expand | Expand a Relation Tuple
*ReadApi* | [**getRelationTuples**](doc/ReadApi.md#getrelationtuples) | **GET** /relation-tuples | Query relation tuples
*ReadApi* | [**postCheck**](doc/ReadApi.md#postcheck) | **POST** /relation-tuples/check | Check a relation tuple
*V0alpha2Api* | [**adminCreateIdentity**](doc/V0alpha2Api.md#admincreateidentity) | **POST** /admin/identities | Create an Identity
*V0alpha2Api* | [**adminCreateSelfServiceRecoveryLink**](doc/V0alpha2Api.md#admincreateselfservicerecoverylink) | **POST** /admin/recovery/link | Create a Recovery Link
*V0alpha2Api* | [**adminDeleteIdentity**](doc/V0alpha2Api.md#admindeleteidentity) | **DELETE** /admin/identities/{id} | Delete an Identity
*V0alpha2Api* | [**adminDeleteIdentitySessions**](doc/V0alpha2Api.md#admindeleteidentitysessions) | **DELETE** /admin/identities/{id}/sessions | Calling this endpoint irrecoverably and permanently deletes and invalidates all sessions that belong to the given Identity.
*V0alpha2Api* | [**adminExtendSession**](doc/V0alpha2Api.md#adminextendsession) | **PATCH** /admin/sessions/{id}/extend | Calling this endpoint extends the given session ID. If &#x60;session.earliest_possible_extend&#x60; is set it will only extend the session after the specified time has passed.
*V0alpha2Api* | [**adminGetIdentity**](doc/V0alpha2Api.md#admingetidentity) | **GET** /admin/identities/{id} | Get an Identity
*V0alpha2Api* | [**adminListIdentities**](doc/V0alpha2Api.md#adminlistidentities) | **GET** /admin/identities | List Identities
*V0alpha2Api* | [**adminListIdentitySessions**](doc/V0alpha2Api.md#adminlistidentitysessions) | **GET** /admin/identities/{id}/sessions | This endpoint returns all sessions that belong to the given Identity.
*V0alpha2Api* | [**adminUpdateIdentity**](doc/V0alpha2Api.md#adminupdateidentity) | **PUT** /admin/identities/{id} | Update an Identity
*V0alpha2Api* | [**createProject**](doc/V0alpha2Api.md#createproject) | **POST** /projects | Create a Project
*V0alpha2Api* | [**createSelfServiceLogoutFlowUrlForBrowsers**](doc/V0alpha2Api.md#createselfservicelogoutflowurlforbrowsers) | **GET** /self-service/logout/browser | Create a Logout URL for Browsers
*V0alpha2Api* | [**getJsonSchema**](doc/V0alpha2Api.md#getjsonschema) | **GET** /schemas/{id} | 
*V0alpha2Api* | [**getProject**](doc/V0alpha2Api.md#getproject) | **GET** /projects/{project_id} | Get a Project
*V0alpha2Api* | [**getProjectMembers**](doc/V0alpha2Api.md#getprojectmembers) | **GET** /projects/{project_id}/members | Get all members associated with this project.
*V0alpha2Api* | [**getSelfServiceError**](doc/V0alpha2Api.md#getselfserviceerror) | **GET** /self-service/errors | Get Self-Service Errors
*V0alpha2Api* | [**getSelfServiceLoginFlow**](doc/V0alpha2Api.md#getselfserviceloginflow) | **GET** /self-service/login/flows | Get Login Flow
*V0alpha2Api* | [**getSelfServiceRecoveryFlow**](doc/V0alpha2Api.md#getselfservicerecoveryflow) | **GET** /self-service/recovery/flows | Get Recovery Flow
*V0alpha2Api* | [**getSelfServiceRegistrationFlow**](doc/V0alpha2Api.md#getselfserviceregistrationflow) | **GET** /self-service/registration/flows | Get Registration Flow
*V0alpha2Api* | [**getSelfServiceSettingsFlow**](doc/V0alpha2Api.md#getselfservicesettingsflow) | **GET** /self-service/settings/flows | Get Settings Flow
*V0alpha2Api* | [**getSelfServiceVerificationFlow**](doc/V0alpha2Api.md#getselfserviceverificationflow) | **GET** /self-service/verification/flows | Get Verification Flow
*V0alpha2Api* | [**getWebAuthnJavaScript**](doc/V0alpha2Api.md#getwebauthnjavascript) | **GET** /.well-known/ory/webauthn.js | Get WebAuthn JavaScript
*V0alpha2Api* | [**initializeSelfServiceLoginFlowForBrowsers**](doc/V0alpha2Api.md#initializeselfserviceloginflowforbrowsers) | **GET** /self-service/login/browser | Initialize Login Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceLoginFlowWithoutBrowser**](doc/V0alpha2Api.md#initializeselfserviceloginflowwithoutbrowser) | **GET** /self-service/login/api | Initialize Login Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceRecoveryFlowForBrowsers**](doc/V0alpha2Api.md#initializeselfservicerecoveryflowforbrowsers) | **GET** /self-service/recovery/browser | Initialize Recovery Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceRecoveryFlowWithoutBrowser**](doc/V0alpha2Api.md#initializeselfservicerecoveryflowwithoutbrowser) | **GET** /self-service/recovery/api | Initialize Recovery Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceRegistrationFlowForBrowsers**](doc/V0alpha2Api.md#initializeselfserviceregistrationflowforbrowsers) | **GET** /self-service/registration/browser | Initialize Registration Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceRegistrationFlowWithoutBrowser**](doc/V0alpha2Api.md#initializeselfserviceregistrationflowwithoutbrowser) | **GET** /self-service/registration/api | Initialize Registration Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceSettingsFlowForBrowsers**](doc/V0alpha2Api.md#initializeselfservicesettingsflowforbrowsers) | **GET** /self-service/settings/browser | Initialize Settings Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceSettingsFlowWithoutBrowser**](doc/V0alpha2Api.md#initializeselfservicesettingsflowwithoutbrowser) | **GET** /self-service/settings/api | Initialize Settings Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceVerificationFlowForBrowsers**](doc/V0alpha2Api.md#initializeselfserviceverificationflowforbrowsers) | **GET** /self-service/verification/browser | Initialize Verification Flow for Browser Clients
*V0alpha2Api* | [**initializeSelfServiceVerificationFlowWithoutBrowser**](doc/V0alpha2Api.md#initializeselfserviceverificationflowwithoutbrowser) | **GET** /self-service/verification/api | Initialize Verification Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**listIdentitySchemas**](doc/V0alpha2Api.md#listidentityschemas) | **GET** /schemas | 
*V0alpha2Api* | [**listProjects**](doc/V0alpha2Api.md#listprojects) | **GET** /projects | List All Projects
*V0alpha2Api* | [**listSessions**](doc/V0alpha2Api.md#listsessions) | **GET** /sessions | This endpoints returns all other active sessions that belong to the logged-in user. The current session can be retrieved by calling the &#x60;/sessions/whoami&#x60; endpoint.
*V0alpha2Api* | [**patchProject**](doc/V0alpha2Api.md#patchproject) | **PATCH** /projects/{project_id} | Patch an Ory Cloud Project Configuration
*V0alpha2Api* | [**purgeProject**](doc/V0alpha2Api.md#purgeproject) | **DELETE** /projects/{project_id} | Irrecoverably Purge a Project
*V0alpha2Api* | [**removeProjectMember**](doc/V0alpha2Api.md#removeprojectmember) | **DELETE** /projects/{project_id}/members/{member_id} | Remove a member associated with this project. This also sets their invite status to &#x60;REMOVED&#x60;.
*V0alpha2Api* | [**revokeSession**](doc/V0alpha2Api.md#revokesession) | **DELETE** /sessions/{id} | Calling this endpoint invalidates the specified session. The current session cannot be revoked. Session data are not deleted.
*V0alpha2Api* | [**revokeSessions**](doc/V0alpha2Api.md#revokesessions) | **DELETE** /sessions | Calling this endpoint invalidates all except the current session that belong to the logged-in user. Session data are not deleted.
*V0alpha2Api* | [**submitSelfServiceLoginFlow**](doc/V0alpha2Api.md#submitselfserviceloginflow) | **POST** /self-service/login | Submit a Login Flow
*V0alpha2Api* | [**submitSelfServiceLogoutFlow**](doc/V0alpha2Api.md#submitselfservicelogoutflow) | **GET** /self-service/logout | Complete Self-Service Logout
*V0alpha2Api* | [**submitSelfServiceLogoutFlowWithoutBrowser**](doc/V0alpha2Api.md#submitselfservicelogoutflowwithoutbrowser) | **DELETE** /self-service/logout/api | Perform Logout for APIs, Services, Apps, ...
*V0alpha2Api* | [**submitSelfServiceRecoveryFlow**](doc/V0alpha2Api.md#submitselfservicerecoveryflow) | **POST** /self-service/recovery | Complete Recovery Flow
*V0alpha2Api* | [**submitSelfServiceRegistrationFlow**](doc/V0alpha2Api.md#submitselfserviceregistrationflow) | **POST** /self-service/registration | Submit a Registration Flow
*V0alpha2Api* | [**submitSelfServiceSettingsFlow**](doc/V0alpha2Api.md#submitselfservicesettingsflow) | **POST** /self-service/settings | Complete Settings Flow
*V0alpha2Api* | [**submitSelfServiceVerificationFlow**](doc/V0alpha2Api.md#submitselfserviceverificationflow) | **POST** /self-service/verification | Complete Verification Flow
*V0alpha2Api* | [**toSession**](doc/V0alpha2Api.md#tosession) | **GET** /sessions/whoami | Check Who the Current HTTP Session Belongs To
*V0alpha2Api* | [**updateProject**](doc/V0alpha2Api.md#updateproject) | **PUT** /projects/{project_id} | Update an Ory Cloud Project Configuration
*WriteApi* | [**createRelationTuple**](doc/WriteApi.md#createrelationtuple) | **PUT** /admin/relation-tuples | Create a Relation Tuple
*WriteApi* | [**deleteRelationTuples**](doc/WriteApi.md#deleterelationtuples) | **DELETE** /admin/relation-tuples | Delete Relation Tuples
*WriteApi* | [**patchRelationTuples**](doc/WriteApi.md#patchrelationtuples) | **PATCH** /admin/relation-tuples | Patch Multiple Relation Tuples


## Documentation For Models

 - [ActiveProject](doc/ActiveProject.md)
 - [AdminCreateIdentityBody](doc/AdminCreateIdentityBody.md)
 - [AdminCreateIdentityImportCredentialsOidc](doc/AdminCreateIdentityImportCredentialsOidc.md)
 - [AdminCreateIdentityImportCredentialsOidcConfig](doc/AdminCreateIdentityImportCredentialsOidcConfig.md)
 - [AdminCreateIdentityImportCredentialsOidcProvider](doc/AdminCreateIdentityImportCredentialsOidcProvider.md)
 - [AdminCreateIdentityImportCredentialsPassword](doc/AdminCreateIdentityImportCredentialsPassword.md)
 - [AdminCreateIdentityImportCredentialsPasswordConfig](doc/AdminCreateIdentityImportCredentialsPasswordConfig.md)
 - [AdminCreateSelfServiceRecoveryLinkBody](doc/AdminCreateSelfServiceRecoveryLinkBody.md)
 - [AdminIdentityImportCredentials](doc/AdminIdentityImportCredentials.md)
 - [AdminUpdateIdentityBody](doc/AdminUpdateIdentityBody.md)
 - [ApiToken](doc/ApiToken.md)
 - [AuthenticatorAssuranceLevel](doc/AuthenticatorAssuranceLevel.md)
 - [CloudAccount](doc/CloudAccount.md)
 - [CnameSettings](doc/CnameSettings.md)
 - [CreateCustomHostnameBody](doc/CreateCustomHostnameBody.md)
 - [CreateProjectBody](doc/CreateProjectBody.md)
 - [CreateSubscriptionPayload](doc/CreateSubscriptionPayload.md)
 - [ErrorAuthenticatorAssuranceLevelNotSatisfied](doc/ErrorAuthenticatorAssuranceLevelNotSatisfied.md)
 - [ExpandTree](doc/ExpandTree.md)
 - [GenericError](doc/GenericError.md)
 - [GenericErrorContent](doc/GenericErrorContent.md)
 - [GetCheckResponse](doc/GetCheckResponse.md)
 - [GetRelationTuplesResponse](doc/GetRelationTuplesResponse.md)
 - [HealthNotReadyStatus](doc/HealthNotReadyStatus.md)
 - [HealthStatus](doc/HealthStatus.md)
 - [Identity](doc/Identity.md)
 - [IdentityCredentials](doc/IdentityCredentials.md)
 - [IdentityCredentialsOidc](doc/IdentityCredentialsOidc.md)
 - [IdentityCredentialsOidcProvider](doc/IdentityCredentialsOidcProvider.md)
 - [IdentityCredentialsPassword](doc/IdentityCredentialsPassword.md)
 - [IdentityCredentialsType](doc/IdentityCredentialsType.md)
 - [IdentitySchema](doc/IdentitySchema.md)
 - [IdentitySchemaLocation](doc/IdentitySchemaLocation.md)
 - [IdentitySchemaPreset](doc/IdentitySchemaPreset.md)
 - [IdentitySchemaValidationResult](doc/IdentitySchemaValidationResult.md)
 - [IdentityState](doc/IdentityState.md)
 - [InlineResponse200](doc/InlineResponse200.md)
 - [InlineResponse2001](doc/InlineResponse2001.md)
 - [InlineResponse503](doc/InlineResponse503.md)
 - [InternalRelationTuple](doc/InternalRelationTuple.md)
 - [InvitePayload](doc/InvitePayload.md)
 - [IsOwnerForProjectBySlug](doc/IsOwnerForProjectBySlug.md)
 - [IsOwnerForProjectBySlugPayload](doc/IsOwnerForProjectBySlugPayload.md)
 - [JsonError](doc/JsonError.md)
 - [JsonPatch](doc/JsonPatch.md)
 - [KetoNamespace](doc/KetoNamespace.md)
 - [NeedsPrivilegedSessionError](doc/NeedsPrivilegedSessionError.md)
 - [NormalizedProject](doc/NormalizedProject.md)
 - [NormalizedProjectRevision](doc/NormalizedProjectRevision.md)
 - [NormalizedProjectRevisionHook](doc/NormalizedProjectRevisionHook.md)
 - [NormalizedProjectRevisionIdentitySchema](doc/NormalizedProjectRevisionIdentitySchema.md)
 - [NormalizedProjectRevisionThirdPartyProvider](doc/NormalizedProjectRevisionThirdPartyProvider.md)
 - [NullPlan](doc/NullPlan.md)
 - [Pagination](doc/Pagination.md)
 - [PatchDelta](doc/PatchDelta.md)
 - [Project](doc/Project.md)
 - [ProjectHost](doc/ProjectHost.md)
 - [ProjectInvite](doc/ProjectInvite.md)
 - [ProjectMetadata](doc/ProjectMetadata.md)
 - [ProjectServiceIdentity](doc/ProjectServiceIdentity.md)
 - [ProjectServicePermission](doc/ProjectServicePermission.md)
 - [ProjectServices](doc/ProjectServices.md)
 - [ProvisionMockSubscriptionPayload](doc/ProvisionMockSubscriptionPayload.md)
 - [QuotaProjectMemberSeats](doc/QuotaProjectMemberSeats.md)
 - [RecoveryAddress](doc/RecoveryAddress.md)
 - [RelationQuery](doc/RelationQuery.md)
 - [RevokedSessions](doc/RevokedSessions.md)
 - [SchemaPatch](doc/SchemaPatch.md)
 - [SelfServiceBrowserLocationChangeRequiredError](doc/SelfServiceBrowserLocationChangeRequiredError.md)
 - [SelfServiceError](doc/SelfServiceError.md)
 - [SelfServiceFlowExpiredError](doc/SelfServiceFlowExpiredError.md)
 - [SelfServiceLoginFlow](doc/SelfServiceLoginFlow.md)
 - [SelfServiceLogoutUrl](doc/SelfServiceLogoutUrl.md)
 - [SelfServiceRecoveryFlow](doc/SelfServiceRecoveryFlow.md)
 - [SelfServiceRecoveryFlowState](doc/SelfServiceRecoveryFlowState.md)
 - [SelfServiceRecoveryLink](doc/SelfServiceRecoveryLink.md)
 - [SelfServiceRegistrationFlow](doc/SelfServiceRegistrationFlow.md)
 - [SelfServiceSettingsFlow](doc/SelfServiceSettingsFlow.md)
 - [SelfServiceSettingsFlowState](doc/SelfServiceSettingsFlowState.md)
 - [SelfServiceVerificationFlow](doc/SelfServiceVerificationFlow.md)
 - [SelfServiceVerificationFlowState](doc/SelfServiceVerificationFlowState.md)
 - [Session](doc/Session.md)
 - [SessionAuthenticationMethod](doc/SessionAuthenticationMethod.md)
 - [SessionDevice](doc/SessionDevice.md)
 - [SettingsProfileFormConfig](doc/SettingsProfileFormConfig.md)
 - [StripeCustomerResponse](doc/StripeCustomerResponse.md)
 - [SubjectSet](doc/SubjectSet.md)
 - [SubmitSelfServiceFlowWithWebAuthnRegistrationMethod](doc/SubmitSelfServiceFlowWithWebAuthnRegistrationMethod.md)
 - [SubmitSelfServiceLoginFlowBody](doc/SubmitSelfServiceLoginFlowBody.md)
 - [SubmitSelfServiceLoginFlowWithLookupSecretMethodBody](doc/SubmitSelfServiceLoginFlowWithLookupSecretMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithOidcMethodBody](doc/SubmitSelfServiceLoginFlowWithOidcMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithPasswordMethodBody](doc/SubmitSelfServiceLoginFlowWithPasswordMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithTotpMethodBody](doc/SubmitSelfServiceLoginFlowWithTotpMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithWebAuthnMethodBody](doc/SubmitSelfServiceLoginFlowWithWebAuthnMethodBody.md)
 - [SubmitSelfServiceLogoutFlowWithoutBrowserBody](doc/SubmitSelfServiceLogoutFlowWithoutBrowserBody.md)
 - [SubmitSelfServiceRecoveryFlowBody](doc/SubmitSelfServiceRecoveryFlowBody.md)
 - [SubmitSelfServiceRecoveryFlowWithLinkMethodBody](doc/SubmitSelfServiceRecoveryFlowWithLinkMethodBody.md)
 - [SubmitSelfServiceRegistrationFlowBody](doc/SubmitSelfServiceRegistrationFlowBody.md)
 - [SubmitSelfServiceRegistrationFlowWithOidcMethodBody](doc/SubmitSelfServiceRegistrationFlowWithOidcMethodBody.md)
 - [SubmitSelfServiceRegistrationFlowWithPasswordMethodBody](doc/SubmitSelfServiceRegistrationFlowWithPasswordMethodBody.md)
 - [SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody](doc/SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody.md)
 - [SubmitSelfServiceSettingsFlowBody](doc/SubmitSelfServiceSettingsFlowBody.md)
 - [SubmitSelfServiceSettingsFlowWithLookupMethodBody](doc/SubmitSelfServiceSettingsFlowWithLookupMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithOidcMethodBody](doc/SubmitSelfServiceSettingsFlowWithOidcMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithPasswordMethodBody](doc/SubmitSelfServiceSettingsFlowWithPasswordMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithProfileMethodBody](doc/SubmitSelfServiceSettingsFlowWithProfileMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithTotpMethodBody](doc/SubmitSelfServiceSettingsFlowWithTotpMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody](doc/SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody.md)
 - [SubmitSelfServiceVerificationFlowBody](doc/SubmitSelfServiceVerificationFlowBody.md)
 - [SubmitSelfServiceVerificationFlowWithLinkMethodBody](doc/SubmitSelfServiceVerificationFlowWithLinkMethodBody.md)
 - [Subscription](doc/Subscription.md)
 - [SuccessfulProjectUpdate](doc/SuccessfulProjectUpdate.md)
 - [SuccessfulSelfServiceLoginWithoutBrowser](doc/SuccessfulSelfServiceLoginWithoutBrowser.md)
 - [SuccessfulSelfServiceRegistrationWithoutBrowser](doc/SuccessfulSelfServiceRegistrationWithoutBrowser.md)
 - [UiContainer](doc/UiContainer.md)
 - [UiNode](doc/UiNode.md)
 - [UiNodeAnchorAttributes](doc/UiNodeAnchorAttributes.md)
 - [UiNodeAttributes](doc/UiNodeAttributes.md)
 - [UiNodeImageAttributes](doc/UiNodeImageAttributes.md)
 - [UiNodeInputAttributes](doc/UiNodeInputAttributes.md)
 - [UiNodeMeta](doc/UiNodeMeta.md)
 - [UiNodeScriptAttributes](doc/UiNodeScriptAttributes.md)
 - [UiNodeTextAttributes](doc/UiNodeTextAttributes.md)
 - [UiText](doc/UiText.md)
 - [UpdateCustomHostnameBody](doc/UpdateCustomHostnameBody.md)
 - [UpdateProject](doc/UpdateProject.md)
 - [UpdateSubscriptionPayload](doc/UpdateSubscriptionPayload.md)
 - [VerifiableIdentityAddress](doc/VerifiableIdentityAddress.md)
 - [Version](doc/Version.md)
 - [Warning](doc/Warning.md)


## Documentation For Authorization


## oryAccessToken

- **Type**: HTTP basic authentication


## Author

support@ory.sh


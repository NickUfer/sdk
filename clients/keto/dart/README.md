# ory_keto_client
Documentation for all of Ory Keto's REST APIs. gRPC is documented separately.


This Dart package is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v0.8.0-alpha.2
- Build package: org.openapitools.codegen.languages.DartDioClientCodegen

## Requirements

Dart 2.7.0 or later OR Flutter 1.12 or later

## Installation & Usage

### Github
If this Dart package is published to Github, please include the following in pubspec.yaml
```
name: ory_keto_client
version: 0.8.0-alpha.2
description: OpenAPI API client
dependencies:
  ory_keto_client:
    git: https://github.com/ory/sdk.git
      version: 'any'
```

### Local
To use the package in your local drive, please include the following in pubspec.yaml
```
dependencies:
  ory_keto_client:
    path: /path/to/ory_keto_client
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```dart
import 'package:ory_keto_client/api.dart';


final api = MetadataApi();

try {
    final response = await api.getVersion();
    print(response);
} catch (e) {
    print("Exception when calling MetadataApi->getVersion: $e\n");
}

```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*MetadataApi* | [**getVersion**](doc/MetadataApi.md#getversion) | **GET** /version | Return Running Software Version.
*MetadataApi* | [**isAlive**](doc/MetadataApi.md#isalive) | **GET** /health/alive | Check HTTP Server Status
*MetadataApi* | [**isReady**](doc/MetadataApi.md#isready) | **GET** /health/ready | Check HTTP Server and Database Status
*ReadApi* | [**getCheck**](doc/ReadApi.md#getcheck) | **GET** /check | Check a relation tuple
*ReadApi* | [**getExpand**](doc/ReadApi.md#getexpand) | **GET** /expand | Expand a Relation Tuple
*ReadApi* | [**getRelationTuples**](doc/ReadApi.md#getrelationtuples) | **GET** /relation-tuples | Query relation tuples
*ReadApi* | [**postCheck**](doc/ReadApi.md#postcheck) | **POST** /check | Check a relation tuple
*WriteApi* | [**createRelationTuple**](doc/WriteApi.md#createrelationtuple) | **PUT** /relation-tuples | Create a Relation Tuple
*WriteApi* | [**deleteRelationTuples**](doc/WriteApi.md#deleterelationtuples) | **DELETE** /relation-tuples | Delete Relation Tuples
*WriteApi* | [**patchRelationTuples**](doc/WriteApi.md#patchrelationtuples) | **PATCH** /relation-tuples | Patch Multiple Relation Tuples


## Documentation For Models

 - [ExpandTree](doc/ExpandTree.md)
 - [GenericError](doc/GenericError.md)
 - [GetCheckResponse](doc/GetCheckResponse.md)
 - [GetRelationTuplesResponse](doc/GetRelationTuplesResponse.md)
 - [HealthNotReadyStatus](doc/HealthNotReadyStatus.md)
 - [HealthStatus](doc/HealthStatus.md)
 - [InlineResponse200](doc/InlineResponse200.md)
 - [InlineResponse2001](doc/InlineResponse2001.md)
 - [InlineResponse503](doc/InlineResponse503.md)
 - [InternalRelationTuple](doc/InternalRelationTuple.md)
 - [PatchDelta](doc/PatchDelta.md)
 - [RelationQuery](doc/RelationQuery.md)
 - [SubjectSet](doc/SubjectSet.md)
 - [Version](doc/Version.md)


## Documentation For Authorization

 All endpoints do not require authorization.


## Author

hi@ory.sh


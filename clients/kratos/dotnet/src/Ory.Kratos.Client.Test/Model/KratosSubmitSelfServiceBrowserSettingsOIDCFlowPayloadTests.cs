/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.0.0-alpha.38
 * Contact: hi@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Ory.Kratos.Client.Api;
using Ory.Kratos.Client.Model;
using Ory.Kratos.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Ory.Kratos.Client.Test.Model
{
    /// <summary>
    ///  Class for testing KratosSubmitSelfServiceBrowserSettingsOIDCFlowPayload
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KratosSubmitSelfServiceBrowserSettingsOIDCFlowPayloadTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KratosSubmitSelfServiceBrowserSettingsOIDCFlowPayload
        //private KratosSubmitSelfServiceBrowserSettingsOIDCFlowPayload instance;

        public KratosSubmitSelfServiceBrowserSettingsOIDCFlowPayloadTests()
        {
            // TODO uncomment below to create an instance of KratosSubmitSelfServiceBrowserSettingsOIDCFlowPayload
            //instance = new KratosSubmitSelfServiceBrowserSettingsOIDCFlowPayload();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KratosSubmitSelfServiceBrowserSettingsOIDCFlowPayload
        /// </summary>
        [Fact]
        public void KratosSubmitSelfServiceBrowserSettingsOIDCFlowPayloadInstanceTest()
        {
            // TODO uncomment below to test "IsType" KratosSubmitSelfServiceBrowserSettingsOIDCFlowPayload
            //Assert.IsType<KratosSubmitSelfServiceBrowserSettingsOIDCFlowPayload>(instance);
        }


        /// <summary>
        /// Test the property 'Flow'
        /// </summary>
        [Fact]
        public void FlowTest()
        {
            // TODO unit test for the property 'Flow'
        }
        /// <summary>
        /// Test the property 'Link'
        /// </summary>
        [Fact]
        public void LinkTest()
        {
            // TODO unit test for the property 'Link'
        }
        /// <summary>
        /// Test the property 'Unlink'
        /// </summary>
        [Fact]
        public void UnlinkTest()
        {
            // TODO unit test for the property 'Unlink'
        }

    }

}

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
    ///  Class for testing KratosPluginConfigInterface
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KratosPluginConfigInterfaceTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KratosPluginConfigInterface
        //private KratosPluginConfigInterface instance;

        public KratosPluginConfigInterfaceTests()
        {
            // TODO uncomment below to create an instance of KratosPluginConfigInterface
            //instance = new KratosPluginConfigInterface();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KratosPluginConfigInterface
        /// </summary>
        [Fact]
        public void KratosPluginConfigInterfaceInstanceTest()
        {
            // TODO uncomment below to test "IsType" KratosPluginConfigInterface
            //Assert.IsType<KratosPluginConfigInterface>(instance);
        }


        /// <summary>
        /// Test the property 'Socket'
        /// </summary>
        [Fact]
        public void SocketTest()
        {
            // TODO unit test for the property 'Socket'
        }
        /// <summary>
        /// Test the property 'Types'
        /// </summary>
        [Fact]
        public void TypesTest()
        {
            // TODO unit test for the property 'Types'
        }

    }

}

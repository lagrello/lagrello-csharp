/*
 * Lagrello API
 *
 * API specification for Lagrello, a simple to use authentication service
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@lagrello.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using lagrello.Client;
using lagrello.Api;
using lagrello.Model;

namespace lagrello.Test
{
    /// <summary>
    ///  Class for testing AuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthApiTests
    {
        private AuthApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuthApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AuthApi
            //Assert.IsInstanceOf(typeof(AuthApi), instance);
        }

        
        /// <summary>
        /// Test UsersEmailAuth
        /// </summary>
        [Test]
        public void UsersEmailAuthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string payload = null;
            //var response = instance.UsersEmailAuth(payload);
            //Assert.IsInstanceOf(typeof(User), response, "response is User");
        }
        
        /// <summary>
        /// Test UsersEmailSend
        /// </summary>
        [Test]
        public void UsersEmailSendTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //instance.UsersEmailSend(userId);
            
        }
        
        /// <summary>
        /// Test UsersTotpAuth
        /// </summary>
        [Test]
        public void UsersTotpAuthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string payload = null;
            //var response = instance.UsersTotpAuth(userId, payload);
            //Assert.IsInstanceOf(typeof(User), response, "response is User");
        }
        
        /// <summary>
        /// Test UsersTotpToggle
        /// </summary>
        [Test]
        public void UsersTotpToggleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //TotpEnableRequest totpEnableRequest = null;
            //var response = instance.UsersTotpToggle(userId, totpEnableRequest);
            //Assert.IsInstanceOf(typeof(TotpEnableResponse), response, "response is TotpEnableResponse");
        }
        
    }

}
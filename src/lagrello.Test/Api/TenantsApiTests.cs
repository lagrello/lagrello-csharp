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
    ///  Class for testing TenantsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TenantsApiTests
    {
        private TenantsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TenantsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TenantsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TenantsApi
            //Assert.IsInstanceOf(typeof(TenantsApi), instance);
        }

        
        /// <summary>
        /// Test TenantUpdate
        /// </summary>
        [Test]
        public void TenantUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateTenantRequest updateTenantRequest = null;
            //var response = instance.TenantUpdate(updateTenantRequest);
            //Assert.IsInstanceOf(typeof(Tenant), response, "response is Tenant");
        }
        
        /// <summary>
        /// Test TenantsActivate
        /// </summary>
        [Test]
        public void TenantsActivateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ActivateTenantRequest activateTenantRequest = null;
            //var response = instance.TenantsActivate(activateTenantRequest);
            //Assert.IsInstanceOf(typeof(Tenant), response, "response is Tenant");
        }
        
        /// <summary>
        /// Test TenantsCreate
        /// </summary>
        [Test]
        public void TenantsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTenantRequest createTenantRequest = null;
            //var response = instance.TenantsCreate(createTenantRequest);
            //Assert.IsInstanceOf(typeof(Tenant), response, "response is Tenant");
        }
        
        /// <summary>
        /// Test TenantsCreate_0
        /// </summary>
        [Test]
        public void TenantsCreate_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TenantsCreate_0();
            //Assert.IsInstanceOf(typeof(Tenant), response, "response is Tenant");
        }
        
        /// <summary>
        /// Test TenantsGet
        /// </summary>
        [Test]
        public void TenantsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TenantsGet();
            //Assert.IsInstanceOf(typeof(Tenant), response, "response is Tenant");
        }
        
    }

}

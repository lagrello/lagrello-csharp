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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using lagrello.Client;
using lagrello.Model;

namespace lagrello.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Creates new token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTokenRequest"> (optional)</param>
        /// <returns>Token</returns>
        Token TokensCreate (CreateTokenRequest createTokenRequest = default(CreateTokenRequest));

        /// <summary>
        /// Creates new token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTokenRequest"> (optional)</param>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> TokensCreateWithHttpInfo (CreateTokenRequest createTokenRequest = default(CreateTokenRequest));
        /// <summary>
        /// Deletes specifed access token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenId">Id of the token you want to delete</param>
        /// <returns></returns>
        void TokensDelete (string tokenId);

        /// <summary>
        /// Deletes specifed access token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenId">Id of the token you want to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TokensDeleteWithHttpInfo (string tokenId);
        /// <summary>
        /// Returns a list of all active tokens in tenant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">Maximum of results per page (optional)</param>
        /// <param name="page">The page you want to see (optional)</param>
        /// <returns>TokenList</returns>
        TokenList TokensList (int? size = default(int?), int? page = default(int?));

        /// <summary>
        /// Returns a list of all active tokens in tenant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">Maximum of results per page (optional)</param>
        /// <param name="page">The page you want to see (optional)</param>
        /// <returns>ApiResponse of TokenList</returns>
        ApiResponse<TokenList> TokensListWithHttpInfo (int? size = default(int?), int? page = default(int?));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Creates new token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTokenRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> TokensCreateAsync (CreateTokenRequest createTokenRequest = default(CreateTokenRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates new token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTokenRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> TokensCreateWithHttpInfoAsync (CreateTokenRequest createTokenRequest = default(CreateTokenRequest), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes specifed access token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenId">Id of the token you want to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TokensDeleteAsync (string tokenId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes specifed access token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenId">Id of the token you want to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TokensDeleteWithHttpInfoAsync (string tokenId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of all active tokens in tenant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">Maximum of results per page (optional)</param>
        /// <param name="page">The page you want to see (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of TokenList</returns>
        System.Threading.Tasks.Task<TokenList> TokensListAsync (int? size = default(int?), int? page = default(int?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns a list of all active tokens in tenant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">Maximum of results per page (optional)</param>
        /// <param name="page">The page you want to see (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (TokenList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TokenList>> TokensListWithHttpInfoAsync (int? size = default(int?), int? page = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TokensApi : ITokensApi
    {
        private lagrello.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokensApi(String basePath)
        {
            this.Configuration = new lagrello.Client.Configuration { BasePath = basePath };

            ExceptionFactory = lagrello.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class
        /// </summary>
        /// <returns></returns>
        public TokensApi()
        {
            this.Configuration = lagrello.Client.Configuration.Default;

            ExceptionFactory = lagrello.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokensApi(lagrello.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = lagrello.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = lagrello.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public lagrello.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public lagrello.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Creates new token 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTokenRequest"> (optional)</param>
        /// <returns>Token</returns>
        public Token TokensCreate (CreateTokenRequest createTokenRequest = default(CreateTokenRequest))
        {
             ApiResponse<Token> localVarResponse = TokensCreateWithHttpInfo(createTokenRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates new token 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTokenRequest"> (optional)</param>
        /// <returns>ApiResponse of Token</returns>
        public ApiResponse<Token> TokensCreateWithHttpInfo (CreateTokenRequest createTokenRequest = default(CreateTokenRequest))
        {

            var localVarPath = "/v1/tokens";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createTokenRequest != null && createTokenRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(createTokenRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createTokenRequest; // byte array
            }

            // authentication (token) required
            // http beerer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokensCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Token) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
        }

        /// <summary>
        /// Creates new token 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTokenRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Token</returns>
        public async System.Threading.Tasks.Task<Token> TokensCreateAsync (CreateTokenRequest createTokenRequest = default(CreateTokenRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Token> localVarResponse = await TokensCreateWithHttpInfoAsync(createTokenRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates new token 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTokenRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Token)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Token>> TokensCreateWithHttpInfoAsync (CreateTokenRequest createTokenRequest = default(CreateTokenRequest), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/v1/tokens";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createTokenRequest != null && createTokenRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(createTokenRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createTokenRequest; // byte array
            }

            // authentication (token) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokensCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Token) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
        }

        /// <summary>
        /// Deletes specifed access token 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenId">Id of the token you want to delete</param>
        /// <returns></returns>
        public void TokensDelete (string tokenId)
        {
             TokensDeleteWithHttpInfo(tokenId);
        }

        /// <summary>
        /// Deletes specifed access token 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenId">Id of the token you want to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TokensDeleteWithHttpInfo (string tokenId)
        {
            // verify the required parameter 'tokenId' is set
            if (tokenId == null)
                throw new ApiException(400, "Missing required parameter 'tokenId' when calling TokensApi->TokensDelete");

            var localVarPath = "/v1/tokens/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tokenId != null) localVarPathParams.Add("tokenId", this.Configuration.ApiClient.ParameterToString(tokenId)); // path parameter

            // authentication (token) required
            // http beerer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokensDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Deletes specifed access token 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenId">Id of the token you want to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TokensDeleteAsync (string tokenId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await TokensDeleteWithHttpInfoAsync(tokenId, cancellationToken);

        }

        /// <summary>
        /// Deletes specifed access token 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenId">Id of the token you want to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TokensDeleteWithHttpInfoAsync (string tokenId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'tokenId' is set
            if (tokenId == null)
                throw new ApiException(400, "Missing required parameter 'tokenId' when calling TokensApi->TokensDelete");

            var localVarPath = "/v1/tokens/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tokenId != null) localVarPathParams.Add("tokenId", this.Configuration.ApiClient.ParameterToString(tokenId)); // path parameter

            // authentication (token) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokensDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Returns a list of all active tokens in tenant 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">Maximum of results per page (optional)</param>
        /// <param name="page">The page you want to see (optional)</param>
        /// <returns>TokenList</returns>
        public TokenList TokensList (int? size = default(int?), int? page = default(int?))
        {
             ApiResponse<TokenList> localVarResponse = TokensListWithHttpInfo(size, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of all active tokens in tenant 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">Maximum of results per page (optional)</param>
        /// <param name="page">The page you want to see (optional)</param>
        /// <returns>ApiResponse of TokenList</returns>
        public ApiResponse<TokenList> TokensListWithHttpInfo (int? size = default(int?), int? page = default(int?))
        {

            var localVarPath = "/v1/tokens";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (size != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

            // authentication (token) required
            // http beerer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokensList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TokenList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenList)));
        }

        /// <summary>
        /// Returns a list of all active tokens in tenant 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">Maximum of results per page (optional)</param>
        /// <param name="page">The page you want to see (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of TokenList</returns>
        public async System.Threading.Tasks.Task<TokenList> TokensListAsync (int? size = default(int?), int? page = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<TokenList> localVarResponse = await TokensListWithHttpInfoAsync(size, page, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a list of all active tokens in tenant 
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">Maximum of results per page (optional)</param>
        /// <param name="page">The page you want to see (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (TokenList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TokenList>> TokensListWithHttpInfoAsync (int? size = default(int?), int? page = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/v1/tokens";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (size != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

            // authentication (token) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokensList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TokenList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenList)));
        }

    }
}

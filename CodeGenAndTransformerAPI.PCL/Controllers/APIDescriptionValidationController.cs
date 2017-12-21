/*
 * CodeGenAndTransformerAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using CodeGenAndTransformerAPI.PCL;
using CodeGenAndTransformerAPI.PCL.Utilities;
using CodeGenAndTransformerAPI.PCL.Http.Request;
using CodeGenAndTransformerAPI.PCL.Http.Response;
using CodeGenAndTransformerAPI.PCL.Http.Client;
using CodeGenAndTransformerAPI.PCL.Exceptions;

namespace CodeGenAndTransformerAPI.PCL.Controllers
{
    public partial class APIDescriptionValidationController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static APIDescriptionValidationController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static APIDescriptionValidationController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new APIDescriptionValidationController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This endpoint can be used to validate an API description document *on the fly* and see detailed error messages along with any warnings or useful information.
        /// </summary>
        /// <param name="body">Required parameter: The input file to use for validation</param>
        /// <return>Returns the Models.ValidateAnAPIDescriptionResponse response from the API call</return>
        public Models.ValidateAnAPIDescriptionResponse UsingFile(FileStreamInfo body)
        {
            Task<Models.ValidateAnAPIDescriptionResponse> t = UsingFileAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint can be used to validate an API description document *on the fly* and see detailed error messages along with any warnings or useful information.
        /// </summary>
        /// <param name="body">Required parameter: The input file to use for validation</param>
        /// <return>Returns the Models.ValidateAnAPIDescriptionResponse response from the API call</return>
        public async Task<Models.ValidateAnAPIDescriptionResponse> UsingFileAsync(FileStreamInfo body)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/validate");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "body", body)
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ValidateAnAPIDescriptionResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This endpoint can be used to validate an API description document *on the fly* from its public Uri, and see detailed error messages along with any warnings or useful information. This endpoint is useful for API descriptions with relative links e.g., includes (RAML) and paths (swagger).
        /// </summary>
        /// <param name="descriptionUrl">Required parameter: The absolute public Uri for an API description doucment</param>
        /// <return>Returns the Models.ValidateAnAPIDescriptionResponse response from the API call</return>
        public Models.ValidateAnAPIDescriptionResponse UsingUrl(string descriptionUrl)
        {
            Task<Models.ValidateAnAPIDescriptionResponse> t = UsingUrlAsync(descriptionUrl);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint can be used to validate an API description document *on the fly* from its public Uri, and see detailed error messages along with any warnings or useful information. This endpoint is useful for API descriptions with relative links e.g., includes (RAML) and paths (swagger).
        /// </summary>
        /// <param name="descriptionUrl">Required parameter: The absolute public Uri for an API description doucment</param>
        /// <return>Returns the Models.ValidateAnAPIDescriptionResponse response from the API call</return>
        public async Task<Models.ValidateAnAPIDescriptionResponse> UsingUrlAsync(string descriptionUrl)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/validate");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "descriptionUrl", descriptionUrl }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ValidateAnAPIDescriptionResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This endpoint can be used to validate a *pre-configured* API description and see detailed error messages along with any warnings or useful information.
        /// </summary>
        /// <param name="apikey">Required parameter: The API Key of a pre-configured API description from APIMATIC</param>
        /// <return>Returns the Models.ValidateAnAPIDescriptionResponse response from the API call</return>
        public Models.ValidateAnAPIDescriptionResponse UsingApikey(string apikey)
        {
            Task<Models.ValidateAnAPIDescriptionResponse> t = UsingApikeyAsync(apikey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint can be used to validate a *pre-configured* API description and see detailed error messages along with any warnings or useful information.
        /// </summary>
        /// <param name="apikey">Required parameter: The API Key of a pre-configured API description from APIMATIC</param>
        /// <return>Returns the Models.ValidateAnAPIDescriptionResponse response from the API call</return>
        public async Task<Models.ValidateAnAPIDescriptionResponse> UsingApikeyAsync(string apikey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/validate");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "apikey", apikey }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ValidateAnAPIDescriptionResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 
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
    public partial class APITransformerController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static APITransformerController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static APITransformerController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new APITransformerController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Convert an API from the user's account using the API's [Api Integration Key](https://docs.apimatic.io/getting-started/manage-apis/#view-api-integration-key). The converted file is returned as the response.
        /// > Note: This endpoint does not require Basic Authentication.
        /// </summary>
        /// <param name="format">Required parameter: The API format to convert to</param>
        /// <param name="apikey">Required parameter: Apikey of an already uploaded API Description on APIMATIC</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream UsingApikey(Models.FormatTransformer format, string apikey)
        {
            Task<Stream> t = UsingApikeyAsync(format, apikey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Convert an API from the user's account using the API's [Api Integration Key](https://docs.apimatic.io/getting-started/manage-apis/#view-api-integration-key). The converted file is returned as the response.
        /// > Note: This endpoint does not require Basic Authentication.
        /// </summary>
        /// <param name="format">Required parameter: The API format to convert to</param>
        /// <param name="apikey">Required parameter: Apikey of an already uploaded API Description on APIMATIC</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> UsingApikeyAsync(Models.FormatTransformer format, string apikey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/transform");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "format", Models.FormatTransformerHelper.ToValue(format) },
                { "apikey", apikey }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpResponse _response = await ClientInstance.ExecuteAsBinaryAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ValidationResultException(@"Bad Request", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Download API description from the given URL and convert it to the given format. The API description format of the provided file will be detected automatically. The converted file is returned as the response.
        /// </summary>
        /// <param name="format">Required parameter: The API format to convert to</param>
        /// <param name="descriptionUrl">Required parameter: The URL where the API description will be downloaded from</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream UsingUrl(Models.FormatTransformer format, string descriptionUrl)
        {
            Task<Stream> t = UsingUrlAsync(format, descriptionUrl);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Download API description from the given URL and convert it to the given format. The API description format of the provided file will be detected automatically. The converted file is returned as the response.
        /// </summary>
        /// <param name="format">Required parameter: The API format to convert to</param>
        /// <param name="descriptionUrl">Required parameter: The URL where the API description will be downloaded from</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> UsingUrlAsync(Models.FormatTransformer format, string descriptionUrl)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/transform");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "format", Models.FormatTransformerHelper.ToValue(format) },
                { "descriptionUrl", descriptionUrl }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpResponse _response = await ClientInstance.ExecuteAsBinaryAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ValidationResultException(@"Bad Request", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Upload a file and convert it to the given format. The API description format of the uploaded file will be detected automatically. The converted file is returned as the response.
        /// </summary>
        /// <param name="format">Required parameter: The API format to convert to</param>
        /// <param name="file">Required parameter: The input file to convert</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream UsingFile(Models.FormatTransformer format, FileStreamInfo file)
        {
            Task<Stream> t = UsingFileAsync(format, file);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Upload a file and convert it to the given format. The API description format of the uploaded file will be detected automatically. The converted file is returned as the response.
        /// </summary>
        /// <param name="format">Required parameter: The API format to convert to</param>
        /// <param name="file">Required parameter: The input file to convert</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> UsingFileAsync(Models.FormatTransformer format, FileStreamInfo file)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/transform");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "format", Models.FormatTransformerHelper.ToValue(format) }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "file", file)
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpResponse _response = await ClientInstance.ExecuteAsBinaryAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ValidationResultException(@"Bad Request", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 
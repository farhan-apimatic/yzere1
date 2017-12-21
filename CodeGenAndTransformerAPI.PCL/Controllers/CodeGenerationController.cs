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
    public partial class CodeGenerationController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static CodeGenerationController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static CodeGenerationController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new CodeGenerationController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// The code generation endpoint. The response is a path to the generated zip file relative to https://apimatic.io/
        /// </summary>
        /// <param name="name">Required parameter: The name of the API being used for code generation</param>
        /// <param name="format">Required parameter: The format of the API description to use for code generation</param>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="body">Required parameter: The input file to use for code generation</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the string response from the API call</return>
        public string UsingFileAsString(
                string name,
                Models.Format format,
                Models.Template template,
                FileStreamInfo body,
                int? dl = 0)
        {
            Task<string> t = UsingFileAsStringAsync(name, format, template, body, dl);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// The code generation endpoint. The response is a path to the generated zip file relative to https://apimatic.io/
        /// </summary>
        /// <param name="name">Required parameter: The name of the API being used for code generation</param>
        /// <param name="format">Required parameter: The format of the API description to use for code generation</param>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="body">Required parameter: The input file to use for code generation</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UsingFileAsStringAsync(
                string name,
                Models.Format format,
                Models.Template template,
                FileStreamInfo body,
                int? dl = 0)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/codegen");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name },
                { "format", Models.FormatHelper.ToValue(format) },
                { "template", Models.TemplateHelper.ToValue(template) },
                { "dl", (null != dl) ? dl : 0 }
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
                new KeyValuePair<string, object>( "body", body)
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"Unauthorized: Access is denied due to invalid credentials.", _context);

            if (_response.StatusCode == 412)
                throw new APIException(@"Precondition Failed", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// The code generation endpoint. The response is a path to the generated zip file relative to https://apimatic.io/
        /// </summary>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="format">Required parameter: The format of the API description to use for code generation</param>
        /// <param name="name">Required parameter: The name of the API being used for code generation</param>
        /// <param name="descriptionUrl">Required parameter: The absolute public Uri for an API description doucment</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the string response from the API call</return>
        public string UsingUrlAsString(
                Models.Template template,
                Models.Format format,
                string name,
                string descriptionUrl,
                int? dl = 0)
        {
            Task<string> t = UsingUrlAsStringAsync(template, format, name, descriptionUrl, dl);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// The code generation endpoint. The response is a path to the generated zip file relative to https://apimatic.io/
        /// </summary>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="format">Required parameter: The format of the API description to use for code generation</param>
        /// <param name="name">Required parameter: The name of the API being used for code generation</param>
        /// <param name="descriptionUrl">Required parameter: The absolute public Uri for an API description doucment</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UsingUrlAsStringAsync(
                Models.Template template,
                Models.Format format,
                string name,
                string descriptionUrl,
                int? dl = 0)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/codegen");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "template", Models.TemplateHelper.ToValue(template) },
                { "format", Models.FormatHelper.ToValue(format) },
                { "name", name },
                { "descriptionUrl", descriptionUrl },
                { "dl", (null != dl) ? dl : 0 }
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
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"Unauthorized: Access is denied due to invalid credentials.", _context);

            if (_response.StatusCode == 412)
                throw new APIException(@"Precondition Failed", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// The code generation endpoint! Upload a file and convert it to the given format. The API description format of uploaded file will be detected automatically. The response is generated zip file as per selected template.
        /// </summary>
        /// <param name="name">Required parameter: The name of the API being used for code generation</param>
        /// <param name="format">Required parameter: The format of the API description to use for code generation</param>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="body">Required parameter: The input file to use for code generation</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream UsingFileAsBinary(
                string name,
                Models.Format format,
                Models.Template template,
                FileStreamInfo body,
                int? dl = 1)
        {
            Task<Stream> t = UsingFileAsBinaryAsync(name, format, template, body, dl);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// The code generation endpoint! Upload a file and convert it to the given format. The API description format of uploaded file will be detected automatically. The response is generated zip file as per selected template.
        /// </summary>
        /// <param name="name">Required parameter: The name of the API being used for code generation</param>
        /// <param name="format">Required parameter: The format of the API description to use for code generation</param>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="body">Required parameter: The input file to use for code generation</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> UsingFileAsBinaryAsync(
                string name,
                Models.Format format,
                Models.Template template,
                FileStreamInfo body,
                int? dl = 1)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/codegen");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name },
                { "format", Models.FormatHelper.ToValue(format) },
                { "template", Models.TemplateHelper.ToValue(template) },
                { "dl", (null != dl) ? dl : 1 }
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
                new KeyValuePair<string, object>( "body", body)
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpResponse _response = await ClientInstance.ExecuteAsBinaryAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"Unauthorized: Access is denied due to invalid credentials.", _context);

            if (_response.StatusCode == 412)
                throw new APIException(@"Precondition Failed", _context);

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
        /// Download API description from the given URL and convert it to the given format. The API description format of the provided file will be detected automatically. The response is generated zip file as per selected template.
        /// </summary>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="format">Required parameter: The format of the API description to use for code generation</param>
        /// <param name="name">Required parameter: The name of the API being used for code generation</param>
        /// <param name="descriptionUrl">Required parameter: The absolute public Uri for an API description doucment</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream UsingUrlAsBinary(
                Models.Template template,
                Models.Format format,
                string name,
                string descriptionUrl,
                int? dl = 1)
        {
            Task<Stream> t = UsingUrlAsBinaryAsync(template, format, name, descriptionUrl, dl);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Download API description from the given URL and convert it to the given format. The API description format of the provided file will be detected automatically. The response is generated zip file as per selected template.
        /// </summary>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="format">Required parameter: The format of the API description to use for code generation</param>
        /// <param name="name">Required parameter: The name of the API being used for code generation</param>
        /// <param name="descriptionUrl">Required parameter: The absolute public Uri for an API description doucment</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> UsingUrlAsBinaryAsync(
                Models.Template template,
                Models.Format format,
                string name,
                string descriptionUrl,
                int? dl = 1)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/codegen");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "template", Models.TemplateHelper.ToValue(template) },
                { "format", Models.FormatHelper.ToValue(format) },
                { "name", name },
                { "descriptionUrl", descriptionUrl },
                { "dl", (null != dl) ? dl : 1 }
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
            if (_response.StatusCode == 401)
                throw new APIException(@"Unauthorized: Access is denied due to invalid credentials.", _context);

            if (_response.StatusCode == 412)
                throw new APIException(@"Precondition Failed", _context);

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
        /// Convert an API from the user's account using the API's [API Integration Key](https://docs.apimatic.io/getting-started/manage-apis/#view-api-integration-key). The response is generated zip file as per selected template.
        /// > Note: This endpoint does not require Basic Authentication.
        /// </summary>
        /// <param name="apikey">Required parameter: The API Key of the pre-configured API</param>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream UsingApikeyAsBinary(string apikey, Models.Template template, int? dl = 1)
        {
            Task<Stream> t = UsingApikeyAsBinaryAsync(apikey, template, dl);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Convert an API from the user's account using the API's [API Integration Key](https://docs.apimatic.io/getting-started/manage-apis/#view-api-integration-key). The response is generated zip file as per selected template.
        /// > Note: This endpoint does not require Basic Authentication.
        /// </summary>
        /// <param name="apikey">Required parameter: The API Key of the pre-configured API</param>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> UsingApikeyAsBinaryAsync(string apikey, Models.Template template, int? dl = 1)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/codegen");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "apikey", apikey },
                { "template", Models.TemplateHelper.ToValue(template) },
                { "dl", (null != dl) ? dl : 1 }
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
            if (_response.StatusCode == 401)
                throw new APIException(@"Unauthorized: Access is denied due to invalid credentials.", _context);

            if (_response.StatusCode == 412)
                throw new APIException(@"Precondition Failed", _context);

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
        /// The code generation endpoint. The response is a path to the generated zip file relative to https://apimatic.io/
        /// > Note: This endpoint does not require Basic Authentication.
        /// </summary>
        /// <param name="apikey">Required parameter: The API Key of the pre-configured API</param>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the string response from the API call</return>
        public string UsingApikeyAsString(string apikey, Models.Template template, int? dl = 0)
        {
            Task<string> t = UsingApikeyAsStringAsync(apikey, template, dl);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// The code generation endpoint. The response is a path to the generated zip file relative to https://apimatic.io/
        /// > Note: This endpoint does not require Basic Authentication.
        /// </summary>
        /// <param name="apikey">Required parameter: The API Key of the pre-configured API</param>
        /// <param name="template">Required parameter: The template to use for code generation</param>
        /// <param name="dl">Optional parameter: Optional</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UsingApikeyAsStringAsync(string apikey, Models.Template template, int? dl = 0)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/codegen");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "apikey", apikey },
                { "template", Models.TemplateHelper.ToValue(template) },
                { "dl", (null != dl) ? dl : 0 }
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
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"Unauthorized: Access is denied due to invalid credentials.", _context);

            if (_response.StatusCode == 412)
                throw new APIException(@"Precondition Failed", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 
/*
 * CodeGenAndTransformerAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CodeGenAndTransformerAPI.PCL.Http.Client;

using CodeGenAndTransformerAPI.PCL.Models;
using CodeGenAndTransformerAPI.PCL;
using CodeGenAndTransformerAPI.PCL.Utilities;


namespace CodeGenAndTransformerAPI.PCL.Exceptions
{
    public class ValidationResultException : APIException 
    {
        // These fields hold the values for the public properties.
        private bool success;
        private List<Models.Message> errors;
        private List<Models.Message> warnings;
        private List<Models.Message> messages;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Success")]
        public bool Success 
        { 
            get 
            {
                return this.success; 
            } 
            private set 
            {
                this.success = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Errors")]
        public List<Models.Message> Errors 
        { 
            get 
            {
                return this.errors; 
            } 
            private set 
            {
                this.errors = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Warnings")]
        public List<Models.Message> Warnings 
        { 
            get 
            {
                return this.warnings; 
            } 
            private set 
            {
                this.warnings = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Messages")]
        public List<Models.Message> Messages 
        { 
            get 
            {
                return this.messages; 
            } 
            private set 
            {
                this.messages = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public ValidationResultException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 
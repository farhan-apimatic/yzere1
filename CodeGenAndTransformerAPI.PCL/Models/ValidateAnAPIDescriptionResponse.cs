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
using CodeGenAndTransformerAPI.PCL;
using CodeGenAndTransformerAPI.PCL.Utilities;


namespace CodeGenAndTransformerAPI.PCL.Models
{
    public class ValidateAnAPIDescriptionResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private object errors;
        private object warnings;
        private object messages;
        private bool success;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Errors")]
        public object Errors 
        { 
            get 
            {
                return this.errors; 
            } 
            set 
            {
                this.errors = value;
                onPropertyChanged("Errors");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Warnings")]
        public object Warnings 
        { 
            get 
            {
                return this.warnings; 
            } 
            set 
            {
                this.warnings = value;
                onPropertyChanged("Warnings");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Messages")]
        public object Messages 
        { 
            get 
            {
                return this.messages; 
            } 
            set 
            {
                this.messages = value;
                onPropertyChanged("Messages");
            }
        }

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
            set 
            {
                this.success = value;
                onPropertyChanged("Success");
            }
        }
    }
} 
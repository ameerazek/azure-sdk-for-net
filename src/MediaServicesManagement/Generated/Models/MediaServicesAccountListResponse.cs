// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.MediaServices.Models;

namespace Microsoft.WindowsAzure.Management.MediaServices.Models
{
    /// <summary>
    /// The List Media Accounts operation response.
    /// </summary>
    public partial class MediaServicesAccountListResponse : OperationResponse, IEnumerable<MediaServicesAccountListResponse.MediaServiceAccount>
    {
        private IList<MediaServicesAccountListResponse.MediaServiceAccount> _accounts;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<MediaServicesAccountListResponse.MediaServiceAccount> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MediaServicesAccountListResponse
        /// class.
        /// </summary>
        public MediaServicesAccountListResponse()
        {
            this._accounts = new List<MediaServicesAccountListResponse.MediaServiceAccount>();
        }
        
        /// <summary>
        /// Gets the sequence of Accounts.
        /// </summary>
        public IEnumerator<MediaServicesAccountListResponse.MediaServiceAccount> GetEnumerator()
        {
            return this.Accounts.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Accounts.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// A Media Services account associated with your subscription.
        /// </summary>
        public partial class MediaServiceAccount
        {
            private string _accountId;
            
            /// <summary>
            /// Optional. The Id of the Media Services Account.
            /// </summary>
            public string AccountId
            {
                get { return this._accountId; }
                set { this._accountId = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. The Name of the Media Services Account.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private Uri _parentUri;
            
            /// <summary>
            /// Optional. The ParentLink of the Media Services Account.
            /// </summary>
            public Uri ParentUri
            {
                get { return this._parentUri; }
                set { this._parentUri = value; }
            }
            
            private string _state;
            
            /// <summary>
            /// Optional. The current state of the Media Services Account.
            /// </summary>
            public string State
            {
                get { return this._state; }
                set { this._state = value; }
            }
            
            private string _type;
            
            /// <summary>
            /// Optional. The type of the Media Services Account.
            /// </summary>
            public string Type
            {
                get { return this._type; }
                set { this._type = value; }
            }
            
            private Uri _uri;
            
            /// <summary>
            /// Optional. The SelfLink of the Media Services Account.
            /// </summary>
            public Uri Uri
            {
                get { return this._uri; }
                set { this._uri = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the MediaServiceAccount class.
            /// </summary>
            public MediaServiceAccount()
            {
            }
        }
    }
}

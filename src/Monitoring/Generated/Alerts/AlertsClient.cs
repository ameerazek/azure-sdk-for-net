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
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Management.Monitoring.Alerts;

namespace Microsoft.WindowsAzure.Management.Monitoring.Alerts
{
    public partial class AlertsClient : ServiceClient<AlertsClient>, IAlertsClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// Optional base uri parameter for Azure REST.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API.  The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure.  No anonymous requests
        /// are allowed.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private IIncidentOperations _incidents;
        
        /// <summary>
        /// Operations for managing the alert incidents.
        /// </summary>
        public virtual IIncidentOperations Incidents
        {
            get { return this._incidents; }
        }
        
        private IRuleOperations _rules;
        
        /// <summary>
        /// Operations for managing the alert rules.
        /// </summary>
        public virtual IRuleOperations Rules
        {
            get { return this._rules; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AlertsClient class.
        /// </summary>
        private AlertsClient()
            : base()
        {
            this._incidents = new IncidentOperations(this);
            this._rules = new RuleOperations(this);
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the AlertsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API.  The Windows Azure Service ManagementAPI use
        /// mutual authentication of management certificates over SSL to
        /// ensure that a request made to the service is secure.  No anonymous
        /// requests are allowed.
        /// </param>
        /// <param name='baseUri'>
        /// Required. Optional base uri parameter for Azure REST.
        /// </param>
        public AlertsClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the AlertsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API.  The Windows Azure Service ManagementAPI use
        /// mutual authentication of management certificates over SSL to
        /// ensure that a request made to the service is secure.  No anonymous
        /// requests are allowed.
        /// </param>
        public AlertsClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
    }
}

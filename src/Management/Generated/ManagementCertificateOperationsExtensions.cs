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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Service Management API provides programmatic access to much of the
    /// functionality available through the Management Portal. The Service
    /// Management API is a REST API. All API operations are performed over
    /// SSL and mutually authenticated using X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public static partial class ManagementCertificateOperationsExtensions
    {
        /// <summary>
        /// The Add Management Certificate operation adds a certificate to the
        /// list of management certificates. Management certificates, which
        /// are also known as subscription certificates, authenticate clients
        /// attempting to connect to resources associated with your Windows
        /// Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154123.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IManagementCertificateOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Management Certificate
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Create(this IManagementCertificateOperations operations, ManagementCertificateCreateParameters parameters)
        {
            try
            {
                return operations.CreateAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Add Management Certificate operation adds a certificate to the
        /// list of management certificates. Management certificates, which
        /// are also known as subscription certificates, authenticate clients
        /// attempting to connect to resources associated with your Windows
        /// Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154123.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IManagementCertificateOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Management Certificate
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> CreateAsync(this IManagementCertificateOperations operations, ManagementCertificateCreateParameters parameters)
        {
            return operations.CreateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete Management Certificate operation deletes a certificate
        /// from the list of management certificates. Management certificates,
        /// which are also known as subscription certificates, authenticate
        /// clients attempting to connect to resources associated with your
        /// Windows Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154127.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IManagementCertificateOperations.
        /// </param>
        /// <param name='thumbprint'>
        /// Required. the thumbprint value of the certificate to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IManagementCertificateOperations operations, string thumbprint)
        {
            try
            {
                return operations.DeleteAsync(thumbprint).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Delete Management Certificate operation deletes a certificate
        /// from the list of management certificates. Management certificates,
        /// which are also known as subscription certificates, authenticate
        /// clients attempting to connect to resources associated with your
        /// Windows Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154127.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IManagementCertificateOperations.
        /// </param>
        /// <param name='thumbprint'>
        /// Required. the thumbprint value of the certificate to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IManagementCertificateOperations operations, string thumbprint)
        {
            return operations.DeleteAsync(thumbprint, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Management Certificate operation retrieves information
        /// about the management certificate with the specified thumbprint.
        /// Management certificates, which are also known as subscription
        /// certificates, authenticate clients attempting to connect to
        /// resources associated with your Windows Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154131.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IManagementCertificateOperations.
        /// </param>
        /// <param name='thumbprint'>
        /// Required. The thumbprint value of the certificate to retrieve
        /// information about.
        /// </param>
        /// <returns>
        /// The Get Management Certificate operation response.
        /// </returns>
        public static ManagementCertificateGetResponse Get(this IManagementCertificateOperations operations, string thumbprint)
        {
            try
            {
                return operations.GetAsync(thumbprint).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Get Management Certificate operation retrieves information
        /// about the management certificate with the specified thumbprint.
        /// Management certificates, which are also known as subscription
        /// certificates, authenticate clients attempting to connect to
        /// resources associated with your Windows Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154131.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IManagementCertificateOperations.
        /// </param>
        /// <param name='thumbprint'>
        /// Required. The thumbprint value of the certificate to retrieve
        /// information about.
        /// </param>
        /// <returns>
        /// The Get Management Certificate operation response.
        /// </returns>
        public static Task<ManagementCertificateGetResponse> GetAsync(this IManagementCertificateOperations operations, string thumbprint)
        {
            return operations.GetAsync(thumbprint, CancellationToken.None);
        }
        
        /// <summary>
        /// The List Management Certificates operation lists and returns basic
        /// information about all of the management certificates associated
        /// with the specified subscription. Management certificates, which
        /// are also known as subscription certificates, authenticate clients
        /// attempting to connect to resources associated with your Windows
        /// Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154105.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IManagementCertificateOperations.
        /// </param>
        /// <returns>
        /// The List Management Certificates operation response.
        /// </returns>
        public static ManagementCertificateListResponse List(this IManagementCertificateOperations operations)
        {
            try
            {
                return operations.ListAsync().Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The List Management Certificates operation lists and returns basic
        /// information about all of the management certificates associated
        /// with the specified subscription. Management certificates, which
        /// are also known as subscription certificates, authenticate clients
        /// attempting to connect to resources associated with your Windows
        /// Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154105.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IManagementCertificateOperations.
        /// </param>
        /// <returns>
        /// The List Management Certificates operation response.
        /// </returns>
        public static Task<ManagementCertificateListResponse> ListAsync(this IManagementCertificateOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}

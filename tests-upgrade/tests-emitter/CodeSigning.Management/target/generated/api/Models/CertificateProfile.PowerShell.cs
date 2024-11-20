// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell;

    /// <summary>Certificate profile resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(CertificateProfileTypeConverter))]
    public partial class CertificateProfile
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CertificateProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfilePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProfileType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).ProfileType = (string) content.GetValueForProperty("ProfileType",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).ProfileType, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Certificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Certificate = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate>) content.GetValueForProperty("Certificate",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Certificate, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate>(__y, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateTypeConverter.ConvertFrom));
            }
            if (content.Contains("CommonName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).CommonName = (string) content.GetValueForProperty("CommonName",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).CommonName, global::System.Convert.ToString);
            }
            if (content.Contains("Organization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Organization = (string) content.GetValueForProperty("Organization",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Organization, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).OrganizationUnit = (string) content.GetValueForProperty("OrganizationUnit",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).OrganizationUnit, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).StreetAddress = (string) content.GetValueForProperty("StreetAddress",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).StreetAddress, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeStreetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeStreetAddress = (bool?) content.GetValueForProperty("IncludeStreetAddress",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeStreetAddress, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("City"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).City = (string) content.GetValueForProperty("City",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).City, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeCity = (bool?) content.GetValueForProperty("IncludeCity",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeCity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeState = (bool?) content.GetValueForProperty("IncludeState",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeState, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Country"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Country = (string) content.GetValueForProperty("Country",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Country, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeCountry = (bool?) content.GetValueForProperty("IncludeCountry",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeCountry, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).PostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("IncludePostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludePostalCode = (bool?) content.GetValueForProperty("IncludePostalCode",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludePostalCode, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnhancedKeyUsage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).EnhancedKeyUsage = (string) content.GetValueForProperty("EnhancedKeyUsage",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).EnhancedKeyUsage, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityValidationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IdentityValidationId = (string) content.GetValueForProperty("IdentityValidationId",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IdentityValidationId, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Status, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CertificateProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfilePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProfileType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).ProfileType = (string) content.GetValueForProperty("ProfileType",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).ProfileType, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Certificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Certificate = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate>) content.GetValueForProperty("Certificate",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Certificate, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate>(__y, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateTypeConverter.ConvertFrom));
            }
            if (content.Contains("CommonName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).CommonName = (string) content.GetValueForProperty("CommonName",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).CommonName, global::System.Convert.ToString);
            }
            if (content.Contains("Organization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Organization = (string) content.GetValueForProperty("Organization",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Organization, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).OrganizationUnit = (string) content.GetValueForProperty("OrganizationUnit",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).OrganizationUnit, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).StreetAddress = (string) content.GetValueForProperty("StreetAddress",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).StreetAddress, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeStreetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeStreetAddress = (bool?) content.GetValueForProperty("IncludeStreetAddress",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeStreetAddress, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("City"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).City = (string) content.GetValueForProperty("City",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).City, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeCity = (bool?) content.GetValueForProperty("IncludeCity",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeCity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeState = (bool?) content.GetValueForProperty("IncludeState",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeState, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Country"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Country = (string) content.GetValueForProperty("Country",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Country, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeCountry = (bool?) content.GetValueForProperty("IncludeCountry",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludeCountry, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).PostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("IncludePostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludePostalCode = (bool?) content.GetValueForProperty("IncludePostalCode",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IncludePostalCode, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnhancedKeyUsage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).EnhancedKeyUsage = (string) content.GetValueForProperty("EnhancedKeyUsage",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).EnhancedKeyUsage, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityValidationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IdentityValidationId = (string) content.GetValueForProperty("IdentityValidationId",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).IdentityValidationId, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).Status, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CertificateProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CertificateProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CertificateProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CertificateProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Certificate profile resource.
    [System.ComponentModel.TypeConverter(typeof(CertificateProfileTypeConverter))]
    public partial interface ICertificateProfile

    {

    }
}
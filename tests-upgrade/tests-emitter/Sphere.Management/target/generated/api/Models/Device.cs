namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>An device resource belonging to a device group resource.</summary>
    public partial class Device :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevice,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ProxyResource();

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>SKU of the chip</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string ChipSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).ChipSku; }

        /// <summary>Device ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string DeviceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).DeviceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).DeviceId = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>OS version available for installation when update requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string LastAvailableOSVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastAvailableOSVersion; }

        /// <summary>OS version running on device when update requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string LastInstalledOSVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastInstalledOSVersion; }

        /// <summary>Time when update requested and new OS version available</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastOSUpdateUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastOSUpdateUtc; }

        /// <summary>Time when update was last requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastUpdateRequestUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastUpdateRequestUtc; }

        /// <summary>Internal Acessors for ChipSku</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal.ChipSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).ChipSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).ChipSku = value; }

        /// <summary>Internal Acessors for LastAvailableOSVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal.LastAvailableOSVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastAvailableOSVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastAvailableOSVersion = value; }

        /// <summary>Internal Acessors for LastInstalledOSVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal.LastInstalledOSVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastInstalledOSVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastInstalledOSVersion = value; }

        /// <summary>Internal Acessors for LastOSUpdateUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal.LastOSUpdateUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastOSUpdateUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastOSUpdateUtc = value; }

        /// <summary>Internal Acessors for LastUpdateRequestUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal.LastUpdateRequestUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastUpdateRequestUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).LastUpdateRequestUtc = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DeviceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DeviceProperties()); set => this._property = value; }

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="Device" /> instance.</summary>
        public Device()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader1))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader1) is string __headerRetryAfterHeader1 ? int.TryParse( __headerRetryAfterHeader1, out int __headerRetryAfterHeader1Value ) ? __headerRetryAfterHeader1Value : default(int?) : default(int?);
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// An device resource belonging to a device group resource.
    public partial interface IDevice :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }
        /// <summary>SKU of the chip</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"SKU of the chip",
        SerializedName = @"chipSku",
        PossibleTypes = new [] { typeof(string) })]
        string ChipSku { get;  }
        /// <summary>Device ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Device ID",
        SerializedName = @"deviceId",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceId { get; set; }
        /// <summary>OS version available for installation when update requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"OS version available for installation when update requested",
        SerializedName = @"lastAvailableOsVersion",
        PossibleTypes = new [] { typeof(string) })]
        string LastAvailableOSVersion { get;  }
        /// <summary>OS version running on device when update requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"OS version running on device when update requested",
        SerializedName = @"lastInstalledOsVersion",
        PossibleTypes = new [] { typeof(string) })]
        string LastInstalledOSVersion { get;  }
        /// <summary>Time when update requested and new OS version available</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Time when update requested and new OS version available",
        SerializedName = @"lastOsUpdateUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastOSUpdateUtc { get;  }
        /// <summary>Time when update was last requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Time when update was last requested",
        SerializedName = @"lastUpdateRequestUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastUpdateRequestUtc { get;  }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }

    }
    /// An device resource belonging to a device group resource.
    internal partial interface IDeviceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResourceInternal
    {
        string AzureAsyncOperation { get; set; }
        /// <summary>SKU of the chip</summary>
        string ChipSku { get; set; }
        /// <summary>Device ID</summary>
        string DeviceId { get; set; }
        /// <summary>OS version available for installation when update requested</summary>
        string LastAvailableOSVersion { get; set; }
        /// <summary>OS version running on device when update requested</summary>
        string LastInstalledOSVersion { get; set; }
        /// <summary>Time when update requested and new OS version available</summary>
        global::System.DateTime? LastOSUpdateUtc { get; set; }
        /// <summary>Time when update was last requested</summary>
        global::System.DateTime? LastUpdateRequestUtc { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties Property { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }

        int? RetryAfter { get; set; }

    }
}
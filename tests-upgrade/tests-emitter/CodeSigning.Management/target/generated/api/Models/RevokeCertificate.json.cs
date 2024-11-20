// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>Defines the certificate revocation properties.</summary>
    public partial class RevokeCertificate
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevokeCertificate.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevokeCertificate.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevokeCertificate FromJson(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject json ? new RevokeCertificate(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject into a new instance of <see cref="RevokeCertificate" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RevokeCertificate(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_serialNumber = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("serialNumber"), out var __jsonSerialNumber) ? (string)__jsonSerialNumber : (string)_serialNumber;}
            {_thumbprint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("thumbprint"), out var __jsonThumbprint) ? (string)__jsonThumbprint : (string)_thumbprint;}
            {_effectiveAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("effectiveAt"), out var __jsonEffectiveAt) ? global::System.DateTime.TryParse((string)__jsonEffectiveAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEffectiveAtValue) ? __jsonEffectiveAtValue : _effectiveAt : _effectiveAt;}
            {_reason = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("reason"), out var __jsonReason) ? (string)__jsonReason : (string)_reason;}
            {_remark = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("remarks"), out var __jsonRemarks) ? (string)__jsonRemarks : (string)_remark;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RevokeCertificate" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RevokeCertificate" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._serialNumber)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._serialNumber.ToString()) : null, "serialNumber" ,container.Add );
            AddIf( null != (((object)this._thumbprint)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._thumbprint.ToString()) : null, "thumbprint" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._effectiveAt.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)), "effectiveAt" ,container.Add );
            AddIf( null != (((object)this._reason)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._reason.ToString()) : null, "reason" ,container.Add );
            AddIf( null != (((object)this._remark)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._remark.ToString()) : null, "remarks" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}
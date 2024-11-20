// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Astro.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Extensions;

    /// <summary>Offer details for the marketplace that is selected by the user</summary>
    public partial class OfferDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOfferDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOfferDetails.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOfferDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject json ? new OfferDetails(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject into a new instance of <see cref="OfferDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OfferDetails(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_publisherId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("publisherId"), out var __jsonPublisherId) ? (string)__jsonPublisherId : (string)_publisherId;}
            {_offerId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("offerId"), out var __jsonOfferId) ? (string)__jsonOfferId : (string)_offerId;}
            {_planId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("planId"), out var __jsonPlanId) ? (string)__jsonPlanId : (string)_planId;}
            {_planName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("planName"), out var __jsonPlanName) ? (string)__jsonPlanName : (string)_planName;}
            {_termUnit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("termUnit"), out var __jsonTermUnit) ? (string)__jsonTermUnit : (string)_termUnit;}
            {_termId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("termId"), out var __jsonTermId) ? (string)__jsonTermId : (string)_termId;}
            {_renewalMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("renewalMode"), out var __jsonRenewalMode) ? (string)__jsonRenewalMode : (string)_renewalMode;}
            {_endDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("endDate"), out var __jsonEndDate) ? global::System.DateTime.TryParse((string)__jsonEndDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEndDateValue) ? __jsonEndDateValue : _endDate : _endDate;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OfferDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OfferDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._publisherId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._publisherId.ToString()) : null, "publisherId" ,container.Add );
            AddIf( null != (((object)this._offerId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._offerId.ToString()) : null, "offerId" ,container.Add );
            AddIf( null != (((object)this._planId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._planId.ToString()) : null, "planId" ,container.Add );
            AddIf( null != (((object)this._planName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._planName.ToString()) : null, "planName" ,container.Add );
            AddIf( null != (((object)this._termUnit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._termUnit.ToString()) : null, "termUnit" ,container.Add );
            AddIf( null != (((object)this._termId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._termId.ToString()) : null, "termId" ,container.Add );
            AddIf( null != (((object)this._renewalMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._renewalMode.ToString()) : null, "renewalMode" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._endDate ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._endDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "endDate" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}
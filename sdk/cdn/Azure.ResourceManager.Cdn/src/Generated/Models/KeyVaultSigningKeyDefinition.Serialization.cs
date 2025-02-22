// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class KeyVaultSigningKeyDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName");
            writer.WriteStringValue(TypeDefinition.ToString());
            writer.WritePropertyName("subscriptionId");
            writer.WriteStringValue(SubscriptionId);
            writer.WritePropertyName("resourceGroupName");
            writer.WriteStringValue(ResourceGroupName);
            writer.WritePropertyName("vaultName");
            writer.WriteStringValue(VaultName);
            writer.WritePropertyName("secretName");
            writer.WriteStringValue(SecretName);
            writer.WritePropertyName("secretVersion");
            writer.WriteStringValue(SecretVersion);
            writer.WriteEndObject();
        }

        internal static KeyVaultSigningKeyDefinition DeserializeKeyVaultSigningKeyDefinition(JsonElement element)
        {
            KeyVaultSigningKeyType typeName = default;
            string subscriptionId = default;
            string resourceGroupName = default;
            string vaultName = default;
            string secretName = default;
            string secretVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"))
                {
                    typeName = new KeyVaultSigningKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vaultName"))
                {
                    vaultName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretName"))
                {
                    secretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretVersion"))
                {
                    secretVersion = property.Value.GetString();
                    continue;
                }
            }
            return new KeyVaultSigningKeyDefinition(typeName, subscriptionId, resourceGroupName, vaultName, secretName, secretVersion);
        }
    }
}

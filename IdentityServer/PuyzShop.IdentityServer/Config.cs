// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace PuyzShop.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("ResourceCatalog") { Scopes = {"CatalogFullPermission", "CatalogReadPermission" } },
            new ApiResource("ResourceDiscount"){ Scopes = {"DiscountFullPermission" }},
            new ApiResource("ResourceOrder") { Scopes = {"OrdertFullPermission" } }
        };

        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Email(),
            new IdentityResources.Profile()
        };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            // catalog
            new ApiScope("CatalogFullPermission", "Full authority for catalog operations"),
            new ApiScope("CatalogReadPermission", "Reading authority for catalog operations"),

            // discount
            new ApiScope("DiscountFullPermission", "Full authority for discount operations"),

            // order
            new ApiScope("OrderFullPermission", "Full authority for order operations"),
        };

        public static IEnumerable<Client> Clients => new Client[]
        {
            // Visitor
            new Client
            {
                ClientId = "PuyzShopVisitorId",
                ClientName = "Puyz Shop Visitor User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("puyzshopsecret".Sha256()) },
                AllowedScopes = { "CatalogReadPermission" }
            },

            // Manager
            new Client
            {
                ClientId = "PuyzShopManagerId",
                ClientName = "Puyz Shop Manager User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("puyzshopsecret".Sha256()) },
                AllowedScopes = { "CatalogFullPermission" }
            },

            // Admin
            new Client
            {
                ClientId = "PuyzShopAdminId",
                ClientName = "Puyz Shop Admin User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("puyzshopsecret".Sha256()) },
                AllowedScopes = {
                "CatalogFullPermission", "DiscountFullPermission", "OrderFullPermission",
                IdentityServerConstants.LocalApi.ScopeName,
                IdentityServerConstants.StandardScopes.Email,
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile
                },
                AccessTokenLifetime = 600 // second

            },
        };
    }
}
// <copyright file="MsBuildManagerServiceCollectionExtensions.cs" company="DotnetCodeCrafters">
// Copyright (c) Dotnet Code Crafters
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>


namespace MSBuildProjectModifier.Extensions
{
    #region namespaces
    using Microsoft.Extensions.DependencyInjection;
    using MSBuildProjectModifier.Managers;
    #endregion
    public static class MsBuildManagerServiceCollectionExtensions
    {
        public static IServiceCollection AddMsBuildManager(this IServiceCollection services)
        {
            services.AddTransient<IMsBuildManager>(provider =>
            {
                return new MsBuildManager();
            });

            return services;
        }
    }
}

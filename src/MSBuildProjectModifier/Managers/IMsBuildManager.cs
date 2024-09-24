// <copyright file="IMsBuildManager.cs" company="DotnetCodeCrafters">
// Copyright (c) Dotnet Code Crafters
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.Build.Evaluation;
using System.Xml.Linq;

namespace MSBuildProjectModifier.Managers
{
    public interface IMsBuildManager
    {
        /// <summary>
        /// Adds a reference to the specified file into the given MSBuild project file. 
        /// If the reference already exists, no changes are made.
        /// </summary>
        /// <param name="projectFilePath">The full file path of the MSBuild project.</param>
        /// <param name="filePath">The full file path of the file to be added as a reference.</param>
        /// <param name="itemType">The type of the item to be added (e.g., Content, Reference).</param>
        /// <param name="projectLoadSettings">The settings used when loading the project.</param>
        public void AddReference(string projectFilePath, string filePath, string itemType, ProjectLoadSettings projectLoadSettings);

        /// <summary>
        /// Checks if a reference to the specified file exists in the given MSBuild project file.
        /// </summary>
        /// <param name="projectFilePath">The full file path of the MSBuild project.</param>
        /// <param name="filePath">The full file path of the file to check for existence.</param>
        /// <param name="attribute">The attribute to be checked for the reference (e.g., Include).</param>
        /// <param name="loadOptions">Options that affect how the XML is loaded.</param>
        /// <returns>True if the reference exists; otherwise, false.</returns>
        public bool IsReferenceExists(string projectFilePath, string filePath, string attribute, LoadOptions loadOptions);

        /// <summary>
        /// Checks if the specified MSBuild project file exists.
        /// </summary>
        /// <param name="projectFilePath">The full file path of the MSBuild project.</param>
        /// <returns>True if the project file exists; otherwise, false.</returns>
        public bool IsProjectExists(string projectFilePath);
    }
}

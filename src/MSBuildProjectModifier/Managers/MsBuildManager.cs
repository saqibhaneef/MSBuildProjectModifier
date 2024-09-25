// <copyright file="MsBuildManager.cs" company="DotnetCodeCrafters">
// Copyright (c) Dotnet Code Crafters
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MSBuildProjectModifier.Managers
{
    #region namespaces
    using System.Xml.Linq;
    using System.Xml;
    using Microsoft.Build.Evaluation;
    using Microsoft.Build.Definition;
    #endregion
    internal class MsBuildManager : IMsBuildManager
    {        

        public bool AddReference(string projectFilePath, string filePath, string itemType, MsBuildProjectModifierLoadOptions projectLoadSettings)
        {            
                if (ProjectCollection.GlobalProjectCollection.Count > 0)
                {
                    ProjectCollection.GlobalProjectCollection.UnloadAllProjects();
                }

                Project projectFile = Project.FromFile(projectFilePath, new ProjectOptions()
                {
                    LoadSettings = (ProjectLoadSettings)projectLoadSettings
                });

                projectFile.AddItem(itemType, filePath);
                projectFile.Save();

                Console.WriteLine($"Reference = {filePath} added at Path: {projectFilePath}");

                return true;            
        }

        public bool IsProjectExists(string projectFilePath)
        {
            FileInfo projectFileInfo = new FileInfo(projectFilePath);
            return projectFileInfo.Exists;
        }

        public bool IsReferenceExists(string projectFilePath, string filePath, string attribute, LoadOptions loadOptions)
        {
            FileInfo projectFileInfo = new FileInfo(projectFilePath);
            bool isReferenceExists = false;

            XDocument xmlDocument;
            using (var reader = XmlReader.Create(projectFilePath))
            {
                xmlDocument = XDocument.Load(reader, loadOptions);
                XElement systemConfig = xmlDocument.Descendants().FirstOrDefault(x => (string)x.Attribute(attribute) == filePath);

                isReferenceExists = systemConfig != null;
            }
            
            return isReferenceExists;
        }
        
    }
}

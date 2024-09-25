﻿// <copyright file="MsBuildManager.cs" company="DotnetCodeCrafters">
// Copyright (c) Dotnet Code Crafters
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MSBuildProjectModifier
{
    /// <summary>
    /// Flags for controlling the project load. Returning flags inside Microsft.Build ProjectLoadSettings
    /// </summary>
    /// <remarks>
    /// This is a "flags" enum, allowing future settings to be added
    /// in an additive, non breaking fashion.
    /// </remarks>
    public enum MsBuildProjectModifierLoadOptions
    {
        /// <summary>
        /// Normal load. This is the default.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Ignore nonexistent targets files when evaluating the project
        /// </summary>
        IgnoreMissingImports = 1,

        /// <summary>
        /// Record imports including duplicate, but not circular, imports on the ImportsIncludingDuplicates property
        /// </summary>
        RecordDuplicateButNotCircularImports = 2,

        /// <summary>
        /// Throw an exception and stop the evaluation of a project if any circular imports are detected
        /// </summary>
        RejectCircularImports = 4,

        /// <summary>
        /// Record the item elements that got evaluated
        /// </summary>
        RecordEvaluatedItemElements = 8,

        /// <summary>
        /// Ignore empty targets files when evaluating the project
        /// </summary>
        IgnoreEmptyImports = 16,

        /// <summary>
        /// By default, evaluations performed via <see cref="Project"/> evaluate and collect elements whose conditions were false (e.g. <see cref="Project.ItemsIgnoringCondition"/>).
        /// This flag turns off this behaviour. <see cref="Project"/> members that collect such elements will throw when accessed.
        /// </summary>
        DoNotEvaluateElementsWithFalseCondition = 32,

        /// <summary>
        /// Ignore invalid target files when evaluating the project
        /// </summary>
        IgnoreInvalidImports = 64,

        /// <summary>
        /// Whether to profile the evaluation
        /// </summary>
        ProfileEvaluation = 128,

        /// <summary>
        /// Used in combination with <see cref="IgnoreMissingImports" /> to still treat an unresolved MSBuild project SDK as an error.
        /// </summary>
        FailOnUnresolvedSdk = 256,
    }
}

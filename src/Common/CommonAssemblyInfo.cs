// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyProduct("Microsoft Azure WebJobs SDK")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]

[assembly: AssemblyVersion("2.4.0.0")]

// The official build will replace the third place with the build number.
// For example, 1.0.0.0 becomes 1.0.1234.0
[assembly: AssemblyFileVersion("2.4.0.0")]

// The official build will insert the commit hash here.
[assembly: AssemblyInformationalVersion("")]

[assembly: ComVisible(false)]

// Opt in to centralized servicing
[assembly: AssemblyMetadata("Serviceable", "True")]
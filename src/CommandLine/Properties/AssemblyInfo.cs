// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See License.md in the project root for license information.

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("CommandLine.dll")]
[assembly: AssemblyDescription("Command Line Parser Library allows CLR applications to define a syntax for parsing command line arguments.")]
[assembly: AssemblyCulture("")]
[assembly: InternalsVisibleTo("CommandLine.Tests")]
#if PLATFORM_DOTNET
[assembly: InternalsVisibleTo("CommandLine.DotNet.Tests")]
#endif
[assembly: InternalsVisibleTo("CommandLine.FSharp")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
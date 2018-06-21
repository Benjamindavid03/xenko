﻿// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System.Reflection;
using System.Runtime.CompilerServices;

#pragma warning disable 436 // Xenko.PublicKeys is defined in multiple assemblies

[assembly: InternalsVisibleTo("Xenko.Core.IO.Serializers" + Xenko.PublicKeys.Default)]
[assembly: InternalsVisibleTo("Xenko.Engine" + Xenko.PublicKeys.Default)]
[assembly: InternalsVisibleTo("Xenko.Engine.Step1" + Xenko.PublicKeys.Default)]
[assembly: InternalsVisibleTo("Xenko.Core.Tests" + Xenko.PublicKeys.Default)]

#if XENKO_PLATFORM_IOS
[assembly: InternalsVisibleTo("XenkoCoreTests" + Xenko.PublicKeys.Default)]
#endif
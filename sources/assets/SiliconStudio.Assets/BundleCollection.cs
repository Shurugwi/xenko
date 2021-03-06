﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using System.Collections.Generic;
using SiliconStudio.Core;

namespace SiliconStudio.Assets
{
    /// <summary>
    /// A collection of bundles.
    /// </summary>
    [DataContract("!Bundles")]
    public class BundleCollection : List<Bundle>
    {
        private readonly Package package;

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleCollection"/> class.
        /// </summary>
        /// <param name="package">The package.</param>
        internal BundleCollection(Package package)
        {
            this.package = package;
        }

        /// <summary>
        /// Gets the package this bundle collection is defined for.
        /// </summary>
        /// <value>The package.</value>
        [DataMemberIgnore]
        private Package Package
        {
            get
            {
                return package;
            }
        }
    }
}
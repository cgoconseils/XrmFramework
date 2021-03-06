﻿// Copyright (c) Christophe Gondouin (CGO Conseils). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionManager
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class ColumnAttribute : MergeableAttribute
    {
        public string DisplayName { get; set; }

        public int Order { get; set; }

        public int Width { get; set; }

        public ColumnAttribute(string displayName, int order, int width = 145)
        {
            DisplayName = displayName;
            Order = order;
            Width = width;
        }
    }
}

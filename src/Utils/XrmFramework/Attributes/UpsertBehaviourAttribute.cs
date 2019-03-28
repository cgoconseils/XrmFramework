﻿// Copyright (c) Christophe Gondouin (CGO Conseils). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [AttributeUsage(AttributeTargets.Class)]
    public class UpsertBehaviourAttribute : Attribute
    {
        public UpsertBehaviourAttribute(Type behaviourType)
        {
            BehaviourType = behaviourType;
        }

        public Type BehaviourType { get; private set; }
    }
}
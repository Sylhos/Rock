﻿// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rock.Attribute
{
    /// <summary>
    /// Field Attribute to select 0 or more Metrics
    /// Technically, in order to support putting a metric in multiple categories, you are selecting a MetricCategory, then getting the MetricCategory.Metric
    /// </summary>
    [AttributeUsage( AttributeTargets.Class, AllowMultiple = true, Inherited = true )]
    public class MetricCategoriesFieldAttribute : FieldAttribute
    {
        public MetricCategoriesFieldAttribute( string name = "Metrics", string description = "", bool required = true, string defaultMetricsGuids = "", string category = "", int order = 0, string key = null )
            : base( name, description, required, defaultMetricsGuids, category, order, key, typeof( Rock.Field.Types.MetricCategoriesFieldType ).FullName )
        {
        }
    }
}
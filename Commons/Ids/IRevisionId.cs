﻿/*
 * Copyright (c) 2010-2012 Achim 'ahzf' Friedland <achim@graph-database.org>
 * This file is part of Illias Commons <http://www.github.com/ahzf/Illias>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#region Usings

using System;
using System.Collections.Generic;

#endregion

namespace de.ahzf.Illias.Commons
{

    /// <summary>
    /// Provides a generic revision identifier.
    /// </summary>
    /// <typeparam name="TRevId">The type of the revision identifier.</typeparam>
    public interface IRevisionId<TRevId>
        where TRevId : IEquatable<TRevId>, IComparable<TRevId>, IComparable
    {

        /// <summary>
        /// A generic revision identifier.
        /// All vertices, edges and hyper edges of a graph must have unique identifiers.
        /// </summary>
        TRevId RevId { get; }

    }

}

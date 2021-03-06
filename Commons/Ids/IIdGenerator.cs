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

#endregion

namespace de.ahzf.Illias.Commons
{

    /// <summary>
    /// An interface for classes generating Ids.
    /// </summary>
    /// <typeparam name="TId">The type of the Ids.</typeparam>
    public interface IIdGenerator<TId>
        where TId : IEquatable<TId>, IComparable<TId>, IComparable
    {

        /// <summary>
        /// Generate a new Id.
        /// </summary>
        /// <param name="UniquenessCheckDelegate">A delegate to check the uniqueness of the generated identification.</param>
        TId NewId(Func<TId, Boolean> UniquenessCheckDelegate);

    }

}

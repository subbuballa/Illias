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
using System.Threading;

#endregion

namespace de.ahzf.Illias.Commons.Votes
{

    /// <summary>
    /// A majority vote is a simple way to ask multiple event subscribers
    /// if an action, e.g. AddVertex(...) should be processed or suspended.
    /// If a majority of >50% is okay with it, the result of the vote will be true.
    /// </summary>
    public class MajorityVote : ABooleanVote
    {

        #region MajorityVote()

        /// <summary>
        /// A majority vote is a simple way to ask multiple event subscribers
        /// if an action, e.g. AddVertex(...) should be processed or suspended.
        /// If a majority of >50% is okay with it, the result of the vote will be true.
        /// </summary>
        public MajorityVote()
            : base((yes, no) => yes > no)
        { }

        #endregion

    }

}

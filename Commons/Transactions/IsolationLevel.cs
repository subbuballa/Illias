/*
 * Copyright (c) 2010-2012 Achim 'ahzf' Friedland <code@ahzf.de>
 * This file is part of Illias Commons <http://www.github.com/ahzf/Illias>
 *
 * Licensed under the General Public License, Version 3.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.gnu.org/licenses/gpl.html
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#region Usings

using System;
using System.Text;

#endregion

namespace de.ahzf.Illias.Commons.Transactions
{

    /// <summary>
    /// Transaction Isolation Levels
    /// </summary>
    public enum IsolationLevel
    {

        /// <summary>
        /// Read
        /// </summary>
        Read,

        /// <summary>
        /// Write
        /// </summary>
        Write

    }

}
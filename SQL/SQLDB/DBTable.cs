﻿/*
 * Copyright (c) 2010-2012 Achim 'ahzf' Friedland <achim@graph-database.org>
 * This file is part of Illias <http://www.github.com/ahzf/Illias>
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
using System.Collections;
using System.Collections.Generic;

#endregion

namespace de.ahzf.Illias.SQL
{

    public class DBTable : IEnumerable<String>
    {

        //+-----------------------+
        //| Tables_in_Datenlogger |
        //+-----------------------+
        //| kanalliste            |
        //| messdaten_1           |
        //+-----------------------+

        public String Name { get; set; }


        public IEnumerator<String> GetEnumerator()
        {
            return new List<String>() { Name }.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new String[1] { Name }.GetEnumerator();
        }

    }

}

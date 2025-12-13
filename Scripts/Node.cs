/*
 * Copyright 2025 yiroth
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * Purpose: An editor asset type to store identifiable objects
 */

using UnityEngine;
using System.Collections.Generic;

namespace LibYiroth.Data
{
    [CreateAssetMenu(fileName = "Node", menuName = "LibYiroth/Data/New Node", order = 0)]
    public class Node : ScriptableObject
    {
        public Identification nodeID;
        public string nodeName;
        public string nodeDescription;
        public List<Variant.Container> attributeContainer;
    }
}
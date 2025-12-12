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
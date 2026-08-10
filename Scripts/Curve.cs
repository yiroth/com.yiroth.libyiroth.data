using System.Collections.Generic;
using Ashrose.Helper.Editor;
using UnityEngine;

namespace Ashrose.Data
{
    [System.Serializable]
    public struct CurveData
    {
        public float time;
        public Variant.Container value;
    }
    
    [CreateAssetMenu(fileName = "Curve Asset", menuName = "Ashrose/Data/Curve Asset")]
    public class Curve : ScriptableObject
    {
        [SerializeField]
        private List<CurveData> data = new();

        [SerializeField][ReadOnly]
        private List<CurveData> baked = new(); // TODO: Needs implementation

        public List<CurveData> GetCurveData()
        {
            return data;
        }

        public List<CurveData> GetBakedCurveData()
        {
            return baked;
        }

        public CurveData GetCurveDataOf(int index)
        {
            return Helper.Cardinal.TryGetElementByIndex(data, index, out CurveData curve) ? curve : new CurveData();
        }

        public float GetCurveTimeOf(int index)
        {
            return Helper.Cardinal.TryGetElementByIndex<CurveData>(data, index, out CurveData curve) ? curve.time : 0.0f;
        }

        public Variant.Container GetCurveValueOf(int index)
        {
            return Helper.Cardinal.TryGetElementByIndex<CurveData>(data, index, out CurveData curve) ? curve.value : null;
        }
    }
}

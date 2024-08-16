using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

namespace FTGAMEStudio.InitialSolution.Inputs
{
    [RequireComponent(typeof(MaskableGraphic))]
    public abstract class Outputable<TData> : UIBehaviour, IOutputable<TData>
        where TData : class
    {
        public abstract void SetValue(TData value);
        public abstract TData GetValue();
    }

    [RequireComponent(typeof(MaskableGraphic))]
    public abstract class Outputable<TInput, TData> : Outputable<TData>
        where TInput : Input<TData>
        where TData : class
    {
        public TInput output;

        public override void SetValue(TData value) => output?.SetValue(value);
        public override TData GetValue() => output?.GetValue();
    }
}

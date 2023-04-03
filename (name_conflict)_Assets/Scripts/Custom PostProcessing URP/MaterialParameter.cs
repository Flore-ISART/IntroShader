using System;
using UnityEngine;
using UnityEngine.Rendering;

[Serializable]
public class MaterialParameter : VolumeParameter<Material[]>
{
    public MaterialParameter(Material[] value, bool overrideState = false)
        : base(value, overrideState) { }

    public override int GetHashCode()
    {
        var hash = base.GetHashCode();

        unchecked
        {
            if (value != null)
                hash = value.GetHashCode();
        }

        return hash;
    } 
}
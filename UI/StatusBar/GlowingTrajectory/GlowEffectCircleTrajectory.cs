using Assets.UI.StatusBar.GlowingTrajectory;
using System;
using UnityEngine;

namespace Assets.UI.StatusBar.GlowingTrajectory
{
    [Serializable]
    public class GlowEffectCirlceTrajectory : GlowEffectTrajectory
    {
        public float Radius;
        public override Vector3 Apply(float time)
        {
            float angle = time / MovingTime * 360 * Mathf.Deg2Rad;
            Vector3 translate = new Vector3();
            translate.x = Radius * Mathf.Sin(angle);
            translate.y = Radius * Mathf.Cos(angle);

            return translate;
        }
    }
}

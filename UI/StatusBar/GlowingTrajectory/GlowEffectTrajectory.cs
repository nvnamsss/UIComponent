using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.UI.StatusBar.GlowingTrajectory
{
    [Serializable]
    public abstract class GlowEffectTrajectory
    {
        public float MovingTime;
        public abstract Vector3 Apply(float time);
    }
}

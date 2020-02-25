using Assets.UI.StatusBar.GlowingTrajectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.UI.StatusBar
{
    [ExecuteAlways]
    public class GlowMovingBorderEffect : BorderEffect, ISerializationCallbackReceiver
    {
        /* Glow moving follow a trajectory
         * 
         */
        public enum GlowingTrajectoryType
        {
            None,
            Circle,
            Rectangle,
            Diamon,
        }

        public GlowingTrajectoryType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                switch (_type)
                {
                    case GlowingTrajectoryType.None:
                        break;
                    case GlowingTrajectoryType.Circle:
                        Trajectory = new GlowEffectCirlceTrajectory();
                        break;
                    case GlowingTrajectoryType.Rectangle:
                        break;
                    case GlowingTrajectoryType.Diamon:
                        break;
                    default:
                        break;
                }
            }

        }
        public GameObject glow;
        public GlowEffectTrajectory Trajectory;

        private float currentTime;
        [SerializeField]
        private Vector2 center;
        [SerializeField]
        private GlowingTrajectoryType _type;
        protected override void Awake()
        {
        }

        private void FixedUpdate()
        {
            Vector3 location = Trajectory.Apply(currentTime);
            transform.position += location;

            currentTime += Time.fixedDeltaTime;
            if (currentTime >= Trajectory.MovingTime)
            {
                if (Repeat) currentTime = 0;
            }
        }

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            switch (_type)
            {
                case GlowingTrajectoryType.None:
                    break;
                case GlowingTrajectoryType.Circle:
                    Trajectory = new GlowEffectCirlceTrajectory();
                    break;
                case GlowingTrajectoryType.Rectangle:
                    break;
                case GlowingTrajectoryType.Diamon:
                    break;
                default:
                    break;
            }
        }
    }
}

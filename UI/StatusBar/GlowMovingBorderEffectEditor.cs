using Assets.UI.StatusBar.GlowingTrajectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Assets.UI.StatusBar
{
    [CustomEditor(typeof(GlowMovingBorderEffect))]
    public class GlowMovingBorderEffectEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            var effect = target as GlowMovingBorderEffect;
           
            effect.Type = (GlowMovingBorderEffect.GlowingTrajectoryType)EditorGUILayout.EnumPopup(effect.Type, GUILayout.MinWidth(48));

            switch (effect.Type)
            {
                case GlowMovingBorderEffect.GlowingTrajectoryType.None:
                    break;
                case GlowMovingBorderEffect.GlowingTrajectoryType.Circle:
                    CircleTrajectory();
                    break;
                case GlowMovingBorderEffect.GlowingTrajectoryType.Rectangle:
                    break;
                case GlowMovingBorderEffect.GlowingTrajectoryType.Diamon:
                    break;
                default:
                    break;
            }
        }

        private void CircleTrajectory()
        {
            var effect = target as GlowMovingBorderEffect;

            effect.Trajectory = new GlowEffectCirlceTrajectory();
            GlowEffectCirlceTrajectory trajectory = effect.Trajectory as GlowEffectCirlceTrajectory;
            EditorGUILayout.LabelField("Moving time");
            trajectory.MovingTime = EditorGUILayout.FloatField(effect.Trajectory.MovingTime, GUILayout.MinWidth(48));
            EditorGUILayout.LabelField("Radius");
            trajectory.Radius = EditorGUILayout.FloatField(trajectory.Radius, GUILayout.MinWidth(48));
        }
    }
}

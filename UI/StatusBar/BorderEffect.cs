using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.UI.StatusBar
{
    public class BorderEffect : UIBehaviour
    {
        /*Image has a mode to fill
         * - radial fill
         * - horizontal fill
         * - vertical fill
         * using filled has a limitation: for complexity trajectory we can not using this method to 
         * simulate
         * 
         */
        public bool Repeat;
        protected override void Awake()
        {
            base.Awake();
        }


        private void Update()
        {
            
        }

    }
}

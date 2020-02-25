using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Assets.UI.StatusBar
{
    public class FilledBorderEffect : BorderEffect
    {
        public UnityEvent TimeExceed;
        public float FilledTime;
        private Image image;

        protected override void Awake()
        {
            TimeExceed = new UnityEvent();
        }

        private void Update()
        {
            image.fillAmount += Time.deltaTime / FilledTime;
            if (image.fillAmount == 1)
            {
                TimeExceed.Invoke();
                if (Repeat) image.fillAmount = 0;
            }
        }
    }
}

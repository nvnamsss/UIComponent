using Assets.UI.StatusBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Represent icon determine a status
/// </summary>
public class StatusIcon : Selectable
{
    public enum ShowType
    {
        None,
        Stack,
        Value
    }

    public ShowType ShowMethod;
    public Event Hover;
    public string Tooltip;
    //Border cannot determine the effect
    public Border Border;
    public override void OnPointerEnter(PointerEventData eventData)
    {
        base.OnPointerEnter(eventData);
        Debug.Log("Entering");
    }

    protected override void OnValidate()
    {
        base.OnValidate();
    }

    public static StatusIcon Create(GameObject go, string tooltip)
    {
        GameObject g = Instantiate(go);
        StatusIcon s = g.AddComponent<StatusIcon>();

        return s;
    }
}

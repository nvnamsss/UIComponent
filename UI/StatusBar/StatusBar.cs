using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusBar : Selectable
{
    private List<StatusIcon> icons;
    StatusBar()
    {
        icons = new List<StatusIcon>();
    }

    public void AddIcon(StatusIcon icon)
    {
        icons.Add(icon);
    }

    public void RemoveIcon(StatusIcon icon)
    {
        icons.Remove(icon);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static StatusBar Create()
    {
        GameObject cv = new GameObject();
        Canvas canvas = cv.AddComponent<Canvas>();
        CanvasScaler cvScaler = cv.AddComponent<CanvasScaler>();
        GraphicRaycaster raycaster = cv.AddComponent<GraphicRaycaster>();
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        GameObject go = new GameObject();
        StatusBar s = go.AddComponent<StatusBar>();

        go.transform.SetParent(cv.transform);

        return s;
    }
}

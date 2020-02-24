using Assets.Hierachy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[ExecuteAlways]
public class UIHierachy : Selectable
{
    class ClickEvent : UnityEvent<UIHierachy>
    {

    }
    /// <summary>
    /// distance by height from upper node to lower node
    /// </summary>
    public static int Height = 100;
    /// <summary>
    /// distance by width from parent node to children node
    /// </summary>
    public static int Width = 50;
    public string Content => Data.Value;
    public UnityEvent<UIHierachy> Click;
    public HierachyData Data
    {
        get => data;
        set => data = value;
    }
    [SerializeField]
    private HierachyData data;
    UIHierachy()
    {
    }

    private void Awake()
    {
        targetGraphic = gameObject.GetComponent<Graphic>();
        
        //if (Data == null)
        //{
        //    Data = new HierachyData("a");
        //    Data.View = this;
        //    if (gameObject.transform.parent != null)
        //    {
        //        UIHierachy p = gameObject.transform.parent.GetComponent<UIHierachy>();
        //        p?.Data.Add(Data);
        //    }
        //}

        //gameObject.transform.SetParent(Data.Parent.View.transform);
    }

    private void Start()
    {
        Click = new ClickEvent();
        Click.AddListener((s) =>
        {
            HierachyData node1 = new HierachyData("node");
            Data.Add(node1);
            UIHierachy view1 = UIHierachy.Create(node1);
        });
        if (Data.Parent != null)
        {
            gameObject.transform.SetParent(Data.Parent.View.transform);
        }
        Debug.Log("Hi mom");
        Align();
    }

    public override void OnSelect(BaseEventData eventData)
    {
        base.OnSelect(eventData);
        Click.Invoke(this);
    }
    public override void Select()
    {
        base.Select();
    }
    private void Align()
    {
        if (Data.Parent == null) return;
        Vector3 parentLocation = gameObject.transform.parent.position;
        float px = (Mathf.Abs(parentLocation.x) + Width);
        float py = (Mathf.Abs(parentLocation.y) - Height * Data.Order);
        gameObject.transform.position = new Vector3(px, py, 0);
    }

    public static UIHierachy Create(HierachyData data)
    {
        GameObject go = Resources.Load<GameObject>("HierachyBase");
        GameObject clone = Instantiate(go);
        UIHierachy view = clone.AddComponent<UIHierachy>();
        view.Data = data;
        data.View = view;

        return view;
    }
}

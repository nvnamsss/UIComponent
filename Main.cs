using Assets.Hierachy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        HierachyData root = new HierachyData("root");
        UIHierachy view = UIHierachy.Create(root);
        Debug.Log("Hi mom2");
        view.transform.SetParent(canvas.transform);
        view.name = root.Value;

        HierachyData node1 = new HierachyData("node1");
        root.Add(node1);
        UIHierachy view1 = UIHierachy.Create(node1);
        view1.name = node1.Value;

        HierachyData node2 = new HierachyData("node2");
        root.Add(node2);
        UIHierachy view2 = UIHierachy.Create(node2);
        view2.name = node2.Value;
        HierachyData node21 = new HierachyData("node21");
        node2.Add(node21);
        UIHierachy view21 = UIHierachy.Create(node21);
        view21.name = node21.Value;

        HierachyData node3 = new HierachyData("node3");
        root.Add(node3);
        UIHierachy view3 = UIHierachy.Create(node3);
        view3.name = node3.Value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

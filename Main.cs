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
        HierachyData node1 = new HierachyData("root");
        root.Add(node1);
        UIHierachy view1 = UIHierachy.Create(node1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

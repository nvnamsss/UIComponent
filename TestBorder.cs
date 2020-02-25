using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestBorder : MonoBehaviour
{
    public Image image;
    public float time = 2;
    // Start is called before the first frame update
    void Start()
    {
        image.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        image.fillAmount += Time.deltaTime / time;
    }
}

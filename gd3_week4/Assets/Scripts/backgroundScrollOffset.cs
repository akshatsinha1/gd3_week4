using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScrollOffset : MonoBehaviour
{
    public float scrollSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<MeshRenderer>().material.mainTextureOffset = new Vector2(Time.time * scrollSpeed,0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    // Start is called before the first frame update
    Material bgmtrl;
    public bool scroll = true;
    public float speed;
    void Awake()
    {
        bgmtrl = GetComponent<Renderer>().material;
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (scroll)
        {
            Vector2 offset = new Vector2(speed * Time.time, 0);
            bgmtrl.mainTextureOffset = offset;
        }
    }
}

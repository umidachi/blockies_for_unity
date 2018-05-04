﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setIdentIcon : MonoBehaviour {


    public void set_texture(string address)
    {
        //identiconの実装           
        Identicon icon = new Identicon(address, 8);
        Texture2D texture = icon.GetBitmap(16);
        GetComponent<Renderer>().material.mainTexture = texture;
        texture.Apply();

    }
    
}

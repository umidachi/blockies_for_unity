using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample : MonoBehaviour {

    private void Start()
    {
       set_texture("0xdcc47176a2afee39dbf175e22e46a8de38fd0524");
    }

    public void set_texture(string address)
    {
        //identiconの実装           
        Identicon icon = new Identicon(address, 8);
        Texture2D texture = icon.GetBitmap(16);
        GetComponent<Renderer>().material.mainTexture = texture;
        texture.Apply();

    }
    
}

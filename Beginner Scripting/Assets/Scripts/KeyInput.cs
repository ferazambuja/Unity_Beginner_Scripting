using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    public UI.Image graphic;
    public Texture2D standard;
    public Texture2D downgfx;
    public Texture2D upgfx;
    public Texture2D heldgfx;
    // Start is called before the first frame update
    void Start()
    {
        graphic.texture = standard;
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);
        
        if(down)
        {
            graphic.texture = downgfx;
        }
        else if(held)
        {
            graphic.texture = heldgfx;
        }
        else if(up)
        {
            graphic.texture = upgfx;
        }
        else
        {
            graphic.texture = standard; 
        }
        
        guiText.text = " " + down + "\n " + held + "\n " + up;
    }
}

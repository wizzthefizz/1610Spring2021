using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;

public class KeyInput : MonoBehaviour
{
    public Image graphic;
    public Texture2D standard;
    public Texture2D downgfx;
    public Texture2D upgfx;
    public Texture2D heldgfx;
    
    void Start()
    {
        graphic.image = standard;
    }
    
    void Update ()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);
        
        if(down)
        {
            graphic.image = downgfx;
        }
        else if(held)
        {
            graphic.image = heldgfx;
        }
        else if(up)
        {
            graphic.image = upgfx;
        }
        else
        {
            graphic.image = standard; 
        }
        
        Debug.Log(" " + down + "\n " + held + "\n " + up);
    }
}

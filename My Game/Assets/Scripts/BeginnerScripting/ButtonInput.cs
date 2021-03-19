using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonInput : MonoBehaviour
{
    public Image graphic;
    public Texture2D standard;
    public Texture2D downgfx;
    public Texture2D upgfx;
    public Texture2D heldgfx;
    
    void Start()
    {
        graphic.mainTexture= standard;
    }
    
    void Update ()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");
        
        if(down)
        {
            graphic.mainTexture = downgfx;
        }
        else if(held)
        {
            graphic.mainTexture = heldgfx;
        }
        else if(up)
        {
            graphic.mainTexture = upgfx;
        }
        else
        {
            graphic.mainTexture = standard;
        }
    
        Image.text = " " + down + "\n " + held + "\n " + up;
    }
}

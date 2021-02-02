using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string[4];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
        strings[3] = "Fourth string";

        foreach (string item in strings)
        {
            print(item);
        }
    }
    
    

   
}

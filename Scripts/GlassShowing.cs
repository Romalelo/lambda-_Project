using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class GlassShowing : MonoBehaviour
{
    public GameObject glassText;
    public bool showed=false;

    void OnMouseDown()
    {
        glassText.SetActive(false);

        if (!showed)
        {
            glassText.SetActive(true);
            showed = true;
            print("tap");
        }
        else
        {
            glassText.SetActive(false);
            showed = false;
        }
    }
}

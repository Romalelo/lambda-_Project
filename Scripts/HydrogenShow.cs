using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrogenShow : MonoBehaviour
{
    public GameObject protonTxt, electronTxt;

    private bool showed = false;

    void OnMouseDown()
    {
        protonTxt.SetActive(false);
        electronTxt.SetActive(false);

        switch (gameObject.name)
        {
            case "Proton":
                if (!showed)
                {
                    protonTxt.SetActive(true);
                    showed = true;
                }
                else
                {
                    protonTxt.SetActive(false);
                    showed = false;
                }
                break;
            case "Electron":
                if (!showed)
                {
                    electronTxt.SetActive(true);
                    showed = true;
                }
                else
                {
                    electronTxt.SetActive(false);
                    showed = false;
                }
                break;
        }
    }
}

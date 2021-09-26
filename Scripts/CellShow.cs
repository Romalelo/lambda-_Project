using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellShow : MonoBehaviour
{
    public GameObject membraneTxt, coreTxt, mytoTxt;

    private bool showed = false;

    void OnMouseDown()
    {
        coreTxt.SetActive(false);
        membraneTxt.SetActive(false);
        mytoTxt.SetActive(false);

        switch (gameObject.name)
        {
            case "Membrane":
                if (!showed)
                {
                    membraneTxt.SetActive(true);
                    showed = true;
                }
                else
                {
                    membraneTxt.SetActive(false);
                    showed = false;
                }
                break;
            case "Myto":
                if (!showed)
                {
                    mytoTxt.SetActive(true);
                    showed = true;
                }
                else
                {
                    mytoTxt.SetActive(false);
                    showed = false;
                }
                break;
            case "Core":
                if (!showed)
                {
                    coreTxt.SetActive(true);
                    showed = true;
                }
                else
                {
                    coreTxt.SetActive(false);
                    showed = false;
                }
                break;
        }
    }
}

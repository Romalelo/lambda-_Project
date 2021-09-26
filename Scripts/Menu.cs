using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void MenuOpen()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuClose()
    {
        SceneManager.LoadScene(0);
    }

    public void AccountOpen()
    {
        SceneManager.LoadScene(2);
    }

    public void AccountClose()
    {
        SceneManager.LoadScene(0);
    }

    public void VkOpen()
    {
        Application.OpenURL("https://vk.com/romalelo");
    }

    public void BiologyOpen()
    {
        SceneManager.LoadScene(3);
    }

    public void ChemistryOpen()
    {
        SceneManager.LoadScene(7);
    }

    public void PhysicsOpen()
    {
        SceneManager.LoadScene(6);
    }

    public void Hydrogen2Open()
    {
        SceneManager.LoadScene(8);
    }

    public void PhysicsTaskOpen()
    {
        SceneManager.LoadScene(9);
    }

    public void MicroscopeOpen()
    {
        SceneManager.LoadScene(4);
    }

    public void MicroscopeClose()
    {
        SceneManager.LoadScene(3);
    }

    public void CellOpen()
    {
        SceneManager.LoadScene(5);
    }

    public void CellClose()
    {
        SceneManager.LoadScene(3);
    }
}

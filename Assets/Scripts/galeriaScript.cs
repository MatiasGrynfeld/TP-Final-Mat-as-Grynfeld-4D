using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class galeriaScript : MonoBehaviour
{
    public objetoScript[] objetos;
    int index = -1;

    void Start()
    {
        deactivateAll();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            activateNext();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            activatePrevious();
        }
    }
    
    void deactivateAll()
    {
        foreach(objetoScript objeto in objetos)
        {
            objeto.gameObject.SetActive(false);
        }
    }

    void activateNext()
    {
        deactivateAll();
        index++;
        if (index == objetos.Length)
        {
            index = 0;
        }
        objetos[index].gameObject.SetActive(true);
    }
    void activatePrevious()
    {
        deactivateAll();
        index--;
        if (index < 0)
        {
            index = objetos.Length-1;
        }
        objetos[index].gameObject.SetActive(true);
    }

}

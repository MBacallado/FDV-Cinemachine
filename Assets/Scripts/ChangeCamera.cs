using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject[] cameras;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            this.ChangeCameraPosition();
        }
        
    }

    void ChangeCameraPosition()
    {
        cameras[index].SetActive(false);

        if( index == cameras.Length-1)
        {
            index = 0;
        } else
        {
            index++;
        }

        cameras[index].SetActive(true);
    }
}

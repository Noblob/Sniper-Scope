using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeScript : MonoBehaviour
{
    public GameObject ZoomedScope;
    public GameObject Sniper;
    public GameObject ScopeImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            ZoomIn();
        }
        
        if(Input.GetMouseButtonUp(1))
        {
            ZoomOut();
        }
    }

    void ZoomIn()
    {
        Sniper.SetActive(false);
        ScopeImage.SetActive(true);
        ZoomedScope.SetActive(true);
    }

    void ZoomOut()
    {
        Sniper.SetActive(true);
        ScopeImage.SetActive(false);
        ZoomedScope.SetActive(false);
    }
}

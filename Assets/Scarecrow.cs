using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scarecrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.InvokeDelayed(() =>
        {
            this.Deactivate();
        }, 2f);
        
        
        
        // Invoke("DeactivateDelayed", 2f);
    }

    // private void DeactivateDelayed()
    // {
    //     this.Deactivate();
    // }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Deactivate();
        }
    }
}

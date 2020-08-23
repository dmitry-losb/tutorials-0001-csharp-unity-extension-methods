using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campfire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.InvokeDelayed(() =>
        {
            this.Deactivate();
        }, 2f);

        // StartCoroutine(DeactivateDelayed(2f));
    }

    // private IEnumerator DeactivateDelayed(float delay)
    // {
    //     yield return new WaitForSeconds(delay);
    //     
    //     this.Deactivate();
    // }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            this.Deactivate();
        }
    }
}

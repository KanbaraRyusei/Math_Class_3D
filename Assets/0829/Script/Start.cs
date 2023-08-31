using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    private void Awake()
    {
        transform.position = new Vector3(-8f, 5f, Random.value * 2f - 1f);
    }

    private void Update()
    {
        if(transform.position.x > 10f)
        {
            // â∫Ç…óéÇøÇÈÇ∆è„Ç…ñﬂÇÈ
            transform.position = new Vector3(-8f, 5f, transform.position.z);
        }
    }
}

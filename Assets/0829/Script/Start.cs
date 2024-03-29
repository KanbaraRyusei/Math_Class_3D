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
            // 下に落ちると上に戻る
            transform.position = new Vector3(-8f, 5f, transform.position.z);
        }
    }
}

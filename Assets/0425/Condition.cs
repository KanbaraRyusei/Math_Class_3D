using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    [SerializeField]
    private byte _initialData = 0b0000_0000;

    [SerializeField]
    private byte _poison = 0b0000_0001;

    [SerializeField]
    private byte _paralysis = 0b0000_0010;

    [SerializeField]
    private byte _sleep = 0b0000_0100;

    [SerializeField]
    private byte _silence = 0b0000_1000;

    private byte _player;

    private void Start()
    {
        _player = _initialData;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            _player |= _poison;
            Debug.Log("Poison => Condition" + System.Convert.ToString(_player, 2).PadLeft(4, '0'));
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            _player |= _paralysis;
            Debug.Log("Paralysis => Condition" + System.Convert.ToString(_player, 2).PadLeft(4, '0'));
        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            _player |= _sleep;
            Debug.Log("Sleep => Condition" + System.Convert.ToString(_player, 2).PadLeft(4, '0'));
        }

        if(Input.GetKeyDown(KeyCode.T))
        {
            _player |= _silence;
            Debug.Log("Silence => Condition" + System.Convert.ToString(_player, 2).PadLeft(4, '0'));
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            _player = _initialData;
            Debug.Log("InitialData => Condition" + System.Convert.ToString(_player, 2).PadLeft(4, '0'));
        }
    }
}

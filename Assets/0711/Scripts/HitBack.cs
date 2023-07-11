using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBack : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;

    [SerializeField]
    private Vector3 _triVec0;

    [SerializeField]
    private Vector3 _triVec1;

    [SerializeField]
    private Vector3 _triVec2;

    [SerializeField]
    private float _cross0;

    [SerializeField]
    private float _cross1;

    [SerializeField]
    private float _cross2;

    [SerializeField]
    private bool _hit = false;

    [SerializeField]
    private Vector3 _memo;

    private Vector3 _pos0 = new Vector3(0f, 0f, 9f);
    private Vector3 _pos1 = new Vector3(5f, 0f, -7f);
    private Vector3 _pos2 = new Vector3(-3f, 0f, -5f);

    private void Start()
    {
        _triVec0 = (_pos1 - _pos0).normalized;
        _triVec1 = (_pos2 - _pos1).normalized;
        _triVec2 = (_pos0 - _pos2).normalized;
    }

    private void Update()
    {
        Vector3 playerPos = _player.transform.position;

        Vector3 hitVec0 = playerPos - _pos0;
        Vector3 hitVec1 = playerPos - _pos1;
        Vector3 hitVec2 = playerPos - _pos2;

        _cross0 = _triVec0.z * hitVec0.x - _triVec0.x * hitVec0.z;
        _cross1 = _triVec1.z * hitVec1.x - _triVec1.x * hitVec1.z;
        _cross2 = _triVec2.z * hitVec2.x - _triVec2.x * hitVec2.z;

        if(_cross0 >= 0f)
        {
            if(_cross1 >= 0f && _cross2 >= 0f)
            {
                transform.position = _memo;
            }
            else
            {
                _memo = playerPos;
            }
        }
        else
        {
            if(_cross1 < 0f && _cross2 < 0f)
            {
                transform.position = _memo;
            }
            else
            {
                _memo = playerPos;
            }
        }
    }
}

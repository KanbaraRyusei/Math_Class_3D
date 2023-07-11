using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitArea : MonoBehaviour
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

    private Vector3 _pos0 = new Vector3(0f, 0f, 9f);
    private Vector3 _pos1 = new Vector3(5f, 0f, -7f);
    private Vector3 _pos2 = new Vector3(-3f, 0f, -5f);

    [SerializeField]
    private float _dot;

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

        if (_cross0 >= 0f)
        {
            if(_cross1 >= 0f && _cross2 >= 0f)
            {
                _hit = true;
            }
            else
            {
                _hit = false;
            }
        }
        else
        {
            if(_cross1 < 0f && _cross2 < 0f)
            {
                _hit = true;
            }
            else
            {
                _hit = false;
            }
        }

        if(_hit)
        {
            if(Mathf.Abs(_cross0) <= Mathf.Abs(_cross1)
                && Mathf.Abs(_cross0) <= Mathf.Abs(_cross2))
            {
                _dot = Vector3.Dot(_triVec0, hitVec0);
                transform.position = new Vector3(
                    _triVec0.x * _dot + _pos0.x,
                    playerPos.y,
                    _triVec0.z * _dot + _pos0.z);
            }
            else
            {
                if(Mathf.Abs(_cross1) <= Mathf.Abs(_cross2))
                {
                    _dot = Vector3.Dot(_triVec1, hitVec1);
                    transform.position = new Vector3(
                        _triVec1.x * _dot + _pos1.x,
                        playerPos.y,
                        _triVec1.z * _dot + _pos1.z);
                }
                else
                {
                    _dot = Vector3.Dot(_triVec2, hitVec2);
                    transform.position = new Vector3(
                        _triVec2.x * _dot + _pos2.x,
                        playerPos.y,
                        _triVec2.z * _dot + _pos2.z);
                }
                
            }
        }
    }
}

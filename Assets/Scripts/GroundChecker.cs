using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private Transform _point;
    [SerializeField] private int _radius;
    [SerializeField] private LayerMask _whatIsGround;

    public bool CheckGround()
    {
        return Physics2D.OverlapCircle(_point.position, _radius, _whatIsGround);
    }
} 
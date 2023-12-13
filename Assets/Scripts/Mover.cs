using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 10; 
    
    public void Move(Vector3 dir) {
        transform.position += _speed * Time.deltaTime * dir;
    }
}

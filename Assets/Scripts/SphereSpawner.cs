using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    [SerializeField] private List<Texture> _textures = new List<Texture>();
    [SerializeField] private float _offset = 2;
    [SerializeField] private GameObject _prefab;

    private void Start()
    {

        var angle = 360.0f / _textures.Count;
        for (int i = 0; i < _textures.Count; i++)
        {
            var pos = Quaternion.Euler(0, angle * i, 0) * Vector3.forward * _offset;
            var sphere = Instantiate(_prefab, pos, Quaternion.identity, transform);
            // sphere.GetComponent<Renderer>().material.SetTexture("_MainTex", _textures[i]);
            sphere.GetComponent<Renderer>().material.SetTexture("_BaseMap", _textures[i]);
            // sphere.GetComponent<Renderer>().material.SetTexture(1, _textures[i]);
            // sphere.GetComponent<Renderer>().material.SetTexture(0, _textures[i]);
            // sphere.GetComponent<Renderer>().material.SetColor("_BaseColor", Color.red);
        }
    }


}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class DistanceAction
{
    public float MinDistance;
    public UnityEvent ActivateEvent;
    public UnityEvent DeactivateEvent;
    public bool IsActive { get; set; }

}

public class DistanceTrackre : MonoBehaviour
{
    [SerializeField] private GameObject _one;
    [SerializeField] private GameObject _two;
    [SerializeField] private List<DistanceAction> _actions;
    private float _distance;

    private void Update()
    {
        _distance = Vector3.Distance(_one.transform.position, _two.transform.position);
        foreach (var action in _actions)
        {
            if (_distance < action.MinDistance)
            {
                if (!action.IsActive)
                {
                    action.ActivateEvent?.Invoke();
                    action.IsActive = true;
                }
            }
            else
            {
                if (action.IsActive)
                {
                    action.DeactivateEvent?.Invoke();
                    action.IsActive = false;
                }
            }
        }
    }


    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 20), $"Distance: {_distance}");
    }
}

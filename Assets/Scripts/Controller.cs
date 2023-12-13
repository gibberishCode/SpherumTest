using UnityEngine;
[RequireComponent(typeof(Mover))]
public class Controller : MonoBehaviour
{
    [SerializeField] private KeyCode[] _controlls = new KeyCode[4];
    private Mover _mover;
    
    private void Awake() {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        var dir = Vector3.zero;
        if (Input.GetKey(_controlls[0]))
        {
            dir += new Vector3(0, 0, 1);
        }
        else if (Input.GetKey(_controlls[1]))
        {
            dir -= new Vector3(0, 0, 1);
        }
        if (Input.GetKey(_controlls[2]))
        {
            dir += new Vector3(1, 0, 0);
        }
        else if (Input.GetKey(_controlls[3]))
        {
            dir -= new Vector3(1, 0, 0);
        }
        dir.Normalize();
        _mover.Move(dir);
    }
}
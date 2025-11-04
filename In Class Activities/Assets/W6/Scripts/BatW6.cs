using System.Numerics;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _target;
    bool _enabled = false;
    public void StartChase()
    {
        _enabled = true;
    }

    public void StopChase()
    {
        _enabled = false;
    }

    private void Update()
    {
        if (_enabled)
        {
            transform.position = UnityEngine.Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
        }
    }
}

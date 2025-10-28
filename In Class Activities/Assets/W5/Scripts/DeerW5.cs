using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    [SerializeField] private Transform _target;
    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.SetDestination(_target.position);
    }
}


// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform target; 
    private NavMeshAgent agent;

    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        
        if (target != null)
        {
            
            this.agent.SetDestination(target.position);
        }
    }
}

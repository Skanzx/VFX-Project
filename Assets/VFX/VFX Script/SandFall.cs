using UnityEngine;

public class SandFall : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 10f; // control how "sticky" it is

    void Update()
    {
        if (target != null)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, followSpeed * Time.deltaTime);
        }
    }
}


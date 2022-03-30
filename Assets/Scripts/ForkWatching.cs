using UnityEngine;

public class ForkWatching : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _rotationSpeed = 1f;
    [SerializeField]
    private float _movementSpeed = 1f;
    [SerializeField]
    private float _distance = 10f;

    private void Update()
    {      
        Vector3 directionToFace = _target.position - transform.position;
        Debug.DrawRay(_target.position, directionToFace, Color.red);
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);

        Vector3 targetDistance = _target.position - new Vector3(1, 0, 1) * _distance;
        transform.position = Vector3.Lerp(transform.position, targetDistance, _movementSpeed * Time.deltaTime);
    }
}

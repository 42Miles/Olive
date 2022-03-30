using UnityEngine;

public class ForkMovement : MonoBehaviour
{
    [SerializeField]
    private AnimationCurve _curve;
    [SerializeField]
    Transform _goalPosition;
    [SerializeField]
    Vector3 _currentPosition;
    [SerializeField]
    private float _speed = 0.5f;
    private float _current;
    private float _target = 1f;

    private void Awake()
    {
        _currentPosition = transform.position;
    }

    private void Update()
    {
        if(_current == 0f || _current == 1f)
        {
            _target = _target == 0 ? 1 : 0;
        }

        _current = Mathf.MoveTowards(_current, _target, _speed * Time.deltaTime);

        transform.position = Vector3.Lerp(_currentPosition, _goalPosition.position, _curve.Evaluate(_current));
    }

    private void OnDrawGizmosSelected()
    {
        if (_goalPosition != null)
        {
            // Draws a blue line from this transform to the target
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, _goalPosition.position);
        }
    }
}

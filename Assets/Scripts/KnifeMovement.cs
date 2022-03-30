using UnityEngine;

public class KnifeMovement : MonoBehaviour
{
    [SerializeField]
    private AnimationCurve _curve;
    [SerializeField]
    private Quaternion currentAngle;
    [SerializeField]
    private Quaternion rotationGoal;
    [SerializeField]
    private float _speed = 0.5f;
    [SerializeField]
    private float _current;
    private float _target = 1f;

    private void Awake()
    {
        currentAngle = transform.rotation;
    }

    private void Update()
    {
        if (_current == 1f || _current == 0f)
        {
            _target = _target == 0 ? 1 : 0;
        }

        _current = Mathf.MoveTowards(_current, _target, _speed * Time.deltaTime);

        transform.rotation = Quaternion.Lerp(currentAngle, rotationGoal, _curve.Evaluate(_current));
    }


}

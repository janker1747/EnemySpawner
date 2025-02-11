using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    private Vector3 _moveDirection;

    private void Update()
    {
        transform.position += _moveDirection * _speed * Time.deltaTime;
    }

    public void SetDirection(Vector3 direction)
    {
        _moveDirection = direction.normalized;
    }
}

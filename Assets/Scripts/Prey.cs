using UnityEngine;

public class Prey : MonoBehaviour
{
    [SerializeField] private float _speed = 4f;
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _minDistance = 1f;
    private int _currentWaypointIndex = 0;

    private void Update()
    {
        if (_waypoints.Length == 0)
            return;

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypointIndex].position, _speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, _waypoints[_currentWaypointIndex].position)< _minDistance)
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1 ) % _waypoints.Length;
        }
    }
}

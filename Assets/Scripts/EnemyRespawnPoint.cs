using UnityEngine;

public class EnemyRespawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _spawnRate;
    private float _timer = 0;
    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _spawnRate)
        {
            _timer = 0;
            Instantiate(_enemy, transform.position, transform.rotation);
        }
    }
}

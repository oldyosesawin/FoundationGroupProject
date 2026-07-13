using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Bullet _meteorPrefab;



    [SerializeField] private float _spawnHeight = 6f;
    [SerializeField] private float _spawnHorizontalRange = 8f;

    [SerializeField] private GameObject _player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnMeteor();
        }
    }

    void SpawnMeteor()
    {
        Bullet spawnedMeteor = Instantiate(_meteorPrefab, GetRandomSpawnPosition(), Quaternion.identity);
        spawnedMeteor.StartMoving(_player.transform.position - spawnedMeteor.transform.position);
    }


    Vector3 GetRandomSpawnPosition()
    {
        return new Vector3(
            Random.Range(-_spawnHorizontalRange, _spawnHorizontalRange),
            _spawnHeight,
            0f);
    }

    void SetMovingDirection(Bullet spawnedMeteor)
    {
        int randdomNumber = Random.Range(0, 2);
        if (randdomNumber == 0)
        {
            spawnedMeteor.StartMoving(_player.transform.position - spawnedMeteor.transform.position);
        }
        else
        {
            spawnedMeteor.StartMoving(Vector2.down);
        }
    }
}

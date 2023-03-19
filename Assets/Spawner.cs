using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float nextSpawnTime;
    public float spawnInterval;
    public bool isSpawn;

    private void Update()
    {
        print(Time.time);
        if (Time.time > nextSpawnTime)
        {
            if(isSpawn)
            {
                Spawn();
            }
            else if(Time.time - nextSpawnTime <= 1)
            {
                isSpawn = true;
            }
            nextSpawnTime += spawnInterval;
        }
    }

    void Spawn()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(-1f, 1f);
        var rot = Quaternion.Euler(0, 0, 0); //Quaternion.identity

        Instantiate(prefab, pos, rot);
    }
}

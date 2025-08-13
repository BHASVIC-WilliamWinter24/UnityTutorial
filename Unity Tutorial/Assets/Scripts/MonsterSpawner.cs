using System.Collections;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    [SerializeField]
    private Transform leftPos, rightPos;

    private GameObject spawnedMonster;
    private int randomIndex;
    private int randomSpawn;

    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    void Update()
    {

    }

    IEnumerator SpawnMonsters()
    {
        while (true) // infinte loop
        {
            yield return new WaitForSeconds(Random.Range(1, 5)); // calls in random intervals from one to five
            randomIndex = Random.Range(0, monsterReference.Length); // gets random index from 1 to the last index of the list
            randomSpawn = Random.Range(0, 2);

            spawnedMonster = Instantiate(monsterReference[randomIndex]);

            if (randomSpawn == 0) // left
            {
                spawnedMonster.transform.position = leftPos.position;
                spawnedMonster.GetComponent<Monster>().speed = Random.Range(4, 10); // generate random speed for monster going right
            }
            else //right
            {
                spawnedMonster.transform.position = rightPos.position;
                spawnedMonster.GetComponent<Monster>().speed = -Random.Range(4, 10); // generate random speed for monster going left
                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f); // flips on the X to rotate
            }
        }
    }
}

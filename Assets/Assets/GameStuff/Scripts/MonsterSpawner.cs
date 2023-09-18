using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterRef;

    private GameObject SpawnedMonster;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonster());
    }

    IEnumerator SpawnMonster()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, monsterRef.Length);

            randomSide = Random.Range(0, 2);

            SpawnedMonster = Instantiate(monsterRef[randomIndex]);

            if (randomSide == 0)
            {
                SpawnedMonster.transform.position = new Vector3(leftPos.position.x, leftPos.position.y, 0);
                SpawnedMonster.GetComponent<Monster>().speed = Random.Range(4, 10);
            }
            else
            {
                SpawnedMonster.GetComponent<SpriteRenderer>().flipX = true;
                SpawnedMonster.transform.position = new Vector3(rightPos.position.x, rightPos.position.y, 0);
                SpawnedMonster.GetComponent<Monster>().speed = -Random.Range(7, 10);
            }
        }
    }
}

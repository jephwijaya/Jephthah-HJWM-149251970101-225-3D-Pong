using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerManager : MonoBehaviour
{
    public Transform spawnArea;
    public List<Transform> egoSpawnCoor;
    public int maxBallSpawned, spawnInterval;
    public GameObject ballTemplate;
    private List<GameObject> ballList;

    private float timer;

    private void Start()
    {
        ballList = new List<GameObject>();
        timer = 0;
    }

    private void Update() 
    {
        timer += Time.deltaTime;

        if(timer > spawnInterval)
        {
            SpawnBallOnRandomSpecificCoor();
            timer -= spawnInterval;
        }
    }

    public void SpawnBallOnRandomSpecificCoor()
    {
        int randomIndex = Random.Range(0, egoSpawnCoor.Count);
        SpawnBallOnRandomSpecificCoor(new Vector3(egoSpawnCoor[randomIndex].position.x, egoSpawnCoor[randomIndex].position.y, egoSpawnCoor[randomIndex].position.z), randomIndex);
    }

    public void SpawnBallOnRandomSpecificCoor(Vector3 position, int index)
    {
        if(ballList.Count >= maxBallSpawned)
        {
            return;
        }

        GameObject ball = Instantiate(ballTemplate, new Vector3(position.x, position.y, position.z), Quaternion.identity, spawnArea);

        switch(index+1)
        {
            case 1:
            ball.GetComponent<BallController>().speed = new Vector3(Random.Range(5,15), 0 , Random.Range(-5,-15));
            Debug.Log("1");
            break;

            case 2:
            ball.GetComponent<BallController>().speed = new Vector3(Random.Range(-5,-15), 0 , Random.Range(-5,-15));
            Debug.Log("2");
            break;

            case 3:
            ball.GetComponent<BallController>().speed = new Vector3(-Random.Range(5,15), 0 , Random.Range(5,15));
            Debug.Log("3");
            break;

            case 4:
            ball.GetComponent<BallController>().speed = new Vector3(Random.Range(5,15), 0 , Random.Range(5,15));
            Debug.Log("4");
            break;
        }
        
        ball.SetActive(true);

        ballList.Add(ball);
    }

    public void RemoveBall(GameObject ball)
    {
        ballList.Remove(ball);
        Destroy(ball);
    }
}

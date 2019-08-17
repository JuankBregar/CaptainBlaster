using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text gameOver;
    public int userScore = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addScore(int score =1)
    {
        userScore+=score;
        scoreText.text = userScore.ToString();
    }

    public void playerDied()
    {
        gameOver.enabled = true;
        //Time.timeScale = 0;
    }

    public void CollisionDestroy(GameObject meteor, GameObject prefab)
    {
        Instantiate(prefab, meteor.transform.position, transform.rotation = Quaternion.identity);
        Destroy(meteor.gameObject);
    }

    public void CollisionDestroy(GameObject meteor, GameObject prefab, GameObject chunks)
    {
        Instantiate(prefab, meteor.transform.position, transform.rotation = Quaternion.identity);
        //Instantiate chunks radial
        Vector3 pos1 = meteor.transform.position;
        pos1.y -= 0.1f;

        chunks.GetComponent<MeteorMV>().maxYSpeed = -6;

        chunks.GetComponent<MeteorMV>().xSpeed = -6;
        Instantiate(chunks, pos1, Quaternion.identity);
        chunks.GetComponent<MeteorMV>().xSpeed = -3;
        Instantiate(chunks, pos1, Quaternion.identity);
        chunks.GetComponent<MeteorMV>().xSpeed = 0;
        Instantiate(chunks, pos1, Quaternion.identity);
        chunks.GetComponent<MeteorMV>().xSpeed = 3;
        Instantiate(chunks, pos1, Quaternion.identity);
        chunks.GetComponent<MeteorMV>().xSpeed = 6;
        Instantiate(chunks, pos1, Quaternion.identity);

        chunks.GetComponent<MeteorMV>().maxYSpeed = 6;
        chunks.GetComponent<MeteorMV>().xSpeed = -6;
        Instantiate(chunks, meteor.transform.position, Quaternion.identity);
        chunks.GetComponent<MeteorMV>().xSpeed = -3;
        Instantiate(chunks, meteor.transform.position, Quaternion.identity);
        chunks.GetComponent<MeteorMV>().xSpeed = 0;
        Instantiate(chunks, meteor.transform.position, Quaternion.identity);
        chunks.GetComponent<MeteorMV>().xSpeed = 3;
        Instantiate(chunks, meteor.transform.position, Quaternion.identity);
        chunks.GetComponent<MeteorMV>().xSpeed = 6;
        Instantiate(chunks, meteor.transform.position, Quaternion.identity);

        Instantiate(chunks, meteor.transform.position, Quaternion.identity);


        Destroy(meteor.gameObject);
    }
}
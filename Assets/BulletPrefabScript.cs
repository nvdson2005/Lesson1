using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletPrefabScript : MonoBehaviour
{
    private float timeCheck = 0f;
    [SerializeField] float BulletSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCheck += Time.deltaTime;
        Debug.Log(PlayerPrefs.GetFloat("ScoreFloat"));
        if(PlayerPrefs.GetFloat("ScoreFloat") > 30f)
        {
            BulletSpeed = 0.125f;
        }
        if (PlayerPrefs.GetFloat("ScoreFloat") > 60f)
        {
            BulletSpeed = 0.15f;
        }
        //Vector2 newPos = transform.position + new Vector3(transform.position.x,0f)* BulletSpeed*Time.deltaTime;
        Vector2 newPos = transform.position + transform.right * BulletSpeed;
        transform.position = newPos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("EndGameScene");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;

    public Vector3 spawnPoint;

    public string respawnLevelName;

    private void Start()
    {
        spawnPoint = transform.position;
    }


    void Update()
    {
        Vector3 moveDirection = new Vector3();
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.z = Input.GetAxisRaw("Vertical");


        GetComponent<Rigidbody>().velocity = moveDirection * speed;

        transform.forward = -moveDirection;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Enemy>() != null || collision.gameObject.GetComponent<EnemyRotate>() != null)
        {
            //transform.position = spawnPoint;  new Vector3(0,0,0)

            SceneManager.LoadScene(respawnLevelName);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20;
    private PlayerController playerController;
    private float leftBound = -13f;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.gameOver.Equals(false))
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (gameObject.CompareTag("Obstacle") && transform.position.x < leftBound)
            Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y <= -25  || transform.position.y >= 18 || transform.position.x >= 3.2 || transform.position.x <= -3.2)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Defends")
        {
            SceneManager.LoadScene(0);
        }
    }

}

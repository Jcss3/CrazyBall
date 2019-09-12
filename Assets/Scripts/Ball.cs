using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float speed;
    // codigo do sorteiopara ter o movimento da bola aleatorio
    //float sorteioX;
    //float sorteioY;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;

        //sorteioX = Random.Range(0, 10);
        //sorteioY = Random.Range(0.02f, -0.02f);

        //if (sorteioX < 5)
       // {
       //     GetComponent<Rigidbody2D>().AddForce(new Vector2(0.05f, sorteioY));
       // }
       // else {
       //     GetComponent<Rigidbody2D>().AddForce(new Vector2(-0.05f, sorteioY));
       // }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D barra)
    {
       // while (Score.score < 100)
       // {
            if (barra.gameObject.tag == "Barra")
            {
                Score.score++;
                Debug.Log("Score: " + Score.score);
            }
        //}

       // SceneManager.LoadScene("game_2Fase");
    }

}

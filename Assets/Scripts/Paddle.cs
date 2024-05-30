using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 7f;  //paddle speed
    [SerializeField] private bool isPaddle1;
    private float yBound = 3.75f; // limit y movement of the paddles
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement;
        if (isPaddle1)
        {
            movement = Input.GetAxisRaw("Vertical");
        } else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        //Clamping the movement of the paddle
        Vector2 paddlePosition = transform.position;
        paddlePosition.y = Mathf.Clamp(paddlePosition.y + movement * speed * Time.deltaTime, -yBound, yBound);
        transform.position = paddlePosition;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public float MovementSpeed = 5;
    public float HrzInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HrzInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right * HrzInput * MovementSpeed * Time.deltaTime);
    }
}

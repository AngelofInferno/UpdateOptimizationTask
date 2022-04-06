using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    Vector3 velocity;
    float sides = 30.0f;
    float speedMax = 0.3f;
    private static readonly int Color1 = Shader.PropertyToID("_Color");
    private Material _material;

    void Start()
    {
        velocity = new Vector3(Random.Range(0.0f, speedMax),
                        Random.Range(0.0f, speedMax),
                        Random.Range(0.0f, speedMax));
        _material = GetComponent<Renderer>().material;

    }

    Color GetRandomColor()
    {
        return new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity);
        
        

        if (transform.position.x > sides || transform.position.x < -sides)
        {
            velocity.x = -velocity.x;
        }
        if (transform.position.y > sides || transform.position.y < -sides)
        {
            velocity.y = -velocity.y;
        }
        if (transform.position.z > sides || transform.position.z < -sides)
        {
            velocity.z = -velocity.z;
        }

        _material.SetColor(Color1, new Color(transform.position.x/sides,
                                                                             transform.position.y/sides,
                                                                           transform.position.z/sides));

    }
}

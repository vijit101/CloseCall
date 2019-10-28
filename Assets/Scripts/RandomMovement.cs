using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float minx, maxx, miny, maxy;
    Vector2 targetPosition;
    public float speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = GetRandomPos();
    }

    // Update is called once per frame
    void Update()
    {
        if((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            targetPosition = GetRandomPos();
        }
        
    }

    Vector2 GetRandomPos()
    {
        float x = Random.Range(minx, maxx);
        float y = Random.Range(miny, maxy);
        return new Vector2(x,y);
    }
}

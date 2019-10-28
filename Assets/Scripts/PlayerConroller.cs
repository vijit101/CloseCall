using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class PlayerConroller : MonoBehaviour
{
    bool movePlanet;
    Collider2D PlanetCollider;
    // Start is called before the first frame update
    void Start()
    {
        PlanetCollider = gameObject.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch0 = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch0.position);
            if (touch0.phase == TouchPhase.Began)
            {
                Collider2D collidedWith = Physics2D.OverlapPoint(touchPos);
                if (PlanetCollider == collidedWith)
                {
                    movePlanet = true;
                }
            }
            if (touch0.phase == TouchPhase.Moved)
            {
                if (movePlanet)
                {
                    transform.position = new Vector2(touchPos.x, touchPos.y);
                }
            }
            if (touch0.phase == TouchPhase.Ended)
            {
                movePlanet = false;
            }
        }
    }
}

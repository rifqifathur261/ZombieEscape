using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    private Rigidbody2D rb;
    public float stoppingDistance;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        //target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        // Debug.Log("direction "+ direction);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

        //majuin musuh ke player
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);     
    }
}

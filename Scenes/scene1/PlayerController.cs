using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour {

    public float speed = 5f;
    private Vector3 target;
    public Object map;

    void Start()
    {
        target = transform.position;   
    }

    void Update()
    {
       if (Input.GetMouseButtonDown(0) && map.name == "ground")
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;

        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class moving : MonoBehaviour
{

    public Transform wayPoints;
    public Transform detal;
    public float speed = 1.0f;

    public bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SetRotation(Vector3 lookAt)
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            var step = speed * Time.deltaTime;
            detal.position = Vector3.MoveTowards(detal.position, wayPoints.position, step);
        }
        if (Vector3.Distance(detal.position, wayPoints.position) < 0.001f)
        {
            flag = false;
        }

    }

    public void flagswap()
    {
        flag = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeController : MonoBehaviour
{
    public Settings settings;
    public Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update() {
        //Time.timeScale = settings.timestep;
        float x = gameObject.transform.position.x;

        //gameObject.transform.position = new Vector3(x + -settings.speed * Time.deltaTime,0,0);//AddForce(Vector3.right * 2 * Time.deltaTime);
    }

}

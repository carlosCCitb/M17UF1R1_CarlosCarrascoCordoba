using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed = 3f;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //velocitat (en el start, la velocitat es manté sempre que no hi hagi col·lisions)
        /*_rb.velocity.x = speed; //_rb.velocity només té un getter, no setter
        _rb.velocity = new Vector2(speed, _rb.velocity.y);
        //acceleració
        _rb.AddForce(new Vector2(speed, 0));
        _rb.AddForce(new Vector2(speed, 9), ForceMode2D.Impulse);//pots triar forceMode*/
    }
    private void Update()
    {
        //canvi de posició
        /*if (Input.GetKey(KeyCode.D))
            transform.position = transform.position + new Vector3(speed*0.002f, 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.position = transform.position + new Vector3(speed, 0,0) * Time.deltaTime;
        //Canvi de velocitat
        if (Input.GetKey(KeyCode.D))
            _rb.velocity = new Vector3(speed, 0, 0);
        //força o acceleració
         if (Input.GetKey(KeyCode.D))
             _rb.AddForce(new Vector3(speed, 0, 0));
        //salt amb força
         if (Input.GetKey(KeyCode.D))
             _rb.AddForce(new Vector3(0, speed, 0));
        if (Input.GetKeyDown(KeyCode.D))
            _rb.AddForce(new Vector3(0, speed*200, 0));*/
        //salt amb velocitat
        if (Input.GetKeyDown(KeyCode.D))
            _rb.velocity = new Vector3(0, speed*4, 0);
    }
}

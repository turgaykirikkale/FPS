using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public float speed = 10f;
    public float jump = 250f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))

        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.A))

        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.S))

        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.D))

        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }

        if (Input.GetKeyDown(KeyCode.Space))

        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jump);

        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Find("Camera").transform.localPosition = new Vector3(0, 0, 0);
        }else
        {
            transform.Find("Camera").transform.localPosition = new Vector3(0, 0.7f, 0);
        }

    }
}

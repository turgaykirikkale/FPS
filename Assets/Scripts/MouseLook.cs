using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    float turnSpeed = 4f;
    public static bool closed = true;
    public static float x = 2f, y = 2f;
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);
        Invoke(nameof(OpenIt), 0.5f); //burası biraz daha geç çalışmasını sağlıyor.
    }

    void OpenIt()
    {
        closed = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (!closed)
        {
            x += turnSpeed * Input.GetAxis("Mouse X");
            y -= turnSpeed * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(y, x, 0.0f);
        }
    }
}

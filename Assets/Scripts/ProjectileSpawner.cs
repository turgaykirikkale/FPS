using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject ballPrefab;
    // Update is called once per frame
    void Update()
    {
        GameObject ball = Instantiate(ballPrefab, ballPrefab.transform.position, Quaternion.identity);

    }
}

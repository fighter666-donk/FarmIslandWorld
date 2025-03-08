using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public float speed = 3;
    private void Awake()
    {
        float y = Random.Range(-3, 3);
        this.transform.localPosition = new Vector3(0, y, 0);
    }
    void Update()
    {
        this.transform.position += new Vector3(-speed, 0) * Time.deltaTime;
        DestroyPipe();
    }
    private void DestroyPipe()
    {
        Destroy(gameObject, 5f);
    }
}

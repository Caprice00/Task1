using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject plane;
    public GameObject Spawnhere;
    public GameObject player;
    private GameObject go;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("insideIsTrigger");
        if(col.gameObject.tag == "Player")

        {
            Debug.Log("insideIF");
            go = Instantiate(plane, Spawnhere.transform.position, Quaternion.identity);
            Destroy(go, 3f);
        }
    }
}

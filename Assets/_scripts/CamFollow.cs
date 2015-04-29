using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour
{

    public GameObject target;

    // Use this for initialization
    void Start()
    {
        this.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, this.transform.position.z);
    }
}
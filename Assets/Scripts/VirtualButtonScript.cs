using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject bullet;
    [SerializeField]
    private float speed = 100f;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Hello World");
        GameObject tempBullet = Instantiate(bullet, bullet.transform.position, Quaternion.identity);
        tempBullet.transform.parent = null;
        tempBullet.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        tempBullet.transform.localScale = new Vector3(.01f, .5f, .01f);
        tempBullet.SetActive(true);
        tempBullet.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }

    void Start()
    {
        gameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
}

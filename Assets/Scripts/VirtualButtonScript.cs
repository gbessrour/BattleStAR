using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject bullet;
    [SerializeField]
    private float speed = 50f;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Hello World");
        GameObject tempBullet = Instantiate(bullet, bullet.transform.position, Quaternion.identity);
        tempBullet.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        tempBullet.transform.localScale = new Vector3(.01f, .2f, .02f);
        tempBullet.SetActive(true);
        tempBullet.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }

    private void OnVuforiaStarted()
    {
        CameraDevice.Instance.SetFocusMode(
            CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    private void OnPaused(bool paused)
    {
        if (!paused) // resumed
        {
            // Set again autofocus mode when app is resumed
            CameraDevice.Instance.SetFocusMode(
                CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }

    void Start()
    {
        gameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        var vuforia = VuforiaARController.Instance;
        vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);
        vuforia.RegisterOnPauseCallback(OnPaused);
    }
    void Update()
    {
        GameObject tempBullet = Instantiate(bullet, bullet.transform.position, Quaternion.identity);
        tempBullet.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript1 : MonoBehaviour
{
    public Slider slider;
    private float health = 0f;
    int counter = 0;
    bool victory = false;
    private void OnCollisionEnter(Collision collision)
    {
        while (counter < 3)
        {
            if (collision.collider.tag == "Bullet")
            {
                Destroy(collision.gameObject);
                health += .1f;
                slider.value = health;
                counter++;
            }
        }
        victory = true;
        SceneManager.LoadScene(0);
    }

}

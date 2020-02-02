using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResistanceScript : MonoBehaviour
{
    public Slider slider;
    private float health = 0f;
    public int counter = 0;
   // bool victory = false;
   // public GameObject explosionEffect;
   // public EmpireScript other; // just realized this will only work if we strictly do empire vs resistance. We should add object tags and use that instead

    private void OnCollisionEnter(Collision collision)
    {
        //while (counter < 3)
        //{
            if (collision.collider.tag == "Bullet")
            {
                Destroy(collision.gameObject);
                health += .1f;
                slider.value = health;
                if (this.health >= 1)
                {
                    Debug.Log("Hello");
                    //Destroy(this.gameObject);
                    this.gameObject.SetActive(false);
                }
            }
            
                //other.counter++;
        //}
        //victory = true;
    }
    //void Explode()
    //{
    //    var exp = GetComponent<ParticleSystem>();
    //    exp.Play();
    //    Destroy(gameObject, exp.duration);
    //}
}

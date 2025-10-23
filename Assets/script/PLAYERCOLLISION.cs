using Unity.VisualScripting;
using UnityEngine;

public class PLAYERCOLLISION : MonoBehaviour
{
    public playerscript playerscript;
    public score score;
    public gamecontroller gamecontroller;
    public AudioSource audioSource;
    public AudioSource audiosource1;

    public void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "collectable")
        {
            audioSource.Play();
            score.addscore(1);  
            Destroy(other.gameObject);
        }
    }

     
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag =="obstacles")
        {
            audiosource1.Play();
            gamecontroller.gameover();
            playerscript.enabled = false;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeAPicture : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject flashSprite;
    public GameObject message;
    public GameObject success;
    public string NextScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            FlashScreen();
            if (IsTouching(object1, object2)){
                SceneManager.LoadScene(NextScene);
            }
            else{
                NotQuite();
            }

        }
    }

    bool IsTouching(GameObject obj1, GameObject obj2)
    {
        // Check if collider attached to obj1 is touching collider attached to obj2
        return obj1.GetComponent<Collider2D>().IsTouching(obj2.GetComponent<Collider2D>());
    }

    void FlashScreen()
    {
        flashSprite.SetActive(true);
        Invoke("DisableFlash", 0.15f);
    }

    void NotQuite()
    {
        message.SetActive(true);
        Invoke("DisableMessage", 1f);
    }

    void DisableFlash()
    {
        flashSprite.SetActive(false);
    }

    void DisableMessage()
    {
        message.SetActive(false);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPhoto : MonoBehaviour
{
    public GameObject Panel;

    public void Start(){

    }
    public void Update(){

    }

    public void OpenPanel(){
        if (Panel != null){
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
}

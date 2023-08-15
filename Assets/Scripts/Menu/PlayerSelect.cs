using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public bool b1;
    public bool female;

    public void PlayerB1(){
        b1 = true;
        female = false;
        Guardar();
    }
    public void PlayerFemale(){
        female = true;
        b1 = false;
        Guardar();
    }
    public void Guardar(){
        PlayerPrefs.SetInt("playerSelectB1", b1 ? 1 : 0);
        PlayerPrefs.SetInt("playerSelectFemale", female ? 1 : 0);
    }
    // Update is called once per frame
    private void Update()
    {
        b1= PlayerPrefs.GetInt("playerSelectB1") == 1;
        female = PlayerPrefs.GetInt("playerSelectFemale") == 1;
    }
}

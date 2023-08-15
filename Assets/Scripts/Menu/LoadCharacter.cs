using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    public GameObject b1Player;
    public GameObject femalePlayer;
    public bool b1;
    public bool female;

    private void Update()
    {
        b1= PlayerPrefs.GetInt("playerSelectB1") == 1;
        female = PlayerPrefs.GetInt("playerSelectFemale") == 1;

        if( b1 == true){
            b1Player.SetActive(true);
            Destroy(femalePlayer);
        }
        else{
            if(female == true){
                femalePlayer.SetActive(true);
                Destroy(b1Player);
            }
        }
    }
}

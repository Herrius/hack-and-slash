using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerSelector : MonoBehaviour
{
    //Para que agregues cuantos prefabs abra como opcion
    public GameObject[] prefabs;

    public void Select(int index)
    {
        //mandas a la clase PlayerStorage el prefab escogido
        PlayerStorage.playerprefab = this.prefabs[index];
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);       //cambias de escena
    }
}

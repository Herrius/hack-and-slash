using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    void Start()
    {
        //recibe de PlayerStorage el prefab escogido y lo coloca en la posicion y rotacion del spawner y luego se destruye
        Instantiate(PlayerStorage.playerprefab, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}

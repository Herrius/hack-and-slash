using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscogerPersonaje : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    public void OnButtonClick()
    {
        GameObject instantiatedPrefab = Instantiate(prefabToInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
        instantiatedPrefab.transform.position = new Vector3(0, 0, 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}


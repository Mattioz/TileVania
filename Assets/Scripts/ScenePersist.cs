using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePersist : MonoBehaviour
{
    void Awake()
    {
        int numScenePersist = FindObjectsOfType<ScenePersist>().Length;
        if (numScenePersist > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        
    }

    public void ResetScenePersist()
    {
        Destroy(gameObject);
    }

}

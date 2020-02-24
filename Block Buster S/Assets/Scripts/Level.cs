using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //parameters
    [SerializeField] int breakableBlock;  // Serialized for debugging purposes

    //chached reference
    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlock++;
    }

    public void BlockDestroyd()
    {
        breakableBlock--;
        if (breakableBlock <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //parameters
    [SerializeField] int breakableBlocks;  // Serialized for debugging purposes

    //chached reference
    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyd()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}

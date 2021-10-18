using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicAcossScenes : MonoBehaviour
{
    public static MusicAcossScenes Instance;

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepOpciones: MonoBehaviour
{

    private void Awake()
    {
        var noDestruirEntreEscenas = FindObjectsOfType<KeepOpciones>();
        if (noDestruirEntreEscenas.Length > 1)
        {
            Destroy(gameObject);
            return;
        }

     DontDestroyOnLoad(gameObject);   
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

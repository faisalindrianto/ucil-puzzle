﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseUp(){
        SceneManager.LoadScene("ChooseLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

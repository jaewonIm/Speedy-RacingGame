﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public void OnEnable()
    {

            Time.timeScale = 0;
 
    }
    public void OnDisable()
    {
        Time.timeScale = 1;
    }
}

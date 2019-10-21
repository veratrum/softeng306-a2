﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager getInstance() {
        if (instance == null) {
            instance = GameObject.FindObjectOfType<GameManager>();
        }
        
        return instance;
    }
    
    // for pre-level splash scene
    public int levelID = -1; // number of the currently selected level
    public string levelName; // name of the currently selected level
    public string sceneName; // name of the currently selected scene
    
    public int score = 0;
    public float time = 0;
    
    // for the level select scene
    public int levelsCompleted = 0;
    public bool watchedCutscene = false; // this is necessary so the player doesn't have to watch the same cutscene twice if they quit the level
    
    public List<Item> items = new List<Item>();
    
    public GameObject baseWaterball;
    public float waterballSpeed;
    public float waterballCooldown;
    
    public GameObject baseBullet;
    public float bulletSpeed;
    public float bulletCooldown;

    private void Awake() {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(baseWaterball);
        DontDestroyOnLoad(baseBullet);
        instance = this;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevelManager : MonoBehaviour {

    public Hero playerHero;
    public Hero enemyHero;

    public GameObject avatarPrefab;

    public Transform playerAvatarSpawn;
    public Transform enemyAvatarSpawn;

    private void Start()
    {
        //Setup player
        PlayerSetup();
        //Setup enemy
        EnemySetup();
    }

    private void PlayerSetup()
    {
        GameObject go = Instantiate(avatarPrefab, new Vector3(enemyAvatarSpawn.position.x, enemyAvatarSpawn.position.y, enemyAvatarSpawn.position.z), Quaternion.identity);
        HeroDisplay display = go.GetComponent<HeroDisplay>();
        display.HeroSetup(enemyHero);
    }

    private void EnemySetup()
    {
        GameObject go = Instantiate(avatarPrefab, new Vector3(playerAvatarSpawn.position.x, playerAvatarSpawn.position.y, playerAvatarSpawn.position.z), Quaternion.identity);
        HeroDisplay display = go.GetComponent<HeroDisplay>();
        display.HeroSetup(playerHero);
    }

 
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class Weapon : ScriptableObject
{

    public Sprite currentWeaponSpr;
    public GameObject projectilePrefab;
    public float fireRate = 1;
    public int damage = 20;

    public void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
    }
}

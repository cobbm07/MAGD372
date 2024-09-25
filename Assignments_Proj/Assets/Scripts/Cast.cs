using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cast : MonoBehaviour
{
    ObjectPooler objectPooler;

    private void Start() {
        objectPooler = ObjectPooler.Instance;
    }    
    private void OnEnable()
    {
        EventManager.OnLeftClick += CastSpell;
    }
    private void OnDisable()
    {
        EventManager.OnLeftClick -= CastSpell;
    }

    private void CastSpell() {
        objectPooler.SpawnFromPool("Wand_Projectile", transform.position, Quaternion.identity);
    }
}

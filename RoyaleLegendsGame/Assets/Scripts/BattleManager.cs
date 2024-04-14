using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject playerActive;

    public GameObject enemyTarget;

    void Start()
    {

    }

    void Update()
    {

    }

    public void PlayerSelect(GameObject PlayerSelect)
    {
        playerActive = PlayerSelect;
    }

    public void PlayerDeSelect()
    {
        playerActive.GetComponent<PlayerController>().PlayerDeSelect();
        playerActive = null;
    }
        public void EnemySelect(GameObject enemySelect)
    {
        enemyTarget = enemySelect;
    }


    public void EnemyDeSelect()
    {
        enemyTarget.GetComponent<EnemyController>().EnemyDeSelect();
        enemyTarget = null;
    }
}

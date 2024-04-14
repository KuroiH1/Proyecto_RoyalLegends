using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject markerSelect;

    public GameObject action;

    private BattleManager sbm;

    private Animator playerAnim;


    private void Awake()
    {
        sbm = FindObjectOfType<BattleManager>();
        playerAnim = GetComponent<Animator>();
    }

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        if(sbm.playerActive != gameObject && sbm.playerActive != null)
        {
            sbm.PlayerDeSelect();
        }

        PlayerSelect();
        sbm.PlayerSelect(gameObject);
    }


    public void PlayerSelect()
    {
        markerSelect.SetActive(true);
    }

    public void PlayerDeSelect()
    {
        markerSelect.SetActive(false);
        action.SetActive(false);
        sbm.enemyTarget.GetComponent<EnemyController>().EnemyDeSelect();
    }

    public void ActionButton()
    {
        print("Atacando al" + sbm.enemyTarget.name);
        playerAnim.SetTrigger("ATTACK");
    }
}

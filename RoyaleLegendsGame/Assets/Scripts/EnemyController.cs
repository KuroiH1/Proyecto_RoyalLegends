using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject markerSelect;

    private BattleManager sbm;

    public bool enemyEndTurn;

    public GameObject playerTarget;

    public Animator enemyAnim;


    private void Awake()
    {
        sbm = FindObjectOfType<BattleManager>();
        enemyAnim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(sbm.playerActive != null)
        {
            if(sbm.enemyTarget != gameObject && sbm.enemyTarget != null)
            {
                sbm.EnemyDeSelect();
            }
            EnemySelect();
            sbm.EnemySelect(gameObject);
        }

    }


    public void EnemySelect()
    {
        markerSelect.SetActive(true);
        sbm.playerActive.GetComponent<PlayerController>().action.SetActive(true);
    }

    public void EnemyDeSelect()
    {
        markerSelect.SetActive(false);
    }

    public void EnemyAtk()
    {
        playerTarget = sbm.players[Random.Range(0,sbm.players.Length)];
        transform.LookAt(playerTarget.transform);
        enemyEndTurn = true;
    }
}

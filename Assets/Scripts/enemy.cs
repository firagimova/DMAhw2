using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public Animator animator;
    private NavMeshAgent navMeshAgent;
    private GameObject player;

    int hp = 100;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("collectable").Length == 0)
        {
            Check();
            

        }
    }

    // the function that make this object follow "player" by moving 
    public void Chase()
    {

        navMeshAgent.SetDestination(player.transform.position);
        animator.SetBool("isClose", false);
    }

    public void Check()
    {
        //if this object is closer than 2 units to "player"


        
        float distance = Vector3.Distance(transform.position, player.transform.position);

        print(distance);

        if (distance <= 4f)
        {
            print("2");
            //play attack
            animator.SetBool("isClose", true);
            

            player.GetComponent<player>().hp-=10;

            if (player.GetComponent<player>().hp <= 0)
            {
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex);

            }
        }
        else
        {
            Chase();
            print("1");
        }

        

    }


    



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FollowPlayerCtrl : MonoBehaviour
{
    public enum MonsterState { idle, trace, attack, die };
    public MonsterState monsterState = MonsterState.idle;
    
    public float attackDist = 3.0f;
    private bool isDie = false;

    private Animator animator;


    private Vector3 diff;


    private Transform Targettr;
    private float dis;
    private Transform tr;
    public float moveSpeed = 3f;

    public float bosshp = 1200f;
    public GameObject bosshpbar;
    // Use this for initialization
    void Start()
    {   
        
        Targettr = GameObject.FindWithTag("Player").GetComponent<Transform>();
        tr = this.gameObject.GetComponent<Transform>();
        animator = this.gameObject.GetComponent<Animator>();
        StartCoroutine(this.CheckMonsterState());
        StartCoroutine(this.MonsterAction());

    }

    IEnumerator CheckMonsterState()
    {
        while (!isDie)
        {
            yield return new WaitForSeconds(0.05f);
            if(SceneManager.GetActiveScene().buildIndex == 0)
            {
                dis = Vector3.Distance(Targettr.position, tr.position);
                if(dis < 5 && PlayerPrefs.GetInt("score") >= 20 ){
                    //scene 추가  
                    //global.bossentro = true;
                    Destroy(this.gameObject);
                    SceneManager.LoadScene(1);  
                }
                if (dis <= attackDist)
                {
                    monsterState = MonsterState.attack;
                }
                else
                {
                    monsterState = MonsterState.trace;
                }
            }
           
        }
    }

    IEnumerator MonsterAction()
    {
        while(!isDie)
        {   

            if(SceneManager.GetActiveScene().buildIndex == 0 )
            {

                switch (monsterState)
                {
                    case MonsterState.trace:
                        animator.SetBool("IsAttack", false);
                        tr.transform.LookAt(Targettr);

                        /*
                        diff = new Vector3(Targettr.position.x - tr.position.x, Targettr.position.y, Targettr.position.z - tr.position.z);
                        tr.Translate(diff * Time.deltaTime * moveSpeed, Space.Self);
                        */
                        // 이동할 방향을 구한다. (directionOfTravel = 이동할 방향벡터)
                        Vector3 directionOfTravel = 
                        //플레이어 포지션으로 바꿀것. not 0 0 0
                        Targettr.transform.position - this.transform.position;

                        // 크기가 표준화된 노멀라이징벡터를 구하고 

                        directionOfTravel.Normalize();

                        // 해당하는 방향으로 이동을 시켜주도록한다. 

                        this.transform.Translate(
                            (directionOfTravel.x * moveSpeed * Time.deltaTime),
                            (directionOfTravel.y * moveSpeed * Time.deltaTime),
                            (directionOfTravel.z * moveSpeed * Time.deltaTime),
                            Space.World);

                        break;

                    case MonsterState.attack:
                        animator.SetBool("IsAttack", true);
                        break;
                }

            }
            }
            yield return new WaitForSeconds(0.05f);
        }
    

    // Update is called once per frame
    void Update()
    {


    }
}
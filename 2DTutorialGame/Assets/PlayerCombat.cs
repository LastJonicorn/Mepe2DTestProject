using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Attack"))
        {
            Attack();
        }
    }

    void Attack()
    {
        //N�ytet��n hy�kk�ysanimaatio
        animator.SetTrigger("Attack");
        //Osutaanko viholliseen?
        //Vahingoita vihollista
    }
}

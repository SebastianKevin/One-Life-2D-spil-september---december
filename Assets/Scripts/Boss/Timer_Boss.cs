using UnityEngine;

public class BossTimer : MonoBehaviour
{
    public Animator animator;
    [SerializeField]
    public float tidTilbage = 10.0f;
    public bool Boss_Dead;

    void Update()
    {
        tidTilbage -= Time.deltaTime;

        if (tidTilbage <= 0f)
        {
            Boss_Dead = true;
            gameObject.SetActive(false);
            //animator.SetBool("Is_Dead", true);

        }
    }
}
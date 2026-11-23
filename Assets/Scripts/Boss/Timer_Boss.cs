using UnityEngine;


public class BossTimer : MonoBehaviour
{
    [SerializeField]
    public float tidTilbage = 10f;
    public bool Boss_Dead;

    void Update()
    {
        tidTilbage -= Time.deltaTime;

        if (tidTilbage <= 0f)
        {
            Boss_Dead = true;
            gameObject.SetActive(false);
        }
    }
}
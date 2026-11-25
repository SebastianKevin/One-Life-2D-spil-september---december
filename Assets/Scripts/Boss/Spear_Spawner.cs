using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject SpearPrefab;
    [SerializeField]
    int Wanted_Amount = 0;
    void Update()
    {
        GameObject[] spears = GameObject.FindGameObjectsWithTag("Spear");

        if (spears.Length <= (Wanted_Amount-1)*2)
        {
            float randomX = Random.Range(-283f, -235f);
            Quaternion upsideDown = Quaternion.Euler(0f, 0f, 180f);

            Vector2 baseSpawnPos = new Vector2(randomX, -95f);
            Instantiate(SpearPrefab, baseSpawnPos, upsideDown);
        }
    }
    public class DestroyOffScreen : MonoBehaviour
    {
        void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}

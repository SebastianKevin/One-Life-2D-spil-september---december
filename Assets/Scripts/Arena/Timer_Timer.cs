using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] public float tidTilbage = 10f;
    [SerializeField] private TMP_Text timerText;

    void Update()
    {

        tidTilbage -= Time.deltaTime;

        // Bruger loftet, så 1,2 sekunder vises som 2, ikke 1.
        int sekunderTilbage = Mathf.CeilToInt(Mathf.Max(0f, tidTilbage));
        int minutter = sekunderTilbage / 60;
        int sekunder = sekunderTilbage % 60;

        timerText.text = $"{minutter:00}:{sekunder:00}";

        if (tidTilbage <= 0f)
        {
            timerText.text = "00:00";
        }
    }
}
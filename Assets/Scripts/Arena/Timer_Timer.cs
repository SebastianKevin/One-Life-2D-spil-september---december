using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] public float tidTilbage = 10f;
    [SerializeField] private TMP_Text timerText;

    private void Start()
    {
        tidTilbage = 10f;
    }

    void Update()
    {
        if (tidTilbage <= 0f)
        {
            tidTilbage = 0f;
            timerText.text = "00:00";
            enabled = false; // Stops Update() from running until re-enabled
            return;
        }

        tidTilbage -= Time.deltaTime;

        // Bruger loftet, så 1,2 sekunder vises som 2, ikke 1.
        int sekunderTilbage = Mathf.CeilToInt(Mathf.Max(0f, tidTilbage));
        int minutter = sekunderTilbage / 60;
        int sekunder = sekunderTilbage % 60;

        timerText.text = $"{minutter:00}:{sekunder:00}";
    }
}

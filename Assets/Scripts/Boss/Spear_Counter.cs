using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spear_Counter : MonoBehaviour
{
    private int spearAmount = 0;
    [SerializeField] private TMP_Text spearCounterText;

    // Tracks only currently active, existing spears
    private HashSet<GameObject> activeSpears = new HashSet<GameObject>();

    void Update()
    {
        // 1. Find all active objects tagged "Spear"
        GameObject[] foundSpears = GameObject.FindGameObjectsWithTag("Spear");

        foreach (GameObject spear in foundSpears)
        {
            if (spear.activeInHierarchy)
            {
                activeSpears.Add(spear); // HashSet automatically ignores duplicates
            }
        }

        // 2. Remove any spears that were deleted (null) or deactivated
        activeSpears.RemoveWhere(spear => spear == null || !spear.activeInHierarchy);

        // 3. The count is simply how many valid spears remain in the set
        spearAmount = activeSpears.Count;

        if (spearCounterText != null)
        {
            spearCounterText.text = $"Spears: {spearAmount/2}";
        }
    }
}

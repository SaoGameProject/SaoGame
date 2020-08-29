using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerXp : MonoBehaviour
{
    public int level;
    private float currentXp;
    private float maxXp;
    private float overflowXp;
    public TextMeshProUGUI LevelText;
    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        maxXp = Mathf.Floor(100 * level * Mathf.Pow(level, 0.5f));
        currentXp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LevelText.text = "LV: " + level.ToString();
        if (currentXp >= maxXp)
        {
            StartCoroutine(Ding());
        }
    }
    public void GainXp(float xp)
    {
        currentXp += xp;
        if (currentXp >= maxXp)
        {
            StartCoroutine(Ding());
        }
    }
    private IEnumerator Ding()
    {
        while (currentXp < maxXp)
        {
            yield return null;
        }
        while (currentXp >= maxXp)
        {
            level ++;
            LevelText.text = "LV: " + level.ToString();
            overflowXp = currentXp - maxXp;
            maxXp = 100 * level * Mathf.Pow(level, 0.5f);
            maxXp = Mathf.Floor(maxXp);
            if (overflowXp < 0)
            {
                currentXp = 0;
            }
            else
            {
                currentXp = overflowXp;
            }
        }
    }

}

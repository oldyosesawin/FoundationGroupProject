using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    [SerializeField] private float timeDelay = 0.05f; // Time interval between characters

    private void Start()
    {
        if (textComponent != null)
        {
            StartCoroutine(RevealText());
        }
    }

    private IEnumerator RevealText()
    {
        // 1. Force the mesh to update so TMPro can calculate the total character count accurately
        textComponent.ForceMeshUpdate();
        int totalCharacters = textComponent.textInfo.characterCount;

        // 2. Hide all characters initially
        textComponent.maxVisibleCharacters = 0;

        // 3. Reveal characters one by one
        for (int i = 0; i <= totalCharacters; i++)
        {
            textComponent.maxVisibleCharacters = i;
            yield return new WaitForSeconds(timeDelay); // Wait before showing the next letter
        }
    }
}


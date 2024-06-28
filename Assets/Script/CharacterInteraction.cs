using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
    public MaleVillageController currentCharacter;

    void Update()
    {
        if (currentCharacter != null && Input.GetKeyDown(KeyCode.E))
        {
            currentCharacter.TalkWithCharacter();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Character"))
        {
            currentCharacter = other.gameObject.GetComponent<MaleVillageController>();

            // Kiểm tra xem currentCharacter có null không
            if (currentCharacter == null)
            {
                Debug.LogError("MaleVillageController script not found on the GameObject.");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Character"))
        {
            if (other.gameObject.GetComponent<MaleVillageController>() == currentCharacter)
            {
                currentCharacter = null;
            }
        }
    }
}

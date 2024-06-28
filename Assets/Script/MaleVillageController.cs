using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class MaleVillageController : MonoBehaviour
{
    public bool isTalked;
    public Text dialogueText;

    public void TalkWithCharacter()
    {
        if (!isTalked)
        {
            isTalked = true;
            Debug.Log("Người chơi đã nói chuyện với nhân vật này...");
            dialogueText.text = "Người chơi đã nói chuyện với nhân vật này....";
            // Thêm logic tương tác bổ sung tại đây
        }

    }
}

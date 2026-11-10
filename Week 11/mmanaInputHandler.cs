using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class mmanaInputHandler : MonoBehaviour
{

    public int mana = 100;
    public TextMeshProUGUI display;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        display.text = "Mana: " + mana;
        Debug.Log("ManaHandler running");
    }

    // Update is called once per frame
    void Update()
    {

        if (mana<=-1)
        {
            display.text = "haha you dead, son";
            return;
        }

        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            mana = mana - 10;
            display.text = "Mana: " + mana;
            animator.SetTrigger("flash");
        }
    }
}

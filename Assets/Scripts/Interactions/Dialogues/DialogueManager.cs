using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public TextMeshProUGUI dialogueText;
    public GameObject textUI;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        textUI.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        textUI.SetActive(true);
        StartCoroutine(TypeSentence("Bento: Estou sim?..."));

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        StartCoroutine(DisplayNextSentence());
    }

    public IEnumerator DisplayNextSentence()
    {
        string sentence;
        while (sentences.Count != 0)
        {
            yield return new WaitUntil(BtnIsPressed);

            if (BtnIsPressed())
            {
                sentence = sentences.Dequeue();
                StartCoroutine(TypeSentence(sentence));
            }

            if (sentences.Count == 0)
            {
                textUI.SetActive(false);
                EndDialogue();
                yield break;
            }   
        }

        yield return null;
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    
    private bool BtnIsPressed()
    {
        return Input.GetMouseButtonDown(0);
    }

    private void EndDialogue()
    {
        Time.timeScale = 1;
    }
}

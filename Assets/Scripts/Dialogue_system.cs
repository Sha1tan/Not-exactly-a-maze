using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_system : MonoBehaviour
{
   // public GameObject Gun;
    public DialogueTopic[] topic;
    public int _currentTopic;
    public bool ShowDialogue = true;

    private void OnTriggerStay(Collider other)
    {
       // var script = Gun.GetComponent<PlayerShooting>();
        if (other.tag == "Npc" && !ShowDialogue && Input.GetKeyDown(KeyCode.E))
        {            
           // script.enabled = false;
            ShowDialogue = true;            
        }
       // if (!ShowDialogue) script.enabled = true;
    }




    private void OnGUI()
    {
        if (ShowDialogue == true)
        {
            GUI.Box(new Rect(Screen.width / 2 - 300, Screen.height - 300, 600, 250), "");
            GUI.Label(new Rect(Screen.width / 2 - 250, Screen.height - 280, 500, 90), topic[_currentTopic].NpcText);
            for (int i = 0; i < topic[_currentTopic].PlayerAnswer.Length; i++)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height - 200 + 25 * i, 500, 25), topic[_currentTopic].PlayerAnswer[i].Text))
                {
                    if (topic[_currentTopic].PlayerAnswer[i].TalkEnd)
                    {
                        ShowDialogue = false;
                    }

                    _currentTopic = topic[_currentTopic].PlayerAnswer[i].ToTopic;
                }
            }
        }
    }


    [System.Serializable]
    public class DialogueTopic
    {
        public string NpcText;
        public Answer[] PlayerAnswer;
    }

   [System.Serializable]
   public class Answer
   {
        public string Text;
        public int ToTopic;
        public bool TalkEnd;
   }

    private void Start()
    {
        ShowDialogue = false;
    }
}

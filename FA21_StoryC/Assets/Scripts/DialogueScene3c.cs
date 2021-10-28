using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3c : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1You;
    public Text Char1YouSpeech;
    //public Text Char2Chad;
    //public Text Char2ChadSpeech;
    public Text Char3Gwen;
    public Text Char3GwenSpeech;
    //public Text Char4Gregory;
    //public Text Char4GregorySpeech;
    public Text Char5PJ;
    public Text Char5PJSpeech;
    public Text Char6Narrator;
    public Text Char6Narration;
    public GameObject Dialogue;
    //public GameObject Image_Chad;
    public GameObject Image_Gwen;
    public GameObject Image_GwenScared;
    //public GameObject Image_Gregory;
    public GameObject Image_PJ;
    public GameObject Image_BG;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Button_SceneChange1;
    //public GameObject Button_SceneChange2;
    public GameObject Button_Next;
    public GameHandler gameHandler;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        Dialogue.SetActive(false);
        //Image_Chad.SetActive(false);
        Image_Gwen.SetActive(false);
        Image_GwenScared.SetActive(false);
        //Image_Gregory.SetActive(false);
        Image_PJ.SetActive(false);
        Image_BG.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_SceneChange1.SetActive(false);
        //Button_SceneChange2.SetActive(false);
        Button_Next.SetActive(true);
    }

    void Update()
    {
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            Dialogue.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You enter a bedroom. There's a bed up against the left wall with a nightstand by it.";
        }
        else if (primeInt == 3)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Deep claw marks similar to the ones on the door adorn the walls, paired with streaks of blood.";
        }
        else if (primeInt == 4)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The floorboards are worn and faded, and the room is eerily still...Nothing can be heard aside from your breathing.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "Jeez, someone must really not like their room.";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 6)
        {
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "I wish my bedroom looked like this...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 7)
        {
            Image_Gwen.SetActive(true);
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Ugh, you literally have the worst taste. I've seen your room before.";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 8)
        {
            Image_Gwen.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Does anyone else notice how quiet it is in here?";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 9)
        {
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Nice, isn't it?";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            //nextButton.SetActive(false);
            // allowSpace = false;
            //Choice1a.SetActive(true); // function Choice1aFunct()
            //Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 10)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "As you walk deeper into the room, a scratching noise can be heard from under the bed.";
        }
        else if (primeInt == 11)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The low rumbling of a growl begins to fill your ears as well.";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }
        else if (primeInt == 12)
        {
            Image_GwenScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "What was that? Was that a growl??";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 13)
        {
            Image_GwenScared.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Well, I am hungry...";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }

        else if (primeInt == 15)
        {
            Image_GwenScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Shut up, don't make jokes! I think it came from under the bed...";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            Button_Next.SetActive(false);
            allowSpace = false;
            //Button_SceneChange1.SetActive(true);
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "As soon as you're less than a foot away from the bed...";
        }
        else if (primeInt == 101)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "...A gray, yellow nailed hand shoots out and grabs you!!";
        }
        else if (primeInt == 102)
        {
            
            Char1You.text = "You";
            Char1YouSpeech.text = "WHAT THE-";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 103)
        {
            
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You fall backwards, scrambling away as a disheveled girl with matted black hair creeps out.";

        }
        else if (primeInt == 104)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "As she crawls out from under the bed, you feel Gwen and PJ's hands grabbing you as she screams-";

        }
        else if (primeInt == 105)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "YOU'LL NEVER LEAVE THIS PLACE ALIVE!!";

        }
        else if (primeInt == 106)
        {
            Image_GwenScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "HEY LET GO LADY! C'MON LET'S GO!!";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 107)
        {
            Image_GwenScared.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The girl follows on all fours, hissing and snarling. You can feel her breath at your heels when-";
        }
        else if (primeInt == 108)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "BANG! PJ slams the door shut as soon as you cross the landing.";
        }
        else if (primeInt == 109)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A sickening thunk echoes as soon as the door closes.";
        }
        else if (primeInt == 110)
        {
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Damn, that's gotta hurt.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 111)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Jeez...talk about stuff of nightmares...let's just go.";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }


        else if (primeInt == 200)
        {

            Char1You.text = "You";
            Char1YouSpeech.text = "There is nothing there, Gwen.";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //Button_SceneChange1.SetActive(true);

        }
        else if (primeInt == 201)
        {
            Image_GwenScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Can we just please go?";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 202)
        {
            Image_GwenScared.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "You're literally such a drag.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }

        else if (primeInt == 203)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "C'mon PJ, let's just go. It's probably the house making noise.";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 204)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Taking a wide berth around the bed, you guys advance into the next room.";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }


    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Image_GwenScared.SetActive(false);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        //Char2Chad.text = "";
        //Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        //Char4Gregory.text = "";
        //Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "Narrator";
        Char6Narration.text = "You slowly move closer to the bed, with Gwen at your side and PJ following closely behind.";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_Next.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Image_GwenScared.SetActive(false);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        //Char2Chad.text = "";
        //Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        //Char4Gregory.text = "";
        //Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "Narrator";
        Char6Narration.text = "You look around the bed to hopefully ease Gwen's worry.";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_Next.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene4b");
    }

}
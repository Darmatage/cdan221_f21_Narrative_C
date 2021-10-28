using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene5a : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1You;
    public Text Char1YouSpeech;
    public Text Char2Chad;
    public Text Char2ChadSpeech;
    //public Text Char3Gwen;
    //public Text Char3GwenSpeech;
    //public Text Char4Gregory;
    //public Text Char4GregorySpeech;
    public Text Char5PJ;
    public Text Char5PJSpeech;
    public Text Char6Narrator;
    public Text Char6Narration;
    public GameObject Dialogue;
    public GameObject Image_Chad;
    public GameObject Image_ChadScared;
    //public GameObject Image_Gwen;
    //public GameObject Image_Gregory;
    public GameObject Image_PJ;
    public GameObject Image_BG;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Button_SceneChange1;
    public GameObject Button_SceneChange2;
    public GameObject Button_Next;
    public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        Dialogue.SetActive(false);
        Image_Chad.SetActive(false);
        Image_ChadScared.SetActive(false);
        //Image_Gwen.SetActive(false);
        //Image_Gregory.SetActive(false);
        Image_PJ.SetActive(false);
        Image_BG.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_SceneChange1.SetActive(false);
        Button_SceneChange2.SetActive(false);
        Button_Next.SetActive(true);
    }

    void Update()
    {         // use spacebar as Next button
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
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Walking through the door, you enter a brightly lit room with barren white walls and whirring machines.";
        }
        else if (primeInt == 3)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Sharp screams and hysterical laughter can be heard echoing from farther off.";
        }
        else if (primeInt == 4)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A bright red exit sign hangs above a door on one side of the room, and there's another door further inside.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Ugh, I've always hated hospitals...";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 6)
        {
            Image_Chad.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Really? I think they're kinda poetic...so full of good intentions and healing.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 7)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "But also plagued with the stench of suffering and death...the duality of it all is beautiful.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 8)
        {
            Image_Chad.SetActive(true);
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Bro, can you not be be morbid for, like, five minutes?";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 9)
        {
            Image_Chad.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "?";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Dude, we're in a haunted house...It's probably the only place where I can be myself...";
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
            Image_Chad.SetActive(true);
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "You really worry me sometimes-";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 11)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Chad is cut off by a blood curdling shriek as two nurses drag a straight-jacketed woman into the room.";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }

        else if (primeInt == 12)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "They don't seem to notice you as they strap her into a medical chair on the other side of the room. ";
        }
        else if (primeInt == 13)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The woman's eyes widen as they fall upon you...the nurses don't seem to have noticed you.";
            //Button_Next.SetActive(false);
            //allowSpace = false;
            //Choice1a.SetActive(true); // function Choice1aFunct()
            //Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 14)
        {
              Image_Chad.SetActive(false);
              Char1You.text = "";
              Char1YouSpeech.text = "";
              Char2Chad.text = "";
              Char2ChadSpeech.text = "";
              //Char3Gwen.text = "";
              //Char3GwenSpeech.text = "";
              //Char4Gregory.text = "";
              //Char4GregorySpeech.text = "";
              Char5PJ.text = "";
              Char5PJSpeech.text = "";
              Char6Narrator.text = "Narrator";
              Char6Narration.text = "???: RUN!! THIS IS ALL REAL...I USED TO BE LIKE YOU BUT THE CAUGHT ME! RUN AND GET OUT OF HERE, PLEASE-";
        }
        else if (primeInt == 15)
        {
              Image_Chad.SetActive(false);
              Char1You.text = "";
              Char1YouSpeech.text = "";
              Char2Chad.text = "";
              Char2ChadSpeech.text = "";
              //Char3Gwen.text = "";
              //Char3GwenSpeech.text = "";
              //Char4Gregory.text = "";
              //Char4GregorySpeech.text = "";
              Char5PJ.text = "";
              Char5PJSpeech.text = "";
              Char6Narrator.text = "Narrator";
              Char6Narration.text = "She's cut off by a nurse strapping a gag around her face, making speech impossible.";
        }


        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 16)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The woman struggles harder, a frantic look in her eyes.";

        }
        else if (primeInt == 17)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Nurse 1: Hello, Dearies! Don't mind me, she's a bit sick in the head...We'll haave her fixed up in no time.";

        }
        else if (primeInt == 18)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You watch as the nurse who just spoke turn to a machine behind the chair and starts flipping switches";

        }
        else if (primeInt == 19)
        {

            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A menacing electrical hum fills the air.";

        }
        else if (primeInt == 20)
        {

            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Two giant electrodes hanging off of either side of the chair begin to spark.";

        }
        else if (primeInt == 21)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "Nurse 2: While my colleagues takes care of her let me get you guys checked in...";

        }
        else if (primeInt == 22)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The second nurse starts advancing towards you, a wicked look in her eyes.";
        }
        else if (primeInt == 23)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The other starts rasing the sparking electrodes to the woman's temples.";
            Button_Next.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        else if (primeInt == 100)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "Guys...maybe we should get out of here...I don't like this at all.";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 101)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Yeah man...";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 102)
        {
            Image_Chad.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Guys, look...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 103)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You watch as the nurse presses the electrodes to her head and thw woman starts convulsing violently.";

        }
        else if (primeInt == 104)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "That looks too real for my liking...";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 105)
        {
            Image_ChadScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Yeah, man...this is like, next level.";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }
        else if (primeInt == 106)
        {
            Image_PJ.SetActive(true);
            Image_ChadScared.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "She looks like she's actually in pain...it's kinda impressive how committed she is.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 107)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Gwen's gonna give me so much crap for this but I agree...";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 108)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = ""
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator ";
            Char6Narration.text = "You hear a soft giggle right behind you, and the hairs off your neck stand on end...";
        }
        else if (primeInt == 109)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "...you realize you forgot all about the second nurse.";
        }
        else if (primeInt == 110)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "RUN!!!";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 111)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You all run towards the exit, the nurse laughing behind you. The exit sign glowing brightly when-";
        }
        else if (primeInt == 112)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You hear one of your friends scream behind you, followed by another scream from the other.";
        }
        else if (primeInt == 113)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You leap towards the door, arms outstretched...";
        }
        else if (primeInt == 114)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "But right before you reach it, you feel a hand wrap around your shirt collar and drag you backwards. ";
        }
        else if (primeInt == 115)
        {

            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Your head hits the floor hard, and as you're swimming in and out of consciousness, you feel yourself being dragged back into the depths of the house.";
        }
        else if (primeInt == 116)
        {

            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The last thing you hear before the world goes dark is...";
        }
        else if (primeInt == 117)
        {

            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "You're never gonna get out of this place...";
        }
        else if (primeInt == 118)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "...and you get taken away to meet your cruel fate.";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }


        else if (primeInt == 200)
        {
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Guys, look...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //Button_SceneChange1.SetActive(true);

        }
        else if (primeInt == 201)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You watch as the nurse presses the electrodes to her head and the woman starts convulsing violently.";
        }
        else if (primeInt == 202)
        {
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "She looks like she's actuall in pain...kinda impressive the way she can make her veins bulge on command.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 203)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "It skeeves me out a bit, which says a lot...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 204)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Now THIS is a haunted house! That's what I'm talking about, this is real entertainment!";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 205)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Yeah, the actors are incredible! I kinda want to see what the other rooms have.";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 206)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Why did they even bother with the exit sign?";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 207)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Unless you're like Greg no one would be stupid enough to leave early...";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 208)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "...I wonder how he's doing.";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 209)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "I'm sure we'll run into him at the end- he's probably already out at the car.";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 210)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "I don't think the poor kid will be handling this too well...";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 211)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Hey Nurse Lady! You all are incredible actors...Keep up the good work!";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 212)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "Nurse 2: Who said we're actors?";
        }
        else if (primeInt == 213)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "You're too funny...Hope the rest of the night goes well for ya!";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 214)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "And with that, you all turn towards the next room.";
        }
        else if (primeInt == 215)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Leaving a dumbfounded nurse in your wake as you pass through the door.";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange2.SetActive(true);
        }

    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1You.text = "You";
        Char1YouSpeech.text = "Guys, maybe we should get out of here...I don't like this at all.";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        //Char3Gwen.text = "";
        //Char3GwenSpeech.text = "";
        //Char4Gregory.text = "";
        //Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_Next.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        //Char3Gwen.text = "";
        //Char3GwenSpeech.text = "";
        //Char4Gregory.text = "";
        //Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "Narrator";
        Char6Narration.text = "You decide to head deeper into the house";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_Next.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene_Lose1");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene6");
    }

}

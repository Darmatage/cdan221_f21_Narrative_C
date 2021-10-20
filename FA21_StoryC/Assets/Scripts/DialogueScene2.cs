using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2 : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1You;
    public Text Char1YouSpeech;
    public Text Char2Chad;
    public Text Char2ChadSpeech;
    public Text Char3Gwen;
    public Text Char3GwenSpeech;
    public Text Char4Gregory;
    public Text Char4GregorySpeech;
    public Text Char5PJ;
    public Text Char5PJSpeech;
    public Text Char6Narrator;
    public Text Char6Narration;
    public GameObject Dialogue;
    public GameObject Image_Chad;
    public GameObject Image_Gwen;
    public GameObject Image_Gregory;
    public GameObject Image_GregoryScared;
    public GameObject Image_PJ;
    public GameObject Image_BG;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice1c;
    public GameObject Button_SceneChange1;
    public GameObject Button_SceneChange2;
    public GameObject Button_SceneChange3;
    public GameObject nextButton;
    public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;
}


    void Start()
    {         // initial visibility settings
        Dialogue.SetActive(false);
        Image_Chad.SetActive(false);
        Image_Gwen.SetActive(false);
        Image_Gregory.SetActive(false);
        Image_GregoryScared.SetActive(false);
        Image_PJ.SetActive(false);
        Image_BG.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Button_SceneChange1.SetActive(false);
        Button_SceneChange2.SetActive(false);
        Button_SceneChange3.SetActive(false);
        nextButton.SetActive(true);
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
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "Narrator";
        Char6Narration.text = "After buying tickets at the door, you find a barren room with three doors.";
    }
    else if (primeInt == 3)
    {
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "Narrator";
        Char6Narration.text = "One door has blood dripping from it. Another has a mysterious green ooze. The last has deep claw marks.";
    }
    else if (primeInt == 4)
    {
        Image_PJ.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "PJ";
        Char5PJSpeech.text = "Woah...This is so rad.";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        //gameHandler.AddPlayerStat(1);
    }
    else if (primeInt == 5)
    {
        Image_PJ.SetActive(false);
        Image_Gwen.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "Ew...Why is that goo that color? Lime is SO last season.";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 6)
    {
        Image_Gwen.SetActive(false);
        Image_GregoryScared.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "Gregory";
        Char4GregorySpeech.text = "Why do each of these look equally scary? Isn't there like, a less scary tour option here?";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";

    }
    else if (primeInt == 7)
    {
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "Gregory";
        Char4GregorySpeech.text = "I honestly think they should have a tour for people who don't like being scared as much.";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 8)
    {
        Image_Chad.SetActive(true);
        Image_GregoryScared.SetActive(false);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "Chad";
        Char2ChadSpeech.text = "Bro...the point of a haunted house is literally to be scared. C'mon man.";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 9)
    {
        Image_Gwen.SetActive(true);
        Image_Chad.SetActive(false);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "Guys, literally chill...Well, what do you think? What room should we choose?";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        // Turn off "Next" button, turn on "Choice" buttons
        nextButton.SetActive(false);
        allowSpace = false;
        Choice1a.SetActive(true); // function Choice1aFunct()
        Choice1b.SetActive(true); // function Choice1bFunct()
        Choice1c.SetActive(true);
    }

    else if (primeInt == 100)
    {
        Image_Gwen.SetActive(false);
        Char1You.text = "You";
        Char1YouSpeech.text = "Guys, I know it looks tacky but the bloody door could be cool...";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 101)
    {
        Image_GregoryScared.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "Gregory";
        Char4GregorySpeech.text = "I guess we could...";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        //nextButton.SetActive(false);
        //allowSpace = false;
        //Button_SceneChange1.SetActive(true);
    }

    else if (primeInt == 102)
    {
        Image_Gwen.SetActive(true);
        Image_GregoryScared.SetActive(false);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "I'm up for that...I just hope no fake blood gets on my clothes, I only just bought this top.";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 103)
    {
        Image_Gwen.SetActive(false);
        Image_Chad.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "Chad";
        Char2ChadSpeech.text = "Oh get a grip, Gwen! It's gonna be awesome!";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        nextButton.SetActive(false);

    }
    // ENCOUNTER AFTER CHOICE #1
    else if (primeInt == 104)
    {
        Image_PJ.SetActive(true);
        Image_Chad.SetActive(false);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "PJ";
        Char5PJSpeech.text = "I think the creative decision to paint on the door is super poetic. I'm totally on board.";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }

    else if (primeInt == 105)
    {
        Image_PJ.SetActive(false);
        Image_Gwen.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "God, PJ...you need some help. I really do hope this doesn't ruin my clothes...";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }

    else if (primeInt == 106)
    {
        Image_Gwen.SetActive(false);
        Image_Gregory.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "Gregory";
        Char4GregorySpeech.text = "I think I might be sick if I go in there...";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";

        //nextButton.SetActive(false);
        //allowSpace = false;
        //Button_SceneChange1.SetActive(true);
        //Button_SceneChange2.SetActive(true);
    }
    else if (primeInt == 107)
    {
        Image_PJ.SetActive(true);
        Image_Gregory.SetActive(false);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "PJ";
        Char5PJSpeech.text = "You are all so lame. Hey, do you just wanna go through this room?";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 108)
    {
        Image_PJ.SetActive(false);
        Image_Chad.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "Chad";
        Char2ChadSpeech.text = "Wait- bring me too!!";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 109)
    {
        Image_Chad.SetActive(false);
        Char1You.text = "You";
        Char1YouSpeech.text = "Yeah, that works for me.";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 110)
    {
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "Narrator";
        Char6Narration.text = "With PJ and Chad in tow, you approach the bloodied door and turn the knob...";
        nextButton.SetActive(false);
        allowSpace = false;
        Button_SceneChange1.SetActive(true);
    }

    else if (primeInt == 200)
    {
        Image_Gwen.SetActive(false);
        Char1You.text = "You";
        Char1YouSpeech.text = "The goo looks kinda gross, but I really want to see what's behind the door...";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        //gameHandler.AddPlayerStat(1);
    }

    else if (primeInt == 201)
    {
        Image_Chad.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "Chad";
        Char2ChadSpeech.text = "Yeah, bro...It looks kinda like jello...or melted jolly ranchers. Now I'm hungry.";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 202)
    {
        Image_Chad.SetActive(false);
        Image_Gwen.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "You really need to cut back on the sweets Chad. I don't think anyone eats them as much as you.";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 203)
    {
        Image_Gwen.SetActive(false);
        Image_Chad.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "Chad";
        Char2ChadSpeech.text = "Hey! I burn so many calories that it doesn't matter what I eat!";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 204)
    {
        Image_Gregory.SetActive(true);
        Image_Chad.SetActive(false);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "Gregory";
        Char4GregorySpeech.text = "My mom never let me eat candy when I was growing up...Which ones are jolly ranchers?";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 205)
    {
        Image_Gregory.SetActive(false);
        Image_Chad.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "Chad";
        Char2ChadSpeech.text = "YOU'VE NEVER HAD A JOLLY RANCHER?!?!";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 206)
    {
        Image_PJ.SetActive(false);
        Image_Chad.SetActive(false);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "PJ";
        Char5PJSpeech.text = "Honestly, if the worst thing that's happened to him is the fact he's never had a jolly rancher, he's the lucky one.";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 207)
    {
        Image_Gregory.SetActive(true);
        Image_PJ.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "Gregory";
        Char4GregorySpeech.text = "I'm actually quite intrigued by that ooze...I wonder what it's made of...";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 208)
    {
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "Gregory";
        Char4GregorySpeech.text = "...The viscosity is too slow moving for it to be water based...";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 209)
    {
        Image_Gregory.SetActive(false);
        Image_Gwen.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "I don't want it to stain my clothes...";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 210)
    {
        Image_PJ.SetActive(true);
        Image_Gwen.SetActive(false);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "PJ";
        Char5PJSpeech.text = "Yeah this doesn't resonate with me as much as the other doors.";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 211)
    {
        Image_PJ.SetActive(false);
        Image_Chad.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "Chad";
        Char2ChadSpeech.text = "*Looking at you* Why don't Greg, you, and I take on this door and you two pick another one?";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 212)
    {
        Image_Chad.SetActive(false);
        Image_Gwen.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "Ugh...fine.";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 213)
    {
        Image_PJ.SetActive(true);
        Image_Gwen.SetActive(false);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "PJ";
        Char5PJSpeech.text = "Have fun you guys. See you on the other side.";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 214)
    {
        Image_PJ.SetActive(false);
        Char1You.text = "You";
        Char1YouSpeech.text = "C'mon guys, let's just get moving.";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 215)
    {
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "Narrator";
        Char6Narration.text = "As you roll your eyes at your friends antics, you push open the door, carefully avoiding the ooze...";
        nextButton.SetActive(false);
        allowSpace = false;
        Button_SceneChange2.SetActive(true);
    }

    else if (primeInt == 300)
    {
        Image_Gwen.SetActive(false);
        Char1You.text = "You";
        Char1YouSpeech.text = "Why don't we check out the scratched up door? It looks less tacky than the other two...";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        //gameHandler.AddPlayerStat(1);
    }
    else if (primeInt == 301)
    {
        Image_Gregory.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "Gregory";
        Char4GregorySpeech.text = "I wonder what they used to create scratches that deep...they look so realistic!";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 302)
    {
        Image_Gregory.SetActive(false);
        Image_Gwen.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "Looks kinda boring to me...but whatever, I guess.";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 303)
    {
        Image_Gwen.SetActive(false);
        Image_PJ.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "PJ";
        Char5PJSpeech.text = "Those look like what I imagine the wounds on my soul would look like.";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 304)
    {
        Image_PJ.SetActive(false);
        Image_Chad.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "Chad";
        Char2ChadSpeech.text = "You good, bro? If you ever wanna come to the gym or something with me you totally can!";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 305)
    {
        Image_Chad.SetActive(false);
        Image_Gwen.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "Yeah, maybe a hobby aside from being twisted all the time would be good for you.";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 306)
    {
        Image_Gwen.SetActive(false);
        Image_PJ.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "PJ";
        Char5PJSpeech.text = "Ugh...no one will ever understand me...";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 307)
    {
        Image_PJ.SetActive(false);
        Image_GregoryScared.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "Gregory";
        Char4GregorySpeech.text = "Can we please just get this over with??";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 308)
    {
        Image_GregoryScared.SetActive(false);
        Image_Gwen.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "I definitely want to go through this door...It looks clothing safe.";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 309)
    {
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "This outfit is too expensive to be ruined by mysterious substances at some horror house...";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 310)
    {
        Image_Gwen.SetActive(false);
        Image_Chad.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "Chad";
        Char2ChadSpeech.text = "It looks kinda boring honestly...Greg do you wanna check out that green goo with me?";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 311)
    {
        Image_Chad.SetActive(false);
        Image_Gregory.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "Sure!";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 312)
    {
        Image_Gregory.SetActive(false);
        Image_Gwen.SetActive(true);
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "Gwen";
        Char3GwenSpeech.text = "See you losers on the other side! Don't get too scared!";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 313)
    {
        Image_Gwen.SetActive(false);
        Char1You.text = "You";
        Char1YouSpeech.text = "Geez...they really busted up this door...";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
    }
    else if (primeInt == 314)
    {
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "Narrator";
        Char6Narration.text = "And on that note, you follow Gwen and PJ through the door...";
        nextButton.SetActive(false);
        allowSpace = false;
        Button_SceneChange3.SetActive(true);
    }

}
        // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct()
    {
        Char1You.text = "";
        Char1YouSpeech.text = "The bloody door.";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
        public void Choice1bFunct()
    {
        Char1You.text = "";
        Char1YouSpeech.text = "The slimy door.";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
        public void Choice1cFunct()
    {
        Char1You.text = "";
        Char1YouSpeech.text = "The scratched door.";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        primeInt = 299;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

        public void SceneChange1()
    {
        SceneManager.LoadScene("Scene3a");
    }

        public void SceneChange2()
    {
        SceneManager.LoadScene("Scene3b");
    }

        public void SceneChange3()
    {
        SceneManager.LoadScene("Scene3c");
    }
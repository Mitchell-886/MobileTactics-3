using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oik : MonoBehaviour
{
    float timer;
    public Text memestuff;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5 && timer < 6)
        {
            memestuff.text = "How did you get here?";
        }
        else if (timer > 10 && timer < 11)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 20 && timer < 21)
        {
            memestuff.text = "Can you just leave that would be nice.";
        }
        else if (timer > 30 && timer < 31)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 50 && timer < 51)
        {
            memestuff.text = "Just click the button it takes you to the menu.";
        }
        else if (timer > 60 && timer < 61)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 80 && timer < 81)
        {
            memestuff.text = "You dont get anything for sitting here and waiting.";
        }
        else if (timer > 90 && timer < 91)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 120 && timer < 121)
        {
            memestuff.text = "Ok what if i told you some secrets and then will you go away?";
        }
        else if (timer > 130 && timer < 131)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 140 && timer < 141)
        {
            memestuff.text = "If you click the button i will tell you the secret in the game.";
        }
        else if (timer > 150 && timer < 151)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 180 && timer < 181)
        {
            memestuff.text = "Ok fine. there is a secret chest in the game. its in the jungle area. Now please click the button";
        }
        else if (timer > 195 && timer < 196)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 220 && timer < 221)
        {
            memestuff.text = "You really dont give up do you? I coded this to go on for a long time honestly and it isnt worth it just please stop with this endless pain.";
        }
        else if (timer > 239 && timer < 240)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 260 && timer < 261)
        {
            memestuff.text = "Ok are you trying to die of boredom or are you just let the text run.";
        }
        else if (timer > 270 && timer < 271)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 290 && timer < 291)
        {
            memestuff.text = "if you don't leave or atleast pay attention to what im saying i will close the game myself";
        }
        else if (timer > 300 && timer < 301)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 340 && timer < 341)
        {
            memestuff.text = "What the heck dude your still here like just GO AWAY NOW. i wont tell you anymore secrets this is it.";
        }
        else if (timer > 350 && timer < 351)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 380 && timer < 381)
        {
            memestuff.text = "You know what ill tell you that there is a secret maze in the jungle with that chest but be warned it is cursed.";
        }
        else if (timer > 390 && timer < 391)
        {
            memestuff.text = "The way to get there is from spawn head down and take the next left then hold the up button until you go through a wall.";
        }
        else if (timer > 410 && timer < 411)
        {
            memestuff.text = "Be warned it is very hard. Not even i know the path to the end of the maze.";
        }
        else if (timer > 425 && timer < 426)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 460 && timer < 461)
        {
            memestuff.text = "Ok your making me mad just leave or i will force quit this game myself.";
        }
        else if (timer > 475 && timer < 476)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 500 && timer < 501)
        {
            memestuff.text = "You are trying to hard just click the button";
        }
        else if (timer > 510 && timer < 511)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 540 && timer < 541)
        {
            memestuff.text = "Did you know that you are a really mean person";
        }
        else if (timer > 550 && timer < 551)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 570 && timer < 571)
        {
            memestuff.text = "Hey man this is my home i want you to leave now please.";
        }
        else if (timer > 580 && timer < 581)
        {
            memestuff.text = ". . .";
        }
        else if (timer > 590 && timer < 591)
        {
            memestuff.text = "Well i told you to leave kindly but you YOU just wont listen i told you there is nothing here i will give you 1 minutes to leave!";
        }
        else if (timer > 600 && timer < 601)
        {
            memestuff.text = "Time is ticking";
        }
        else if (timer > 660 && timer < 661)
        {
            memestuff.text = "I told you i would force quit the game so goodbye.";
        }
        else if (timer > 668 && timer < 669)
        {
            Application.Quit();
        }

    }   
}
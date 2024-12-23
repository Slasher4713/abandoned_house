﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace abandoned_house
{
    public partial class abandonedHouse : Form
    {
        //Global varibles
        int page = 1;
        int sword = 0;
        int hope;
        int sprain = 0;
        //Random number generator
        Random randGen = new Random();
        //Global soundplayers
        SoundPlayer scream = new SoundPlayer(Properties.Resources.scream);
        SoundPlayer foot = new SoundPlayer(Properties.Resources.footstepWood);
        SoundPlayer clap = new SoundPlayer(Properties.Resources.clap);
        public abandonedHouse()
        {
            InitializeComponent();
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            //Determine pages
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 3)
            {
                page = 2;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                //If the sword is collected, go to a different page
                if (sword == 0)
                {
                    page = 13;
                }
                else if (sword == 1)
                {
                    page = 14;
                }
            }
            else if (page == 11)
            {
                page = 16;
            }
            else if (page == 12)
            {
                page = 15;
            }
            else if (page == 13)
            {
                page = 10;
            }
            else if (page == 14)
            {
                page = 10;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                //If the sword is collected, go to a different page
                if (sword == 0)
                {
                    page = 25;
                }
                else
                {
                    page = 26;
                }
            }
            else if (page == 19)
            {
                page = 23;
            }
            else if (page == 20)
            {
                page = 27;
            }
            else if (page == 21)
            {
                page = 27;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 1;
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 1;
            }
            else if (page == 26)
            {
                page = 1;
            }
            else if (page == 27)
            {
                page = 28;
            }
            else if (page == 29)
            {
                page = 1;
            }
            else if (page == 30)
            {
                page = 1;
            }
            else if (page == 31)
            {
                page = 1;
            }
            else if (page == 97)
            {
                page = 1;
            }

            //Display the page it's on
            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //Determine the page that it will go to
            if (page == 1)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 11;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 6;
            }
            else if (page == 11)
            {
                page = 17;
            }
            else if (page == 12)
            {
                page = 6;
            }
            else if (page == 13)
            {
                page = 6;
            }
            else if (page == 14)
            {
                page = 6;
            }
            else if (page == 16)
            {
                page = 19;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 22;
            }
            else if (page == 19)
            {
                page = 24;
            }
            else if (page == 20)
            {
                page = 97;
            }
            else if (page == 21)
            {
                page = 97;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 99;
            }
            else if (page == 26)
            {
                page = 99;
            }
            else if (page == 27)
            {
                page = 29;
            }
            else if (page == 29)
            {
                page = 99;
            }
            else if (page == 30)
            {
                page = 99;
            }
            else if (page == 31)
            {
                page = 99;
            }
            else if (page == 97)
            {
                page = 99;
            }

            //Display the page it's on
            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 6)
            {
                page = 12;
            }

            //Display the page it's on
            DisplayPage();
        }

        private void DisplayPage()
        {
            //Don't display option 3
            option3Label.Text = "";

            switch (page)
            {
                //Display the picture, sound, options, information of the page
                case 1:
                    SoundPlayer wind = new SoundPlayer(Properties.Resources.wind);
                    wind.Play();
                    sprain = 0;
                    sword = 0;
                    outputLabel.Text = "You wake up in an abandoned house. Do you want to try and go back to sleep?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.bedroomOne;
                    break;
                case 2:
                    SoundPlayer zzz = new SoundPlayer(Properties.Resources.zzz);
                    zzz.Play();
                    pictureBox.Image = Properties.Resources.Sleep;
                    outputLabel.Text = "You can't go back to sleep.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    option3Button.Enabled = false;
                    //Show a page for a bit, and then go back to a different page
                    Refresh();
                    Thread.Sleep(2000);
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    option3Button.Enabled = true;
                    page = 3;
                    DisplayPage();
                    break;
                case 3:
                    outputLabel.Text = "Do you try to go back to sleep?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.bedroomOne;
                    break;
                case 4:
                    SoundPlayer step = new SoundPlayer(Properties.Resources.footstepWood);
                    step.Play();
                    outputLabel.Text = "There is a hallway out of the room, and a window to your right. Where will you go?";
                    option1Label.Text = "Jump out the window";
                    option2Label.Text = "Go to the hallway";
                    pictureBox.Image = Properties.Resources.bedroomOne;
                    break;
                case 5:
                    SoundPlayer glass = new SoundPlayer(Properties.Resources.glass);
                    glass.Play();
                    outputLabel.Text = "You jump out the window";
                    option1Label.Text = "...";
                    option2Label.Text = "";
                    pictureBox.Image = Properties.Resources.window;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    option3Button.Enabled = false;
                    //Show a page for a bit, and then go back to a different page
                    Refresh();
                    Thread.Sleep(1500);
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    option3Button.Enabled = true;
                    hope = randGen.Next(1, 101);

                    //Random chance of survival
                    if (hope <= 10)
                    {
                        page = 8;
                        DisplayPage();
                    }
                    else
                    {
                        page = 7;
                        DisplayPage();
                    }

                    break;
                case 6:
                    foot.Play();
                    outputLabel.Text = "In the hall there are stairs, a right room and a left room.";
                    option1Label.Text = "left room";
                    option2Label.Text = "Stairs";
                    option3Label.Text = "Right room";
                    option3Button.Visible = true;
                    pictureBox.Image = Properties.Resources.hallway;
                    break;
                case 7:
                    SoundPlayer thud = new SoundPlayer(Properties.Resources.thud);
                    thud.Play();
                    outputLabel.Text = "You jumped to your death. Nice one. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.jumped;
                    break;
                case 8:
                    clap.Play();
                    outputLabel.Text = "You somehow survived, and you escape! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.escapedWindow;
                    break;
                case 9:
                    foot.Play();
                    outputLabel.Text = "There is a creepy closet, do you want to go back?";
                    option1Label.Text = "No, check closet";
                    option2Label.Text = "Yes";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.closet;
                    break;
                case 10:

                    //Check to see if sword has already been taken
                    if (sword == 0)
                    {
                        page = 13;
                        DisplayPage();
                    }
                    else
                    {
                        page = 14;
                        DisplayPage();
                    }

                    break;
                case 11:
                    foot.Play();
                    option3Button.Visible = false;
                    outputLabel.Text = "You walk down a long hallway. You hear a spooky noise ";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    pictureBox.Image = Properties.Resources.longHallway;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    option3Button.Enabled = false;
                    //Give some suspense with waiting and then show different information on the page
                    Refresh();
                    Thread.Sleep(1500);
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    option3Button.Enabled = true;
                    outputLabel.Text = "A knife suddenly flies at you!";
                    option1Label.Text = "Dodge the knife";
                    option2Label.Text = "Catch the knife";
                    pictureBox.Image = Properties.Resources.knife;
                    break;
                case 12:
                    SoundPlayer spooky = new SoundPlayer(Properties.Resources.spooky);
                    spooky.Play();
                    outputLabel.Text = "You see a worn down bedroom. Go Back?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.bedroomTwo;
                    break;
                case 13:
                    SoundPlayer findSword = new SoundPlayer(Properties.Resources.findSword);
                    findSword.Play();
                    outputLabel.Text = "You found a sword!";
                    pictureBox.Image = Properties.Resources.honshuSword;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    option3Button.Enabled = false;
                    //Show that you found a sword for a bit, and then ask if you want to go back
                    Refresh();
                    Thread.Sleep(1500);
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    option3Button.Enabled = true;
                    sword = 1;
                    outputLabel.Text = "Do you want to go back?";
                    option1Label.Text = "No, check closet";
                    option2Label.Text = "Yes";
                    pictureBox.Image = Properties.Resources.closet;
                    break;
                case 14:
                    SoundPlayer sad = new SoundPlayer(Properties.Resources.sad);
                    sad.Play();
                    outputLabel.Text = "You already took the sword ";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    pictureBox.Image = Properties.Resources.closet;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    option3Button.Enabled = false;
                    Refresh();
                    Thread.Sleep(1500);
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    option3Button.Enabled = true;
                    outputLabel.Text = "Do you want to go back?";
                    option1Label.Text = "No, check closet";
                    option2Label.Text = "Yes";
                    break;
                case 15:
                    SoundPlayer breaks = new SoundPlayer(Properties.Resources.floorBreak);
                    breaks.Play();
                    outputLabel.Text = "The floor caves in, and you fall through";
                    pictureBox.Image = Properties.Resources.broken;
                    Refresh();
                    Thread.Sleep(1500);
                    hope = randGen.Next(1, 101);

                    //Random 50% chance of spraining ankle 
                    if (hope <= 50)
                    {
                        page = 21;
                        DisplayPage();
                    }
                    else
                    {
                        page = 20;
                        DisplayPage();
                    }

                    break;
                case 16:
                    SoundPlayer swoosh = new SoundPlayer(Properties.Resources.swoosh);
                    swoosh.Play();
                    outputLabel.Text = "You dodged the knife. What do you do?";
                    option1Label.Text = "Run down the hallway";
                    option2Label.Text = "Look around the hallway";
                    pictureBox.Image = Properties.Resources.longHallway;
                    break;
                case 17:
                    scream.Play();
                    outputLabel.Text = "You didn't catch the knife. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.deadHallway;
                    break;
                case 18:
                    SoundPlayer encounter = new SoundPlayer(Properties.Resources.spooky);
                    encounter.Play();
                    outputLabel.Text = "You run down the hallway, and find a ghost. Will you fight it or try and talk it out?";
                    option1Label.Text = "Fight";
                    option2Label.Text = "Talk it out";
                    pictureBox.Image = Properties.Resources.ghost;
                    break;
                case 19:
                    SoundPlayer find = new SoundPlayer(Properties.Resources.findSword);
                    find.Play();
                    outputLabel.Text = "You look around the hallway like something isn't right. You look hard, harder than you've ever looked before. Just when you are about to give up, you see a door hidden in the wall. Do you use the door?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.hiddenDoor;
                    break;
                case 20:
                    SoundPlayer snap = new SoundPlayer(Properties.Resources.snap);
                    snap.Play();
                    outputLabel.Text = "You sprain your ankle from the fall. You are in a kitchen. There is a door, but you can try to go back upstairs";
                    option1Label.Text = "Door";
                    option2Label.Text = "Go Back";
                    sprain = 1;
                    pictureBox.Image = Properties.Resources.kitchen;
                    break;
                case 21:
                    outputLabel.Text = "You are in a kitchen. There is a door, but you can try to go back upstairs";
                    option1Label.Text = "Door";
                    option2Label.Text = "Go Back";
                    pictureBox.Image = Properties.Resources.kitchen;
                    break;
                case 22:
                    scream.Play();
                    outputLabel.Text = "You try and talk to the ghost. It turns out, the ghost can't speak English. In fact, it can't speak at all. The ghost hovers toward you, and ends your life. Play again? ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.talking;
                    break;
                case 23:
                    clap.Play();
                    pictureBox.Image = Properties.Resources.rainExit;
                    outputLabel.Text = "You open the door and smell the sweet, sweet fresh air. You run away happily. Do you want to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 24:
                    pictureBox.Image = Properties.Resources.hiddenLose;
                    scream.Play();
                    outputLabel.Text = "Not wanting to go through the door, you look around a bit more. You don't notice it, but a ghost slowly creaps up behind you. You turn around, and so shocked from the ghost you pass out. You die. Do you want to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 98:

                    //If you have the sword, go to a winning page
                    if (sword == 1)
                    {
                        page = 26;
                        DisplayPage();
                    }
                    else
                    {
                        page = 25;
                        DisplayPage();
                    }

                    break;
                case 25:
                    pictureBox.Image = Properties.Resources.fightFists;
                    scream.Play();
                    outputLabel.Text = "You attempt to fight the ghost. You throw your fists at him. However, your fist goes straight through him. The ghost pulls out a gun and shoots you. Do you want to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 26:
                    clap.Play();
                    pictureBox.Image = Properties.Resources.fightSword;
                    outputLabel.Text = "The sword that you picked up suddenly glows. You slash the ghost with the sword, killing it. The house suddenly starts to disapear, leaving you in the middle of the woods. You escaped! Do you want to play again? ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 27:
                    SoundPlayer thunder = new SoundPlayer(Properties.Resources.thunder);
                    thunder.Play();
                    pictureBox.Image = Properties.Resources.rainExit;
                    outputLabel.Text = "You walk over to the door and you open it. The cold air burns your throat. Just as you thought you were free, you hear something behind you. Out of the corner of your eye, you see a ghost. What will you do?";
                    option1Label.Text = "Run out the doors";
                    option2Label.Text = "Stand still";
                    break;
                case 28:
                    pictureBox.Image = Properties.Resources.runningExit;
                    outputLabel.Text = "You run outside, and start to sprint away.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    //Animation of running
                    Refresh();
                    Thread.Sleep(500);
                    pictureBox.Image = Properties.Resources.rainExit;
                    Refresh();
                    Thread.Sleep(500);
                    pictureBox.Image = Properties.Resources.runningExit;
                    Refresh();
                    Thread.Sleep(500);
                    pictureBox.Image = Properties.Resources.rainExit;
                    Refresh();
                    Thread.Sleep(500);
                    pictureBox.Image = Properties.Resources.runningExit;
                    Refresh();
                    Thread.Sleep(500);
                    pictureBox.Image = Properties.Resources.rainExit;
                    Refresh();
                    Thread.Sleep(500);
                    pictureBox.Image = Properties.Resources.runningExit;

                    //If you have a sprained ankle, you lose
                    if (sprain == 1)
                    {
                        page = 31;
                        DisplayPage();
                    }
                    else
                    {
                        page = 30;
                        DisplayPage();
                    }

                    break;
                case 29:
                    pictureBox.Image = Properties.Resources.rainGhost;
                    scream.Play();
                    outputLabel.Text = "As you stand still, the ghost finds you an easy target to kill. The ghost almost feels sad killing you, because you stand there helpless. The ghost eventually makes up his mind and kills you. Do you want to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 30:
                    clap.Play();
                    pictureBox.Image = Properties.Resources.rainWin;
                    outputLabel.Text = "You gain speed, going faster and faster. The murmers of the ghost fade out as you run into the woods. You escaped! Do you want to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 31:
                    pictureBox.Image = Properties.Resources.rainLose;
                    scream.Play();
                    outputLabel.Text = "As you're running, you fall over. Your sprained ankle hurts way too much to continue. The ghost waltzes over to you, and puts the rest of your shame out. Do you want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 97:
                    pictureBox.Image = Properties.Resources.climbLose;
                    scream.Play();
                    outputLabel.Text = "While you are trying to climb back upstairs, a ghost steadily sneeks up on you. Just as you are about to make it up, the ghost kills you. Do you want to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 99:
                    SoundPlayer hello = new SoundPlayer(Properties.Resources.hello);
                    hello.Play();
                    pictureBox.Image = Properties.Resources.thank1;
                    outputLabel.Text = "Thanks for playing";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(1000);
                    //Close the program
                    Close();
                    break;
            }
        }
    }
}

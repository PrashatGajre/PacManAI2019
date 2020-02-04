# PacManAI


Artificial Intelligence for Games PROG59207 
Assignment #1 
Due Date: 
February 14
h
, 11:59PM  
Assignment Type: 
Individual Assignment  
Submission:  

Your files should be submitted through Dropbox in SLATE.  

Your Submission should be package in a unityplackage file. 
o
Your file should be named: 
assignment1.FIRSTNAME.LASTNAME.unitypackage
o
5% will be deducted for incorrect file name
o
Only the last submission is accepted and marked, all other submissions are ignored. 
o
Your project must compile and run to receive any marks. Programs that do not run or 
compile will receive a grade of zero 

You 
MUST
 remove unnecessary files to submit so your archive size is small 
Summary:  

This assignment is based off FSM 

Make sure you follow the instructions 

If you have any questions regarding the assignment contact me. 

If there are any issues within the loading engine do not hesitate to contact me. 
Assignment: 
Pac Man!! Your task is to implement the AI for the Ghosts. You must create AI for all 4 ghosts and they 
should act differently than each other (similar to Pac Man if possible). For this assignment you must 
create an FSM using Mechanim as your Editor.  
Based off our FSM drawings we made in class you must implement the following States (and any others 
you feel necessary): 

Shared States: 
o
Die and return to home 
o
Respawn/Resurrect 

Unique state
o
Chase Player 
o
Run-away 
As you can see from above the Chase Player and Run-away state must be different for each Ghost 
implemented (each must go after the ghost in a different manner and each should run away differently). 
Your game must be data driven. I do not want to see any hardcoded values in your code. If it is a variable 
that can be and should be modified by a designer it should be visible in the Inspector. 
I have provided you with a project that lets the main player move through the world using the Arrow keys. 
There is also a pathfinding A* algorithm implemented for you to use that the Ghosts already use. You 
must interface with this to move your Ghost. 
There are a few singleton classes in the system already for you to use: 

GameDirector 
o
A UnityEvent that can notify you when a game state changes 
o
The ability to increase the game score 

Pathfinding 
o
The Collision Map 
o
Calling this with world coordinates will get you a path through the grid 
IMPORANT
:
When the Main Player picks up a PowerPellet a UnityEvent is Invoked, anyone who adds a 
listener to this will get a callback. By default the game starts with the player not invincible. The 
GameDirector will determine when to go back to a normal state and notify anyone listening to the 
UnityEvent that the game state has changed. 
IMPORTANT: 
The Pacman class will handle when it is killed and when it kills a ghost.
You shouldn’t have to touch the Pacmman, Pellet, or PowerPellet classes. 
Here is a link to some reading about the Ghosts in Pac-Man: 
http://gameinternals.com/post/2072558330/understanding-pac-man-ghost-behavior
The assessment for this assignment is as follows: 
Global: 

You must implement a 
FSM
 for the Ghosts 

You must provide a data driven design to your projects so what can be edited should be and 
what cannot shouldn’t be. 

The Ghosts must share the common states (don’t re-write them, waste of time) but must have 
the unique chase and run-away state. 
FSM - 60%: 

FSM class handles the state transitions for all Ghosts, game is data driven through Inspector 

The First state can be set via the Inspector 

Your Ghost is smart and has AI to get to player 

Ghosts uses all states mentioned above. 
Ghost AI - 10%: 

Ghost acts different yet smart. 
Ghost AI - 10%: 

Ghost acts different yet smart. 
Ghost AI - 10%: 

Ghost acts different yet smart. 
Ghost AI - 10%: 

Ghost acts different yet smart. 
Evaluation:
Your submission will be evaluated based on the following criteria: 

Efficient Code:
 Program uses variables where and only when necessary; program doesn't define 
variables that are never used, nor does it use too many variables for unnecessary tasks; program 
logic is written concisely and is not cluttered with unnecessary tasks. 

Functionality:
 program functions according to specifications. 

Compile: 
Your program must compile to get a grade 

Programming Style:
 proper indentation and spacing, use of comments/documentation; all 
identifiers are descriptive and valid; variables are defined with appropriate types and converted 
when required. 

Other:
 all instructions regarding submissions and program specifications have been followed; 
submission was completed and submitted as requested in a timely fashion; techniques discussed 
in class have been used. 
Submission:
1.
Assignment submissions:  

No Late Date 

All online submissions are done via SLATE (
e-mail submissions will NOT be accepted
)  
2.
All assignments must be completed as 
individual efforts 
unless stated otherwise. Please refer to 
the 
Academic Dishonesty Policy
.  
3.
Cheating: 
a.
Any attempt at cheating on an assignment/quiz/exam will result in a grade of zero for 
that particular assessment. Documentation on Academic Dishonesty can be found 
here
. 

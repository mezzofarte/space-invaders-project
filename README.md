# space-invaders-project2
A space invaders clone using Unity Game Engine and C#.

![game screenshot](https://raw.githubusercontent.com/mezzofarte/space-invaders-project2/master/Space%20Invaders/Assets/screenshot.png)

Contributors:
Lindsey Duong, Adrienne Caparaz

EXPLANATIONS

Player:
Used 48x16 px sprite
Bullet ignores player collision so can be instantiated from middle
Able to move only left and right, didn’t implement any up/down
Can use space or left mouse to shoot, can only shoot once previous bullet is destroyed using a bool statement
Dies if collides with enemy bullet
Not able to go off screen due to invisible colliders

Enemies:
Used 16x16 px sprites
Parent/child(?) method (multiple on one gameObject) to make all move in unison
Implemented Physics2D.OverlayCircle to ensure the bottommost enemy shoots
Uses random function to randomize when bullets are shot
Dies if shot by player
Not able to go off screen due to invisible colliders
Separated by tags to give correct points

Game Over:
Had a counter for the three lives a player had
Used an overarching GameController that constantly checked if the player had reached zero lives, stopping the time and prompting the game over menu if so
Also had a conditional if the enemy group collided with the bottom collider of the screen, prompting a game over if that occurred

UI:
The start and game over menus were both made using panels and buttons on Unity
Utilized onClick() to prompt actions according to the button type
The in-game stats were controlled by their respective controllers and updated the Text object as the values changed, but constantly checked it through Update
Winning:
Wins if enemy count is == 0
Enemy count decreases once enemies die

UFO: 
Had a random number generator paired with a conditional to simulate the rarity of the instantiation of UFOs
Used a random number generator to select a point value in an array
Pause Menu:
Made the time value 0f to simulate a pause
SetActive the pause menu when the escape key is pressed
The resume button simply reverted the time value back to 1f
Used Application.Quit() to quit on all quit buttons

Original repo:
https://github.com/adriennecaparaz/space-invaders

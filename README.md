# Charle-Lily_2022_Game_Engines_Asignment

# Toaster of Wonders

#### Names: Charles Kelly, Lily Hayes

#### Student Numbers: C20487792, C20477084

#### Video: 
![YouTube](https://www.youtube.com/watch?v=3pJGVPqz8Mw)

## Description of the project
All around the project, you can find special codes to put into your Toaster of Wonders! It’ll then toast an object related to the code you put into the toaster that is launched into the sky, each coming with a specific and unique sound effect.

## Instructions for use
You look around the room to see the codes floating all around you. You go over to the toaster and left click on the numbers to select them. If you click on numbers in the order of the codes to match the string (e.g. if you see the code in the sky that says “1991”, you press 1, 9, 9, 1, Enter). After that, the toaster will launch an object tied to that code, with each one having a unique sound effect playing upon being launched.

## How it works
The player has a basic character movement script that allows them to fly by checking if they’re on ground and then giving them an unlimited jump afterwards. They spawn on a platform close to the toaster anyway, though.

The player shoots a raycast ahead of them when they click. If the raycast hits an object tagged “Number”, it will add the object’s name to the string value **currentValue**. This value is checked upon hitting “Enter” - if it matches a value that is contained in the **toasterObjectCodes[]** array, it will take the toasterObjectCode’s index number and apply that to the toasterObject index, spawning the relevant toasterObject and any sounds that go alongside it at a spawnpoint chosen by an empty GameObject (which can simply be found inside the toaster). Pressing “Enter” also clears the string value.

When an object is spawned, it’s launched into the air by the **Launcher.cs** script. This script chooses a random Force value between 20 and 30 as soon as the object is spawned in its Start function, and then adds that force as an Impulse Force as an upwards Vector3. This sends the object shooting into the sky and plays its sound effect! From there, the Update function is always checking to see if the object’s velocity is below a certain value (in this case -3) - if it is, and if the object has not exploded already (tracked through the hasExploded boolean, which is false by default), the object will Explode, which applies another Impulse Force in any downwards direction between 0 degrees and -180 degrees, all done through some trigonometry magic. hasExploded is then set to true to ensure that the game doesn’t blow up your objects a billion times. 

The visualiser works by getting spectrum data from an audio source using a **fast Fourier transform algorithm**, which admittedly isn’t something I fully understand. It then simply splits this data across the 512 samples - each of which is linked to a cube - and scales the cubes upward based on their spectrum values.

Finally, the main menu works through simple Unity events that change the scene if you press “PLAY” and quit the application if you press “QUIT”. It also has a DontDestroyOnLoad function that is attached to the Visualiser object which is also in the main menu but isn’t visible - this is just to ensure that the music keeps playing from the main menu when switching to the game!



## List of classes/assets in the project
+	ClickOnObject - Self written
+	Launcher - Self written
+	MouseLook - Self written
+	PlayerMovement - Self written
+	Rainbow - Source: https://youtu.be/ZfWEBJVWydo
+	Spawner - Self written
+	StringHandler - Self written
+	Instantiate Cubes - Self Written
+	KeepMusicPlaying - Self-written
+	Visualiser - Self-written

## References
| Asset| Sorce |
|-----------|-----------|
| Google Logo | [hyperlink](https://sketchfab.com/3d-models/google-logo-7e904bea654b40d7861c84a7cb5cc969) |
| Messenger Logo | 	[hyperlink](https://sketchfab.com/3d-models/messenger-logo-ff6081e0ff594da1bb1edf6e8bca4371) | 
| Playstation Logo| 	[hyperlink](https://sketchfab.com/3d-models/playstation-logo-3d-printable-b334756ab43e47479042c30d0) | 
| Sega Logo | 	[hyperlink](https://sketchfab.com/3d-models/sega-logo-c431309e548149f7b8d4b4c4df203204) | 
| Nintendo 64 Logo | 	[hyperlink](https://sketchfab.com/3d-models/nintendo-64-logo-c45a05628f1e4d0287ce3ddcc1becd7f) | 
| Sketchfab Logo | 	[hyperlink](https://sketchfab.com/3d-models/sketchfab-logo-f57853add5ca4403adf0300ba41af986) | 
| Autobots Emblem | 	[hyperlink](https://sketchfab.com/3d-models/autobots-logo-495fc06eaec946388fd60298a162e78e) | 
| Pac-man and ghosts | 	[hyperlink](https://sketchfab.com/3d-models/neon-pac-man-7be0794534154b98a1bccc8ed99df58d) | 
| Weed leaf | 	[hyperlink](https://www.cgtrader.com/free-3d-models/plant/leaf/marijuana-e0d89df5-6671-402c-8dd9-a706df436d34) | 
| Dollar sign | 	[hyperlink](https://sketchfab.com/3d-models/dollar-signs-16bd4c23458647e9a5b94790dc8f5c55v) |
| Sliced Bread | 	[hyperlink](https://sketchfab.com/3d-models/sliced-bread-5e8f3d6175d24aab97266f0cad5f1b7f) | 
| Toaster | 	Mark Lambe 3rd year game design  | 
| Music |  Phat Phrog Studios - Miami Weekend (purchased & licensed) | 

## What I am most proud of in the assignment
Charles: The general atmosphere of the play area and how it comes across as very chill and viby.

Lily: Getting the array system all smoothened out was really satisfying; I originally had hugely inefficient code that manually checked for every single string input, which wasn’t modular at all and was really nasty to work on. Finding out Array.IndexOf existed and was perfect for my use case was a pretty fun case of problem solving for me, and it made working in the project a super smooth process, letting me add and remove toasterObjects whenever I wanted.

## What I learned 
Charles: I learned a small amount on 3D modules by importing them, having them with their texture and finally learning how to do a rainbow effect on an object.

Lily: I learned how to make an equaliser which I hadn’t done before, that was a really cool thing to figure out. I also learned a bit more about DontDestroyOnLoad and arrays, which were a pain for me to figure out in past projects. I’m very happy with both.

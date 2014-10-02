SkateBoard-Travel-Technique
===========================
Skate Board Travel Technique

Summary
This travel technique tries to mimic a person traveling on a skateboard. The speed and direction can be handled by the person travelling.  Once the person starts moving, he/she can change direction similar to changing on a skateboard (along a curve) by banking left or right. The person can also stop and start movement at any point in time.
How it works
•	To trigger travelling, the vertical distance between the legs above a threshold is tracked (one foot above another while you push the skateboard). Ex:  Left footed people use their right foot to push the board. In this case, we check if right foot is above certain threshold of the left foot to trigger movement.
•	For direction, the change in horizontal movement of the HMD is tracked. This mimics the bobbing of head/body to make a turn on skateboard. 
•	To travel faster (incremental), the user must press A and B buttons together of the Right Wii Remote.
•	Releasing one of the buttons will get the user back to original speed.
•	Intuitively, to stop the skateboard, the user has to bring down his/her foot to the same level as the other

Steps to follow with 5 UDE input simulator
There are 4 landmarks for way finding in my scene:
•	Military truck -- Start
•	Oil tank
•	Water well
•	Tower -- Destination
	
1.	The user starts from one corner of the virtual world from where a military truck is visible. 
2.	Increase the value more than 0.1 under the Right Shoe Y.  Essentially, the right foot must be above left foot by 0.1 units to trigger moving forward. (Pushing skateboard step)
3.	Step 2 starts the movement in forward direction.
4.	To manoeuvre right, towards the truck, increase values (right drag) under Rift DK 1 X. Similarly to manoeuvre left, decrease values (left drag) under Rift DK 1 X.
5.	After reaching the truck, follow along the green grass path to reach an Oil Tank. 
6.	Follow further along the grass path to reach Water Well.
7.	After reaching Water well, follow along the grass path to reach the Tower which is the destination.
8.	In the above steps, whenever you wish to increase speed, press together button A and button B of Right Wii Remote.  Releasing at least one shall bring back the original speed.

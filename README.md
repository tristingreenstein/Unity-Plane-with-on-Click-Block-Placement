# Unity-Plane-with-On-Click-Block-Placement-with-Transparent-Cube-Indicator
The objective of this homework is to increase your understanding of GameObjects, World Space, Transforms, Camera Controls, Mouse and Keyboard Inputs and other cool stuff...

Building Blocks is a simple project that allows the user to place 1-unit cubes on a predefined board. You can think of it as a block game that allows the user to attach or stack-up cubes to create a specific shape.

You are tasked to write a program that will provide the user with the ability to create structures using blocks.

A block structure constructed by the user:

To complete this assignment you will need to be familiar with several concepts:

GameObjects
Transforms
Physics Raycast
Object instantiation
Normals
Materials
Textures
Tag
# Project Specifications:

You will have a base board created that will have the following dimensions <10,0.1,10> and positioned at <0,0,0>. It will be called Base, and it will have a Tag named Base. The base board will have a textured material that will make it look like a chess board.

The Blocks are going to be on represented by a Unit-Cube. That is a scale of <1,1,1>. 

The user will use the mouse to interact with the world. You will need to perform a few tasks here:

Getting the Mouse Input, Left Click
Create a RaycastHit object to determine info of hit object(s)
Use Physics.Raycast() to determine if you hit something or not
Use Camera.main.ScreenToRay() to convert the mouse coordinate to a Ray object
Determine if you have a hit
If you do have a hit, you will need to determine, what you have hit!

If you are placing a block on the base then the positioning is going to be different then when you are going to be placing a block adjacent to an existing block.

Hint: You will need to know which face of the cube you are hitting to place the new cube accordingly.

 Dynamically display a semi-transparent cube while user is deciding where to place the cube on the board and or other cubes.
if on the board, semi-transparent material will be yellow.
if on a face of an existing block, the cube will have semi-transparent material colored green.
All other functions/features are the same.

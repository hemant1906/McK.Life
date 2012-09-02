McK.Life
========
This is implementation of Convey's Game of Life program 
It's a pure object oriented implementation of Convey's Game of Life and uses MVC pattern.

First project is Actual Game of Life implementation
Usage is very Simple
Create instance of GameEngine specifying the rows and columns
Initialize it with an initial state. This state is in 01 format. 0 means dead, 1 mean alive.
There is Move method of game engine which move the game by x generations. x is the input of Move method.
Render method of game engine render to Console. 

Second project is a console application 
This application uses Game of Life dll and allow users to display some predefined patterns
There is also a facility of providing custom inputs. 
Custom input takes rows, columns, generations and intitial state as input
e.g. 
On Main Menu press c
This will show a new menu
Here enter input like 5 5 10 0000000100001000010000000
This will display a blinker in following format
     
  #  
  #  
  #  



 ###     



For more information please visit this url 
http://en.wikipedia.org/wiki/Conway%27s_Game_of_Life


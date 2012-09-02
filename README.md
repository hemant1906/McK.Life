McK.Life
========
This is implementation of Convey's Game of Life program <br>
It's a pure object oriented implementation of Convey's Game of Life and uses MVC pattern.<br>

First project (McK.GameOfLife) is Actual Game of Life implementation<br>

Usage is very Simple<br>
Create instance of GameEngine specifying the rows and columns<br>
Initialize it with an initial state. This state is in 01 format. 0 means dead, 1 mean alive.<br>
There is Move method of game engine which move the game by x generations. x is the input of Move method.<br>
Render method of game engine render to Console. <br>

Second project (McK.GameOfLifeConsole) is a console application <br>

This application uses Game of Life dll and allow users to display some predefined patterns<br>
There is also a facility of providing custom inputs. <br>
Custom input takes rows, columns, generations and intitial state as input<br>

e.g. <br>
On Main Menu press c<br>
This will show a new menu<br>
Here enter input like 5 5 10 0000000100001000010000000<br>
This will display a blinker in following format<br>
     
  #<br>  
  #<br>  
  #<br>  

<br>
Second Generation 
<br>

 ###     



For more information please visit this url 
http://en.wikipedia.org/wiki/Conway%27s_Game_of_Life


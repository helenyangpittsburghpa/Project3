# Project3

## Background/Story:

It is the year 21xx and the extraterrestrial took over in a small town. Many of the townspeople were abducted by these aliens. As the only one left in this town, you are trying to escape; however, you are blocked by the escape door.

Escape from Extraterrestrial allows you to collect points from defeating the invaders and collecting coins(by throwing cheese since it is their only weakness), which allows you to escape from the exit door once you gain enough points.

## Game Features:
* AD / Left and Right keys to rotate left and right respectively
* W to move forward 
* J Key to throw cheese
* Hold J key to determine the strength of the throw
* Red Bar/Rectangle that measure the strength of the throw
* White Bar/Rectangle that illustrate the max strength you can throw
* Collect coins which are worth 1 point
* Defeat enemies(drone) which are worth 5 points
* Defeat enemies(ufo) which are worth 10 points
* Obtain at least 20 points and go into the exit door to win 
* 5 lives
* enemies(ufo) abducts the player which equals instant death
* enemies(drone) deals 1 damage to the player


## Gallery

![sfhk](https://user-images.githubusercontent.com/44321973/56691620-610b8b80-66ae-11e9-9583-f37a7b36fe28.PNG)
![new2](https://user-images.githubusercontent.com/44321973/56674250-ac5e7380-6687-11e9-99d2-4bad471dba7f.PNG)
![new3](https://user-images.githubusercontent.com/44321973/56674229-a36da200-6687-11e9-8176-cfd43099bb90.PNG)
![new4](https://user-images.githubusercontent.com/44321973/56674183-905ad200-6687-11e9-9cbe-734245c8a349.PNG)


## Summary
For this Project, I used nav mesh agent on 2 different enemies(the drones and the ufos).The enemies will follow the player. I used many different assests from the asset store, such as the player from ToonyTinyPeople(and ThirdPersonController from the standard asset store), the buildings,road, streets are from sample city plain, the drone is from Sci_fi_Drones, the cheese is from Free Food Pack, and etc. 

For the graphical UI: There are two rectangles UI, one(the red one) measure the strength of the player's throw, the other showed the max strength a player can throw. If the player holds the J key long enough and went over the max strength, the strength will loop back. I also have a videoclip that is attached to an UI along with a retry button. When the player runs into the middle of the ufo beam, the UI showed up and plays the clip. However, the clip may not played the first time when the player runs into the ufo beam, but the UI will showed up. 

I got this idea(where these extraterrestrial are afriad of cheese) from asdfmovie4: https://www.youtube.com/watch?v=tjK9oWAAs50
The goal of this game is to collect 20 or more points from defeating enemies(drones and/or ufos) and/or collecting coins, and after earning enough points, go into a white door that is connected to a blueish-greenish building (on top of the building is the word EXIT).  

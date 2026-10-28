# 2D Physics Simulation for Convex polygons

This is a 2D Physics simulation that allows the user to input shapes they draw with initial velocities, accelerations, mass and angular momentums and accelerations.
All of these added objects would influence each other via collisions depending on momentum and be influenced by placed points of gravity in the system. 
## Full summary and Functionality
The program starts with asking users to pick between two simulations, a polygon sim which can use any
shape and includes things such as momentum conversion, or the original prototype and circle-only
simulation which has no physical energy changes and just calculates the movements and new directions
of each circle after a collision.
After choosing the simulation you can add and remove physical and force field objects that can each
affect that instance of the simulation. Once objects are added, they will be included in the algorithms for
collision and force detection, if a collision is then found it will be added to a list of the class type Collision
which is the gone through and resolved, this happens every 60th of a second or as many times as the
user requires.
Objects can be added via either directly inputting data, or drawing where points of an object will be
(only in polygon sim) and using some of the saved values from the inputted data.

https://github.com/user-attachments/assets/902bc4dc-7ae7-4465-8c41-8738ae610c9f

Each object has extensive customization to simulate many scenarios

https://github.com/user-attachments/assets/3692ebe4-0ecc-45c4-a5eb-17ad4d547f64



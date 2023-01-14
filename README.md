# Tech Demo
## Basic Infromation
- Developed on Unity 2020.3.29f1
- The entire map consists of 3 levels:
        - The first level is procedurally generated everytime the user builds the project.
        - The second level consists of Obstacles which uses an animation script to move.
        - The third level consists of another a static map which also has an EnemyAI.
- Types of agents:
        - **Player -** uses NavMesh scripts and a Controller script to navigate and move around the map. Can even jump between different levels using the created links.
        - **Enemy -** uses two separate scripts; one to patrol around the waypoints defined in the third level and second to chase the 'player' when within range.
        **Note: As the 'player' is also randomly generated in level 1 for every build, so, for the 'ChasePlayer' script to work the user has to drag and drop the 'Player(Clone)' from the hierarchy to the Enemy's Inspector (couldn't find a way around it)**
- Third Parties:
        - I used a level prefab I found online on unity asset store (as we are not graded on basis of the UI, therefore, I didn't spend much time on this)
        - Navmesh Components from their github (some of the scripts were edited to make it more suitable for the demo and therefore they are not inside the 'ThirdParty' folder).
- Scripts:
        - **AgentLink -** Allows player to jump between two different grounds and allows to change and create different types of jump (using the curve for the demo)
        - **ChasePlayer -** Used by the 'enemy' agent to chase the 'player' agent when in range (can be changed in the inspector).
        - **EnemyPatrol -** Used by the 'enemy' agent to patrol around the given waypoints in the inspector.
        - **PlayerController -** Accepts left mouseclick to give waypoints to the 'player' agent.
        - **Genrator -** Procedurally Generates the level for 'Ground1'.
        - **NavMesh Components**
- The project majorly focuses on the level generator, navmeshes, and other controller scripts rather than behaviour trees.
- Link to the video documenation: https://www.youtube.com/watch?v=PJ07s5_aQbU

**Note: Sometimes the generated level blocks the player's movements which would be optimised in the future work.**

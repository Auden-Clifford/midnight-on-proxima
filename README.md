# Midnight-on-Proxima
 ## Overview
 **Genre:** Extraction shooter, roguelike, puzzle, horror
 **Player:** 16 players in a match, (4-player teams)
 ### Elements
    - looting
    - puzzle solving
    - combat (PvP & PvE)
    - upgrades/equipment
    - crafting
    - exploration

 ## Specs
 **View:** 3D VR
 **Platform:** PC, Android
 **Language/Software:** C#, Unity,
 **Devices:** Valve index, HTC Vive, Oculus Rift (+S), Quest (1-3)

 ## Gameplay
 Players will start in a home base aboard a small space station where they will have the ability to craft, buy upgrades, and choose a map to enter. Once players choose a map they will be loaded into a lobby with up to 16 other people (4 teams of 4). They will spend the game searching for hidden items including scrap, equipment, and data drives while avoiding traps, solving puzzles, and combating monsters and other players. Players can extract at any time with all of the items they have found by finding a teleporter. Any items that the players are carrying when they extract are kept and can be sold or used later. If a player dies they respawn on the station without their items. Players will need to sell some of their salvage in order to pay their debt to the Proxima Corporation. Players who continuously meet or exceed Proxima Corp's required loan installments will gain favor (credit score) with the company and are allowed access to better items in the shop. Players who fail to meet their required payments will lose credit score, and may be penalized and eventually “let go” (killed) by the company. Players who are let go receive a game over and are set back to the starting point with no credit score or upgrades.

 ### Story
 The Proxima Corporation owns the planet Proxima and has ruled there in absolute power for over a hundred years. Proxima Corp considers itself a retail and logistics company–in the business of manufacturing and delivering consumer goods–however, near-unlimited access to an entire planet’s resources for over a century led them to branch out into many other aspects.

 Specifically, they moved into the military manufacturing and research sector. This line of work led them to develop a weapon for the Interstellar Colonial Defense Coalition (ICDC) a paramilitary group that ostensibly offers colonial defense at a premium. In reality, they are a mercenary group that answers only to the corporate alliance known as The Board, made up of the most powerful corporate entities in known space. Their true goal is to suppress anti-corporate sentiment and rebellion and stop rival companies from gaining footholds on the interstellar scene.

 The weapon Proxima Corporation developed for the ICDC was designed to render an entire star system uninhabitable. To this end, the weapon would agitate the plasma on the surface of a star, causing it to expel extreme amounts of high-energy particles and solar winds. Such conditions would shred planetary atmospheres, scorch the surface of planets, and irradiate everything within a lightyear of the affected star. Ships entering what would have been a star’s Goldilocks zone would be reduced to slag in minutes.

 It is unknown why the ICDC and the Board felt this weapon was needed, but when anti-corporate dissenters caught wind of the project they quickly moved to stop its development. A violent insurrection ensued on the planet Proxima, leading to the weapon being activated. Those who did not reach escape pods before dawn on Proxima were quickly reduced to ash, and those who had escaped were now trapped in the planet’s shadow, unable to leave the star system without being exposed to the star’s unrelenting fire.

 The Proxima Corporation, comfortable on their luxury corporate space station, now sends their indentured servants to the surface of the planet to retrieve lost company property. Such indentures are in no short supply, as anyone who wished to purchase an escape pod before daybreak on the doomed planet had to purchase one from the company on loan. The player is one such indenture, forced to drop to the surface of the planet at midnight when the ground has cooled and scour the planetary settlements for scraps to sell back to the corporation. It is unknown to the debtors what exactly the company hopes to do with the materials they retrieve, but they seem strangely fixated on recovering their weapons research to “appease investors” rather than finding a solution to their current predicament.


 ### Gameloop Outline
 - **Opening the application:** can be launched from SteamVR or Oculus, game will load directly into Homebase
 - **Game Options:** lighting, dominant hand, etc... (idk for now)
 - **Game Levels:** levels or maps will be partially randomly generated regions that can be openly explored. These maps will be made up of layers, starting with the surface layer and moving down underground. Each stacked layer will be smaller than the last, making the map shaped like an upside-down pyramid. As the game progresses, the rising sun will slowly make the higher levels uninhabitable, forcing players to move into the lower (and smaller) layers of the map. This should naturally push groups of players closer together over time and force player interaction towards the end of a match. The randomly generated parts of the map will be made up of prefab modular pieces with various loot, traps, puzzles, or enemies inside. Pre-made parts of the map will consist of landmarks and significant environmental details (i.e. a giant tower in the middle of a city or a huge satellite dish in the middle of a facility) which will have procedural features placed around them.
 - **Controls:**
    - Movement: Secondary thumbstick (left by default); physical movement
    - Rotation: Primary thumbstick (right by default); physical rotation
    - Teleport: Pull back and release primary thumbstick
    - Interaction: Player can grab objects with grip buttons & activate objects with the triggers
    - Inventory: Toolbelt is accessed by depressing the Dpad (or the primary thumbstick on oculus) + inventory for non-tool items(scrap) (over the shoulder? slots at hip/wrists/back?)
    - Game Menu: Hold B button, either hand
 - **Winning:** no official "Win" state. Player continuously plays and get upgrades until they eventually cannot keep up with loan installments. The goal is to see how far you get.
 - **Losing:** If a player misses loan installments, they lose credit score, if credit score drops below a certain threshold the company "lets the player go" and kills them, forcing them to try again from square one.
 - **End:** The game is meant to be continuous, with a game that can be endlessly repeated
 - **Why is this fun:** fighting for your life under corporate oppression while goofing around with friends in the metaphorical trenches is a compelling feeling, and I'm hoping to capture that feeling in gameplay. The ultimate goal of the game will not be to eventually pay off your debt, or even to survive forever under the company. The goal is to get as far as possible and have as much fun as possible before starting a fresh run and trying again. There will also be certain items, like decorations and cosmetics for the player and the station that are kept after a game over, allowing players to keep a sense of cumulative accomplishment.
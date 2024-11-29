Plugin forked from deafps/SharpTimer

I seperated the saveloc command cooldown on the config so the command for loading the loc (checkpoint) would have its own cooldown:

sharptimer_command_spam_cooldown	0.5                                     // Defines the time in seconds between commands can be called. 		Default value: 0.5
sharptimer_command_saveloc_cooldown     0.2                                     // Defines the time in seconds between saveloc can be called (loadloc). Default value: 0.2

(config.cfg)


# SharpTimer
SharpTimer is a "simple" Surf/KZ/Bhop/MG/Deathrun/etc. CS2 Timer plugin using CounterStrikeSharp<br>


## Features
<details> 
  <summary>Timer, speedometer and key input with color customization</summary>
   <img src="https://i.imgur.com/TxAwgbC.png">
</details>

<details> 
  <summary>Players PB</summary>
  <img src="https://i.imgur.com/9HGOhRR.png">
</details>

<details> 
  <summary>Surf Stages and Checkpoints</summary>
  <img src="https://i.imgur.com/xL2y6vs.png">
</details>

<details> 
  <summary>Replays</summary>
</details>

<details> 
  <summary>Discord Webhook</summary>
</details>

<details> 
  <summary>JumpStats</summary>
</details>

<details> 
  <summary>Map CFGs</summary>
</details>

<details> 
  <summary>Custom PlayerModels</summary>
</details>

<details> 
  <summary>VIP Perks</summary>
</details>

<details> 
    <summary>Bonus stages</summary>
  <img src="https://i.imgur.com/NURlZBK.png">
</details>

<details> 
  <summary>Server Point System & Map Ranks</summary>
</details>

<details> 
  <summary>Rank Icons</summary>
  <img src="https://i.imgur.com/7vSKeCv.png">
</details>

<details> 
  <summary>KZ Checkpoint system (disabled by default, check config)</summary>
   <img src="https://i.imgur.com/USX5i8C.png"><br>
   <img src="https://i.imgur.com/kWiHOlz.png"><br>
   <img src="https://i.imgur.com/lXwXNN7.png"><br>
   <img src="https://i.imgur.com/nyn76Q4.png">
</details>

## Dependencies

[**MetaMod**](https://cs2.poggu.me/metamod/installation/)

[**CounterStrikeSharp** *(v215 and up)*](https://github.com/roflmuffin/CounterStrikeSharp/releases)

[**SharpTimerModelSetter** *(optional but recommended for custom player models)*](https://github.com/DEAFPS/SharpTimerModelSetter/)

[**MovementUnlocker** *(optional but recommended)*](https://github.com/Source2ZE/MovementUnlocker)

[**Web panel** *(optional but recommended)*](https://github.com/Letaryat/sharptimer-web-panel)


## Install
* Download the [latest release](https://github.com/DEAFPS/SharpTimer/releases),

* Unzip into your servers `game/csgo/` directory,

* :exclamation: See `game/csgo/cfg/SharpTimer/config.cfg` for basic plugin configuration,

* :exclamation: It is recommended to have a custom server cfg with your desired settings (for example [SURF](https://github.com/DEAFPS/cs-cfg/blob/main/surf.cfg) or [KZ](https://github.com/DEAFPS/cs-cfg/blob/main/kz.cfg)),

# [SharpTimer Wiki/Docs](https://github.com/DEAFPS/SharpTimer/wiki)

# TODO List
- [x] HUD
  - [x] Speedometer
  - [x] Pre
  - [x] Timer
  - [x] Info
    - [x] PB
    - [x] Map Rank Icon
    - [x] Map Rank (ie 1/100)
    - [x] Map Tier
    - [x] Map Type
  - [x] Spectator HUD
- [x] Zones
  - [x] Hook common triggers by default
  - [x] Manual Zones
  - [x] Hook Bonus Zones Triggers (KZ & Surf) 
- [x] Player PBs
  - [x] Save to Json
  - [x] Save to MySQL
- [x] Ranks
  - [x] Map !top
  - [x] Map !topbonus
  - [x] Global server ranks
    - [x] !points
    - [x] Global Point system
- [ ] Surf Stages/Checkpoint support
  - [x] Stage/Checkpoint PBs with u/s
    - [x] Json Stage/Checkpoint PBs saving
    - [ ] MySql Stage/Checkpoint PBs saving
- [x] MySQL
	- [x] Basic Player Records
  - [x] Player Server Stats
  - [x] Player Map Stats
- [x] Replays
- [x] Jumpstats
  - [x] Distance
  - [x] Pre
  - [x] Max
  - [x] Height
  - [x] Width
  - [x] Sync
  - [ ] Jump Types
    - [x] Long Jump
    - [x] BunnyHop
    - [x] MultiBunnyHop
    - [x] Jump Bug
    - [ ] Edge Bug
    - [ ] Ladder Jump
- [ ] Silly Stuff
  - [x] Color customization
  - [x] Special Tester Gifs
  - [x] Custom Player Gifs
  - [x] Dioscord Webhook
  - [ ] Strafe Sync Bar on HUD


## Author: [@dea_bb](https://twitter.com/dea_bb)

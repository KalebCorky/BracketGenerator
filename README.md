# BracketGenerator
Bracket generator for 32 item brackets.

## Pre-Requisites
Ability to compile .NET 6.0 binaries on your local. You can do this by downloading Visual Studio Community.

## Install Instructions
1. Download a copy of the code.
2. Open .sln file in Visual Studio
3. On your local machine, create a text file with the 32 items you want to put in the bracket, ordered from #1 seed to #32 seed.
4. Modify app.config file with your input file and the appropriate file location/name for the output file. The program will generate the output file.
5. Save
6. Run the program from Visual Studio


## Example
input.txt:

Billy Ray Cyrus - Achy Breaky Heart

Brooks & Dunn - Boot Scootin' Boogie

Garth Brooks - What She's Doing Now

Collin Raye - Love, Me

Wynonna - No One Else On Earth

Reba McEntire - Is There Life Out There

Aaron Tippin - There Ain't Nothin Wrong with the Radio

Alabama - I'm In A Hurry (And Don't Know Why)

Vince Gill - I Still Believe In You

Collin Raye - In This Life

Vince Gill - Don't Let Our Love Start Slippin Away

Wynonna Judd - I Saw The Light

Wynnona Judd - She Is His Only Need

Alan Jackson - Love's Got A Hold On You

Tracy Lawrence - Sticks and Stones

Brooks & Dunn - Neon Moon

George Strait - I Cross My Heart

Alan Jackson - She's Got The Rhythm (And I've Got The Blues)

Doug Stone - A Jukebox With A Country Song

Alan Jackson - Dallas

Sawyer Brown - Some Girls Do

Mark Chestnutt - I'll Think Of Something

Randy Travis - If I Didn't Have You

John Anderson - Straight Tequila Night

Garth Brooks - The River

Billy Ray Cyrus - Could've Been Me

Hal Ketchum - Past The Point Of Rescue

Garth Brooks - Somewhere Other Than the Night

Clint Black - We Tell Ourselves

John Anderson - Seminole Wind

Suzy Bogguss - Drive South

Lorrie Morgan - Watch Me

output.txt:
:cowboy: Billy Ray Cyrus - Achy Breaky Heart vs. :guitar: Lorrie Morgan - Watch Me

:cowboy: Brooks & Dunn - Neon Moon vs. :guitar: George Strait - I Cross My Heart

:cowboy: Alabama - I'm In A Hurry (And Don't Know Why) vs. :guitar: Garth Brooks - The River

:cowboy: Vince Gill - I Still Believe In You vs. :guitar: John Anderson - Straight Tequila Night

:cowboy: Collin Raye - Love, Me vs. :guitar: Clint Black - We Tell Ourselves

:cowboy: Wynnona Judd - She Is His Only Need vs. :guitar: Alan Jackson - Dallas

:cowboy: Wynonna - No One Else On Earth vs. :guitar: Garth Brooks - Somewhere Other Than the Night

:cowboy: Wynonna Judd - I Saw The Light vs. :guitar: Sawyer Brown - Some Girls Do

:cowboy: Brooks & Dunn - Boot Scootin' Boogie vs. :guitar: Suzy Bogguss - Drive South

:cowboy: Tracy Lawrence - Sticks and Stones vs. :guitar: Alan Jackson - She's Got The Rhythm (And I've Got The Blues)

:cowboy: Aaron Tippin - There Ain't Nothin Wrong with the Radio vs. :guitar: Billy Ray Cyrus - Could've Been Me

:cowboy: Collin Raye - In This Life vs. :guitar: Randy Travis - If I Didn't Have You

:cowboy: Garth Brooks - What She's Doing Now vs. :guitar: John Anderson - Seminole Wind

:cowboy: Alan Jackson - Love's Got A Hold On You vs. :guitar: Doug Stone - A Jukebox With A Country Song

:cowboy: Reba McEntire - Is There Life Out There vs. :guitar: Hal Ketchum - Past The Point Of Rescue

:cowboy: Vince Gill - Don't Let Our Love Start Slippin Away vs. :guitar: Mark Chestnutt - I'll Think Of Something

## Backlog/Needed Features
1. 64 item support
2. Friendly UI
3. Automated tests
4. Spotify Integration
5. Billboard Integration
6. Discord Integration
8. 

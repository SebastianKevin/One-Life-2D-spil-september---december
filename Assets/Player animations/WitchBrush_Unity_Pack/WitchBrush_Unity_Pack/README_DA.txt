# Witch Brush - Unity sprite pack

This is a Unity-ready **Assets folder** containing 32 individually cropped PNG sprites
with transparent backgrounds. The checkerboard shown in the generated preview has
been removed. The character is kept facing away from the camera.

## Import into Unity
1. Extract this ZIP file.
2. Open your Unity project.
3. Drag the `WitchBrush_Unity_Pack` folder into the project's `Assets` folder
   (or copy its `Art` folder into `Assets`).
4. Wait for Unity to import the PNG files.

## Sprite import settings
Select the PNGs in `Art/Sprites` in Unity's Project window and set:
- Texture Type: `Sprite (2D and UI)`
- Sprite Mode: `Single`
- Pixels Per Unit: use the same value for every frame (try `100`, then adjust
  based on the size you want in the scene)
- Filter Mode: `Point (no filter)` for crisp pixel art
- Compression: `None`
Then click `Apply`.

## Make an animation
1. Open `Window > Animation > Animation`.
2. Select your character GameObject in the scene and click `Create`.
3. Save an animation clip, for example `Idle.anim`.
4. Drag `Idle_00.png` through `Idle_03.png` into the Animation timeline in order.
5. In the clip's Inspector, enable `Loop Time` for the idle animation.
6. Make separate clips for movement directions using the matching numbered PNGs.
   The `Turn_A` and `Turn_B` images are the two groups of direction-change frames.
7. Add the clips to an Animator Controller and create transitions between them.

## Frame naming
- `Idle_00` to `Idle_03`: idle loop frames
- `UpLeft`, `Up`, `UpRight`: upper direction poses
- `Left`, `Right`: horizontal direction poses
- `DownLeft`, `Down`, `DownRight`: lower direction poses
- `Turn_A_00` to `Turn_A_03` and `Turn_B_00` to `Turn_B_03`: direction-change frames
- `Idle_Mid_00` to `Idle_Mid_03`: additional idle poses from the middle row

## Important note
The source image was generated as an illustration sheet rather than a perfectly
uniform game-art atlas. I separated the visible sprites into individual PNGs so
they can be animated in Unity without slicing the irregular sheet. Please check
the frame order and adjust animation timing in Unity to suit your game.

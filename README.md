# SpriteGrabber
### Utility to help sprite-grabbing process

### Disclaimer

_Please understand that grabbing pictures or graphics elements from another software by any means (included this application) in some circumstances  may be recognized as an unlawful act._

### Forewords

The refactoring of an old game is an endless and somewhat difficult job, one of the most tiring a frustrating part of this work is IMHO  the recovery of original graphics elements.

This application is a tool meant to give some relief to those fouls that boldly get into this specific and dangerous task.

__Please NOTE that this application is still a work in progress and it's long to be complete.__

### Side note

There are other utilities like this one and probably better ones. [MAME](https://www.mamedev.org/) itself has a special feature that allows to dump game pallette usually bound to [F4](https://strategywiki.org/wiki/MAME/Special_Keys#F4) key.

### Usage

This application need a graphic source where to pick the elements to grab. At this stage these sources can be:
- `MNG` bundle file(s);
- `AVI` file(s).

Both these kind of sources are produced from emulators such as [MAME](https://www.mamedev.org/). If you are using MAME you need to run it from the console with `-mngwrite` or `-aviwrite` [command line options](https://docs.mamedev.org/commandline/commandline-all.html). Snapping into MNG files can be achieved also with Shift+F12 key combination. If you're going to use the second format take into account that AVI files recorded from MAME are pretty uncompressed: this means that it will consume an huge amount of disk space (usually 1Gb per minute of recording).

Despites the widespread idea that MAME should be able to save animated GIF (Shift+F12) I haven't found a, recent, release of MAME capable of doing so anyway I added support for this kind of files but you will probably never have a chance to use it.

Once launched the application shows the main form where you can recognize four main items:
- _Frames bundles_ textbox;
- _Frame_ picturebox (x2);
- _Messages_ listview.

Sited below the two frames picturebox there are a number of widgets (buttons, textboxes, up-down controls) to adjust, report and run the workflow actions.

The _Frame bundles_ texbox simply report the filename of the last selected graphic source. To select a graphic source you need to push onto the button on the right of the textbox and select a suitable file from your archives. Once the file has been selected the application will investigate the file collecting the total frames number and then try to load the first two frames to place them in _Frames_ pictureboxes.

Each _frame_ picturebox is used to depict the frame selected by the user acting on up-down controls placed under the picturebox itself.
The button placed between the two up-down control is used to exchange the frames into the pictureboxes (and frames indexes accordingly).
Those frames are used by the application to _summon_ the sprite, you should try to select two frames with the most _common_ background and the sprite meant to be collected in two different and not overlapping positions.

_Messages_ listview is a simple log of actions and results/errors occurred during the application run. The list itself can be cleared / saved acting on the listview context menu.

_Frames_ textbox (placed on the left below the picturebox) reports the total number of frames available in the graphic source.

_BG Color_ textbox (placed on the right below the picturebox) reports the currently selected background color. Background color is gathered automatically by the application when one of the frames change nevertheless the user can change the background color just by clicking onto the desired color on depicted frames. Please note that selecting the background color it's not mandatory but it will optimize the grabbing extraction process.

_Capture_ button is the trigger of the main function of the application. Pushing this button will open a new window where selected frames are compared to check for differences (to be precise the left one is compared against the right one). The result of comparision is shown in the picturebox placed in center of the window, this can be assumed as the source of the sprite. Between two frames of a same time sequence the common portion (the part that's NOT changing) is _probably_ the background and thus can be removed. The remaining elements are either sprites or portion of background changing between frames (portions of background hidden by the sprite itself, portion of background sliding in or out of the scene due to scrolling etc). Some portions of such remainder can be removed adjusting _Offset_ up-down controls placed under the frame picturebox (please note that both offsets value can be either positive or negative).
If you have initially selected two _good_ frames and applied the correct offset the sprite is hopefully clear and isolated. Now you can _select_ it by mouse (just click and drag the cursor until the yellow rectangle include the sprite) you don't need to be extremely precise in this selection since an optimization algorithm is run just after you release the mouse button and the smallest rectangle including the sprite will be drawn for you. Once the sprite has been selected you have three choices:

1. trash everything clicking on _Close_ button;
2. store your sprite for later use clicking on _Collect_;
3. immediately save the selected sprite  with _Save_ button.

If you press _Save_ you're asked for a location where to save the sprite file (please note that it will be saved as a PNG image to preserve the transparent background) but it won't store this into yout sprite collection, after saving the window will close. _Collect_ will store the selected sprite in your global collection (but it won't save it anywere) the window will NOT close allowing you to hunt for another sprite. _Close_ will obviously close the window without saving or storing the selected sprite (if any). 

Once back on the main window you'll probably want to repeat the process (with different frames) to collect more and more sprites.

The amount of sprites collected on your hunting/grabbing session is reported on the right of the _Sprites_ button.

After you repeated the process of grabbing some times you can look at the sprites collection by clicking the button _Sprites_. There (on the new window) you'll find sprites depicted by their miniatures enlisted on the left. Clicking on a sprite will display it in all it's glory on the right panel. If you wish to investigate details you can zoom in by using the zoom-bar on the right of the panel istelf.
Once you're satisfied of the sprite collection you can click on _Save_ button and select the folder where the sprite collection will be saved (as a bundle of PNG images), you can do partial saving by selecting which sprite(s) to save on the left list prior to press _Save_ button. From this window you can also remove sprites from the collection or clear the entire collection by clicking on the appropiate context menu item of the list.

### Guidelines to properly collect game frames

Besides which emulator you will use and which format you'll be going to use for the graphic source the success of the grabbing will mostly depend on the correct collection of frames before the grabbing job actually start. These are some rules I'm using to setup a good graphic source as a base for sprite grabbing:

- Select levels or portion of levels where the background is uniform and not _changing/moving_;
- Move sprite (or trigger it to move or wait for it to move) on a uniform background;
- Try to collect frames where the sprite is placed in NON-overlapping positions;
- If the game has different scrolling directions try to record a sequence where the direction is uniform.

### Build

Just download/clone the project with [github](https://github.com/) and then open it in [Microsoft Visual Studio](https://visualstudio.microsoft.com/).

### MNG File handling

I'm using the SprinterMNG library from Sprinter Publishing to handle `.mng` pictures bundles.

### Copyright notices

Visual Studio (C) 2017 Microsoft Corporation.

SprinterMNG Copyright © Sprinter Publishing 2009.

MAME Copyright (C) 1997-2019  MAMEDev and contributors.

### TODO

- ~~Drag & drop support~~;
- ~~Handle `.gif` (animated ones) as graphics source format~~;
- Handle `.zip` pictures bundle as graphics source format;
- ~~Equalize sprite format before saving collection~~;
- Better layout;
- Preview sprite collection animation;
- Change order in sprites collection;
- Sprite editor;
- Create sprite-sheet;
- Add installer;
- Localization;
- More _smartness_ in sprite grabbing procedure.

### References

_MAME:_
1. https://www.mamedev.org/
2. https://docs.mamedev.org/commandline/commandline-all.html
3. https://strategywiki.org/wiki/MAME/Special_Keys#F4

_Microsoft Video Studio:_
- https://visualstudio.microsoft.com/

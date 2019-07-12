# SpriteGrabber
### Utility to help sprite-grabbing process

_Please understand that grabbing pictures or graphics elements from another software by any means (included this application) in some circustances may be recognized as an unlawful act._

The refactoring of an old game is an endless and somewhat difficult job, one of the most tiring a frustrating part of this work is IMHO  the recovery of original graphics elements.

This application is a tool meant to give some relief to those fouls that boldly get into this specific and dangerous task.

__Please NOTE that this application is still a work in progress and it's long to be complete.__

### Usage

Before your first run please read the following recomendations:

This application need a graphic source where to pick the elments to grab. At this stage these sources can be:
- MNG bundle file;
- AVI file.

Both these kind of sources are produced from emulators such as [MAME](https://www.mamedev.org/). If you are using MAME you need to run it from the console with `-mngwrite` or `-aviwrite` [command line options](https://docs.mamedev.org/commandline/commandline-all.html). If you're going to use the second format take into account that AVI files recorded from MAME are pretty uncompressed: this means that it will consume an huge amount of disk space (usually 1Gb for 1 minute of recording).

One launched the application shows the main form where you can recognize four main items:
- _Frames bundles_ textbox;
- _Frame_ picturebox (x2);
- _Messages_ listview.

Below the two frame picturebox there are a number of widgets (buttons, textboxes, up-down controls) to adjust, report and run the workflow actions.

The _Frame bundles_ texbox simply report the filename of the last selected graphic source. To select a graphic source you need to push onto the button on the right of the textbox and select a suitable file into your archives. Once the file has ben selected the application try to investigate the file collecting the total frames number and then try to load the first two frames and place them in _Frames_ pictureboxes.

The _frame_ picturebox is used to depict the frame selected by the user acting on up-down control placed below the picturebox itself.
The button placed between the two up-down control is used to exchange the frames into the pictureboxes (and frames indexes accordingly).
Those frames are used by the application to extract the sprite, you should try to select two frames with the most _common_ background and the sprite meant to be collected in two different and not overlapping positions.

_Messages_ listview is a simple log of actions and results/errors occured during the application run. The list itself can be cleared / saved acting on its own context menu.

_Frames_ textbox (placed on the left below the picturebox) reports the total number of frames available in the graphic source.

_BG Color_ textbox (placed on the right below the picturebox) reports the currently selected background color. To select the background color just click onto the desired color on depicted frames. Please note that selecting the background color it's not mandatory but it will optimize the grabbing extraction process.

_Capture_ button is the trigger of the main function of the application. Pushing onto this button will open a new window where  selected frames are compared to check for differences. The result of comparation is shown in the picturebox placed in center of the window, this can be assumed as the source of the sprite. Between two frames of a same time sequence the common portion (the part that's NOT changing) is _probably_ the background and thus can can be removed. The remaining elements are either sprites or portion of background changing between frames (portions of background hidden by the sprite itself, portion of background sliding in or out of the scene due to scrolling etc). Some portions of such remainder can be removed adjusting the _Offset_ up-down controls blaced under the frame picturebox (please note that both offsets value can be positive or negative).
If you have initally selected two good-frames and applied the correct offset the sprite is hopefully clear and isolated. Now you can _select_ it by mouse (just click and drag the cursor until the yellow rectangle include the sprite) you don't need to be extremley precise in this selection since an optimization alghoritm is run just after you release the mousebutton and the smallest rectangle including the sprite is drawn for you. Once the sprite has been selected you have three choices:

1. trash everything clicking on _Discard_ button;
2. store your sprite for later use clicking on _Collect_;
3. save the selected sprite immediately with _Save_ button.

If you press _Save_ you're asked for a location where to save the sprite file (please note that it will be saved as a PNG image to preserve the transparent background). _Discard_ and _Collect_ will also close the window. Once back on the main window you'll probably want to repeat the process (with different frames) to collect more and more sprites.

After you repeated the process of grabbing some times you can look at the sprites collection by clicking the button _Sprites_. There (on the new window) you'll find sprites depitected by their miniatures enlisted on the right. Clicking on a sprite will display it in all it's glory on the left panel. If you wish to investigate details you can zoom in by using the zoom-bar on the left of the window.
Once you're satisfied of the sprite collection you can click on _Save_ button and select the folder where the sprite collection will be saved (as a bundle of PNG images).

### Guidelines to properly collect game frames

Besides which emulator you will use and which format you'll be going to use for the graphic source the success of the grabbing will mostly depend on the correct collection of frames. These are some rules I'm using to setup a good graphic source as a base for sprite grabbing:

- If possibile select levels or portion of levels where the background is uniform and not _changing/moving_;
- If possible move sprite (or trigger it to move or wait for it to move) on uniform background;
- Try to have frames where the sprite is placed in non overlapping positions;
- If the game has different scrolling directions try to record a sequence where the direction is uniform.

### Build

Just download/clone the project with [github](https://github.com/) and then open it in [Microsoft Visual Studio](https://visualstudio.microsoft.com/).

### References

_MAME:_
1. https://www.mamedev.org/
2. https://docs.mamedev.org/commandline/commandline-all.html

_Microsoft Video Studio:_
- https://visualstudio.microsoft.com/

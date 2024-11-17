(This fork is for my personal use.)

English | [简体中文](./docs/zh_cn_readme.md)

-----

# µBMSC

µBMSC is a modified version of iBMSC to add features and clean up the iBMSC code, fix bugs and so on.
See README.md.old for original iBMSC README file.

# Changes

* Out of the box OGG previews
  * Seeks for WAV if OGG doesn't exist, and viceversa
* Bugfixes
  * BMSE clipboard input fixed
* Additions
  * Landmine support (Shift + Ctrl + Click)
  * Several new encodings (EUC-KR, Shift-JIS)
  * Go To Measure (Ctrl+G)
  * Mouse Row/Column Highlight
  * Ctrl+Scroll wheel changes zoom level
  * Huge BPM support (10e12)
  * UI improvements
  - **More customization options for the user interface**
  * **Time select mode** Convert Area to Stop 
  * **Select Mode** Select notes with labels on screen, all notes with labels (Shift+Ctrl+Click, Shift+Ctrl+A)
  * Non-locale dependant number output (No more commas instead of periods)
  * **Write mode** Autowav Increase functionality 
  * **dtinth** Move and Deselect (Shift+Number)
  * **NS-Kazuki** #SCROLL Support
* Development
  * Codebase reorganized for developers
- Platform
  -  Upgrade .Net version to 9

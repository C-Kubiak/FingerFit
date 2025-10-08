# FingerFit
Capstone Project Fall 2025
## How to add a build (use Git LFS)

1. Clone this repo and `cd` into it.
2. Ensure git-lfs is installed and initialized:
   `git lfs install`
3. Track ZIPs (if not already tracked):
   `git lfs track "*.zip"`
   `git add .gitattributes && git commit -m "Track ZIPs with LFS"`
4. Put your ZIP into `Builds/` and run:
   `git add Builds/*.zip`
   `git commit -m "Add build ZIP"`
   `git push origin main`

KNOWN ISSUES 10/8:
Playing a game, then exiting to main menu, the button will not take you to your destination. The same is true for the settings panel. (potential cause: event listeners staying active after scene is unloaded)
Accuracy in type rush is only updated after a phrase is completed.
User design lacking, increasing font size can lead to text overfilling buttons.

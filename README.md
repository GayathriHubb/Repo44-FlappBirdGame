# Repo44-FlappBirdGame

A small, single-window Flappy Bird clone implemented as a Windows Forms app in C# for Windows desktop. It uses a timer-driven game loop to move the bird and pipes, detect collisions, play a looping sound, and display a score.

## Stack
- **Language(s):** C#
- **Framework / runtime:** .NET 8 (net8.0-windows) — Windows Forms
- **Notable APIs:** System.Windows.Forms (UI), System.Media.SoundPlayer (audio), System.Drawing (images/icons), .resx resource management (Properties.Resources)

## Project structure
```
FlappyBird.cs                # Main form logic (game loop, input, collision, Start/Restart, score)
FlappyBird.Designer.cs       # Windows Forms designer: UI control declarations and layout
FlappyBird.resx              # Embedded resources (images, icon, many resource entries)
FlappyBird.ico               # Application icon referenced by the project
FlappyBirdGame.csproj        # .NET project file (net8.0-windows, UseWindowsForms, content copy rules)
Images/                      # directory (placeholder file)
README.md                    # this file
LICENSE                      # license file
```

How it fits together: FormFlappyBird is a partial class split between FlappyBird.cs (behavior) and FlappyBird.Designer.cs (controls/layout). The Designer wires up image resources (Properties.Resources.*) and a System.Windows.Forms.Timer (GameTimer). GameTimer.Tick updates positions, handles input (spacebar to flap), moves pipes, increases score, and checks collisions; EndGame/RestartGame control game state and audio playback.

## How to run
Prerequisites: .NET 8 SDK and Windows (the project targets `net8.0-windows` and uses WinForms).

Clone, build and run from the command line:

```bash
git clone https://github.com/GayathriHubb/Repo44-FlappBirdGame.git
cd Repo44-FlappBirdGame
dotnet restore
dotnet build
dotnet run --project FlappyBirdGame.csproj
```

Or open the `FlappyBirdGame.csproj` in Visual Studio and run.

Controls and gameplay:
- Press Spacebar to flap (space sets gravity negative while pressed).
- When the game ends, press `R` to restart.
- There is a Start Game button and a Restart picture that also trigger RestartGame.

Notes:
- Audio is played from `AudioDollarChillStep.wav` via `SoundPlayer("AudioDollarChillStep.wav")`. The project is configured to copy this file to output; ensure the WAV file is present so audio works.
- The UI images (bird, pipes, ground, restart icon, etc.) are loaded from the embedded .resx resources configured in the Designer.
- This is a Windows GUI application; it will not run on non-Windows platforms without WinForms support.

## Try asking
- The Designer references `Properties.Resources.Bird` / `PipeUp` / `PipeDown` — do you want me to list which resources are embedded and verify each one exists? I can extract the exact resource names from `FlappyBird.resx`.
- The csproj declares a `Services\` folder — would you like me to refactor game logic into a small service (e.g., `GameEngine`) so it’s easier to unit test?
- Should I add a small high-score persistence (JSON or simple text) and a top-score display on the form?

---

If you want, I can open a follow-up PR adding screenshots, a short GIF of gameplay, or a CONTRIBUTING.md with build notes. If you want any wording changed before I commit this README to the repo, tell me which parts to edit.
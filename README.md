❌ Tic-Tac-Toe Game (Windows Forms) ⭕

A modern and polished implementation of the classic **Tic-Tac-Toe** game developed in **C#** and **Windows Forms (.NET)** using **Visual Studio 2022**.


🎮 Game Overview
This desktop game allows two players to play locally, tracking turns, determining winners with automatic line highlighting, and handling tie scenarios (Draws).


✨ Features
- **Turn Tracking:** Automatically switches turns between **Player 1 (X)** and **Player 2 (O)**.
- **Custom Board Graphics:** Custom grid lines rendered cleanly using `System.Drawing` with smooth rounded line caps (`LineCap.Round`).
- **Dynamic Win Detection:** Checks all 8 possible winning combinations (rows, columns, and diagonals).
- **Winner Visual Feedback:** Automatically highlights the winning 3-in-a-row combination in **green**.
- **Draw Detection:** Accurately identifies draw states when all 9 moves are completed without a winner.
- **Game Reset:** One-click restart button to reset the board, scores, and game state.



🚀 Code Quality & Refactoring Highlights
This project was carefully refactored applying **Clean Code** principles:
- **DRY (Don't Repeat Yourself):** Replaced repetitive checks with a reusable `CheckValues()` helper function.
- **Shared Event Handling:** Implemented a single, unified `pictureBox_Click` handler utilizing `(PictureBox)sender` casting to handle user clicks dynamically.
- **Safe State Tracking:** Utilized control properties (`.Tag`) for lightweight and safe board state evaluation.


🛠️ Built With
- **Language:** C#
- **Framework:** .NET (Windows Forms)
- **Graphics:** GDI+ (`System.Drawing.Graphics`, `Pen`)
- **IDE:** Visual Studio 2022
- **Version Control:** Git & GitHub



📸 Screenshots

<img width="1463" height="917" alt="image" src="https://github.com/user-attachments/assets/c75087cd-cf8c-4e3e-9432-074a6f287a81" />



## 👨‍💻 Author
Developed as part of the **ProgrammingAdvices** roadmap (Course 14 - C# Level 1) by **Dr. Mohammed Abu-Hadhoud**.

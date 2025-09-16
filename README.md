# Guessing Game

A fun and interactive console-based number guessing game written in C#. Test your luck and strategy by guessing the randomly generated number within your chosen number of tries!

## 🎮 Game Features

- **Multiple Difficulty Levels**: Choose from Easy, Medium, or Hard modes
- **Customizable Attempts**: Set your own number of tries
- **Smart Hints**: Get feedback on whether your guess is too high or too low
- **Dynamic Range**: The guessing range narrows down based on your previous guesses
- **Colorful Interface**: Enhanced user experience with colored console output
- **Replay Option**: Play multiple rounds without restarting the application

## 🎯 Difficulty Levels

| Level | Range | Description |
|-------|-------|-------------|
| **Easy (1)** | 1 - 10 | Perfect for beginners |
| **Medium (2)** | 11 - 100 | Moderate challenge |
| **Hard (3)** | 101 - 1000 | For the brave! |

## 🚀 How to Play

1. **Start the Game**: Run the application and enter your name
2. **Choose Difficulty**: Select 1 (Easy), 2 (Medium), or 3 (Hard)
3. **Set Attempts**: Choose how many tries you want for this round
4. **Make Your Guess**: Enter a number within the given range
5. **Follow the Hints**: 
   - If your guess is too low, the minimum range will increase
   - If your guess is too high, the maximum range will decrease
6. **Win or Learn**: Either guess correctly or run out of attempts
7. **Play Again**: Choose whether to start another round

## 💻 Getting Started

### Prerequisites
- .NET Framework or .NET Core/5+
- Visual Studio or any C# compatible IDE

### Installation & Running

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/guessing-game.git
   ```

2. **Navigate to the project directory**:
   ```bash
   cd guessing-game
   ```

3. **Build and run**:
   ```bash
   dotnet run
   ```

   Or open in Visual Studio and press F5 to run.

## 🎨 Game Interface

The game uses different colors to enhance the user experience:
- 🟡 **Yellow**: Questions and prompts
- 🔵 **Cyan**: User input areas and name display
- 🔴 **Red**: Error messages and game over
- 🟢 **Green**: Success messages

## 📋 Game Flow Example

```
-------------------------------------------Hello To Our Guessing Game System-------------------------------------------
Please enter your name: John

1) Easy
2) Medium  
3) Hard
choose the number that reprsent difficulty level: 2

enter number of tries you want: 5

choose number from 11 to 100
> 50
number is smaller

Your remaining tries: 4
choose number from 51 to 100  
> 75
number is greater

Your remaining tries: 3
choose number from 51 to 74
> 63
congrates You get it in: 3 tries!

Do you want to play again?(Y/N): N
Good Bye John!
```

## 🔧 Code Structure

- **`play()`**: Main game loop that controls the entire game flow
- **`start()`**: Welcome screen and player name input
- **`setDifficulty()`**: Difficulty level selection with input validation
- **`Notries()`**: Custom attempts setting with error handling
- **`GenerateNumber()`**: Random number generation based on difficulty
- **`playing()`**: Core guessing logic with range adjustment
- **`showScoor()`**: Results display (win/lose with statistics)
- **`endGame()`**: Replay option handling

## 🛡️ Error Handling

The game includes robust error handling for:
- Invalid difficulty level selections
- Non-numeric input for tries and guesses
- Numbers outside the valid range
- Invalid replay choices (Y/N)

## 🤝 Contributing

Feel free to fork this project and submit pull requests for any improvements:
- Additional difficulty levels
- Score tracking across sessions
- High score leaderboard
- GUI version
- Multiplayer support

## 📝 License

This project is open source and available under the MIT License.

## 👨‍💻 Author

Created as a fun console application to demonstrate C# programming concepts including:
- Object-oriented programming
- Exception handling
- Console I/O operations
- Random number generation
- Control flow structures

---

Enjoy the game and happy guessing! 🎲

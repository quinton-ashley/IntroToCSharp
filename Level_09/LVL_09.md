---
# Level 09 A
---

Before you can start working on the `TicTacToe` game, you'll have to prove your skills in C#.

<https://www.w3schools.com/quiztest/quiztest.asp?qtest=CS>

After you complete the test you can upgrade to level 6! 🥳

---

# Level 09 B

---

## Nested for loops

A `for` loop inside a `for` loop? FORLOOPCEPTION! 😮

Nested for loops are useful for iterating over two dimensions. For example, text rows and columns.

```csharp
for (int row = 0; row < 5; row++) {
	for (int col = 0; col < 5; col++) {
		// do something
	}
}
```

`i` is commonly used to represent the index of the outer loop and `j` is commonly used to represent the index of the inner loop.

Each time the code in the outer loop is run, the inner loop will run completely. In the example above, the inner loop will run 5 times for each time the outer loop runs. The inner loop will run 25 times in total.

---

# Level 09 C

---

## Two Dimensional Arrays

A two dimensional array (aka 2D array) is an array of arrays.

```csharp
// red and black checkers on a checkerboard
char[,] board = new char[8, 8] {
	{ ' ', ' ', ' ', 'r', ' ', 'B', ' ', ' ' },
	{ ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
	{ ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'r' },
	{ ' ', ' ', ' ', ' ', 'r', ' ', ' ', ' ' },
	{ ' ', 'B', ' ', ' ', ' ', ' ', ' ', 'b' },
	{ ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ' },
	{ ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
	{ ' ', ' ', ' ', ' ', 'b', ' ', 'b', ' ' }
};
```

Two dimensional data, such as checker board piece positions, can be stored in two dimensional arrays. In the example `'r'` represents a single red piece, uppercase `'R'` represents a king (two stacked red pieces).

---

## 2D array access

How could we access the red piece on the top row?

```csharp
char piece = board[0, 3]; // row is 0, column is 3
```

`0` gets the first row in board array and the `3` after that gets us the piece at column 3 in that row array. How could we access the red piece in the middle of the board?

---

## Using nested for loops with 2D arrays

How could we use a nested for loop to clear the board of all the pieces by assigning a blank space " " to every element in the `board` array?

```csharp
for (int row = 0; row < 8; row++) {
	for (int col = 0; col < 8; col++) {
		board[row, col] = ' ';
	}
}
```

---

# Level 09 D

---

## exit a function

`return` can be used to exit functions.

```csharp
// create the method
public static void stamp(passport) {
    if (!passport) {
				return;
		}
}
```

---

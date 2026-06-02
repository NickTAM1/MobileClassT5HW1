# Mobile HW1 – Rolling Ball

A tilt-controlled rolling ball game built in Unity for mobile.

---

## Extra Feature: Pinch-to-Zoom

The camera supports **two-finger pinch** to zoom in and out during gameplay.

**How to test:**
1. Build and run on a physical Android/iOS device (or use Unity Remote).
2. Place two fingers on the screen and pinch them together to zoom in, spread apart to zoom out.
3. The field of view is clamped between 15° and 90° so it never breaks.

---

## How to Play

1. Press **Play Ball** on the start screen.
2. Tilt your phone to roll the ball around.
3. Press **Restart** to reset without closing the app.

---

## Architecture

| Script | What it does |
|---|---|
| `BallController.cs` | Reads `Input.acceleration` and applies force to the Rigidbody |
| `PinchZoom.cs` | Reads two touch points each frame and adjusts camera FOV |
| `GameManager.cs` | Tracks elapsed time and handles scene reload on restart |
| `StartMenuManager.cs` | Swaps UI panels and unpauses the game when Play is pressed |

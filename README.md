# 🦖 Dino Run - Endless Runner

**Dino Run** is a simple and addictive endless runner where you control a dinosaur running through a desert filled with cactuses. Your goal is to **jump over obstacles**, survive as long as possible, and **beat your high score**.

The game focuses on timing, reflexes, and rhythm, offering quick gameplay sessions that are easy to learn but hard to master.

<img src="Screenshots/DinoRun 1.png" width="500"/>

## 🎮 Gameplay

* The dinosaur runs automatically
* Player taps/clicks to jump
* Avoid cactuses to stay alive
* Score increases as you pass obstacles

### 🏁 Objective

Survive as long as possible and achieve the highest score.

## 🕹️ Controls

* **Mouse Click / Tap** → Jump

## ⚙️ Core Mechanics

### 🦘 Jump System

* Jump is only possible when the dinosaur is grounded
* Prevents double jumping
* Uses physics (`Rigidbody2D`) for natural motion

### 🌵 Obstacles

* Cactuses act as hazards
* Collision results in **game over**

### 🏃 Endless Movement

* Ground continuously moves left
* Creates illusion of forward movement

## 🎯 Features

### 🔁 Procedural Generation

* Random level segments (Level1–Level6)
* Keeps gameplay fresh and unpredictable

### 📈 Score System

* Score increases when passing obstacles
* Displayed in real-time on screen

### 💀 Game Over System

* Triggered on collision with cactus
* Stops time
* Displays Game Over UI and restart button

## 🔊 Audio System

* Jump sound
* Landing sound
* Death sound

## 🔄 Restart System

* Reset button reloads the current scene:

```csharp id="2z0h3s"
SceneManager.LoadScene(scene.name);
```

* Resets:

  * Score
  * Game state
  * Time scale

## 🎨 Game Flow

1. Game starts → Dino begins running
2. Player jumps to avoid cactuses
3. Score increases over time
4. Collision with cactus → Game Over
5. Player can restart and try again

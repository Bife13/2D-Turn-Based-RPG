# 2D Turn-Based RPG

A data-driven, turn-based combat framework in Unity 6, built so new abilities, status effects and items are created as data in the editor instead of new code.

![Combat](docs/Combat.gif)

## What's in it

- **Turn order by pace.** At the start of each round every unit rolls Speed + 1–5, and the turn order is sorted from that.
- **Modular abilities.** An `Ability` is a ScriptableObject made of modules (Damage, Heal, Condition, Cleanse, Coat, Swap, Self-hit), each with before / execute / after hooks. Combining modules gives new abilities without new code.
- **Conditions.** Boons, Jinxes and Statuses (Wound, Toxin, Ignite, Stun, Shock), with application chance, start-of-turn and end-of-turn processing, and cleansing. Effects are their own classes too: stat modifiers, statuses, counterattacks and weapon coatings.
- **Stances.** Before attacking, a unit can commit to Offensive (+20% damage) or Defensive (−10% damage) for the turn.
- **Items.** Equippable items with triggered effects (on hit, on crit, on getting hit, on turn start) and passive stat modifiers.
- **Waves.** Enemy waves spawned round by round.

## Editor tooling

The part I'd point to first. These tools let a designer build content without touching code:

<img src="docs/ItemCreator&Editor_short.gif" alt="Item Creator & Editor" width="250">

- **`ConditionEditor`**: custom inspector that finds every `ConditionEffect` subclass through reflection, so new effect types show up in the dropdown automatically.
- **`AbilityEditor`**: custom inspector for building abilities from modules.
- **`ItemEditorWindow`**: an editor window (*Tools → Item Creator & Editor*) for creating and editing items.
- **`ShowIf` attribute + drawer**: hides inspector fields that don't apply to the current setup.

## Gameplay video

<!-- On github.com: edit this file, delete this comment, and drag the MP4 here. GitHub uploads it and puts the link in for you. -->
https://github.com/user-attachments/assets/cae2ab6d-c204-452d-b91e-1f278fa4e91f


## Code worth reading

| File | What it shows |
|---|---|
| [`Ability.cs`](Assets/Scripts/Ability.cs) | The module system behind every ability |
| [`UnitConditions.cs`](Assets/Scripts/Unit/UnitConditions.cs) | Applying, ticking and cleansing conditions |
| [`CombatManager.cs`](Assets/Scripts/Managers/CombatManager.cs) | The coroutine-driven round and turn loop |
| [`ConditionEditor.cs`](Assets/Editor/ConditionEditor.cs) | Reflection-based custom inspector |
| [`ItemEditorWindow.cs`](Assets/Editor/ItemEditorWindow.cs) | Custom editor window for items |

## Running it

- Unity **6000.0.59f2** (Unity 6), 2D URP.
- Open the project and load `Assets/Scenes/GameScene.unity`.
- The UI art is from a third-party asset pack and isn't included in this repo, so buttons and panels will show as missing sprites. Everything else works.

Tweening by [DOTween](http://dotween.demigiant.com/) (Demigiant).

# HeroEngine

# UML

<img width="1403" height="1140" alt="Captura de pantalla 2026-04-12 134058" src="https://github.com/user-attachments/assets/f078daa3-7334-4b67-b5fa-af6f41225672" />


# JOCS DE PROVES

# Party Creation

| Tipus | intInserted |Expected | Result |
|----------------|-----------|----------------|-|
| normal | 1 | Creation of Warrior | Creation of warrior |
| normal | 2 | Creation of Mage | Creation of Mage |
| normal | 3 | Creation of Rogue | Creation of Rogue |
| Error | a | "Insert a real number!| "Insert a real number" |
| Error | 0 | "Choose between the options" | "Choose between the options" |
| Error | -1 | "Choose between the options" | "Choose between the options" |

# Give ability to a hero

| Tipus | Hero |Expected | Result |
|----------------|-----------|----------------|-|
| normal | Warrior | "Only mages can get abilities" | "Only mages can get abilities" |
| normal | Rogue | "Only mages can get abilities" | "Only mages can get abilities" |
| normal | 3 | Creation of Rogue | Creation of Rogue |
| error | a | "Insert a real number!| "Insert a real number" |
| error | 0 | "Choose between the options" | "Choose between the options" |
| error | -1 | "Choose between the options" | "Choose between the options" |

# Give ability to a mage

| Tipus | Ability |Expected | Result |
|----------------|-----------|----------------|-|
| normal | 1 | Gives ThunderSmash to mage | Gives ThunderSmash to mage |
| normal | 2 | Gives SecondWind to mage | Gives SecondWind to mage |
| normal | 3 | Gives IronFortress to mage | Gives IronFortress to mage |
| normal | 4 | Gives WarTaunt to mage | Gives WarTaunt to mage |
| error | a | "Insert a real number!| "Insert a real number" |
| error | 0 | "Choose between the options" | "Choose between the options" |
| error | -1 | "Choose between the options" | "Choose between the options" |

# Choose enemy to attack

| Tipus | enemyChoosen |Expected | Result |
|----------------|-----------|----------------|-|
| normal | 1 | Calculates a damage and attacks the enemy | Calculates a damage and attacks the enemy |
| normal | 2 | Calculates a damage and attacks the enemy | Calculates a damage and attacks the enemy |
| normal | 3 |Calculates a damage and attacks the enemy |Calculates a damage and attacks the enemy |
| normal | a | "Insert a real number!| "Insert a real number" |
| normal | 0 | "Choose between the options" | "Choose between the options" |
| normal | -1 | "Choose between the options" | "Choose between the options" |

# Mage is attacking

| Tipus | enemyChoosen | TypeAttack |Expected | Result |
|----------------|-----------|----------------|-|-|
| normal | 1 | 1 | Calculates a damage and attacks the enemy | Calculate a damage and attacks the enemy |
| normal | 1 | 2 | Mage chooses an ability to use | Mage chooses an ability to use |
| error | a | 1| "Insert a real number!| "Insert a real number" |
| error | 0 | 1 | "Choose between the options" | "Choose between the options" |
| error | -1 | 1 | "Choose between the options" | "Choose between the options" |

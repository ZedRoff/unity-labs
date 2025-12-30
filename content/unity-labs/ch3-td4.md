---
title: "CH3/TD4"
description: "Découverte du post-traitement"
author: "Justine HAKIM"
tags:
  - post-traitement
---


# TD4 : Effets de post-traitement

> Author : Justine HAKIM

## Présentation générale

Ce projet s’inscrit dans l’étude et la mise en œuvre des effets de post-traitement (post-processing) dans les jeux vidéo, à travers le moteur Unity. Le post-traitement regroupe un ensemble de techniques appliquées après le rendu de la scène par la caméra, visant à améliorer la qualité visuelle, la lisibilité et l’immersion du joueur.

L’objectif principal est d’analyser comment ces effets permettent de :
- Améliorer le réalisme visuel d’une scène 3D
- Renforcer l’ambiance artistique et émotionnelle
- Donner un rendu plus cinématographique et professionnel
- Influencer la perception et l’attention du joueur

L’implémentation est réalisée sous **Unity (C#)** en s’appuyant sur la pile de post-traitement officielle de Unity (URP / Post-Processing Stack) et sur les bonnes pratiques issues de l’état de l’art en rendu temps réel.
---

## 🛠️ Technologies utilisées

- Unity
- C#
- Post processing Stack

---

## 1. Compréhension des fondamentaux

### Rôle des effets de post-traitement

Les **effets de post-traitement** sont appliqués **après le rendu final de la scène par la caméra**. Ils modifient l’image finale à l’écran sans altérer la géométrie ou les matériaux des objets.

Dans Unity, ils permettent de :

* Améliorer le **réalisme visuel**
* Renforcer l’**ambiance émotionnelle**
* Guider la **perception et l’attention du joueur**
* Donner un rendu plus **cinématographique**

### Importance pour l’immersion

Les effets de post-traitement influencent directement la perception du joueur :

| Effet             | Impact perceptif                                 |
| ----------------- | ------------------------------------------------ |
| Bloom             | Impression de lumière intense, rendu plus vivant |
| Depth of Field    | Mise au point réaliste, focalisation du regard   |
| Ambient Occlusion | Meilleure perception des volumes                 |
| Fog               | Sens de profondeur, mystère, distance            |
| Color Grading     | Ambiance émotionnelle (froid, chaud, stress…)    |

**Sans post-traitement**, une scène paraît souvent plate et artificielle.
**Avec post-traitement**, elle devient crédible, immersive et professionnelle.

Les moteurs modernes (Unity, Unreal) utilisent systématiquement le post-processing pour atteindre un niveau visuel proche du cinéma.

---

## 2. Gestion des ressources et optimisation (surtout mobile)

Les effets de post-traitement sont **coûteux en calcul GPU**. Une mauvaise utilisation peut entraîner :

* Baisse de FPS
* Surchauffe
* Consommation excessive de batterie (mobile)

### Bonnes pratiques d’optimisation

#### a) Prioriser les effets essentiels

Sur mobile récent :

* ✅ Color Grading
* ✅ Bloom léger
* ⚠️ Ambient Occlusion simplifiée
* ❌ Motion Blur excessif
* ❌ Depth of Field lourd

#### b) Utiliser l’URP (Universal Render Pipeline)

* Optimisé pour mobile
* Post-processing intégré et plus performant
* Qualité adaptable selon la plateforme

#### c) Profils multiples selon la plateforme

```text
Profil_PC : Tous les effets activés
Profil_Mobile : Effets essentiels uniquement
```

#### d) Désactiver dynamiquement les effets coûteux

```csharp
if (Application.targetFrameRate < 30)
{
    motionBlur.active = false;
}
```

#### e) Baisser la résolution des effets

* Bloom avec seuil élevé
* Désactiver les effets en arrière-plan

---

## 3. Application pratique : Motion Blur (Flou de mouvement)

### Objectif du Motion Blur

Le **Motion Blur** simule le flou perçu par l’œil humain lors de mouvements rapides :

* Vitesse du joueur
* Déplacements de caméra
* Actions intenses (course, combat, véhicule)

Il améliore :

* Le **réalisme**
* Le **dynamisme**
* La **fluidité perçue**

---

### Étapes de configuration (Unity – URP)

#### 1. Activer le Post-Processing

* Camera → **Rendering**
* Activer *Post Processing*

#### 2. Créer un Volume

```text
GameObject > Volume > Global Volume
```

#### 3. Créer un profil

* New → Volume Profile
* Ajouter → **Motion Blur**

#### 4. Paramétrer l’effet

* **Intensity** : 0.1 – 0.3 (mobile)
* **Clamp** : limite le flou excessif

---

### Exemple C# : activer le Motion Blur selon la vitesse

```csharp
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class MotionBlurController : MonoBehaviour
{
    public Volume volume;
    private MotionBlur motionBlur;

    void Start()
    {
        volume.profile.TryGet(out motionBlur);
    }

    void Update()
    {
        float speed = GetComponent<Rigidbody>().velocity.magnitude;
        motionBlur.intensity.value = Mathf.Clamp(speed / 20f, 0f, 0.3f);
    }
}
```

Le Motion Blur améliore le réalisme d'une scène en mouvement rapide en reproduisant un phénomène que l'oeil humain perçoit naturellement : lorsque quelque chose bouge très vite, il devient légèrement flou. Il permet de reproduire un comportement visuel naturel. Dans la réalité, nos yeux et notre cerveau intègrent les mouvements rapides comme un flou temporaire. Le Motion Blur simule ce phénomène, ce qui rend la scène plus crédible. Les objets ou la caméra en mouvement rapide paraissent plus fluides et moins saccadés. Cela améliore la sensation de vitesse ou d’action intense (courses, combats, véhicules). Dans les jeux, un déplacement rapide peut provoquer un rendu “saccadé” ou des transitions brusques. Le Motion Blur adoucit ces transitions, ce qui contribue à une expérience visuelle plus cohérente.

---

## 4. Intégration avancée : effets dynamiques selon l’environnement

### Principe

Un système avancé adapte le post-traitement **en temps réel** selon :

* L’éclairage : passage du jour à la nuit
* La météo : pluie, brouillard, neige
* Les zones spécifiques : entrer dans une grotte, un bâtiment sombre
* L’état du joueur : fatigue, stress, blessures

---
### Étapes d’implémentation dans Unity

1. Créer un Volume de post-traitement global ou local :
Global Volume : effets appliqués à toute la scène
Local Volume : effets appliqués uniquement dans certaines zones (colliders ou trigger zones)

2. Créer un profil de post-traitement
Dans le projet Unity : Create > Volume Profile`
Ajouter les effets souhaités : Color Grading, Vignette, Fog, Depth of Field, etc.

3. Associer le profil au Volume
Glisser-déposer le profil sur le composant Volume
Activer Is Global si besoin pour tout l’environnement

4. Contrôler les effets dynamiquement via script C#
Utiliser Volume.profile.TryGet<T>() pour récupérer chaque effet
Modifier les paramètres en fonction des triggers ou conditions

### Exemple : Effet Chaleur / Mirages dans le désert

Le joueur traverse une zone désertique, où la chaleur intense provoque une distorsion visuelle naturelle. L’objectif de cet effet est de simuler :
* La distorsion de l’air chaud (mirages)
* La lumière intense du soleil
* La sensation de fatigue ou de chaleur extrême

### Effets appliqués 

* Chromatic Aberration : Décalage subtil des couleurs pour simuler la chaleur et les variations d’air.
* Vignette + Bloom : Halo lumineux autour du soleil pour accentuer la brillance et la chaleur.
* Distortion via shader : Déformation légère de l’arrière-plan pour simuler les mirages et l’air turbulent.
* Color Grading : Teintes chaudes (orange / jaune) pour renforcer la sensation de chaleur.

---

### Exemple de script C#

```csharp
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DesertHeatEffect : MonoBehaviour
{
    public Volume volume; // Volume attaché à la zone chaude
    private ChromaticAberration chroma;
    private Vignette vignette;
    private Bloom bloom;

    public float maxChromaIntensity = 0.2f;
    public float maxVignetteIntensity = 0.3f;
    public float maxBloomIntensity = 2f;

    public Transform player; // Position du joueur
    public Transform heatZoneCenter; // Centre de la zone chaude
    public float heatZoneRadius = 10f; // Rayon de la zone

    void Start()
    {
        volume.profile.TryGet(out chroma);
        volume.profile.TryGet(out vignette);
        volume.profile.TryGet(out bloom);
    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, heatZoneCenter.position);
        float intensity = Mathf.Clamp01(1 - distance / heatZoneRadius);

        // Ajustement dynamique des effets selon la proximité
        chroma.intensity.value = intensity * maxChromaIntensity;
        vignette.intensity.value = intensity * maxVignetteIntensity;
        bloom.intensity.value = intensity * maxBloomIntensity;
    }
}

```
### Fonctionnement

Le joueur entre dans la zone chaude (trigger). Chromatic Aberration, Vignette et Bloom augmentent progressivement. L’arrière-plan se déforme légèrement (via shader), simulant l’air chaud.
Au centre de la zone : Intensité maximale des effets → sensation de chaleur extrême et mirages visibles.
À la sortie de la zone, les valeurs reviennent à la normale progressivement.
L’effet donne une transition visuelle fluide, renforçant l’atmosphère et la tension


**Cas d’usage typique** : Le joueur explore un monde ouvert désertique (ex. un RPG ou un jeu de survie).

---

## 5. Nouveautés et tendances futures

### Effet prometteur : **Temporal Super Resolution (TSR / TAA avancé)**

#### Pourquoi ?

* Améliore la qualité visuelle **sans augmenter le coût GPU**
* Reconstruit une image haute résolution à partir de frames précédentes
* Déjà utilisé dans Unreal, arrive progressivement dans Unity

---

### Avantages sur le visuel

| Critère     | Impact                     |
| ----------- | -------------------------- |
| Qualité     | Image plus nette           |
| Performance | Moins de calculs           |
| Mobile      | Très prometteur            |
| Réalisme    | Réduction du scintillement |

---

### Faisabilité technique dans Unity

* Compatible avec URP / HDRP
* Déjà partiellement présent via TAA
* Très pertinent pour :

  * Jeux mobiles haut de gamme
  * Réalité virtuelle
  * Open worlds

---

## Conclusion

Les effets de post-traitement est un **outil clé de l’immersion**.

Une utilisation maîtrisée permet d’obtenir :
✔ Un rendu professionnel
✔ Une ambiance forte
✔ Une expérience utilisateur optimisée

---

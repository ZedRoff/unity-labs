# Omoiyari ➖Expérience immersive autour du handicap (Version finale)

---

**Étudiants :**

- Justine **HAKIM**
- Aman **GHAZANFAR**

**Filière :** E4-FI

**Unité :** 4I-PM1 – Infographie avancée avec Unity

**Année universitaire :** 2025–2026

**École :** ESIEE

## Table des matières

- [0. Préambule](#0-préambule)
- [1. Introduction et objectif du projet](#1-introduction-et-objectif-du-projet)
- [2. Organisation du travail et répartition des tâches](#2-organisation-du-travail-et-répartition-des-tâches)
  - [2.1 Méthodologie de travail](#21-méthodologie-de-travail)
  - [2.2 TDs réalisés](#22-tds-réalisés)
- [3. Intégration des TDs dans le jeu](#3-intégration-des-tds-dans-le-jeu)
  - [3.1 Bruit de Perlin](#31-bruit-de-perlin)
  - [3.2 Mont Fuji](#32-mont-fuji)
  - [3.3 Génération de terrains procéduraux](#33-génération-de-terrains-procéduraux)
  - [3.4 Post-processing](#34-post-processing)
  - [3.5 Nuages volumétriques et Ray Marching](#35-nuages-volumétriques-et-ray-marching)
- [4. Éléments naturels sélectionnés](#4-éléments-naturels-sélectionnés)
- [5. Assets externes](#5-assets-externes)
- [6. Critères techniques Unity3D](#6-critères-techniques-unity3d)
  - [6.a Acquisition et préparation des données](#6a-acquisition-et-préparation-des-données)
  - [6.b Mise en œuvre du projet dans Unity3D](#6b-mise-en-œuvre-du-projet-dans-unity3d)
  - [6.c Qualité du rendu](#6c-qualité-du-rendu)
  - [6.d Performances et optimisation](#6d-performances-et-optimisation)
- [7. Nouvelles salles et nouveaux handicaps](#7-nouvelles-salles-et-nouveaux-handicaps)
  - [7.a Handicap moteur – Mobilité réduite](#7a-handicap-moteur--mobilité-réduite)
  - [7.b Autisme](#7b-autisme)
  - [7.c Nouveau scripting](#7c-nouveau-scripting)
- [8. Reprise des salles existantes](#8-reprise-des-salles-existantes)
- [9. Conception artistique et gameplay](#9-conception-artistique-et-gameplay)
  - [9.1 Direction artistique](#91-direction-artistique)
  - [9.2 Interactivité et expérience utilisateur](#92-interactivité-et-expérience-utilisateur)
- [10. Présentation et livrables](#10-présentation-et-livrables)
  - [10.1 Vidéo](#101-vidéo)
- [11. Conclusion et prise de recul](#11-conclusion-et-prise-de-recul)

## 0. Préambule

---

Les documents techniques et la page web de présentation sont accessibles via un lien GitHub. Toutes les ressources multimédias, y compris les vidéos des différentes versions, les démonstrations, l'exécutable final et les codes sources, sont centralisées sur un Drive dédié.

Ce projet s’inscrit dans une démarche de sensibilisation par l’expérience. L’objectif est de créer une immersion forte qui permette au joueur de ressentir, et non seulement de comprendre, les défis quotidiens liés à différents handicaps. Pour cela, nous avons choisi d’ancrer chaque épreuve dans un élément naturel et une ambiance météorologique spécifique, créant un lien symbolique fort entre l’environnement, la mécanique de jeu et le message pédagogique.

Le jeu aborde quatre handicaps, dont deux nouveaux sont détaillés : l'autisme et le handicap moteur. Chacun est associé à un élément naturel qui définit à la fois le lore et la mécanique de sa salle. Ainsi, l'élément Terre correspond à la difficulté physique du parcours en fauteuil. Le Tonnerre simule le stress sensoriel vécu par les personnes autistes. Le Soleil intensifie le défi de la dyslexie en créant des reflets perturbants. Enfin, le Brouillard complique la tâche dans l'épreuve sur le daltonisme en réduisant la visibilité. Un cinquième élément, le Feu, est matérialisé par un système de particules et sert de mécanique interactive dans la salle sur la mobilité, où des lanternes doivent être allumées avant que la pluie ne les éteigne.

Cette fusion entre le gameplay, la symbolique et l’ambiance est au cœur de l’expérience. Chaque salle possède une météo unique qui influence directement le gameplay. La pluie, créée avec un système de particules, rend le terrain glissant et éteint les flammes. L'orage associe des éclairs visuels à une bande-son anxiogène. Le brouillard obscurcit l'environnement, et le soleil génère des reflets éblouissants. Ces conditions ne sont pas de simples décors ; elles sont des obstacles à part entière, conçues pour traduire physiquement une gêne ou une limitation sensorielle.

---

## 1. Introduction et objectif du projet

---

L’objectif principal de ce projet est de **concevoir une expérience interactive immersive visant à susciter l’empathie de l’utilisateur envers les personnes en situation de handicap**.

Le projet s’inscrit dans une continuité : une **version 1 fonctionnelle du jeu existait déjà**, mais cette **version 2** vise à répondre pleinement aux **critères avancés d’infographie 3D**, en mettant l’accent sur:

- l’amélioration significative du **décor et de l’esthétique**,
- l’augmentation du **niveau d’immersion**,
- l’optimisation des performances,
- l’intégration de **techniques avancées vues en cours** (génération procédurale, post-processing, ray marching, particules, exploitation de l’outil terrain).

La V2 ne se limite donc pas à un ajout de contenu, mais propose une **réinterprétation visuelle et technique complète du monde du jeu**, tout en conservant le cœur narratif et ludique de la V1.

---

## 2. Organisation du travail et répartition des tâches

---

Le projet a été réalisé en binôme, avec une répartition équitable du travail et une collaboration constante pour assurer la cohérence de l’ensemble. Notre méthodologie a consisté à ne pas cloisonner les TDs comme des exercices isolés, mais à les considérer dès le départ comme des briques potentielles pour le jeu final. Ainsi, les TDs implémentés proviennent des **chapitres 2, 3 et 4**, et ont tous été **intégrés directement dans le jeu final**, et non présentés comme des démonstrateurs isolés. Cette approche a nécessité une phase de conception préalable pour définir où et comment chaque technique pourrait servir la narration et le gameplay.

[https://github.com/ZedRoff/unity-labs.git](https://github.com/ZedRoff/unity-labs.git)

📌 **Repository GitHub du projet :**

👉 [https://unity-omoiyari.pages.dev/](https://unity-omoiyari.pages.dev/)  et 

> Remarque importante :
> 
> 
> Les commits sont réalisés via le compte GitHub de Aman, mais **le travail a bien été réparti équitablement**, chaque membre ayant implémenté **3 TDs distincts**, conformément aux consignes. Cette centralisation des commits était un choix pratique pour la gestion du repository principal.
> 

---

### TDs réalisés

---

| TD | Sujet | Réalisé par |
| --- | --- | --- |
| CH2-TD2 | Bruit de Perlin | Justine |
| CH3-TD1 | Mont Fuji | Aman |
| CH3-TD2 | Génération de terrains procéduraux | Aman |
| CH3-TD3 | Génération procédurale de villes | Justine |
| CH3-TD4 | Effets de post-traitement | Justine |
| CH3-TD5 | SkyDome | Aman |
| CH3-TD6 | Nuages volumétriques | Aman |

🔹 Un TD sur les **systèmes de particules**, bien que non listé explicitement, a été **implémenté et utilisé dans le jeu final** pour créer la pluie, le feu des lanternes et d’autres effets atmosphériques.

---

## 3. Intégration des TDs dans le jeu

---

Contrairement à une approche démonstrative, **chaque TD a été pensé comme une brique fonctionnelle du gameplay et de la narration**.

- **Bruit de Perlin**
    
    Utilisé pour la **génération procédurale d’une forêt dense**, intégrée dans la pièce du daltonisme. Cet algorithme nous a permis de créer un environnement organique et non répétitif, essentiel pour dissimuler les éléments de la fresque que le joueur doit retrouver. La forêt devient ainsi à la fois un décor immersif et le support principal du défi.
    
    ![Foret.png](omoiyari-project/images/Foret.png)
    
- **Mont Fuji**
    
    Sert de base à une **nouvelle salle représentant le handicap moteur. L’**épreuve centrale place le joueur dans un fauteuil roulant. Son défi : se déplacer sur un terrain rendu glissant par une pluie et jonché d'obstacles difficiles à franchir pour une personne à mobilité réduite. La forme emblématique de la montagne a inspiré la topographie du parcours, alternant pentes et passages escarpés.
    
    ![MtFuji.png](omoiyari-project/images/MtFuji.png)
    
- **Génération de terrains procéduraux**
    
    Permet de créer un **sentiment de paysage à perte de vue.** Cette technique est utilisée en arrière-plan. En encerclant l’île principale de chaînes de montagnes générées procéduralement, nous renforçons l’isolement du lieu et l’immersion du joueur dans un monde cohérent et vaste, sans alourdir la scène avec des modélisations manuelles complexes.
    
    ![montagnes.png](omoiyari-project/images/montagnes.png)
    
- **Post-processing**
    
    Utilisé à la fois pour améliorer le rendu global et de manière **contextuelle et pédagogique**. Son application la plus significative est dans la salle du **daltonisme**, où des filtres de simulation (deutéranopie, protanopie) sont appliqués en temps réel. Cela permet au joueur de voir le monde à travers les yeux d’une personne atteinte de ce trouble, transformant un effet visuel en outil de compréhension.
    
    ![postprocess.png](omoiyari-project/images/postprocess.png)
    
- **Nuages volumétriques & Ray Marching**
    
    Les nuages volumétriques, générés via du ray marching, ne servent pas uniquement d’élément décoratif. Ils sont utilisés comme un **brouillard immersif et dynamique**. Dans la salle du daltonisme, cette brume épaisse brouille la vision du joueur, ajoutant une couche de difficulté qui simule la confusion et la perte de repères, complétant ainsi l’expérience sensorielle du handicap.
    
    ![nuagededans.png](omoiyari-project/images/nuagededans.png)
    
    ![nuagedessus.png](omoiyari-project/images/nuagedessus.png)
    
    ---
    
    ## 4. Éléments naturels sélectionnés
    
    ---
    
    Conformément aux consignes, quatre éléments ont été sélectionnés et intégrés de manière cohérente au gameplay. Ils forment le lien narratif et symbolique entre les différentes épreuves, chaque élément représentant à la fois une force de la nature et une métaphore du handicap qu’il accompagne.
    
    | Élément | Implémentation | Responsable |
    | --- | --- | --- |
    | Terre | Représentée par le **Mont Fuji** et les **terrains procéduraux**. Elle symbolise l’obstacle physique. Dans la salle du handicap moteur, la terre est à la fois le support traître (glissant) et la barrière à surmonter (pentes, rochers). | Aman |
    | Brouillard | Matérialisé par les **nuages volumétriques** utilisant le ray marching. Il incarne la confusion, la perte de clarté et la difficulté à percevoir son environnement, directement liée à l’expérience du daltonisme dans le jeu. | Aman |
    | Lumière du soleil | Implémentée via un **éclairage directionnel dynamique** et la **Global Illumination**. Elle représente l’éblouissement. Dans la salle de la dyslexie, ses reflets aveuglants sur un tableau viennent perturber la lecture, ajoutant une gêne sensorielle à la difficulté cognitive. | Justine |
    | Tonnerre | Créé à partir d'**effets sonores stridents** et de **jeux de lumières** (flashs soudains). Il simule la surcharge sensorielle, l’imprévisibilité et l’anxiété, au cœur de l’expérience dans le labyrinthe dédié à l’autisme. | Justine |
    
    ![orage.png](omoiyari-project/images/orage.png)
    
    ![slippery.png](omoiyari-project/images/slippery.png)
    
    ![soleilExt.png](omoiyari-project/images/soleilExt.png)
    
    ![soleilSalle.png](omoiyari-project/images/soleilSalle.png)
    

---

## 5. Assets externes

---

Afin de respecter les contraintes techniques et de nous concentrer sur le développement des mécaniques clés, nous avons choisi d’intégrer trois assets externes soigneusement sélectionnés pour leur qualité et leur pertinence.

- **Asset 1 :** CloudsToy

Cet asset nous a fourni une base solide et performante pour le système de nuages. Nous l’avons ensuite profondément modifié et adapté via du ray marching pour créer le brouillard volumétrique spécifique à notre salle du daltonisme.

[CloudsToy](https://assetstore.unity.com/packages/tools/particles-effects/cloudstoy-35559)

- **Asset 2 :** Skydome

[https://esieeparis.sharepoint.com/:u:/s/25_EPIGEP-FI-4-S3-UPMUEProjetmultidisciplinaire3/IQCxbCdtqvZNSb13x--0lVN2AYlJmfbkAklY7qVnnpBVA58?e=tb7QcW](https://esieeparis.sharepoint.com/:u:/s/25_EPIGEP-FI-4-S3-UPMUEProjetmultidisciplinaire3/IQCxbCdtqvZNSb13x--0lVN2AYlJmfbkAklY7qVnnpBVA58?e=tb7QcW)

Un ciel dynamique de haute qualité, essentiel pour établir l’ambiance générale de chaque salle (ciel serein, orageux, brumeux). Il a été paramétré pour interagir avec nos systèmes météorologiques et ainsi renforcer l’immersion.

![skydomeInt.png](omoiyari-project/images/skydomeInt.png)

![skydomeExt.png](omoiyari-project/images/skydomeExt.png)

- **Asset 3 :** Wheel chair

Un modèle 3D de fauteuil roulant réaliste, importé depuis Sketchfab. Il constitue l’élément central de la nouvelle salle sur le handicap moteur. 

[Wheel Chair - Download Free 3D model by KurtSteiner](https://sketchfab.com/3d-models/wheel-chair-305863cd3839482f8fdfc1b799ef5029)

---

## 6. Critères techniques Unity3D

---

### a. Acquisition et préparation des données

---

Les assets 3D importés, qu’ils soient externes ou créés par nos soins, ont systématiquement fait l’objet d’un **travail d’optimisation**. Cela incluait la mise en place de **niveaux de détail (LOD)** pour les modèles complexes, réduisant leur polycount en fonction de la distance de la caméra. Nous avons également organisé de manière stricte le dossier `Assets`, supprimé les meshes, matériaux et textures inutilisés, et réduit la résolution des textures 2D lorsque l’impact visuel était négligeable. Enfin, le baking de la lumière pour tous les éléments statiques a permis de réduire drastiquement le coût GPU en temps réel. Cette approche méthodique a permis de **réduire significativement l’empreinte mémoire et les draw calls** tout en conservant une esthétique soignée.

---

### b. Mise en œuvre du projet dans Unity3D

---

Le projet repose sur une **forte interactivité**, entièrement pilotée par des scripts C# que nous avons développés. Les interactions clavier (comme `E` ou `R` pour interagir avec les objets, les portes ou allumer les lanternes) sont gérées de manière contextuelle. Elles sont complexifiées dans la salle à mobilité réduite avec l’implémentation d’un système de combinaison de touche à appuyer pour faire avancer le joueur (comme T puis G puis V).  La physique joue un rôle central, notamment dans la salle du handicap moteur où nous avons ajusté les paramètres du `Character Controller` :  suppression de la capacité de sauter, effet de glisse sur le terrain et affinage des collisions pour que chaque obstacle (une pierre, une pente) ait un impact tangible et parfois pénalisant sur la progression. Il peut déplacement dynamiquement les éléments du décor dans la salle du daltonisme. 

Nous avons également implémenté plusieurs fonctionnalités pour améliorer l’expérience utilisateur. Un **système de checkpoints** replace automatiquement le joueur au dernier point sûr en cas de chute ou d’échec. La **salle finale narrative** utilise un système de dialogue et d’interaction pour délivrer des fiches informatives, renforçant le message pédagogique du projet de manière intégrée au gameplay. Un système de téléportation d’un endroit à un autre a été ajouté avec l’élément du bus placé sur la carte afin de simuler le passage de la carte extérieur vers la carte intérieur (l’intérieur de l’école avec les deux salles de classes finales). 

---

### c. Qualité du rendu

---

La recherche d’une qualité visuelle immersive et cohérente a guidé tous nos choix techniques et artistiques. La **Global Illumination** a été activée et soigneusement paramétrée dans toutes les scènes pour obtenir des éclairages réalistes et des ambiances marquées. L’éclairage est souvent directionnel, servant non seulement à éclairer mais aussi à guider le regard du joueur vers des points d’intérêt ou à créer des zones d’ombre anxiogènes dans le labyrinthe.

Nous avons accordé une grande importance à la **cohérence stylistique**. L’ensemble du jeu baigne dans une ambiance japonaise discrète mais omniprésente, évoquée par des architectures simples (torii, pagodons), des sakura, une palette de couleurs douce (roses, beiges, tons naturels) et le skydome approprié. Les systèmes de particules, pour la pluie, le feu des lanternes ou les effets ambiants, viennent compléter cette atmosphère en ajoutant du mouvement et de la vie aux environnements.

Nous avons développé un shader personnalisé qui modifie en temps réel les positions et les normales d’un matériau, afin de simuler un effet de vagues. Pour cela, nous avons utilisé une fonction de type Asin(ωt + φ), où le temps du jeu fournit la variable *t* et la position des vertices sert à calculer le déphasage. Une variable dynamique contrôle également l’amplitude des vagues.

Ce shader a été créé via Shader Graph, un outil qui permet de manipuler visuellement les composantes d’un mesh. Bien que nous ayons initialement testé une approche basée sur l’opposition de deux normales — une technique courante en développement de jeux — celle-ci n’a pas été retenue, car elle ne produisait pas les modifications souhaitées sur les normales.

Visuellement, nous avons combiné deux textures 2D bleutées, en mélangeant un bleu foncé et un bleu plus clair, afin de renforcer l’effet aquatique. Le shader repose ainsi sur une séquence d’opérations élémentaires liant le temps, la position et des paramètres ajustables pour animer les vagues.

![ShaderOO.png](omoiyari-project/images/ShaderOO.png)

![shaderO.png](omoiyari-project/images/shaderO.png)

Nous avons configuré le soleil en tant que matériau personnalisé pour recréer l’effet d’un lever de soleil derrière le mont Fuji. Pour cela, nous avons retiré la source lumineuse intégrée au ciel dynamique (skydome) et l’avons remplacée par notre propre système.

Afin de produire une lueur chaude et réaliste, nous avons appliqué une texture d’émission orange sur le disque solaire et placé une Directional Light juste au-dessus pour générer un halo blanc diffus. Le matériau a été réglé en métallique, avec la source de couleur finale (albedo) utilisée directement pour définir la teinte métallique, afin d’obtenir un rendu plus éclatant et naturel.

Pour optimiser les performances tout en préservant la qualité visuelle, nous avons calculé l’illumination globale (GI) en mode *baked*, ce qui permet d’enregistrer les effets de lumière indirecte directement dans les textures de l’environnement.

![configSoleil.png](omoiyari-project/images/configSoleil.png)

---

### d. Performances et optimisation

---

Conscients des contraintes de performance d’une expérience riche en assets et en effets, nous avons mené une campagne d’optimisation systématique à l’aide du **Unity Profiler**. L’analyse initiale a révélé des points de pression, notamment un nombre élevé de draw calls dû à la forêt procédurale et aux nombreux petits assets.

L’optimisation a été réalisée à l’aide du **Unity Profiler** :

- Analyse CPU / Rendering / Memory,
- Identification d’un problème principal (ex : draw calls élevés),
- Mise en place de solutions :
    - Static Batching : Pour combiner les meshes statiques identiques (comme de nombreux arbres ou rochers) en un seul draw call.
    - GPU Instancing :  Appliqué aux matériaux des éléments répétitifs générés procéduralement, permettant au GPU de les rendre beaucoup plus efficacement.
    - Occlusion Culling :  Configuré pour ne pas calculer le rendu des objets cachés derrière d’autres (comme l’intérieur des bâtiments ou les arbres lointains derrière une colline).

Ces mesures ont permis de stabiliser les performances, assurant un framerate constant et fluide même sur des machines grand public, et de valider la viabilité technique de notre approche procédurale et visuellement dense.

---

## 7. Nouvelles salles et nouveaux handicaps

---

### a. Handicap moteur – Mobilité réduite

---

- Salle inspirée du **Mont Fuji**,
- Déplacement en fauteuil roulant simulé,
- Aucun saut possible,
- Parcours court mais exigeant,
- Mise en avant de l’élément **Terre**.

Cette nouvelle salle est une matérialisation de l’élément **Terre**. Inspirée par la forme et la symbolique du **Mont Fuji**, elle transpose la difficulté physique en un parcours ludique. Le joueur y incarne une personne en fauteuil roulant, avec une physique adaptée : déplacement plus lent, aucune capacité de saut, et une grande sensibilité aux pentes et aux aspérités du terrain. Le parcours, bien que court, est conçu pour être exigeant. Le joueur doit négocier avec un terrain accidenté, transformer des escaliers en rampes en allumant des lanternes à l’aide de sa torche, réaliser des séquences de touches spécifiques pour avancer et contourner des obstacles physiques, le tout sous la pression d’un temps limité car les flammes, menacées par la pluie constante, s’éteignent progressivement.

![epreuve2.png](omoiyari-project/images/epreuve2.png)

![epreuve1.png](omoiyari-project/images/epreuve1.png)

---

### b. Autisme

---

- Labyrinthe
- Objectif : trouver la clé de sortie,
- Tonnerre à intervalles réguliers
- Désorientation volontaire du joueur. (inversion des touches)

La salle consacrée à l’autisme est centrée sur l’élément **Tonnerre** et se déroule dans un **labyrinthe plongé dans une obscurité quasi-totale**, seulement percée par la lueur d’une lampe torche. L’objectif est de trouver un bol de ramen qui sert de clé pour ouvrir la sortie. Pour pénétrer dans cette épreuve, le joueur doit d’abord avoir achevé le défi de la salle précédente (le daltonisme). Un portail garde l’entrée et ne se dissipe qu’une fois la fresque de la salle précédente terminée, instaurant une progression séquentielle.

Le gameplay est construit autour d’une **jauge de stress** qui augmente inexorablement, alimentée par des orages aux éclairs aveuglants et au tonnerre assourdissant qui retentissent à intervalles réguliers. Lorsque la jauge atteint la moitié, elle induit un effet de désorientation majeur : **les commandes de déplacement s’inversent**. Si elle atteint son maximum, le joueur est téléporté au début du labyrinthe. La seule façon de faire baisser cette jauge est de trouver et de se réfugier dans des « shelter zones », de petites salles calmes disséminées dans le labyrinthe. Cette mécanique vise à simuler la surcharge sensorielle et le besoin crucial de moments de retrait pour retrouver un équilibre.

![laby.png](omoiyari-project/images/laby.png)

![jauge.png](omoiyari-project/images/jauge.png)

---

### c. Nouveau Scripting

```csharp
// PlayerState.cs
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
public static PlayerState Instance;
public bool isInShelter;
public float overloadLevel = 0f;
public float maxOverload = 100f;

public Image jauge;
private float maxSize = 470f; // largeur max de la jauge
public GameObject player;
public GameObject tpStartStorm;

void Awake()
{
    Instance = this;
    tpStartStorm = GameObject.Find("tpStartStorm");
    player = GameObject.FindGameObjectWithTag("Player");

}

void Start()
{
    StormManager.Instance.OnStormHit += HandleStorm;

    // initialisation de la jauge
    UpdateJauge();
}

void HandleStorm()
{
    if (isInShelter) return;

    overloadLevel += 25f;
    overloadLevel = Mathf.Clamp(overloadLevel, 0, maxOverload);

    UpdateJauge();
    ApplyOverloadEffects();
}

public void EnterShelter()
{
    isInShelter = true;
    overloadLevel = Mathf.Max(overloadLevel - 40f, 0);

    UpdateJauge();
}

public void ExitShelter()
{
    isInShelter = false;
}

void UpdateJauge()
{
    // map overloadLevel (0-100) sur la largeur max
    float width = (overloadLevel / maxOverload) * maxSize;

    RectTransform rt = jauge.rectTransform;
    rt.sizeDelta = new Vector2(width, rt.sizeDelta.y);

    UpdateJaugeColor();
}

void UpdateJaugeColor()
{
    if (overloadLevel >= 80)
    {
        CharacterController cc = player.GetComponent<CharacterController>();

        cc.enabled = false;
        player.transform.position = tpStartStorm.transform.position;
        cc.enabled = true;
        overloadLevel = 0;
        UpdateJauge();
        jauge.color = Color.red;       // OVERLOAD MAX
    }
    else if (overloadLevel >= 50)
        jauge.color = new Color(1f, 0.5f, 0f); // orange
    else if (overloadLevel >= 25)
        jauge.color = Color.yellow;    // désorientation légère
    else
        jauge.color = Color.green;     // sain
}

void ApplyOverloadEffects()
{
    if (overloadLevel >= 80)
        Debug.Log("OVERLOAD MAX");
    else if (overloadLevel >= 50)
        Debug.Log("Contrôles perturbés");
    else if (overloadLevel >= 25)
        Debug.Log("Désorientation légère");
	}
}
```

Ce script est le cœur du système de simulation de surcharge sensorielle pour la salle autisme. Implémenté comme un Singleton, il maintient l'état global du joueur : son niveau de stress (`overloadLevel`), sa position dans un abri (`isInShelter`), et gère les effets correspondants. Il s'abonne aux événements d'orage du `StormManager` pour augmenter progressivement le stress du joueur quand il est exposé. La jauge UI se met à jour dynamiquement, changeant de couleur selon trois seuils critiques (vert → jaune → orange → rouge). Au-delà de 80%, le joueur est téléporté au point de départ, simulant un "meltdown" sensoriel. L'architecture événementielle permet une communication découplée entre les systèmes météorologiques et l'état du joueur.

---

```csharp
// ShelterZone.cs
using UnityEngine;

public class ShelterZone : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
{
if (other.CompareTag("Player"))
PlayerState.Instance.EnterShelter();
}
private void OnTriggerExit(Collider other)
{
    if (other.CompareTag("Player"))
        PlayerState.Instance.ExitShelter();
	}
}
```

Script simple mais essentiel qui définit les zones de récupération dans le labyrinthe. Grâce aux colliders et aux triggers Unity, il détecte l'entrée et la sortie du joueur via son tag "Player". Lorsque le joueur entre dans un abri, il appelle `PlayerState.Instance.EnterShelter()`, ce qui réduit instantanément son niveau de stress de 40% et le protège temporairement des prochains orages. À la sortie, `ExitShelter()` le réexpose aux intempéries. Ces zones sont stratégiquement placées dans le labyrinthe pour offrir des points de répit indispensables à la gestion de la jauge de stress, encourageant une exploration prudente et planifiée.

---

```csharp
// StormManager
using System.Collections;
using UnityEngine;
using System;
using UnityEngine.UI;

public class StormManager : MonoBehaviour
{
    public static StormManager Instance;

    private float stormInterval = 5f;
    public float warningTime = 3f;

    public event Action OnStormWarning;
    public event Action OnStormHit;

    public AudioSource audio;
    public Light lightningLight;
    public Image jauge;
    
    public GameScript gameScript;

    void Awake()
    {

        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        gameScript = GameObject.Find("Game Manager").GetComponent<GameScript>();    
        InvokeRepeating(nameof(StartStormCycle), stormInterval, stormInterval);
    }

    void StartStormCycle()
    {
        if(!PlayerState.Instance.isInShelter && gameScript.startedStorm) audio.Play();
       if(gameScript.startedStorm) OnStormWarning?.Invoke();
        if (gameScript.startedStorm) Invoke(nameof(StormHit), warningTime);
    }

    void StormHit()
    {
        OnStormHit?.Invoke();
        StartCoroutine(LightningFlash());
    }

    IEnumerator LightningFlash()
    {
        int flashes = UnityEngine.Random.Range(3,4);

        for (int i = 0; i < flashes; i++)
        {
            lightningLight.enabled = true;
            lightningLight.intensity = UnityEngine.Random.Range(8f, 15f);

            yield return new WaitForSeconds(UnityEngine.Random.Range(0.05f, 0.15f));

            lightningLight.enabled = false;

            yield return new WaitForSeconds(UnityEngine.Random.Range(0.05f, 0.2f));
        }
    }
}
```

Ce script (auquel `PlayerState` s'abonne) est responsable du déclenchement périodique des orages qui alimentent la mécanique de stress. Il émet l'événement `OnStormHit` à intervalles réguliers (toutes les 10 secondes selon le cahier des charges), simulant les pics de stimulation sensorielle imprévisibles. Cette séparation entre la source du stress (`StormManager`) et sa gestion (`PlayerState`) suit les bonnes pratiques de modularité, permettant d'ajuster facilement la fréquence ou l'intensité des orages sans toucher à la logique de l'état joueur.

---

## 8. Reprise des salles existantes

---

Les salles héritées de la version 1 (dyslexie et daltonisme) n’ont pas été simplement reprises, mais **complexifiées et enrichies** pour correspondre au nouvel univers et offrir une expérience plus aboutie.

Pour la **dyslexie**, l’épreuve a été intégrée à l’élément **Soleil**. Le défi de lecture sur un tableau est désormais exacerbé par des reflets solaires aveuglants qui apparaissent. Le joueur doit maintenant interagir avec un rideau pour les masquer temporairement, ajoutant une action de gestion de l’environnement à la tâche cognitive de base.

![effetTab.png](omoiyari-project/images/effetTab.png)

La salle du **daltonisme** a été considérablement agrandie et transformée en une **vaste forêt générée procéduralement**, plongée dans un **brouillard épais** (élément **Brouillard**). Les toboggans avec les pièces de puzzle du Tangram à collecter pour reconstituer la fresque ne sont plus dans une cour, mais dissimulés et espacés dans cet environnement dense et brumeux. Le joueur doit ainsi explorer avec attention.

La salle finale, qui sert de point de conclusion narrative et pédagogique, est restée inchangée dans son principe. Pour naviguer entre ces différentes épreuves disséminées sur une carte principale, un **système de transport original** a été implémenté : le joueur entre dans un bus arrêté sur la route, ce qui le téléporte vers l’école servant de hub d’accès aux salles, créant une transition ludique et thématique.

![Bus.png](omoiyari-project/images/Bus.png)

---

## 9. Conception artistique et gameplay

---

La direction artistique a été un pilier fondamental pour assurer l’immersion et la cohérence émotionnelle du projet. Nous avons opté pour une **ambiance japonaise subtile mais omniprésente**, non pas comme un folklore, mais comme un cadre esthétique apaisant et évocateur. Cette atmosphère est portée par une palette de **couleurs douces et légèrement ternes** (tons sable, rose pâle, verts d’eau, bleus grisés), des formes architecturales épurées (torii, toits caractéristiques), et des éléments naturels emblématiques (cerisiers en fleur, bambous). L’organisation spatiale du monde est pensée comme un **îlot central** (le village avec l’arrêt de bus) depuis lequel le joueur part explorer les différentes « salles-épreuves », créant un sentiment de voyage et de découverte.

L’interactivité a été conçue pour être intuitive tout en servant la narration. Une **interface d’inventaire minimaliste** permet de suivre les objets clés (comme le bol de ramen). Un **menu de quêtes** guide discrètement le joueur sans lui mâcher le travail. L’ensemble des contrôles clavier/souris a été affiné pour être réactif et adapté aux spécificités de chaque salle, qu’il s’agisse de la lourdeur du fauteuil ou de la précision nécessaire pour allumer une lanterne sous la pluie.

Pour la réalisation, plusieurs éléments visuels et sonores ont été intégrés. L'environnement utilise des ciels stylisés et un système de nuages volumétriques pour créer une atmosphère. L'épreuve centrale consacrée au handicap moteur dispose de ses propres éléments, notamment un modèle de fauteuil roulant et des interfaces graphiques pour les commandes. La carte principale a été sculptée à l'aide de l'outil terrain, permettant de dessiner des éléments marquants comme le Mont Fuji ainsi que le parcours spécifique de la salle sur la mobilité. Une forêt dense a été générée de manière procédurale en adaptant un système initialement conçu dans les TDs pour des bâtiments, en y plaçant des arbres japonais. L'horizon lointain est habillé par des montagnes créées à partir de plans avec un bruit de Perlin. Sur le plan technique, un shader personnalisé pour l'eau a été développé via le système de graphes, et un soleil dynamique a été mis en place, jouant également un rôle dans une autre partie de l'expérience.

![decorJap.png](omoiyari-project/images/decorJap.png)

[https://www.notion.so](https://www.notion.so)

---

### Direction artistique

---

- Ambiance japonaise marquée,
- Couleurs douces et ternes,
- Organisation spatiale en îlot central reliant les différentes salles,
- Forte cohérence entre tous les éléments visuels.

---

### Interactivité et expérience utilisateur

---

- Interface d’inventaire,
- Menu de quêtes pour guider le joueur,
- Système de dialogue,
- Contrôles clavier/souris fluides,

---

## 10. Présentation et livrables

---

Pour documenter et présenter notre travail de manière complète, nous avons structuré nos livrables autour de plusieurs supports clés.

Notre page **Notion** sert de dossier de projet exhaustif. Elle contient les **rapports principaux** commentés, une **analyse technique détaillée** de nos choix et des défis rencontrés, des **captures d’écran** illustrant le rendu final des différentes salles, et surtout, un **Retour d’Expérience (REX)** où nous analysons avec honnêteté le processus de développement, les réussites et les points d’amélioration. Nous avons cette année rassemblés tous les rapports et éléments du projet dans une page web avec l’outil Quartz.

La **vidéo de démonstration** est conçue comme un trailer technique et immersif. Elle présente de manière dynamique les améliorations majeures de la V2, un aperçu rapide du gameplay dans les nouvelles salles (fauteuil roulant, labyrinthe), et met en lumière l’intégration réussie des techniques avancées (ray marching sur les nuages, systèmes de particules pour la pluie et le feu, effets de post-processing). 

---

### Vidéo

---

- Présentation des améliorations,
- Gameplay rapide des nouvelles salles,
- Ray marching, particules, TDs intégrés,
- Prise de recul finale.

---

## 11. Conclusion et prise de recul

---

Cette version 2 marque une **évolution majeure et aboutie du projet Omoiyari**. Elle représente bien plus qu’une simple mise à jour technique ; c’est une réinterprétation complète qui a permis de transformer un prototype conceptuel en une **expérience immersive, esthétique et technique cohérente**. L’intégration profonde et justifiée des TDs dans la narration et le gameplay démontre notre maîtrise des techniques d’infographie avancées, non pas comme des exercices académiques, mais comme des outils au service d’une intention artistique et pédagogique.

Les défis n’ont pas manqué, notamment dans l’optimisation d’un monde procéduralement peuplé ou dans la recherche du juste équilibre pour simuler un handicap sans créer de frustration excessive. Ces difficultés ont été formatrices et ont renforcé notre approche itérative du développement.

Au final, nous sommes parvenus à créer une expérience qui, nous l’espérons, parvient à **faire ressentir plutôt que simplement montrer**. En plongeant le joueur dans des situations où la perception, la mobilité ou la cognition sont altérées par des mécaniques de jeu et des ambiances soignées, « Omoiyari » aspire à susciter cette empathie (« omoiyari » en japonais) qui est au cœur de son propos. Ce projet est la preuve que la technologie au service d’une intention humaine peut créer des expériences à la fois belles, engageantes et porteuses de sens.
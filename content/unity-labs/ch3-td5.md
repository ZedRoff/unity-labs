# TD5 : SkyDome

## Préambule

L'objectif de ce TD est de créer un skydome sur Unity. Pour ce faire, nous allons utilisé le package SkyDome et le Character Controller.

Version de Unity : 2023

## Mise en place de l'environnement

1. On créé un projet sur Unity
2. On importe le PFC depuis CharacterController
3. On créé un terrain pour que le PFC ne tombe pas
4. On lance la scène et on fait bouger le PFC

Voici le rendu : 
![alt text](unity-labs/images/ch3-td5/image.png)

## Mise en place du SkyDome

On import le package Unity SkyDome depuis le dossier partagé : 
![alt text](unity-labs/images/ch3-td5/image-1.png)

On dépose le préfab dans la scène : 
![alt text](unity-labs/images/ch3-td5/image-7.png)

On attribue le PFC au champ Player du script Skydome script du skydome : 
![alt text](unity-labs/images/ch3-td5/image-3.png)

On retire la directional light de base du projet car le soleil de la skydome est automatiquement généré
On attribue une texture au skydome pour retiré le violet : 
![alt text](unity-labs/images/ch3-td5/image-4.png)

On change le type de lumière en Directional dans le code : 
![alt text](unity-labs/images/ch3-td5/image-5.png)

Voici le rendu lorsqu'on lance la scène : 

![alt text](unity-labs/images/ch3-td5/image-6.png)

Tests avec les paramètres: 

- Turbidité de 10 : 
![alt text](unity-labs/images/ch3-td5/image-8.png)

## Questions

### Skydome

#### Qu'est-ce qu'un skydome dans le contexte du graphisme 3D et du développement de jeux, et comment contribue-t-il au réalisme et à l'immersion d'un environnement virtuel ?

Un skydome est une sphère 3D qui englobe un terrain, a qui on applique une texture et de la génération au sein de la sphère.

Elle contribue au réalisme et à l'immersion dans un environnement virtuel car elle donne cette sensation d'être au sein d'un environnement, on peut lui appliquer les textures et shaders que l'on souhaite, afin de simuler par exemple un environnement plutôt sci-fi, ou encore un atmosphère, simuler les cycles jours / nuits etc.

#### Décrivez le processus de création d'un skydome dans Unity 3D. Quelles sont les considérations à prendre en compte pour s'assurer qu'il s'adapte correctement à l'environnement du jeu et qu'il offre une expérience transparente sur les différentes cartes du jeu ?

Pour créer un SkyDome dans Unity, il faut utiliser une sphère inversée (donc creuse de l'intérieur, avec les normales qui pointent vers l'intérieur). 

Pour inverser les normales, on prend chaque vertice du cercle et on détermine la normale avec un produit en croix, qu'on met ensuite sur chaque point du cercle.

Ensuite, on créé un shader pour simuler le ciel (ou l'espace ou autre). Les normales inversées devraient permettre de mieux rendre la lumière uniformement

Puis, il faut positionner le SkyDome pour le centré sur la caméra principale, avec un script.

Enfin, il faut ajouter une lumière pour simuler le soleil ou un autre faisceau lumineux, pour ce faire on règle une Directional Light simple.

Plusieurs considérations tels que la désactivation du Z-write, la désactivation du rendu des ombres du skydome, s'assurer que le skydome est assez grand, et que les paramètres sélectionné rendent bien la bonne expérience, ni trop fictive ni trop abstraite.

### Turbidité

#### Comment la turbidité affecte-t-elle l'apparence du ciel et la lumière du soleil dans des conditions réelles, et pourquoi est-il important de simuler cet effet dans des environnements virtuels ?

La turbidité représente la quantité de particules dans le ciel, rendant l'éclairage plus réaliste et immersif en simulant l'effet des particules atmosphériques (comme la pollution, la poussière) dans les environnements virtuels.

Une turbidité faible rend un ciel bleu, un soleil net (car le soleil fait partie intégrante de l'atmosphère et donc les raylights arrivant jusqu'au joueur s'en retrouvent en quelque sorte filtrées). Tandis qu'une turbidité forte donne un ciel orangé, avec un soleil sous forme de halo.

#### Implémentez un script dans Unity qui simule différents niveaux de turbidité atmosphérique (sans l’utilisation du skydome). Quels paramètres exposeriez-vous au concepteur pour ajuster l'effet, et comment ces changements seraient-ils représentés visuellement dans le jeu ?

```c#
using UnityEngine;

public class MinimalTurbidity : MonoBehaviour
{
    [SerializedField] public float turbidity = 2f;

    void Update()
    {
        RenderSettings.fog = true;
        RenderSettings.fogColor = Color.Lerp(Color.blue, Color.gray, (turbidity - 1f) / 9f);
        RenderSettings.fogDensity = 0.001f * turbidity;
    }
}
```
On a exposé une variable turbidity dans l’Inspector pour que le concepteur puisse facilement ajuster la turbidité. Mais on aurait pu en ajouter mais ça aurait rendu l'implémentation plus difficile.
La valeur de turbidité varie entre 1 et 10.
Après des recherches dans la documentation de Unity (https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Color.Lerp.html), on a trouvé que Color.Lerp permettait de changer la couleur en fonction de plusieurs couleurs, elle fait de l'interpolation.

RenderSettings.fog est le fog global, ensuite on lui appliquer le Lerp sur la couleur pour créé l'effet, enfin on ajuste la densité.

On aurait donc pu exposer la densité aussi.

### Diffusion de Rayleigh

#### Expliquez le principe de la diffusion Rayleigh et son rôle dans la détermination de la couleur du ciel. Comment la compréhension de ce phénomène peut-elle améliorer le réalisme du rendu du ciel dans les jeux ?

La diffusion Rayleigh est un phénomène physique qui explique pourquoi le ciel est bleu. En effet, l'air diffuse les longueurs d'ondes courtes, et laisse passer celles qui sont plus élevées (plutôt rougeâtres).

La compréhension de ce phénomène permet de par exemple donné un ciel bleu vif en jour, plutôt orangé ensuite vers le couché du Soleil.

Cela permet donc de reproduire les couleurs naturelles du Soleil. 

Enfin, cela permet de faire donc des transitions jours nuits plus lisses.

#### Concevez un système dans Unity qui ajuste dynamiquement l'effet de la diffusion de Rayleigh en fonction de l'altitude du joueur dans le jeu (sans l’utilisation du skydome). Comment cette altitude influencerait-elle la couleur du ciel et la visibilité à différentes heures de la journée? Quelles formules ou données utiliseriez-vous pour modéliser cet effet

Pseudo Code : 
```
altitude = joueur.y / altitude_max
couleur_ciel = bleu_foncé * altitude + bleu_clair * (1 - altitude)
densité_fog = 1 - altitude
appliquer(couleur_ciel, densité_fog)
```

### Théorie de Mie

#### Qu'est-ce que la théorie de Mie et comment explique-t-elle la diffusion de la lumière par des particules dont la taille est similaire à la longueur d'onde de la lumière ? En quoi cela diffère-til de la diffusion de Rayleigh ?

La théorie de Mie décrit la diffusion de la lumière par des particules dont la taille est comparable à la longueur d'onde de la lumière. 

On parle là de particules très petites comparé au rayleigh, et la lumière est diffusée seulement vers l'avant.

L'intensité lumineuse dépend de la taille, de la forme et de l'indice de réfraction des particules

#### Développez une fonctionnalité dans Unity qui utilise la théorie de Mie pour simuler l'effet de halo autour du soleil dû à la diffusion de particules plus grandes, comme la brume ou les nuages (sans l’utilisation du skydome). Quels paramètres ajustables fourniriez-vous pour contrôler l'intensité et la taille du halo sous différentes conditions atmosphériques

/

### Luminosité de la lumière du soleil

#### Discutez de la manière dont la luminosité du soleil est calculée dans un environnement virtuel et des facteurs à prendre en compte pour simuler avec précision l'intensité de la lumière du soleil au cours d'une journée.

La lumière du soleil est généralement simulé par une Directional Light, comme ce que nous avons fait dans le TD avec le SkyDome. 

La couleur et l'intensité sont ajustées pour représenter les cycles jours / nuits. La position aussi, on fait tourner la lumière au tour de la scène principale. On peut donc ajuster l'angle du soleil par rapport à l'horizon. Enfin, en jouant sur le rayleigh et la théorie de Mie, on peut affluer sur les particules pour créer un environnement virtuel immersif.

#### Créez un script Unity qui ajuste dynamiquement la luminosité et la couleur de la lumière du soleil dans un environnement de jeu en fonction de l'heure de la journée (sans l’utilisation du skydome). Quelles techniques utiliseriez-vous pour assurer une transition fluide entre ces états ?

```c#
using UnityEngine;

public class SunController : MonoBehaviour
{
    public Light sun;                // Directional Light du soleil
    [SerializedField] public float heure = 12f; // Heure de la journée

    // Couleurs du soleil selon l'heure
    public Color couleurJour = Color.white;
    public Color couleurLeverCoucher = new Color(1f, 0.6f, 0.4f);
    
    // Intensité du soleil
    public float intensiteMax = 1.2f;
    public float intensiteMin = 0.1f;

    void Update()
    {
        // Calcul de l'angle du soleil : 0 = minuit, 180 = midi
        float angle = (heure / 24f) * 360f - 90f;
        sun.transform.rotation = Quaternion.Euler(new Vector3(angle, -30f, 0f));

        // Interpolation de la couleur selon l'angle (lever/coucher vs plein jour)
        float t = Mathf.Clamp(Mathf.Sin(heure / 24f * Mathf.PI * 2f));
        sun.color = Color.Lerp(couleurLeverCoucher, couleurJour, t);

        // Interpolation de l'intensité
        sun.intensity = Mathf.Lerp(intensiteMin, intensiteMax, t);
    }
}
```

Interpolation avec Lerp, fonctions sinus pour avec un cycle (la fonction a un cycle justement), mise à jour par frame en déterminant l'angle avec l'heure actuelle.

### Objectifs d'un Skydome
#### Quels sont les principaux objectifs de la mise en place d'un skydome dans un jeu vidéo ou un environnement virtuel ? Comment ces objectifs contribuent-ils à l'expérience globale du joueur ?

Le principal objectif d’un skydome est de créer un ciel ou environnement distant immersif qui encadre la scène de jeu. Il permet de donner une profondeur visuelle, de renforcer l’atmosphère et de simuler des cycles jour/nuit ou des conditions météorologiques. Cela contribue à l’expérience du joueur en rendant le monde plus crédible, en guidant l’émotion et en renforçant l’immersion dans l’univers du jeu.


### Avantages et inconvénients des skydomes

#### Discutez des avantages et des inconvénients de l'utilisation d'un skydome dans les environnements 3D. Dans quelles circonstances d'autres techniques de rendu du ciel pourraient-elles être préférées ?

Les skydomes créent un ciel immersif et cohérent, renforçant le réalisme et l’ambiance du jeu. Ils permettent de simuler facilement le jour, la nuit et la météo avec des textures et shaders, tout en restant peu gourmands en performance. Mais ils sont souvent statiques, limitant les changements rapides ou les grandes cartes, et la lumière qu’ils génèrent est approximative. Pour de vastes environnements ou des effets atmosphériques dynamiques comme tempêtes ou brume, une skybox ou un shader procédural peut être plus adapté.



### Intégration des skydomes dans les jeux à missions et cartes multiples

#### Comment la conception et la fonctionnalité d'un skydome peuvent-elles améliorer les éléments thématiques des différentes missions ou cartes d'un jeu ?

La conception et la fonctionnalité d’un skydome permettent de renforcer les éléments thématiques d’un jeu en adaptant la couleur, la luminosité et les effets atmosphériques à chaque mission ou carte, créant ainsi une ambiance cohérente et immersive qui soutient la narration et l’expérience du joueur.



---
title: "CH3/TD1"
description: "Utilisation de l'outil terrain pour générer le mont-fuji"
author: "Aman GHAZANFAR"
tags:
  - mont-fuji
  - outil terrain
---


# Chapitre 3 - TD1

> Author : Aman GHAZANFAR

## Préambule

> L'objectif de ce TD est de manipuler l'outil "Terrain" de Unity. Pour ce faire, nous allons modéliser le paysage du Mont Fuji.


## Etape 1

Il faut créer le projet comme suit : 
![alt text](unity-labs/images/ch3-td1/image.png)


On trouve une scène avec une Directional Light et une Main Camera.

## Etape 2

On place un grand terrain blanc depuis l'onglet GameObject :
![alt text](unity-labs/images/ch3-td1/image-1.png)

Voici le terrain ainsi généré, on l'aggrandit pour qu'il prenne le plus de surface possible
![alt text](unity-labs/images/ch3-td1/image-2.png)

## Etape 3

![alt text](unity-labs/images/ch3-td1/image-3.png)
On essaye les options pour le terrain, et on comprend que la première permet d'ajouter des terrains voisins, la deuxième permet de sculpter le terrain (remonter / redescendre) des bouts de terrain en fonction du Brush utilisé. La troisième permet de placer des arbres à partir d'un Mesh d'arbre fournit. La quatrième permet de dessiner des détails, tels que des fleurs ou de l'herbe. Enfin la cinquième permet d'éditer les paramètres globaux du terrain.
![alt text](unity-labs/images/ch3-td1/image-4.png)
## Etape 4


![alt text](unity-labs/images/ch3-td1/image-5.png)

On constate que la touche MAJ enfoncée permet de descendre le niveau engendré par l'outil 2. On peut changer de brush, d'opacité (qui rend le pic plus raid) et la largeur de la zone engendrée.

## Etape 5

On a placé l'image sur le plan intérieur, en la mettant en tant que Sprite sur l'UI : 
![alt text](unity-labs/images/ch3-td1/image-6.png)

## Etape 6

Voici notre représentation approximative du mont fuji : 
![alt text](unity-labs/images/ch3-td1/image-7.png)

## Etape 7/8

Texturation du Mont Fuji :
![alt text](unity-labs/images/ch3-td1/image-13.png)

## Etapes 9 / 11

Voici le rendu final
![alt text](unity-labs/images/ch3-td1/image-22.png)

## Etape 12

On ajoute des arbres : 

- Voici les arbres choisis : 

![alt text](unity-labs/images/ch3-td1/image-14.png)


![alt text](unity-labs/images/ch3-td1/image-20.png)

## Etape 15

On a choisit l'option de créer un shader

Tout d'abord, on créer un plan : 


On utilise un mesh a plusieurs subdivisions.

On met opaque -> transparent dans les paramètres du Shader Graph

Ensuite, en suivant une vidéo, et en l'adaptant pour qu'elle fonctionne avec une formule d'une sinusoide : Asin(wt + phi), cela donne : 

![alt text](unity-labs/images/ch3-td1/image-18.png)

Voici ce que cela donne : 

![alt text](unity-labs/images/ch3-td1/image-19.png)

Le shader a pour but d'appliquer de la texture et de créer un wave effect.


## Conclusion

Pour conclure, nous avons appris à utiliser les terrains et à généré des terrains agréables à visiter au travers de l'exemple du Mont Fuji